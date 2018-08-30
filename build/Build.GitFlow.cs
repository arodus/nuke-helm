// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.ChangeLog;
using Nuke.Common.Utilities;
using Nuke.GitHub;
using static Nuke.GitHub.GitHubTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.Git.GitTasks;

partial class Build
{
    bool IsReleaseBranch => GitRepository.Branch.NotNull().StartsWith("release/");
    bool IsMasterBranch => GitRepository.Branch == "master";
    string ChangelogFile => RootDirectory / "CHANGELOG.md";

    Target Changelog => _ => _
        .OnlyWhen(ShouldUpdateChangelog)
        .Executes(() =>
        {
            ChangelogTasks.FinalizeChangelog(ChangelogFile, GitVersion.MajorMinorPatch, GitRepository);
        });

    Target PrepareRelease => _ => _
        .Before(CompileAddon)
        .DependsOn(Changelog, Clean)
        .Executes(() =>
        {
            var releaseBranch = IsReleaseBranch ? GitRepository.Branch : $"release/v{GitVersion.MajorMinorPatch}";
            var isMasterBranch = IsMasterBranch;
            var pushMaster = false;
            if (!isMasterBranch && !IsReleaseBranch)
                Git($"checkout -b {releaseBranch}");

            if (!GitHasCleanWorkingCopy())
            {
                Git($"add {ChangelogFile}");
                Git($"commit -m \"Finalize v{GitVersion.MajorMinorPatch}\"");
                pushMaster = true;
            }

            if (!isMasterBranch)
            {
                Git("checkout master");
                Git($"merge --no-ff --no-edit {releaseBranch}");
                Git($"branch -D {releaseBranch}");
                pushMaster = true;
            }

            if (IsReleaseBranch)
                Git($"push origin --delete {releaseBranch}");
            if (pushMaster)
                Git("push origin master");
        });

    Target Release => _ => _
        .Requires(() => GitHubApiKey)
        .DependsOn(Push)
        .After(PrepareRelease)
        .Executes(async () =>
        {
            var releaseNotes = new[]
                               {
                                   $"- [NuGet](https://www.nuget.org/packages/{c_toolNamespace}/{GitVersion.SemVer})",
                                   $"- [Changelog](https://github.com/{c_addonRepoOwner}/{c_addonRepoName}/blob/{GitVersion.MajorMinorPatch}/CHANGELOG.md)"
                               };

            await PublishRelease(x => x
                .SetToken(GitHubApiKey)
                .SetArtifactPaths(GlobFiles(OutputDirectory, "*.nupkg").ToArray())
                .SetRepositoryName(c_addonRepoName)
                .SetRepositoryOwner(c_addonRepoOwner)
                .SetCommitSha("master")
                .SetName($"NUKE {c_addonName} v{GitVersion.MajorMinorPatch}")
                .SetTag($"{GitVersion.MajorMinorPatch}")
                .SetReleaseNotes(releaseNotes.Join("\n"))
            );
        });

    bool ShouldUpdateChangelog()
    {
        var changelog = ChangeLogContent;
        if (changelog.ReleaseNotes.FirstOrDefault()?.Version?.Version.ToString(fieldCount: 3) == GitVersion.MajorMinorPatch)
        {
            Logger.Info($"Changelog already contains version {GitVersion.MajorMinorPatch}");
            return false;
        }

        if (changelog.Unreleased == null || changelog.Unreleased.IsEmpty)
        {
            Logger.Info("No changelog items in vNext section.");
            return false;
        }

        return true;
    }
}
