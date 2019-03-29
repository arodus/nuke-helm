// Copyright 2019 Maintainers and Contributors of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tools.NuGet;
using Nuke.GitHub;
using Nuke.Helm.Generator;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.GitHub.GitHubTasks;

partial class Build
{
    PathConstruction.AbsolutePath DefinitionRepositoryPath => TemporaryDirectory / "definition-repository";

    [Parameter("The tag of the Helm release to generate the specifications for")] readonly string HelmReleaseTag;

    Target Specifications => _ => _
        .DependentFor(Generate)
        .Requires(() => HelmReleaseTag)
        .Executes(() =>
        {
            if (Directory.Exists(DefinitionRepositoryPath))
                FileSystemTasks.DeleteDirectory(DefinitionRepositoryPath);

            const string repository = "https://github.com/helm/helm";
            Git($"clone --depth 1 --single-branch --branch {HelmReleaseTag} {repository} {DefinitionRepositoryPath}");

            var settings = new SpecificationGeneratorSettings
                           {
                               DefinitionFolder = DefinitionRepositoryPath / "docs" / "helm",
                               OutputFolder = SourceDirectory / "Nuke.Helm",
                               OverwriteFile = SourceDirectory / "Nuke.Helm" / "Helm.yml"
                           };
            SpecificationGenerator.GenerateSpecifications(settings);
        });
}
