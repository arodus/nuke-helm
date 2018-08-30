// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common.IO;
using Nuke.Common.Tools.Git;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Octokit;

// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable ArrangeTypeModifiers

internal static class RegenerateTasks
{
    public struct ReleaseInformation
    {
        public Version Version { get; }
        public Bump Bump { get; }

        public ReleaseInformation(Version version, Bump bump)
        {
            Version = version;
            Bump = bump;
        }
    }

    public static ReleaseInformation GetReleaseInformation(IEnumerable<Release> releases, Func<Release, Version> parseVersion)
    {
        var (latestVersion, oldVersion) = releases
            .Select(parseVersion)
            .ToArray();

        var bump = GetBump(latestVersion, oldVersion);
        return new ReleaseInformation(latestVersion, bump);
    }

    public static void CheckoutBranchOrCreateNewFrom(string branch, string branchToCreateFrom)
    {
        try
        {
            GitTasks.Git($"checkout -B {branch} --track refs/remotes/origin/{branch}");
        }
        catch (Exception)
        {
            // remote branch does not exist
            GitTasks.Git($"checkout -B {branch} --no-track refs/remotes/origin/{branchToCreateFrom}");
        }
    }

    public static bool IsUpdateAvailable(string versionName, string changelogFile)
    {
        var changelog = TextTasks.ReadAllLines(changelogFile);
        return changelog.All(x => !x.Contains($"[{versionName}]"));
    }

    public static void UpdateChangeLog(string changeLogPath, string releaseName, string releaseUrl)
    {
        var changeLogLines = TextTasks.ReadAllLines(changeLogPath);
        var firstVNextVersionLine = Array.FindIndex(changeLogLines, x => x == "## [vNext]") + 1;
        var latestReleaseSectionLine = Array.FindIndex(changeLogLines, firstVNextVersionLine, x => x.StartsWith("##"));
        var releaseText = changeLogLines
            .Skip(firstVNextVersionLine)
            .Take(latestReleaseSectionLine - firstVNextVersionLine)
            .Where(x => !string.IsNullOrEmpty(x))
            .Append(
                $"- Changed supported version to [{releaseName}]({releaseUrl}).");

        var updatedChangeLog =
            changeLogLines.Take(firstVNextVersionLine)
                .Concat(releaseText)
                .Concat(changeLogLines.Skip(latestReleaseSectionLine));
        TextTasks.WriteAllText(changeLogPath, updatedChangeLog.JoinNewLine());
    }

    public static void GitAdd(bool addUntracked, params string[] refs)
    {
        GitTasks.Git($"add {(addUntracked ? "--all" : string.Empty)} {refs.JoinSpace()}");
    }

    public static void GitCommit(params string[] message)
    {
        GitTasks.Git($"commit {message.Aggregate(string.Empty, (x, y) => $"{x}-m \"{y}\" ").TrimEnd()}");
    }

    public static void AddAndCommitChanges(string[] message, string[] refs, bool addUntracked = false)
    {
        GitAdd(addUntracked, refs);
        GitCommit(message);
    }

    public static Bump GetBump(Version latest, Version old)
    {
        if (latest.Major > old.Major) return Bump.Major;
        return latest.Minor > old.Minor ? Bump.Minor : Bump.Patch;
    }

    [Pure]
    public static string NextSemVer(this GitVersion version, Bump bump)
    {
        switch (bump)
        {
            case Bump.Major:
                return string.Format("{0}.0.0", version.Major + 1);
            case Bump.Minor:
                return string.Format("{0}.{1}.0", version.Major, version.Minor + 1);
            case Bump.Patch:
                return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Patch + 1);
            default:
                throw new ArgumentOutOfRangeException(nameof(bump), bump, null);
        }
    }

    public enum Bump
    {
        Patch,
        Minor,
        Major
    }
}
