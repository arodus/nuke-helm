// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.ChangeLog;
using Nuke.Common.Git;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Tools.Xunit;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Helm;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.Xunit.XunitTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.ChangeLog.ChangelogTasks;

partial class Build : NukeBuild
{
    const string c_addonRepoOwner = "nuke-build";
    const string c_addonRepoName = "helm";
    const string c_addonName = "Helm";
    const string c_toolNamespace = "Nuke.Helm";

    public Build()
    {
        InitGeneration();
        InitGitFlow();
    }

    public static int Main() => Execute<Build>(x => x.CompileAddon);

    [GitRepository] readonly GitRepository GitRepository;
    [GitVersion] readonly GitVersion GitVersion;
    [Solution] readonly Solution Solution;

    [Parameter] readonly string Configuration = IsLocalBuild ? "Debug" : "Release";
    [Parameter("Api key to push packages to NuGet.org")] readonly string NuGetApiKey;
    [Parameter("Api key to access the GitHub")] readonly string GitHubApiKey;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath OutputDirectory => RootDirectory / "output";
    ChangeLog ChangeLogContent => ReadChangelog(ChangelogFile);
    Project AddonProject => Solution.GetProject(c_toolNamespace).NotNull();

    Target Clean => _ => _
        .Executes(() =>
        {
            DeleteDirectories(GlobDirectories(SourceDirectory, "**/bin", "**/obj"));
            EnsureCleanDirectory(OutputDirectory);
        });

    Target Test => _ => _
        .OnlyWhen(() => false)
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
            DotNetBuild(x => x
                .SetProjectFile(Solution)
                .EnableNoRestore()
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(GitVersion.GetNormalizedAssemblyVersion())
                .SetFileVersion(GitVersion.GetNormalizedFileVersion())
                .SetInformationalVersion(GitVersion.InformationalVersion));

            var xUnitSettings = new Xunit2Settings()
                .AddTargetAssemblies(GlobFiles(Solution.Directory / "tests", $"*/bin/{Configuration}/netcoreapp2.1*/Nuke.*.Tests.dll").NotEmpty())
                .AddResultReport(Xunit2ResultFormat.Xml, OutputDirectory / "tests.xml")
                .SetToolPath(ToolPathResolver.GetPackageExecutable("xunit.runner.console", "xunit.console.dll", "netcoreapp2.0"));

            Xunit2(s => xUnitSettings);
        });

    Target CompileAddon => _ => _
        .DependsOn(Clean, GenerateAddon)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(AddonProject));
            DotNetBuild(s => s
                .SetProjectFile(AddonProject)
                .EnableNoRestore()
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(GitVersion.GetNormalizedAssemblyVersion())
                .SetFileVersion(GitVersion.GetNormalizedFileVersion())
                .SetInformationalVersion(GitVersion.InformationalVersion));
        });

    Target Pack => _ => _
        .DependsOn(CompileAddon)
        .Executes(() =>
        {
            var releaseNotes = ExtractChangelogSectionNotes(ChangelogFile)
                .Select(x => x.Replace("- ", "\u2022 ").Replace("`", string.Empty).Replace(",", "%2C"))
                .Concat(string.Empty)
                .Concat($"Full changelog at {GitRepository.SetBranch("master").GetGitHubBrowseUrl(ChangelogFile)}")
                .JoinNewLine();

            DotNetPack(s => new DotNetPackSettings()
                .SetProject(AddonProject)
                .EnableNoBuild()
                .SetConfiguration(Configuration)
                .EnableIncludeSymbols()
                .SetOutputDirectory(OutputDirectory)
                .SetVersion(GitVersion.NuGetVersionV2)
                .SetPackageReleaseNotes(releaseNotes));
        });

    Target Push => _ => _
        .DependsOn(Pack)
        .Requires(() => NuGetApiKey)
        .Requires(() => GitHasCleanWorkingCopy())
        .Requires(() => Configuration.EqualsOrdinalIgnoreCase("release"))
        .Requires(() => IsReleaseBranch || IsMasterBranch)
        .Executes(() =>
        {
            GlobFiles(OutputDirectory, "*.nupkg")
                .Where(x => !x.EndsWith(".symbols.nupkg")).NotEmpty()
                .ForEach(x => DotNetNuGetPush(s => s
                    .SetTargetPath(x)
                    .SetSource("https://api.nuget.org/v3/index.json")
                    .SetSymbolSource("https://nuget.smbsrc.net/")
                    .SetApiKey(NuGetApiKey)));
        });

    partial void InitGeneration();
    partial void InitGitFlow();
}
