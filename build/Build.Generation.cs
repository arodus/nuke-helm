// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.CodeGeneration;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.GitHub;
using Nuke.Helm.Generator;
using Octokit;
using static RegenerateTasks;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.GitHub.GitHubTasks;

partial class Build
{
    const string c_regenerationRepoOwner = "helm";
    const string c_regenerationRepoName = "helm";
    const string c_regenerationRepoGitHubUrl = "https://github.com/" + c_regenerationRepoOwner + "/" + c_addonName;

    Lazy<IReadOnlyList<Release>> LatestReleases;

    [CanBeNull] Release LatestRelease => LatestReleases.Value.Count > 0 ? LatestReleases.Value[index: 0] : null;

    Nuke.Common.ProjectModel.Project KubernetesGeneratorProject => Solution.GetProject($"{c_toolNamespace}.Generator").NotNull();

    AbsolutePath SpecificationDirectory => AddonProject.Directory / "specifications";
    AbsolutePath DefinitionRepositoryPath => TemporaryDirectory / "definition-repository";
    AbsolutePath DocsPath => DefinitionRepositoryPath / "docs";
    AbsolutePath SpecificationOverwritesPath => AddonProject.Directory / "overwrites";

    string GenerationBaseDirectory => AddonProject.Directory / "generated";
    string RegenerationTagName => LatestRelease.NotNull().TagName;

    Target CleanGeneratedFiles => _ => _
        .Executes(() =>
        {
            DeleteDirectory(SpecificationDirectory);
            DeleteDirectory(GenerationBaseDirectory);
            if (IsWin)
                DeleteDirectory(DefinitionRepositoryPath);
            else
                ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("rm"), $"-rf {DefinitionRepositoryPath}").AssertZeroExitCode();
        });

    Target Clone => _ => _
        .DependsOn(CleanGeneratedFiles)
        .Requires(() => GitHubApiKey)
        .Executes(() =>
        {
            Git($"clone --depth 1 --single-branch --branch {RegenerationTagName} {c_regenerationRepoGitHubUrl} {DefinitionRepositoryPath}");
        });

    Target GenerateSpecifications => _ => _
        .DependsOn(Clone)
        .Executes(() =>
        {
            var reference = LatestRelease.NotNull().TagName;
            Logger.Log($"Generating specifications for {reference}");
            var generationSettings = new SpecificationGeneratorSettings
                                     {
                                         DefinitionFolder = DocsPath / "helm",
                                         OutputFolder = SpecificationDirectory,
                                         Reference = reference,
                                         OverwriteFile = SpecificationOverwritesPath / $"{c_addonName}.yml"
                                     };
            SpecificationGenerator.GenerateSpecifications(generationSettings);
        });

    Target GenerateAddon => _ => _
        .After(GenerateSpecifications)
        .Executes(() =>
        {
            CodeGenerator.GenerateCode(SpecificationDirectory,
                GenerationBaseDirectory,
                useNestedNamespaces: false,
                baseNamespace: c_toolNamespace,
                gitRepository: GitRepository);
        });

    Target GenerateSpecificationsAndAddon => _ => _
        .DependsOn(GenerateSpecifications, GenerateAddon);

    Target Regenerate => _ => _
        .Requires(() => GitHubApiKey)
        .Requires(() => LatestRelease != null)
        .OnlyWhen(() => IsUpdateAvailable($"{c_addonName} {LatestRelease.NotNull().Name}", ChangelogFile))
        .WhenSkipped(DependencyBehavior.Skip)
        .DependsOn(CompileAddon, GenerateSpecifications)
        .Executes(async () =>
        {
            var release = GetReleaseInformation(LatestReleases.Value.Take(count: 2), ParseVersion);
            var releaseVersion = release.Version;
            var branch = $"{c_addonRepoName}-update-{release.Version}";
            var versionName = $"{c_addonName} v{release.Version}";
            var message = $"Regenerate for {versionName}";

            var commitMessage = new List<string> { message };
            if (release.Bump != Bump.Patch)
                commitMessage.Add($"+semver: {release.Bump.ToString().ToLowerInvariant()}");
            var prBody = $"Regenerate for [{versionName}]({LatestRelease.NotNull().HtmlUrl}).";

            CheckoutBranchOrCreateNewFrom(branch, "master");
            UpdateChangeLog(ChangelogFile, versionName, LatestRelease.HtmlUrl);
            AddAndCommitChanges(commitMessage.ToArray(), new[] { AddonProject.Directory, ChangelogFile }, addUntracked: true);

            Git($"push --force --set-upstream origin {branch}");

            await CreatePullRequest(x => x
                .SetRepositoryName(c_addonRepoName)
                .SetRepositoryOwner(c_addonRepoOwner)
                .SetBase("master")
                .SetHead(branch)
                .SetTitle(message)
                .SetBody(prBody)
                .SetToken(GitHubApiKey));
        });

    Version ParseVersion(Release release) => Version.Parse(release.TagName.TrimStart(trimChar: 'v'));

    partial void InitGeneration()
    {
        LatestReleases = new Lazy<IReadOnlyList<Release>>(() =>
            GetReleases(x => x.SetRepositoryName(c_regenerationRepoName).SetRepositoryOwner(c_regenerationRepoOwner).SetToken(GitHubApiKey),
                    numberOfReleases: 50)
                .GetAwaiter().GetResult()
                .Where(x => !x.Prerelease && !x.TagName.Contains(value: '-'))
                .OrderByDescending(ParseVersion)
                .ToArray());
    }
}
