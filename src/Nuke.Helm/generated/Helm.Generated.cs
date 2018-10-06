// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.8.0 [CommitSha: 0a204764].
// Generated from https://github.com/nuke-build/helm/blob/helm-update-2.11.0/src/Nuke.Helm/specifications/Helm.json.

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Helm
{
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmTasks
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public static string HelmPath => ToolPathResolver.GetPathExecutable("helm");
        public static IReadOnlyCollection<Output> Helm(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(HelmPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Generate autocompletions script for Helm for the specified shell (bash or zsh). This command can generate shell autocompletions. e.g. 	$ helm completion bash Can be sourced as such 	$ source &lt;(helm completion bash).</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmCompletion(Configure<HelmCompletionSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmCompletionSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command creates a chart directory along with the common files and directories used in a chart. For example, 'helm create foo' will create a directory structure that looks something like this: 	foo/ 	  | 	  |- .helmignore   # Contains patterns to ignore when packaging Helm charts. 	  | 	  |- Chart.yaml    # Information about your chart 	  | 	  |- values.yaml   # The default values for your templates 	  | 	  |- charts/       # Charts that this chart depends on 	  | 	  |- templates/    # The template files 'helm create' takes a path for an argument. If directories in the given path do not exist, Helm will attempt to create them as it goes. If the given destination exists and there are files in that directory, conflicting files will be overwritten, but other files will be left alone.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmCreate(Configure<HelmCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command takes a release name, and then deletes the release from Kubernetes. It removes all of the resources associated with the last release of the chart. Use the '--dry-run' flag to see which releases will be deleted without actually deleting them.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmDelete(Configure<HelmDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Build out the charts/ directory from the requirements.lock file. Build is used to reconstruct a chart's dependencies to the state specified in the lock file. This will not re-negotiate dependencies, as 'helm dependency update' does. If no lock file is found, 'helm dependency build' will mirror the behavior of 'helm dependency update'.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmDependencyBuild(Configure<HelmDependencyBuildSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmDependencyBuildSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>List all of the dependencies declared in a chart. This can take chart archives and chart directories as input. It will not alter the contents of a chart. This will produce an error if the chart cannot be loaded. It will emit a warning if it cannot find a requirements.yaml.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmDependencyList(Configure<HelmDependencyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmDependencyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Update the on-disk dependencies to mirror the requirements.yaml file. This command verifies that the required charts, as expressed in 'requirements.yaml', are present in 'charts/' and are at an acceptable version. It will pull down the latest charts that satisfy the dependencies, and clean up old dependencies. On successful update, this will generate a lock file that can be used to rebuild the requirements to an exact version. Dependencies are not required to be represented in 'requirements.yaml'. For that reason, an update command will not remove charts unless they are (a) present in the requirements.yaml file, but (b) at the wrong version.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmDependencyUpdate(Configure<HelmDependencyUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmDependencyUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Retrieve a package from a package repository, and download it locally. This is useful for fetching packages to inspect, modify, or repackage. It can also be used to perform cryptographic verification of a chart without installing the chart. There are options for unpacking the chart after download. This will create a directory for the chart and uncompress into that directory. If the --verify flag is specified, the requested chart MUST have a provenance file, and MUST pass the verification process. Failure in any part of this will result in an error, and the chart will not be saved locally.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmFetch(Configure<HelmFetchSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmFetchSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command shows the details of a named release. It can be used to get extended information about the release, including:   - The values used to generate the release   - The chart used to generate the release   - The generated manifest file By default, this prints a human readable collection of information about the chart, the supplied values, and the generated manifest file.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmGet(Configure<HelmGetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmGetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command downloads hooks for a given release. Hooks are formatted in YAML and separated by the YAML '---\n' separator.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmGetHooks(Configure<HelmGetHooksSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmGetHooksSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command fetches the generated manifest for a given release. A manifest is a YAML-encoded representation of the Kubernetes resources that were generated from this release's chart(s). If a chart is dependent on other charts, those resources will also be included in the manifest.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmGetManifest(Configure<HelmGetManifestSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmGetManifestSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command shows notes provided by the chart of a named release.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmGetNotes(Configure<HelmGetNotesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmGetNotesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command downloads a values file for a given release.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmGetValues(Configure<HelmGetValuesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmGetValuesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>History prints historical revisions for a given release. A default maximum of 256 revisions will be returned. Setting '--max' configures the maximum length of the revision list returned. The historical release set is printed as a formatted table, e.g:     $ helm history angry-bird --max=4     REVISION   UPDATED                      STATUS           CHART        DESCRIPTION     1           Mon Oct 3 10:15:13 2016     SUPERSEDED      alpine-0.1.0  Initial install     2           Mon Oct 3 10:15:13 2016     SUPERSEDED      alpine-0.1.0  Upgraded successfully     3           Mon Oct 3 10:15:13 2016     SUPERSEDED      alpine-0.1.0  Rolled back to 2     4           Mon Oct 3 10:15:13 2016     DEPLOYED        alpine-0.1.0  Upgraded successfully.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmHistory(Configure<HelmHistorySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmHistorySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command displays the location of HELM_HOME. This is where any helm configuration files live.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmHome(Configure<HelmHomeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmHomeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command installs Tiller (the Helm server-side component) onto your Kubernetes Cluster and sets up local configuration in $HELM_HOME (default ~/.helm/). As with the rest of the Helm commands, 'helm init' discovers Kubernetes clusters by reading $KUBECONFIG (default '~/.kube/config') and using the default context. To set up just a local environment, use '--client-only'. That will configure $HELM_HOME, but not attempt to connect to a Kubernetes cluster and install the Tiller deployment. When installing Tiller, 'helm init' will attempt to install the latest released version. You can specify an alternative image with '--tiller-image'. For those frequently working on the latest code, the flag '--canary-image' will install the latest pre-release version of Tiller (e.g. the HEAD commit in the GitHub repository on the master branch). To dump a manifest containing the Tiller deployment YAML, combine the '--dry-run' and '--debug' flags.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInit(Configure<HelmInitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command inspects a chart and displays information. It takes a chart reference ('stable/drupal'), a full path to a directory or packaged chart, or a URL. Inspect prints the contents of the Chart.yaml file and the values.yaml file.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInspect(Configure<HelmInspectSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInspectSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command inspects a chart (directory, file, or URL) and displays the contents of the Charts.yaml file.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInspectChart(Configure<HelmInspectChartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInspectChartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command inspects a chart (directory, file, or URL) and displays the contents of the README file.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInspectReadme(Configure<HelmInspectReadmeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInspectReadmeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command inspects a chart (directory, file, or URL) and displays the contents of the values.yaml file.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInspectValues(Configure<HelmInspectValuesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInspectValuesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command installs a chart archive. The install argument must be a chart reference, a path to a packaged chart, a path to an unpacked chart directory or a URL. To override values in a chart, use either the '--values' flag and pass in a file or use the '--set' flag and pass configuration from the command line.  To force string values in '--set', use '--set-string' instead. In case a value is large and therefore you want not to use neither '--values' nor '--set', use '--set-file' to read the single large value from file. 	$ helm install -f myvalues.yaml ./redis or 	$ helm install --set name=prod ./redis or 	$ helm install --set-string long_int=1234567890 ./redis or     $ helm install --set-file multiline_text=path/to/textfile You can specify the '--values'/'-f' flag multiple times. The priority will be given to the last (right-most) file specified. For example, if both myvalues.yaml and override.yaml contained a key called 'Test', the value set in override.yaml would take precedence: 	$ helm install -f myvalues.yaml -f override.yaml ./redis You can specify the '--set' flag multiple times. The priority will be given to the last (right-most) set specified. For example, if both 'bar' and 'newbar' values are set for a key called 'foo', the 'newbar' value would take precedence: 	$ helm install --set foo=bar --set foo=newbar ./redis To check the generated manifests of a release without installing the chart, the '--debug' and '--dry-run' flags can be combined. This will still require a round-trip to the Tiller server. If --verify is set, the chart MUST have a provenance file, and the provenance file MUST pass all verification steps. There are five different ways you can express the chart you want to install: 1. By chart reference: helm install stable/mariadb 2. By path to a packaged chart: helm install ./nginx-1.2.3.tgz 3. By path to an unpacked chart directory: helm install ./nginx 4. By absolute URL: helm install https://example.com/charts/nginx-1.2.3.tgz 5. By chart reference and repo url: helm install --repo https://example.com/charts/ nginx CHART REFERENCES A chart reference is a convenient way of reference a chart in a chart repository. When you use a chart reference with a repo prefix ('stable/mariadb'), Helm will look in the local configuration for a chart repository named 'stable', and will then look for a chart in that repository whose name is 'mariadb'. It will install the latest version of that chart unless you also supply a version number with the '--version' flag. To see the list of chart repositories, use 'helm repo list'. To search for charts in a repository, use 'helm search'.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmInstall(Configure<HelmInstallSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmInstallSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command takes a path to a chart and runs a series of tests to verify that the chart is well-formed. If the linter encounters things that will cause the chart to fail installation, it will emit [ERROR] messages. If it encounters issues that break with convention or recommendation, it will emit [WARNING] messages.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmLint(Configure<HelmLintSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmLintSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command lists all of the releases. By default, it lists only releases that are deployed or failed. Flags like '--deleted' and '--all' will alter this behavior. Such flags can be combined: '--deleted --failed'. By default, items are sorted alphabetically. Use the '-d' flag to sort by release date. If an argument is provided, it will be treated as a filter. Filters are regular expressions (Perl compatible) that are applied to the list of releases. Only items that match the filter will be returned. 	$ helm list 'ara[a-z]+' 	NAME            	UPDATED                 	CHART 	maudlin-arachnid	Mon May  9 16:07:08 2016	alpine-0.1.0 If no results are found, 'helm list' will exit 0, but with no output (or in the case of no '-q' flag, only headers). By default, up to 256 items may be returned. To limit this, use the '--max' flag. Setting '--max' to 0 will not return all results. Rather, it will return the server's default, which may be much higher than 256. Pairing the '--max' flag with the '--offset' flag allows you to page through results.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmList(Configure<HelmListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command packages a chart into a versioned chart archive file. If a path is given, this will look at that path for a chart (which must contain a Chart.yaml file) and then package that directory. If no path is given, this will look in the present working directory for a Chart.yaml file, and (if found) build the current directory into a chart. Versioned chart archives are used by Helm package repositories.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmPackage(Configure<HelmPackageSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmPackageSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command allows you to install a plugin from a url to a VCS repo or a local path. Example usage:     $ helm plugin install https://github.com/technosophos/helm-template.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmPluginInstall(Configure<HelmPluginInstallSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmPluginInstallSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>List installed Helm plugins.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmPluginList(Configure<HelmPluginListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmPluginListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Remove one or more Helm plugins.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmPluginRemove(Configure<HelmPluginRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmPluginRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Update one or more Helm plugins.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmPluginUpdate(Configure<HelmPluginUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmPluginUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Add a chart repository.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRepoAdd(Configure<HelmRepoAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRepoAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Read the current directory and generate an index file based on the charts found. This tool is used for creating an 'index.yaml' file for a chart repository. To set an absolute URL to the charts, use '--url' flag. To merge the generated index with an existing index file, use the '--merge' flag. In this case, the charts found in the current directory will be merged into the existing index, with local charts taking priority over existing charts.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRepoIndex(Configure<HelmRepoIndexSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRepoIndexSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>List chart repositories.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRepoList(Configure<HelmRepoListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRepoListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Remove a chart repository.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRepoRemove(Configure<HelmRepoRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRepoRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Update gets the latest information about charts from the respective chart repositories. Information is cached locally, where it is used by commands like 'helm search'. 'helm update' is the deprecated form of 'helm repo update'. It will be removed in future releases.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRepoUpdate(Configure<HelmRepoUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRepoUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command uninstalls Tiller (the Helm server-side component) from your Kubernetes Cluster and optionally deletes local configuration in $HELM_HOME (default ~/.helm/).</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmReset(Configure<HelmResetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmResetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command rolls back a release to a previous revision. The first argument of the rollback command is the name of a release, and the second is a revision (version) number. To see revision numbers, run 'helm history RELEASE'.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmRollback(Configure<HelmRollbackSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmRollbackSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Search reads through all of the repositories configured on the system, and looks for matches. Repositories are managed with 'helm repo' commands.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmSearch(Configure<HelmSearchSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmSearchSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command starts a local chart repository server that serves charts from a local directory. The new server will provide HTTP access to a repository. By default, it will scan all of the charts in '$HELM_HOME/repository/local' and serve those over the local IPv4 TCP port (default '127.0.0.1:8879'). This command is intended to be used for educational and testing purposes only. It is best to rely on a dedicated web server or a cloud-hosted solution like Google Cloud Storage for production use. See https://github.com/kubernetes/helm/blob/master/docs/chart_repository.md#hosting-chart-repositories for more information on hosting chart repositories in a production setting.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmServe(Configure<HelmServeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmServeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command shows the status of a named release. The status consists of: - last deployment time - k8s namespace in which the release lives - state of the release (can be: UNKNOWN, DEPLOYED, DELETED, SUPERSEDED, FAILED or DELETING) - list of resources that this release consists of, sorted by kind - details on last test suite run, if applicable - additional notes provided by the chart.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmStatus(Configure<HelmStatusSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmStatusSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Render chart templates locally and display the output. This does not require Tiller. However, any values that would normally be looked up or retrieved in-cluster will be faked locally. Additionally, none of the server-side testing of chart validity (e.g. whether an API is supported) is done. To render just one template in a chart, use '-x': 	$ helm template mychart -x templates/deployment.yaml.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmTemplate(Configure<HelmTemplateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmTemplateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>The test command runs the tests for a release. The argument this command takes is the name of a deployed release. The tests to be run are defined in the chart that was installed.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmTest(Configure<HelmTestSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmTestSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>This command upgrades a release to a specified version of a chart and/or updates chart values. Required arguments are release and chart. The chart argument can be one of:  - a chart reference('stable/mariadb'); use '--version' and '--devel' flags for versions other than latest,  - a path to a chart directory,  - a packaged chart,  - a fully qualified URL. To customize the chart values, use any of  - '--values'/'-f' to pass in a yaml file holding settings,  - '--set' to provide one or more key=val pairs directly,  - '--set-string' to provide key=val forcing val to be stored as a string,  - '--set-file' to provide key=path to read a single large value from a file at path. To edit or append to the existing customized values, add the   '--reuse-values' flag, otherwise any existing customized values are ignored. If no chart value arguments are provided on the command line, any existing customized values are carried forward. If you want to revert to just the values provided in the chart, use the '--reset-values' flag. You can specify any of the chart value flags multiple times. The priority will be given to the last (right-most) value specified. For example, if both myvalues.yaml and override.yaml contained a key called 'Test', the value set in override.yaml would take precedence: 	$ helm upgrade -f myvalues.yaml -f override.yaml redis ./redis Note that the key name provided to the '--set', '--set-string' and '--set-file' flags can reference structure elements. Examples:   - mybool=TRUE   - livenessProbe.timeoutSeconds=10   - metrics.annotations[0]=hey,metrics.annotations[1]=ho which sets the top level key mybool to true, the nested timeoutSeconds to 10, and two array values, respectively. Note that the value side of the key=val provided to '--set' and '--set-string' flags will pass through shell evaluation followed by yaml type parsing to produce the final value. This may alter inputs with special characters in unexpected ways, for example 	$ helm upgrade --set pwd=3jk$o2,z=f\30.e redis ./redis results in "pwd: 3jk" and "z: f30.e". Use single quotes to avoid shell evaluation and argument delimiters, and use backslash to escape yaml special characters: 	$ helm upgrade --set pwd='3jk$o2z=f\\30.e' redis ./redis which results in the expected "pwd: 3jk$o2z=f\30.e". If a single quote occurs in your value then follow your shell convention for escaping it; for example in bash: 	$ helm upgrade --set pwd='3jk$o2z=f\\30with'\''quote' which results in "pwd: 3jk$o2z=f\30with'quote".</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmUpgrade(Configure<HelmUpgradeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmUpgradeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Verify that the given chart has a valid provenance file. Provenance files provide crytographic verification that a chart has not been tampered with, and was packaged by a trusted provider. This command can be used to verify a local chart. Several other commands provide '--verify' flags that run the same validation. To generate a signed package, use the 'helm package --sign' command.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmVerify(Configure<HelmVerifySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmVerifySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Show the client and server versions for Helm and tiller. This will print a representation of the client and server versions of Helm and Tiller. The output will look something like this: Client: &amp;version.Version{SemVer:"v2.0.0", GitCommit:"ff52399e51bb880526e9cd0ed8386f6433b74da1", GitTreeState:"clean"} Server: &amp;version.Version{SemVer:"v2.0.0", GitCommit:"b0c113dfb9f612a9add796549da66c0d294508a3", GitTreeState:"clean"} - SemVer is the semantic version of the release. - GitCommit is the SHA for the commit that this version was built from. - GitTreeState is "clean" if there are no local code changes when this binary was   built, and "dirty" if the binary was built from locally modified code. To print just the client version, use '--client'. To print just the server version, use '--server'.</p><p>For more details, visit the <a href="https://helm.sh/">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> HelmVersion(Configure<HelmVersionSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new HelmVersionSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region HelmCompletionSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmCompletionSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for completion.</p></summary>
        public virtual bool? Help { get; internal set; }
        public virtual string Shell { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm completion")
              .Add("--help {value}", Help)
              .Add("{value}", Shell);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmCreateSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmCreateSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for create.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>The named Helm starter scaffold.</p></summary>
        public virtual string Starter { get; internal set; }
        /// <summary><p>The name of chart directory to create.</p></summary>
        public virtual string Name { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm create")
              .Add("--help {value}", Help)
              .Add("--starter {value}", Starter)
              .Add("{value}", Name);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmDeleteSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmDeleteSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Specify a description for the release.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Simulate a delete.</p></summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary><p>Help for delete.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Prevent hooks from running during deletion.</p></summary>
        public virtual bool? NoHooks { get; internal set; }
        /// <summary><p>Remove the release from the store and make its name free for later use.</p></summary>
        public virtual bool? Purge { get; internal set; }
        /// <summary><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        public virtual long? Timeout { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the releases to delete.</p></summary>
        public virtual IReadOnlyList<string> ReleaseNames => ReleaseNamesInternal.AsReadOnly();
        internal List<string> ReleaseNamesInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm delete")
              .Add("--description {value}", Description)
              .Add("--dry-run {value}", DryRun)
              .Add("--help {value}", Help)
              .Add("--no-hooks {value}", NoHooks)
              .Add("--purge {value}", Purge)
              .Add("--timeout {value}", Timeout)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseNames, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmDependencyBuildSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmDependencyBuildSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for build.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Verify the packages against signatures.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>The name of the chart to build.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm dependency build")
              .Add("--help {value}", Help)
              .Add("--keyring {value}", Keyring)
              .Add("--verify {value}", Verify)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmDependencyListSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmDependencyListSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for list.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>The name of the chart to list.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm dependency list")
              .Add("--help {value}", Help)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmDependencyUpdateSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmDependencyUpdateSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for update.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Do not refresh the local repository cache.</p></summary>
        public virtual bool? SkipRefresh { get; internal set; }
        /// <summary><p>Verify the packages against signatures.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>The name of the chart to update.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm dependency update")
              .Add("--help {value}", Help)
              .Add("--keyring {value}", Keyring)
              .Add("--skip-refresh {value}", SkipRefresh)
              .Add("--verify {value}", Verify)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmFetchSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmFetchSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Location to write the chart. If this and tardir are specified, tardir is appended to this (default ".").</p></summary>
        public virtual string Destination { get; internal set; }
        /// <summary><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        public virtual bool? Devel { get; internal set; }
        /// <summary><p>Help for fetch.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Chart repository password.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Fetch the provenance file, but don't perform verification.</p></summary>
        public virtual bool? Prov { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>If set to true, will untar the chart after downloading it.</p></summary>
        public virtual bool? Untar { get; internal set; }
        /// <summary><p>If untar is specified, this flag specifies the name of the directory into which the chart is expanded (default ".").</p></summary>
        public virtual string Untardir { get; internal set; }
        /// <summary><p>Chart repository username.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Verify the package against its signature.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Specific version of a chart. Without this, the latest version is fetched.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        public virtual IReadOnlyList<string> Charts => ChartsInternal.AsReadOnly();
        internal List<string> ChartsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm fetch")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--destination {value}", Destination)
              .Add("--devel {value}", Devel)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--password {value}", Password, secret: true)
              .Add("--prov {value}", Prov)
              .Add("--repo {value}", Repo)
              .Add("--untar {value}", Untar)
              .Add("--untardir {value}", Untardir)
              .Add("--username {value}", Username)
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("{value}", Charts, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmGetSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmGetSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for get.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Get the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm get")
              .Add("--help {value}", Help)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmGetHooksSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmGetHooksSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for hooks.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Get the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get the hooks for.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm get hooks")
              .Add("--help {value}", Help)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmGetManifestSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmGetManifestSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for manifest.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Get the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get the manifest for.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm get manifest")
              .Add("--help {value}", Help)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmGetNotesSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmGetNotesSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for notes.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Get the notes of the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm get notes")
              .Add("--help {value}", Help)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmGetValuesSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmGetValuesSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Dump all (computed) values.</p></summary>
        public virtual bool? All { get; internal set; }
        /// <summary><p>Help for values.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Get the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get the values for.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm get values")
              .Add("--all {value}", All)
              .Add("--help {value}", Help)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmHistorySettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmHistorySettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Specifies the max column width of output (default 60).</p></summary>
        public virtual uint? ColWidth { get; internal set; }
        /// <summary><p>Help for history.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Maximum number of revision to include in history (default 256).</p></summary>
        public virtual int? Max { get; internal set; }
        /// <summary><p>Prints the output in the specified format (json|table|yaml) (default "table").</p></summary>
        public virtual string Output { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get the history for.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm history")
              .Add("--col-width {value}", ColWidth)
              .Add("--help {value}", Help)
              .Add("--max {value}", Max)
              .Add("--output {value}", Output)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmHomeSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmHomeSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for home.</p></summary>
        public virtual bool? Help { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm home")
              .Add("--help {value}", Help);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInitSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInitSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Auto-mount the given service account to tiller (default true).</p></summary>
        public virtual bool? AutomountServiceAccountToken { get; internal set; }
        /// <summary><p>Use the canary Tiller image.</p></summary>
        public virtual bool? CanaryImage { get; internal set; }
        /// <summary><p>If set does not install Tiller.</p></summary>
        public virtual bool? ClientOnly { get; internal set; }
        /// <summary><p>Do not install local or remote.</p></summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary><p>Force upgrade of Tiller to the current helm version.</p></summary>
        public virtual bool? ForceUpgrade { get; internal set; }
        /// <summary><p>Help for init.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Limit the maximum number of revisions saved per release. Use 0 for no limit.</p></summary>
        public virtual long? HistoryMax { get; internal set; }
        /// <summary><p>URL for local repository (default "http://127.0.0.1:8879/charts").</p></summary>
        public virtual string LocalRepoUrl { get; internal set; }
        /// <summary><p>Install Tiller with net=host.</p></summary>
        public virtual bool? NetHost { get; internal set; }
        /// <summary><p>Labels to specify the node on which Tiller is installed (app=tiller,helm=rocks).</p></summary>
        public virtual string NodeSelectors { get; internal set; }
        /// <summary><p>Skip installation and output Tiller's manifest in specified format (json or yaml).</p></summary>
        public virtual HelmOutputFormat Output { get; internal set; }
        /// <summary><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> Override => OverrideInternal.AsReadOnly();
        internal Dictionary<string, object> OverrideInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Amount of tiller instances to run on the cluster (default 1).</p></summary>
        public virtual long? Replicas { get; internal set; }
        /// <summary><p>Name of service account.</p></summary>
        public virtual string ServiceAccount { get; internal set; }
        /// <summary><p>Do not refresh (download) the local repository cache.</p></summary>
        public virtual bool? SkipRefresh { get; internal set; }
        /// <summary><p>URL for stable repository (default "https://kubernetes-charts.storage.googleapis.com").</p></summary>
        public virtual string StableRepoUrl { get; internal set; }
        /// <summary><p>Override Tiller image.</p></summary>
        public virtual string TillerImage { get; internal set; }
        /// <summary><p>Install Tiller with TLS enabled.</p></summary>
        public virtual bool? TillerTls { get; internal set; }
        /// <summary><p>Path to TLS certificate file to install with Tiller.</p></summary>
        public virtual string TillerTlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from Tiller.</p></summary>
        public virtual string TillerTlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file to install with Tiller.</p></summary>
        public virtual string TillerTlsKey { get; internal set; }
        /// <summary><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        public virtual bool? TillerTlsVerify { get; internal set; }
        /// <summary><p>Path to CA root certificate.</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Upgrade if Tiller is already installed.</p></summary>
        public virtual bool? Upgrade { get; internal set; }
        /// <summary><p>Block until Tiller is running and ready to receive requests.</p></summary>
        public virtual bool? Wait { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm init")
              .Add("--automount-service-account-token {value}", AutomountServiceAccountToken)
              .Add("--canary-image {value}", CanaryImage)
              .Add("--client-only {value}", ClientOnly)
              .Add("--dry-run {value}", DryRun)
              .Add("--force-upgrade {value}", ForceUpgrade)
              .Add("--help {value}", Help)
              .Add("--history-max {value}", HistoryMax)
              .Add("--local-repo-url {value}", LocalRepoUrl)
              .Add("--net-host {value}", NetHost)
              .Add("--node-selectors {value}", NodeSelectors)
              .Add("--output {value}", Output)
              .Add("--override {value}", Override, "{key}={value}", separator: ',')
              .Add("--replicas {value}", Replicas)
              .Add("--service-account {value}", ServiceAccount)
              .Add("--skip-refresh {value}", SkipRefresh)
              .Add("--stable-repo-url {value}", StableRepoUrl)
              .Add("--tiller-image {value}", TillerImage)
              .Add("--tiller-tls {value}", TillerTls)
              .Add("--tiller-tls-cert {value}", TillerTlsCert)
              .Add("--tiller-tls-hostname {value}", TillerTlsHostname)
              .Add("--tiller-tls-key {value}", TillerTlsKey)
              .Add("--tiller-tls-verify {value}", TillerTlsVerify)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--upgrade {value}", Upgrade)
              .Add("--wait {value}", Wait);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInspectSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInspectSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Help for inspect.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Chart repository password where to locate the requested chart.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>Chart repository username where to locate the requested chart.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Verify the provenance data for this chart.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The name of the chart to inspect.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm inspect")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--password {value}", Password, secret: true)
              .Add("--repo {value}", Repo)
              .Add("--username {value}", Username)
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInspectChartSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInspectChartSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Help for chart.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Chart repository password where to locate the requested chart.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>Chart repository username where to locate the requested chart.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Verify the provenance data for this chart.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The name of the chart to inspect.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm inspect chart")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--password {value}", Password, secret: true)
              .Add("--repo {value}", Repo)
              .Add("--username {value}", Username)
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInspectReadmeSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInspectReadmeSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Help for readme.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>Verify the provenance data for this chart.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The name of the chart to inspect.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm inspect readme")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--repo {value}", Repo)
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInspectValuesSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInspectValuesSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Help for values.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Chart repository password where to locate the requested chart.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>Chart repository username where to locate the requested chart.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Verify the provenance data for this chart.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The name of the chart to inspect.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm inspect values")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--password {value}", Password, secret: true)
              .Add("--repo {value}", Repo)
              .Add("--username {value}", Username)
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmInstallSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmInstallSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Run helm dependency update before installing the chart.</p></summary>
        public virtual bool? DepUp { get; internal set; }
        /// <summary><p>Specify a description for the release.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        public virtual bool? Devel { get; internal set; }
        /// <summary><p>Simulate an install.</p></summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary><p>Help for install.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Location of public keys used for verification (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Release name. If unspecified, it will autogenerate one for you.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Specify template used to name the release.</p></summary>
        public virtual string NameTemplate { get; internal set; }
        /// <summary><p>Namespace to install the release into. Defaults to the current kube config namespace.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        public virtual bool? NoCrdHook { get; internal set; }
        /// <summary><p>Prevent hooks from running during install.</p></summary>
        public virtual bool? NoHooks { get; internal set; }
        /// <summary><p>Chart repository password where to locate the requested chart.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        public virtual bool? Replace { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> Set => SetInternal.AsReadOnly();
        internal Dictionary<string, object> SetInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetFile => SetFileInternal.AsReadOnly();
        internal Dictionary<string, object> SetFileInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetString => SetStringInternal.AsReadOnly();
        internal Dictionary<string, object> SetStringInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        public virtual long? Timeout { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>Chart repository username where to locate the requested chart.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        public virtual IReadOnlyList<string> Values => ValuesInternal.AsReadOnly();
        internal List<string> ValuesInternal { get; set; } = new List<string>();
        /// <summary><p>Verify the package before installing it.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Specify the exact chart version to install. If this is not specified, the latest version is installed.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        public virtual bool? Wait { get; internal set; }
        /// <summary><p>The name of the chart to install.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm install")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--dep-up {value}", DepUp)
              .Add("--description {value}", Description)
              .Add("--devel {value}", Devel)
              .Add("--dry-run {value}", DryRun)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--name {value}", Name)
              .Add("--name-template {value}", NameTemplate)
              .Add("--namespace {value}", Namespace)
              .Add("--no-crd-hook {value}", NoCrdHook)
              .Add("--no-hooks {value}", NoHooks)
              .Add("--password {value}", Password, secret: true)
              .Add("--replace {value}", Replace)
              .Add("--repo {value}", Repo)
              .Add("--set {value}", Set, "{key}={value}", separator: ',')
              .Add("--set-file {value}", SetFile, "{key}={value}", separator: ',')
              .Add("--set-string {value}", SetString, "{key}={value}", separator: ',')
              .Add("--timeout {value}", Timeout)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("--username {value}", Username)
              .Add("--values {value}", Values, separator: ' ')
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("--wait {value}", Wait)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmLintSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmLintSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for lint.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Namespace to put the release into (default "default").</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> Set => SetInternal.AsReadOnly();
        internal Dictionary<string, object> SetInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetFile => SetFileInternal.AsReadOnly();
        internal Dictionary<string, object> SetFileInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetString => SetStringInternal.AsReadOnly();
        internal Dictionary<string, object> SetStringInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Fail on lint warnings.</p></summary>
        public virtual bool? Strict { get; internal set; }
        /// <summary><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        public virtual IReadOnlyList<string> Values => ValuesInternal.AsReadOnly();
        internal List<string> ValuesInternal { get; set; } = new List<string>();
        /// <summary><p>The Path to a chart.</p></summary>
        public virtual string Path { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm lint")
              .Add("--help {value}", Help)
              .Add("--namespace {value}", Namespace)
              .Add("--set {value}", Set, "{key}={value}", separator: ',')
              .Add("--set-file {value}", SetFile, "{key}={value}", separator: ',')
              .Add("--set-string {value}", SetString, "{key}={value}", separator: ',')
              .Add("--strict {value}", Strict)
              .Add("--values {value}", Values, separator: ' ')
              .Add("{value}", Path);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmListSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmListSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        public virtual bool? All { get; internal set; }
        /// <summary><p>Sort by chart name.</p></summary>
        public virtual bool? ChartName { get; internal set; }
        /// <summary><p>Specifies the max column width of output (default 60).</p></summary>
        public virtual uint? ColWidth { get; internal set; }
        /// <summary><p>Sort by release date.</p></summary>
        public virtual bool? Date { get; internal set; }
        /// <summary><p>Show deleted releases.</p></summary>
        public virtual bool? Deleted { get; internal set; }
        /// <summary><p>Show releases that are currently being deleted.</p></summary>
        public virtual bool? Deleting { get; internal set; }
        /// <summary><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        public virtual bool? Deployed { get; internal set; }
        /// <summary><p>Show failed releases.</p></summary>
        public virtual bool? Failed { get; internal set; }
        /// <summary><p>Help for list.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Maximum number of releases to fetch (default 256).</p></summary>
        public virtual long? Max { get; internal set; }
        /// <summary><p>Show releases within a specific namespace.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Next release name in the list, used to offset from start value.</p></summary>
        public virtual string Offset { get; internal set; }
        /// <summary><p>Output the specified format (json or yaml).</p></summary>
        public virtual HelmOutputFormat Output { get; internal set; }
        /// <summary><p>Show pending releases.</p></summary>
        public virtual bool? Pending { get; internal set; }
        /// <summary><p>Reverse the sort order.</p></summary>
        public virtual bool? Reverse { get; internal set; }
        /// <summary><p>Output short (quiet) listing format.</p></summary>
        public virtual bool? Short { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The filter to use.</p></summary>
        public virtual string Filter { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm list")
              .Add("--all {value}", All)
              .Add("--chart-name {value}", ChartName)
              .Add("--col-width {value}", ColWidth)
              .Add("--date {value}", Date)
              .Add("--deleted {value}", Deleted)
              .Add("--deleting {value}", Deleting)
              .Add("--deployed {value}", Deployed)
              .Add("--failed {value}", Failed)
              .Add("--help {value}", Help)
              .Add("--max {value}", Max)
              .Add("--namespace {value}", Namespace)
              .Add("--offset {value}", Offset)
              .Add("--output {value}", Output)
              .Add("--pending {value}", Pending)
              .Add("--reverse {value}", Reverse)
              .Add("--short {value}", Short)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", Filter);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmPackageSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmPackageSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Set the appVersion on the chart to this version.</p></summary>
        public virtual string AppVersion { get; internal set; }
        /// <summary><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        public virtual bool? DependencyUpdate { get; internal set; }
        /// <summary><p>Location to write the chart. (default ".").</p></summary>
        public virtual string Destination { get; internal set; }
        /// <summary><p>Help for package.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Name of the key to use when signing. Used if --sign is true.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Location of a public keyring (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Save packaged chart to local chart repository (default true).</p></summary>
        public virtual bool? Save { get; internal set; }
        /// <summary><p>Use a PGP private key to sign this package.</p></summary>
        public virtual bool? Sign { get; internal set; }
        /// <summary><p>Set the version on the chart to this semver version.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>The paths to the charts to package.</p></summary>
        public virtual IReadOnlyList<string> ChartPaths => ChartPathsInternal.AsReadOnly();
        internal List<string> ChartPathsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm package")
              .Add("--app-version {value}", AppVersion)
              .Add("--dependency-update {value}", DependencyUpdate)
              .Add("--destination {value}", Destination)
              .Add("--help {value}", Help)
              .Add("--key {value}", Key)
              .Add("--keyring {value}", Keyring)
              .Add("--save {value}", Save)
              .Add("--sign {value}", Sign)
              .Add("--version {value}", Version)
              .Add("{value}", ChartPaths, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmPluginInstallSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmPluginInstallSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for install.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Specify a version constraint. If this is not specified, the latest version is installed.</p></summary>
        public virtual string Version { get; internal set; }
        public virtual string Options { get; internal set; }
        /// <summary><p>List of paths or urls of packages to install.</p></summary>
        public virtual IReadOnlyList<string> Paths => PathsInternal.AsReadOnly();
        internal List<string> PathsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm plugin install")
              .Add("--help {value}", Help)
              .Add("--version {value}", Version)
              .Add("{value}", Options)
              .Add("{value}", Paths, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmPluginListSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmPluginListSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for list.</p></summary>
        public virtual bool? Help { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm plugin list")
              .Add("--help {value}", Help);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmPluginRemoveSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmPluginRemoveSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for remove.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>List of plugins to remove.</p></summary>
        public virtual IReadOnlyList<string> Plugins => PluginsInternal.AsReadOnly();
        internal List<string> PluginsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm plugin remove")
              .Add("--help {value}", Help)
              .Add("{value}", Plugins, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmPluginUpdateSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmPluginUpdateSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for update.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>List of plugins to update.</p></summary>
        public virtual IReadOnlyList<string> Plugins => PluginsInternal.AsReadOnly();
        internal List<string> PluginsInternal { get; set; } = new List<string>();
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm plugin update")
              .Add("--help {value}", Help)
              .Add("{value}", Plugins, separator: ' ');
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRepoAddSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRepoAddSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Help for add.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Raise error if repo is already registered.</p></summary>
        public virtual bool? NoUpdate { get; internal set; }
        /// <summary><p>Chart repository password.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Chart repository username.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>The name of the repository to add.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The url of the repository to add.</p></summary>
        public virtual string Url { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm repo add")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--help {value}", Help)
              .Add("--key-file {value}", KeyFile)
              .Add("--no-update {value}", NoUpdate)
              .Add("--password {value}", Password, secret: true)
              .Add("--username {value}", Username)
              .Add("{value}", Name)
              .Add("{value}", Url);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRepoIndexSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRepoIndexSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for index.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Merge the generated index into the given index.</p></summary>
        public virtual string Merge { get; internal set; }
        /// <summary><p>Url of chart repository.</p></summary>
        public virtual string Url { get; internal set; }
        /// <summary><p>The directory of the repository.</p></summary>
        public virtual string Directory { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm repo index")
              .Add("--help {value}", Help)
              .Add("--merge {value}", Merge)
              .Add("--url {value}", Url)
              .Add("{value}", Directory);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRepoListSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRepoListSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for list.</p></summary>
        public virtual bool? Help { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm repo list")
              .Add("--help {value}", Help);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRepoRemoveSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRepoRemoveSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for remove.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>The name of the repository.</p></summary>
        public virtual string Name { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm repo remove")
              .Add("--help {value}", Help)
              .Add("{value}", Name);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRepoUpdateSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRepoUpdateSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for update.</p></summary>
        public virtual bool? Help { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm repo update")
              .Add("--help {value}", Help);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmResetSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmResetSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        public virtual bool? Force { get; internal set; }
        /// <summary><p>Help for reset.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>If set deletes $HELM_HOME.</p></summary>
        public virtual bool? RemoveHelmHome { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm reset")
              .Add("--force {value}", Force)
              .Add("--help {value}", Help)
              .Add("--remove-helm-home {value}", RemoveHelmHome)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmRollbackSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmRollbackSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Specify a description for the release.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Simulate a rollback.</p></summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary><p>Force resource update through delete/recreate if needed.</p></summary>
        public virtual bool? Force { get; internal set; }
        /// <summary><p>Help for rollback.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Prevent hooks from running during rollback.</p></summary>
        public virtual bool? NoHooks { get; internal set; }
        /// <summary><p>Performs pods restart for the resource if applicable.</p></summary>
        public virtual bool? RecreatePods { get; internal set; }
        /// <summary><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        public virtual long? Timeout { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        public virtual bool? Wait { get; internal set; }
        /// <summary><p>The name of the release.</p></summary>
        public virtual string Release { get; internal set; }
        /// <summary><p>The revison to roll back.</p></summary>
        public virtual string Revision { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm rollback")
              .Add("--description {value}", Description)
              .Add("--dry-run {value}", DryRun)
              .Add("--force {value}", Force)
              .Add("--help {value}", Help)
              .Add("--no-hooks {value}", NoHooks)
              .Add("--recreate-pods {value}", RecreatePods)
              .Add("--timeout {value}", Timeout)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("--wait {value}", Wait)
              .Add("{value}", Release)
              .Add("{value}", Revision);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmSearchSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmSearchSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Specifies the max column width of output (default 60).</p></summary>
        public virtual uint? ColWidth { get; internal set; }
        /// <summary><p>Help for search.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Use regular expressions for searching.</p></summary>
        public virtual bool? Regexp { get; internal set; }
        /// <summary><p>Search using semantic versioning constraints.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        public virtual bool? Versions { get; internal set; }
        /// <summary><p>The keyword to search for.</p></summary>
        public virtual string Keyword { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm search")
              .Add("--col-width {value}", ColWidth)
              .Add("--help {value}", Help)
              .Add("--regexp {value}", Regexp)
              .Add("--version {value}", Version)
              .Add("--versions {value}", Versions)
              .Add("{value}", Keyword);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmServeSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmServeSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Address to listen on (default "127.0.0.1:8879").</p></summary>
        public virtual string Address { get; internal set; }
        /// <summary><p>Help for serve.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Local directory path from which to serve charts.</p></summary>
        public virtual string RepoPath { get; internal set; }
        /// <summary><p>External URL of chart repository.</p></summary>
        public virtual string Url { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm serve")
              .Add("--address {value}", Address)
              .Add("--help {value}", Help)
              .Add("--repo-path {value}", RepoPath)
              .Add("--url {value}", Url);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmStatusSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmStatusSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for status.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Output the status in the specified format (json or yaml).</p></summary>
        public virtual HelmOutputFormat Output { get; internal set; }
        /// <summary><p>If set, display the status of the named release with revision.</p></summary>
        public virtual int? Revision { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to get the status for.</p></summary>
        public virtual string ReleaseName { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm status")
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--revision {value}", Revision)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", ReleaseName);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmTemplateSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmTemplateSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Only execute the given templates.</p></summary>
        public virtual IReadOnlyDictionary<string, object> Execute => ExecuteInternal.AsReadOnly();
        internal Dictionary<string, object> ExecuteInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Help for template.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        public virtual bool? IsUpgrade { get; internal set; }
        /// <summary><p>Kubernetes version used as Capabilities.KubeVersion.Major/Minor (default "1.9").</p></summary>
        public virtual string KubeVersion { get; internal set; }
        /// <summary><p>Release name (default "RELEASE-NAME").</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Specify template used to name the release.</p></summary>
        public virtual string NameTemplate { get; internal set; }
        /// <summary><p>Namespace to install the release into.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Show the computed NOTES.txt file as well.</p></summary>
        public virtual bool? Notes { get; internal set; }
        /// <summary><p>Writes the executed templates to files in output-dir instead of stdout.</p></summary>
        public virtual string OutputDir { get; internal set; }
        /// <summary><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> Set => SetInternal.AsReadOnly();
        internal Dictionary<string, object> SetInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetFile => SetFileInternal.AsReadOnly();
        internal Dictionary<string, object> SetFileInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetString => SetStringInternal.AsReadOnly();
        internal Dictionary<string, object> SetStringInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        public virtual IReadOnlyList<string> Values => ValuesInternal.AsReadOnly();
        internal List<string> ValuesInternal { get; set; } = new List<string>();
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm template")
              .Add("--execute {value}", Execute, "{key}={value}", separator: ',')
              .Add("--help {value}", Help)
              .Add("--is-upgrade {value}", IsUpgrade)
              .Add("--kube-version {value}", KubeVersion)
              .Add("--name {value}", Name)
              .Add("--name-template {value}", NameTemplate)
              .Add("--namespace {value}", Namespace)
              .Add("--notes {value}", Notes)
              .Add("--output-dir {value}", OutputDir)
              .Add("--set {value}", Set, "{key}={value}", separator: ',')
              .Add("--set-file {value}", SetFile, "{key}={value}", separator: ',')
              .Add("--set-string {value}", SetString, "{key}={value}", separator: ',')
              .Add("--values {value}", Values, separator: ' ')
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmTestSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmTestSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Delete test pods upon completion.</p></summary>
        public virtual bool? Cleanup { get; internal set; }
        /// <summary><p>Help for test.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        public virtual long? Timeout { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>The name of the release to test.</p></summary>
        public virtual string Release { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm test")
              .Add("--cleanup {value}", Cleanup)
              .Add("--help {value}", Help)
              .Add("--timeout {value}", Timeout)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("{value}", Release);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmUpgradeSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmUpgradeSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        public virtual string CaFile { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        public virtual string CertFile { get; internal set; }
        /// <summary><p>Specify the description to use for the upgrade, rather than the default.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        public virtual bool? Devel { get; internal set; }
        /// <summary><p>Simulate an upgrade.</p></summary>
        public virtual bool? DryRun { get; internal set; }
        /// <summary><p>Force resource update through delete/recreate if needed.</p></summary>
        public virtual bool? Force { get; internal set; }
        /// <summary><p>Help for upgrade.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>If a release by this name doesn't already exist, run an install.</p></summary>
        public virtual bool? Install { get; internal set; }
        /// <summary><p>Identify HTTPS client using this SSL key file.</p></summary>
        public virtual string KeyFile { get; internal set; }
        /// <summary><p>Path to the keyring that contains public signing keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>Namespace to install the release into (only used if --install is set). Defaults to the current kube config namespace.</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Disable pre/post upgrade hooks.</p></summary>
        public virtual bool? NoHooks { get; internal set; }
        /// <summary><p>Chart repository password where to locate the requested chart.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Performs pods restart for the resource if applicable.</p></summary>
        public virtual bool? RecreatePods { get; internal set; }
        /// <summary><p>Chart repository url where to locate the requested chart.</p></summary>
        public virtual string Repo { get; internal set; }
        /// <summary><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        public virtual bool? ResetValues { get; internal set; }
        /// <summary><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        public virtual bool? ReuseValues { get; internal set; }
        /// <summary><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> Set => SetInternal.AsReadOnly();
        internal Dictionary<string, object> SetInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetFile => SetFileInternal.AsReadOnly();
        internal Dictionary<string, object> SetFileInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        public virtual IReadOnlyDictionary<string, object> SetString => SetStringInternal.AsReadOnly();
        internal Dictionary<string, object> SetStringInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        public virtual long? Timeout { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        /// <summary><p>Chart repository username where to locate the requested chart.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        public virtual IReadOnlyList<string> Values => ValuesInternal.AsReadOnly();
        internal List<string> ValuesInternal { get; set; } = new List<string>();
        /// <summary><p>Verify the provenance of the chart before upgrading.</p></summary>
        public virtual bool? Verify { get; internal set; }
        /// <summary><p>Specify the exact chart version to use. If this is not specified, the latest version is used.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        public virtual bool? Wait { get; internal set; }
        /// <summary><p>The name of the release to upgrade.</p></summary>
        public virtual string Release { get; internal set; }
        /// <summary><p>The name of the chart to upgrade.</p></summary>
        public virtual string Chart { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm upgrade")
              .Add("--ca-file {value}", CaFile)
              .Add("--cert-file {value}", CertFile)
              .Add("--description {value}", Description)
              .Add("--devel {value}", Devel)
              .Add("--dry-run {value}", DryRun)
              .Add("--force {value}", Force)
              .Add("--help {value}", Help)
              .Add("--install {value}", Install)
              .Add("--key-file {value}", KeyFile)
              .Add("--keyring {value}", Keyring)
              .Add("--namespace {value}", Namespace)
              .Add("--no-hooks {value}", NoHooks)
              .Add("--password {value}", Password, secret: true)
              .Add("--recreate-pods {value}", RecreatePods)
              .Add("--repo {value}", Repo)
              .Add("--reset-values {value}", ResetValues)
              .Add("--reuse-values {value}", ReuseValues)
              .Add("--set {value}", Set, "{key}={value}", separator: ',')
              .Add("--set-file {value}", SetFile, "{key}={value}", separator: ',')
              .Add("--set-string {value}", SetString, "{key}={value}", separator: ',')
              .Add("--timeout {value}", Timeout)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify)
              .Add("--username {value}", Username)
              .Add("--values {value}", Values, separator: ' ')
              .Add("--verify {value}", Verify)
              .Add("--version {value}", Version)
              .Add("--wait {value}", Wait)
              .Add("{value}", Release)
              .Add("{value}", Chart);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmVerifySettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmVerifySettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Help for verify.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        public virtual string Keyring { get; internal set; }
        /// <summary><p>The path to the chart to verify.</p></summary>
        public virtual string Path { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm verify")
              .Add("--help {value}", Help)
              .Add("--keyring {value}", Keyring)
              .Add("{value}", Path);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmVersionSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmVersionSettings : HelmToolSettings
    {
        /// <summary><p>Path to the Helm executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? HelmTasks.HelmPath;
        /// <summary><p>Client version only.</p></summary>
        public virtual bool? Client { get; internal set; }
        /// <summary><p>Help for version.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Server version only.</p></summary>
        public virtual bool? Server { get; internal set; }
        /// <summary><p>Print the version number.</p></summary>
        public virtual bool? Short { get; internal set; }
        /// <summary><p>Template for version string format.</p></summary>
        public virtual string Template { get; internal set; }
        /// <summary><p>Enable TLS for request.</p></summary>
        public virtual bool? Tls { get; internal set; }
        /// <summary><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        public virtual string TlsCaCert { get; internal set; }
        /// <summary><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        public virtual string TlsCert { get; internal set; }
        /// <summary><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        public virtual string TlsHostname { get; internal set; }
        /// <summary><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        public virtual string TlsKey { get; internal set; }
        /// <summary><p>Enable TLS for request and verify remote.</p></summary>
        public virtual bool? TlsVerify { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("helm version")
              .Add("--client {value}", Client)
              .Add("--help {value}", Help)
              .Add("--server {value}", Server)
              .Add("--short {value}", Short)
              .Add("--template {value}", Template)
              .Add("--tls {value}", Tls)
              .Add("--tls-ca-cert {value}", TlsCaCert)
              .Add("--tls-cert {value}", TlsCert)
              .Add("--tls-hostname {value}", TlsHostname)
              .Add("--tls-key {value}", TlsKey)
              .Add("--tls-verify {value}", TlsVerify);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmCommonSettings
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class HelmCommonSettings : ToolSettings
    {
        /// <summary><p>Enable verbose output.</p></summary>
        public virtual bool? Debug { get; internal set; }
        /// <summary><p>Help for helm.</p></summary>
        public virtual bool? Help { get; internal set; }
        /// <summary><p>Location of your Helm config. Overrides $HELM_HOME (default "~/.helm").</p></summary>
        public virtual string Home { get; internal set; }
        /// <summary><p>Address of Tiller. Overrides $HELM_HOST.</p></summary>
        public virtual string Host { get; internal set; }
        /// <summary><p>Name of the kubeconfig context to use.</p></summary>
        public virtual string KubeContext { get; internal set; }
        /// <summary><p>Absolute path to the kubeconfig file to use.</p></summary>
        public virtual string Kubeconfig { get; internal set; }
        /// <summary><p>The duration (in seconds) Helm will wait to establish a connection to tiller (default 300).</p></summary>
        public virtual long? TillerConnectionTimeout { get; internal set; }
        /// <summary><p>Namespace of Tiller (default "kube-system").</p></summary>
        public virtual string TillerNamespace { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
            
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--home {value}", Home)
              .Add("--host {value}", Host)
              .Add("--kube-context {value}", KubeContext)
              .Add("--kubeconfig {value}", Kubeconfig)
              .Add("--tiller-connection-timeout {value}", TillerConnectionTimeout)
              .Add("--tiller-namespace {value}", TillerNamespace);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region HelmCompletionSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmCompletionSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmCompletionSettings.Help"/>.</em></p><p>Help for completion.</p></summary>
        [Pure]
        public static HelmCompletionSettings SetHelp(this HelmCompletionSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCompletionSettings.Help"/>.</em></p><p>Help for completion.</p></summary>
        [Pure]
        public static HelmCompletionSettings ResetHelp(this HelmCompletionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmCompletionSettings.Help"/>.</em></p><p>Help for completion.</p></summary>
        [Pure]
        public static HelmCompletionSettings EnableHelp(this HelmCompletionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmCompletionSettings.Help"/>.</em></p><p>Help for completion.</p></summary>
        [Pure]
        public static HelmCompletionSettings DisableHelp(this HelmCompletionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmCompletionSettings.Help"/>.</em></p><p>Help for completion.</p></summary>
        [Pure]
        public static HelmCompletionSettings ToggleHelp(this HelmCompletionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Shell
        /// <summary><p><em>Sets <see cref="HelmCompletionSettings.Shell"/>.</em></p></summary>
        [Pure]
        public static HelmCompletionSettings SetShell(this HelmCompletionSettings toolSettings, string shell)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Shell = shell;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCompletionSettings.Shell"/>.</em></p></summary>
        [Pure]
        public static HelmCompletionSettings ResetShell(this HelmCompletionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Shell = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmCreateSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmCreateSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmCreateSettings.Help"/>.</em></p><p>Help for create.</p></summary>
        [Pure]
        public static HelmCreateSettings SetHelp(this HelmCreateSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCreateSettings.Help"/>.</em></p><p>Help for create.</p></summary>
        [Pure]
        public static HelmCreateSettings ResetHelp(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmCreateSettings.Help"/>.</em></p><p>Help for create.</p></summary>
        [Pure]
        public static HelmCreateSettings EnableHelp(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmCreateSettings.Help"/>.</em></p><p>Help for create.</p></summary>
        [Pure]
        public static HelmCreateSettings DisableHelp(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmCreateSettings.Help"/>.</em></p><p>Help for create.</p></summary>
        [Pure]
        public static HelmCreateSettings ToggleHelp(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Starter
        /// <summary><p><em>Sets <see cref="HelmCreateSettings.Starter"/>.</em></p><p>The named Helm starter scaffold.</p></summary>
        [Pure]
        public static HelmCreateSettings SetStarter(this HelmCreateSettings toolSettings, string starter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Starter = starter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCreateSettings.Starter"/>.</em></p><p>The named Helm starter scaffold.</p></summary>
        [Pure]
        public static HelmCreateSettings ResetStarter(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Starter = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="HelmCreateSettings.Name"/>.</em></p><p>The name of chart directory to create.</p></summary>
        [Pure]
        public static HelmCreateSettings SetName(this HelmCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCreateSettings.Name"/>.</em></p><p>The name of chart directory to create.</p></summary>
        [Pure]
        public static HelmCreateSettings ResetName(this HelmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmDeleteSettingsExtensions
    {
        #region Description
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetDescription(this HelmDeleteSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetDescription(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.DryRun"/>.</em></p><p>Simulate a delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetDryRun(this HelmDeleteSettings toolSettings, bool? dryRun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.DryRun"/>.</em></p><p>Simulate a delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetDryRun(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.DryRun"/>.</em></p><p>Simulate a delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnableDryRun(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.DryRun"/>.</em></p><p>Simulate a delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisableDryRun(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.DryRun"/>.</em></p><p>Simulate a delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings ToggleDryRun(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.Help"/>.</em></p><p>Help for delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetHelp(this HelmDeleteSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.Help"/>.</em></p><p>Help for delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetHelp(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.Help"/>.</em></p><p>Help for delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnableHelp(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.Help"/>.</em></p><p>Help for delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisableHelp(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.Help"/>.</em></p><p>Help for delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings ToggleHelp(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region NoHooks
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during deletion.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetNoHooks(this HelmDeleteSettings toolSettings, bool? noHooks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = noHooks;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during deletion.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetNoHooks(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during deletion.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnableNoHooks(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during deletion.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisableNoHooks(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during deletion.</p></summary>
        [Pure]
        public static HelmDeleteSettings ToggleNoHooks(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = !toolSettings.NoHooks;
            return toolSettings;
        }
        #endregion
        #region Purge
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.Purge"/>.</em></p><p>Remove the release from the store and make its name free for later use.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetPurge(this HelmDeleteSettings toolSettings, bool? purge)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Purge = purge;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.Purge"/>.</em></p><p>Remove the release from the store and make its name free for later use.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetPurge(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Purge = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.Purge"/>.</em></p><p>Remove the release from the store and make its name free for later use.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnablePurge(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Purge = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.Purge"/>.</em></p><p>Remove the release from the store and make its name free for later use.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisablePurge(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Purge = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.Purge"/>.</em></p><p>Remove the release from the store and make its name free for later use.</p></summary>
        [Pure]
        public static HelmDeleteSettings TogglePurge(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Purge = !toolSettings.Purge;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTimeout(this HelmDeleteSettings toolSettings, long? timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTimeout(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTls(this HelmDeleteSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTls(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnableTls(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisableTls(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmDeleteSettings ToggleTls(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTlsCaCert(this HelmDeleteSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTlsCaCert(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTlsCert(this HelmDeleteSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTlsCert(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTlsHostname(this HelmDeleteSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTlsHostname(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTlsKey(this HelmDeleteSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTlsKey(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetTlsVerify(this HelmDeleteSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDeleteSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmDeleteSettings ResetTlsVerify(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDeleteSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmDeleteSettings EnableTlsVerify(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDeleteSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmDeleteSettings DisableTlsVerify(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDeleteSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmDeleteSettings ToggleTlsVerify(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseNames
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.ReleaseNames"/> to a new list.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetReleaseNames(this HelmDeleteSettings toolSettings, params string[] releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNamesInternal = releaseNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmDeleteSettings.ReleaseNames"/> to a new list.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings SetReleaseNames(this HelmDeleteSettings toolSettings, IEnumerable<string> releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNamesInternal = releaseNames.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmDeleteSettings.ReleaseNames"/>.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings AddReleaseNames(this HelmDeleteSettings toolSettings, params string[] releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNamesInternal.AddRange(releaseNames);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmDeleteSettings.ReleaseNames"/>.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings AddReleaseNames(this HelmDeleteSettings toolSettings, IEnumerable<string> releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNamesInternal.AddRange(releaseNames);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmDeleteSettings.ReleaseNames"/>.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings ClearReleaseNames(this HelmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNamesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmDeleteSettings.ReleaseNames"/>.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings RemoveReleaseNames(this HelmDeleteSettings toolSettings, params string[] releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(releaseNames);
            toolSettings.ReleaseNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmDeleteSettings.ReleaseNames"/>.</em></p><p>The name of the releases to delete.</p></summary>
        [Pure]
        public static HelmDeleteSettings RemoveReleaseNames(this HelmDeleteSettings toolSettings, IEnumerable<string> releaseNames)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(releaseNames);
            toolSettings.ReleaseNamesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmDependencyBuildSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmDependencyBuildSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmDependencyBuildSettings.Help"/>.</em></p><p>Help for build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings SetHelp(this HelmDependencyBuildSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyBuildSettings.Help"/>.</em></p><p>Help for build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ResetHelp(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyBuildSettings.Help"/>.</em></p><p>Help for build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings EnableHelp(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyBuildSettings.Help"/>.</em></p><p>Help for build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings DisableHelp(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyBuildSettings.Help"/>.</em></p><p>Help for build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ToggleHelp(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmDependencyBuildSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings SetKeyring(this HelmDependencyBuildSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyBuildSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ResetKeyring(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmDependencyBuildSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings SetVerify(this HelmDependencyBuildSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyBuildSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ResetVerify(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyBuildSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings EnableVerify(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyBuildSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings DisableVerify(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyBuildSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ToggleVerify(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmDependencyBuildSettings.Chart"/>.</em></p><p>The name of the chart to build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings SetChart(this HelmDependencyBuildSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyBuildSettings.Chart"/>.</em></p><p>The name of the chart to build.</p></summary>
        [Pure]
        public static HelmDependencyBuildSettings ResetChart(this HelmDependencyBuildSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmDependencyListSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmDependencyListSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmDependencyListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings SetHelp(this HelmDependencyListSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings ResetHelp(this HelmDependencyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings EnableHelp(this HelmDependencyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings DisableHelp(this HelmDependencyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings ToggleHelp(this HelmDependencyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmDependencyListSettings.Chart"/>.</em></p><p>The name of the chart to list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings SetChart(this HelmDependencyListSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyListSettings.Chart"/>.</em></p><p>The name of the chart to list.</p></summary>
        [Pure]
        public static HelmDependencyListSettings ResetChart(this HelmDependencyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmDependencyUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmDependencyUpdateSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmDependencyUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings SetHelp(this HelmDependencyUpdateSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ResetHelp(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings EnableHelp(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings DisableHelp(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ToggleHelp(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmDependencyUpdateSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings SetKeyring(this HelmDependencyUpdateSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyUpdateSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ResetKeyring(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region SkipRefresh
        /// <summary><p><em>Sets <see cref="HelmDependencyUpdateSettings.SkipRefresh"/>.</em></p><p>Do not refresh the local repository cache.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings SetSkipRefresh(this HelmDependencyUpdateSettings toolSettings, bool? skipRefresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = skipRefresh;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyUpdateSettings.SkipRefresh"/>.</em></p><p>Do not refresh the local repository cache.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ResetSkipRefresh(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyUpdateSettings.SkipRefresh"/>.</em></p><p>Do not refresh the local repository cache.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings EnableSkipRefresh(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyUpdateSettings.SkipRefresh"/>.</em></p><p>Do not refresh the local repository cache.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings DisableSkipRefresh(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyUpdateSettings.SkipRefresh"/>.</em></p><p>Do not refresh the local repository cache.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ToggleSkipRefresh(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = !toolSettings.SkipRefresh;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmDependencyUpdateSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings SetVerify(this HelmDependencyUpdateSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyUpdateSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ResetVerify(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmDependencyUpdateSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings EnableVerify(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmDependencyUpdateSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings DisableVerify(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmDependencyUpdateSettings.Verify"/>.</em></p><p>Verify the packages against signatures.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ToggleVerify(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmDependencyUpdateSettings.Chart"/>.</em></p><p>The name of the chart to update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings SetChart(this HelmDependencyUpdateSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmDependencyUpdateSettings.Chart"/>.</em></p><p>The name of the chart to update.</p></summary>
        [Pure]
        public static HelmDependencyUpdateSettings ResetChart(this HelmDependencyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmFetchSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmFetchSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmFetchSettings SetCaFile(this HelmFetchSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetCaFile(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmFetchSettings SetCertFile(this HelmFetchSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetCertFile(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Destination
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Destination"/>.</em></p><p>Location to write the chart. If this and tardir are specified, tardir is appended to this (default ".").</p></summary>
        [Pure]
        public static HelmFetchSettings SetDestination(this HelmFetchSettings toolSettings, string destination)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = destination;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Destination"/>.</em></p><p>Location to write the chart. If this and tardir are specified, tardir is appended to this (default ".").</p></summary>
        [Pure]
        public static HelmFetchSettings ResetDestination(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = null;
            return toolSettings;
        }
        #endregion
        #region Devel
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmFetchSettings SetDevel(this HelmFetchSettings toolSettings, bool? devel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = devel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetDevel(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmFetchSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmFetchSettings EnableDevel(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmFetchSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmFetchSettings DisableDevel(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmFetchSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmFetchSettings ToggleDevel(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = !toolSettings.Devel;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Help"/>.</em></p><p>Help for fetch.</p></summary>
        [Pure]
        public static HelmFetchSettings SetHelp(this HelmFetchSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Help"/>.</em></p><p>Help for fetch.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetHelp(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmFetchSettings.Help"/>.</em></p><p>Help for fetch.</p></summary>
        [Pure]
        public static HelmFetchSettings EnableHelp(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmFetchSettings.Help"/>.</em></p><p>Help for fetch.</p></summary>
        [Pure]
        public static HelmFetchSettings DisableHelp(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmFetchSettings.Help"/>.</em></p><p>Help for fetch.</p></summary>
        [Pure]
        public static HelmFetchSettings ToggleHelp(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmFetchSettings SetKeyFile(this HelmFetchSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetKeyFile(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmFetchSettings SetKeyring(this HelmFetchSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmFetchSettings ResetKeyring(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Password"/>.</em></p><p>Chart repository password.</p></summary>
        [Pure]
        public static HelmFetchSettings SetPassword(this HelmFetchSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Password"/>.</em></p><p>Chart repository password.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetPassword(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Prov
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Prov"/>.</em></p><p>Fetch the provenance file, but don't perform verification.</p></summary>
        [Pure]
        public static HelmFetchSettings SetProv(this HelmFetchSettings toolSettings, bool? prov)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prov = prov;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Prov"/>.</em></p><p>Fetch the provenance file, but don't perform verification.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetProv(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prov = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmFetchSettings.Prov"/>.</em></p><p>Fetch the provenance file, but don't perform verification.</p></summary>
        [Pure]
        public static HelmFetchSettings EnableProv(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prov = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmFetchSettings.Prov"/>.</em></p><p>Fetch the provenance file, but don't perform verification.</p></summary>
        [Pure]
        public static HelmFetchSettings DisableProv(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prov = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmFetchSettings.Prov"/>.</em></p><p>Fetch the provenance file, but don't perform verification.</p></summary>
        [Pure]
        public static HelmFetchSettings ToggleProv(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prov = !toolSettings.Prov;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmFetchSettings SetRepo(this HelmFetchSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetRepo(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Untar
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Untar"/>.</em></p><p>If set to true, will untar the chart after downloading it.</p></summary>
        [Pure]
        public static HelmFetchSettings SetUntar(this HelmFetchSettings toolSettings, bool? untar)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untar = untar;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Untar"/>.</em></p><p>If set to true, will untar the chart after downloading it.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetUntar(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untar = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmFetchSettings.Untar"/>.</em></p><p>If set to true, will untar the chart after downloading it.</p></summary>
        [Pure]
        public static HelmFetchSettings EnableUntar(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untar = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmFetchSettings.Untar"/>.</em></p><p>If set to true, will untar the chart after downloading it.</p></summary>
        [Pure]
        public static HelmFetchSettings DisableUntar(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untar = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmFetchSettings.Untar"/>.</em></p><p>If set to true, will untar the chart after downloading it.</p></summary>
        [Pure]
        public static HelmFetchSettings ToggleUntar(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untar = !toolSettings.Untar;
            return toolSettings;
        }
        #endregion
        #region Untardir
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Untardir"/>.</em></p><p>If untar is specified, this flag specifies the name of the directory into which the chart is expanded (default ".").</p></summary>
        [Pure]
        public static HelmFetchSettings SetUntardir(this HelmFetchSettings toolSettings, string untardir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untardir = untardir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Untardir"/>.</em></p><p>If untar is specified, this flag specifies the name of the directory into which the chart is expanded (default ".").</p></summary>
        [Pure]
        public static HelmFetchSettings ResetUntardir(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Untardir = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Username"/>.</em></p><p>Chart repository username.</p></summary>
        [Pure]
        public static HelmFetchSettings SetUsername(this HelmFetchSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Username"/>.</em></p><p>Chart repository username.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetUsername(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Verify"/>.</em></p><p>Verify the package against its signature.</p></summary>
        [Pure]
        public static HelmFetchSettings SetVerify(this HelmFetchSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Verify"/>.</em></p><p>Verify the package against its signature.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetVerify(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmFetchSettings.Verify"/>.</em></p><p>Verify the package against its signature.</p></summary>
        [Pure]
        public static HelmFetchSettings EnableVerify(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmFetchSettings.Verify"/>.</em></p><p>Verify the package against its signature.</p></summary>
        [Pure]
        public static HelmFetchSettings DisableVerify(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmFetchSettings.Verify"/>.</em></p><p>Verify the package against its signature.</p></summary>
        [Pure]
        public static HelmFetchSettings ToggleVerify(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Version"/>.</em></p><p>Specific version of a chart. Without this, the latest version is fetched.</p></summary>
        [Pure]
        public static HelmFetchSettings SetVersion(this HelmFetchSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmFetchSettings.Version"/>.</em></p><p>Specific version of a chart. Without this, the latest version is fetched.</p></summary>
        [Pure]
        public static HelmFetchSettings ResetVersion(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Charts
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Charts"/> to a new list.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings SetCharts(this HelmFetchSettings toolSettings, params string[] charts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartsInternal = charts.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmFetchSettings.Charts"/> to a new list.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings SetCharts(this HelmFetchSettings toolSettings, IEnumerable<string> charts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartsInternal = charts.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmFetchSettings.Charts"/>.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings AddCharts(this HelmFetchSettings toolSettings, params string[] charts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartsInternal.AddRange(charts);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmFetchSettings.Charts"/>.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings AddCharts(this HelmFetchSettings toolSettings, IEnumerable<string> charts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartsInternal.AddRange(charts);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmFetchSettings.Charts"/>.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings ClearCharts(this HelmFetchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmFetchSettings.Charts"/>.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings RemoveCharts(this HelmFetchSettings toolSettings, params string[] charts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(charts);
            toolSettings.ChartsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmFetchSettings.Charts"/>.</em></p><p>The charts to fetch. Can either be specified by <c>repoName/chartName</c> or directly by an url.</p></summary>
        [Pure]
        public static HelmFetchSettings RemoveCharts(this HelmFetchSettings toolSettings, IEnumerable<string> charts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(charts);
            toolSettings.ChartsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmGetSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmGetSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmGetSettings.Help"/>.</em></p><p>Help for get.</p></summary>
        [Pure]
        public static HelmGetSettings SetHelp(this HelmGetSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.Help"/>.</em></p><p>Help for get.</p></summary>
        [Pure]
        public static HelmGetSettings ResetHelp(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetSettings.Help"/>.</em></p><p>Help for get.</p></summary>
        [Pure]
        public static HelmGetSettings EnableHelp(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetSettings.Help"/>.</em></p><p>Help for get.</p></summary>
        [Pure]
        public static HelmGetSettings DisableHelp(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetSettings.Help"/>.</em></p><p>Help for get.</p></summary>
        [Pure]
        public static HelmGetSettings ToggleHelp(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmGetSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetSettings SetRevision(this HelmGetSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetSettings ResetRevision(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmGetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetSettings SetTls(this HelmGetSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetSettings ResetTls(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetSettings EnableTls(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetSettings DisableTls(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetSettings ToggleTls(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmGetSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetSettings SetTlsCaCert(this HelmGetSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetSettings ResetTlsCaCert(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmGetSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetSettings SetTlsCert(this HelmGetSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetSettings ResetTlsCert(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmGetSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetSettings SetTlsHostname(this HelmGetSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetSettings ResetTlsHostname(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmGetSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetSettings SetTlsKey(this HelmGetSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetSettings ResetTlsKey(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmGetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetSettings SetTlsVerify(this HelmGetSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetSettings ResetTlsVerify(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetSettings EnableTlsVerify(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetSettings DisableTlsVerify(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetSettings ToggleTlsVerify(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmGetSettings.ReleaseName"/>.</em></p><p>The name of the release to get.</p></summary>
        [Pure]
        public static HelmGetSettings SetReleaseName(this HelmGetSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetSettings.ReleaseName"/>.</em></p><p>The name of the release to get.</p></summary>
        [Pure]
        public static HelmGetSettings ResetReleaseName(this HelmGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmGetHooksSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmGetHooksSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.Help"/>.</em></p><p>Help for hooks.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetHelp(this HelmGetHooksSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.Help"/>.</em></p><p>Help for hooks.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetHelp(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetHooksSettings.Help"/>.</em></p><p>Help for hooks.</p></summary>
        [Pure]
        public static HelmGetHooksSettings EnableHelp(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetHooksSettings.Help"/>.</em></p><p>Help for hooks.</p></summary>
        [Pure]
        public static HelmGetHooksSettings DisableHelp(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetHooksSettings.Help"/>.</em></p><p>Help for hooks.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ToggleHelp(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetRevision(this HelmGetHooksSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetRevision(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTls(this HelmGetHooksSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTls(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetHooksSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetHooksSettings EnableTls(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetHooksSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetHooksSettings DisableTls(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetHooksSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ToggleTls(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTlsCaCert(this HelmGetHooksSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTlsCaCert(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTlsCert(this HelmGetHooksSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTlsCert(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTlsHostname(this HelmGetHooksSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTlsHostname(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTlsKey(this HelmGetHooksSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTlsKey(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetTlsVerify(this HelmGetHooksSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetTlsVerify(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetHooksSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetHooksSettings EnableTlsVerify(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetHooksSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetHooksSettings DisableTlsVerify(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetHooksSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ToggleTlsVerify(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmGetHooksSettings.ReleaseName"/>.</em></p><p>The name of the release to get the hooks for.</p></summary>
        [Pure]
        public static HelmGetHooksSettings SetReleaseName(this HelmGetHooksSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetHooksSettings.ReleaseName"/>.</em></p><p>The name of the release to get the hooks for.</p></summary>
        [Pure]
        public static HelmGetHooksSettings ResetReleaseName(this HelmGetHooksSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmGetManifestSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmGetManifestSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.Help"/>.</em></p><p>Help for manifest.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetHelp(this HelmGetManifestSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.Help"/>.</em></p><p>Help for manifest.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetHelp(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetManifestSettings.Help"/>.</em></p><p>Help for manifest.</p></summary>
        [Pure]
        public static HelmGetManifestSettings EnableHelp(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetManifestSettings.Help"/>.</em></p><p>Help for manifest.</p></summary>
        [Pure]
        public static HelmGetManifestSettings DisableHelp(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetManifestSettings.Help"/>.</em></p><p>Help for manifest.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ToggleHelp(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetRevision(this HelmGetManifestSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetRevision(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTls(this HelmGetManifestSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTls(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetManifestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetManifestSettings EnableTls(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetManifestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetManifestSettings DisableTls(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetManifestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ToggleTls(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTlsCaCert(this HelmGetManifestSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTlsCaCert(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTlsCert(this HelmGetManifestSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTlsCert(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTlsHostname(this HelmGetManifestSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTlsHostname(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTlsKey(this HelmGetManifestSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTlsKey(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetTlsVerify(this HelmGetManifestSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetTlsVerify(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetManifestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetManifestSettings EnableTlsVerify(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetManifestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetManifestSettings DisableTlsVerify(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetManifestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ToggleTlsVerify(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmGetManifestSettings.ReleaseName"/>.</em></p><p>The name of the release to get the manifest for.</p></summary>
        [Pure]
        public static HelmGetManifestSettings SetReleaseName(this HelmGetManifestSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetManifestSettings.ReleaseName"/>.</em></p><p>The name of the release to get the manifest for.</p></summary>
        [Pure]
        public static HelmGetManifestSettings ResetReleaseName(this HelmGetManifestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmGetNotesSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmGetNotesSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.Help"/>.</em></p><p>Help for notes.</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetHelp(this HelmGetNotesSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.Help"/>.</em></p><p>Help for notes.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetHelp(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetNotesSettings.Help"/>.</em></p><p>Help for notes.</p></summary>
        [Pure]
        public static HelmGetNotesSettings EnableHelp(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetNotesSettings.Help"/>.</em></p><p>Help for notes.</p></summary>
        [Pure]
        public static HelmGetNotesSettings DisableHelp(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetNotesSettings.Help"/>.</em></p><p>Help for notes.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ToggleHelp(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.Revision"/>.</em></p><p>Get the notes of the named release with revision.</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetRevision(this HelmGetNotesSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.Revision"/>.</em></p><p>Get the notes of the named release with revision.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetRevision(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTls(this HelmGetNotesSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTls(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetNotesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetNotesSettings EnableTls(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetNotesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetNotesSettings DisableTls(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetNotesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ToggleTls(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTlsCaCert(this HelmGetNotesSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTlsCaCert(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTlsCert(this HelmGetNotesSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTlsCert(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTlsHostname(this HelmGetNotesSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTlsHostname(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTlsKey(this HelmGetNotesSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTlsKey(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetNotesSettings SetTlsVerify(this HelmGetNotesSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetTlsVerify(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetNotesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetNotesSettings EnableTlsVerify(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetNotesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetNotesSettings DisableTlsVerify(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetNotesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetNotesSettings ToggleTlsVerify(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmGetNotesSettings.ReleaseName"/>.</em></p></summary>
        [Pure]
        public static HelmGetNotesSettings SetReleaseName(this HelmGetNotesSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetNotesSettings.ReleaseName"/>.</em></p></summary>
        [Pure]
        public static HelmGetNotesSettings ResetReleaseName(this HelmGetNotesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmGetValuesSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmGetValuesSettingsExtensions
    {
        #region All
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.All"/>.</em></p><p>Dump all (computed) values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetAll(this HelmGetValuesSettings toolSettings, bool? all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.All"/>.</em></p><p>Dump all (computed) values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetAll(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetValuesSettings.All"/>.</em></p><p>Dump all (computed) values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings EnableAll(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetValuesSettings.All"/>.</em></p><p>Dump all (computed) values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings DisableAll(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetValuesSettings.All"/>.</em></p><p>Dump all (computed) values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ToggleAll(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = !toolSettings.All;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetHelp(this HelmGetValuesSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetHelp(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings EnableHelp(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings DisableHelp(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ToggleHelp(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetRevision(this HelmGetValuesSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.Revision"/>.</em></p><p>Get the named release with revision.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetRevision(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTls(this HelmGetValuesSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTls(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetValuesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetValuesSettings EnableTls(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetValuesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetValuesSettings DisableTls(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetValuesSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ToggleTls(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTlsCaCert(this HelmGetValuesSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTlsCaCert(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTlsCert(this HelmGetValuesSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTlsCert(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTlsHostname(this HelmGetValuesSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTlsHostname(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTlsKey(this HelmGetValuesSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTlsKey(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetTlsVerify(this HelmGetValuesSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetTlsVerify(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmGetValuesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetValuesSettings EnableTlsVerify(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmGetValuesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetValuesSettings DisableTlsVerify(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmGetValuesSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ToggleTlsVerify(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmGetValuesSettings.ReleaseName"/>.</em></p><p>The name of the release to get the values for.</p></summary>
        [Pure]
        public static HelmGetValuesSettings SetReleaseName(this HelmGetValuesSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmGetValuesSettings.ReleaseName"/>.</em></p><p>The name of the release to get the values for.</p></summary>
        [Pure]
        public static HelmGetValuesSettings ResetReleaseName(this HelmGetValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmHistorySettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmHistorySettingsExtensions
    {
        #region ColWidth
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmHistorySettings SetColWidth(this HelmHistorySettings toolSettings, uint? colWidth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = colWidth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmHistorySettings ResetColWidth(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.Help"/>.</em></p><p>Help for history.</p></summary>
        [Pure]
        public static HelmHistorySettings SetHelp(this HelmHistorySettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.Help"/>.</em></p><p>Help for history.</p></summary>
        [Pure]
        public static HelmHistorySettings ResetHelp(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmHistorySettings.Help"/>.</em></p><p>Help for history.</p></summary>
        [Pure]
        public static HelmHistorySettings EnableHelp(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmHistorySettings.Help"/>.</em></p><p>Help for history.</p></summary>
        [Pure]
        public static HelmHistorySettings DisableHelp(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmHistorySettings.Help"/>.</em></p><p>Help for history.</p></summary>
        [Pure]
        public static HelmHistorySettings ToggleHelp(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Max
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.Max"/>.</em></p><p>Maximum number of revision to include in history (default 256).</p></summary>
        [Pure]
        public static HelmHistorySettings SetMax(this HelmHistorySettings toolSettings, int? max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.Max"/>.</em></p><p>Maximum number of revision to include in history (default 256).</p></summary>
        [Pure]
        public static HelmHistorySettings ResetMax(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.Output"/>.</em></p><p>Prints the output in the specified format (json|table|yaml) (default "table").</p></summary>
        [Pure]
        public static HelmHistorySettings SetOutput(this HelmHistorySettings toolSettings, string output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.Output"/>.</em></p><p>Prints the output in the specified format (json|table|yaml) (default "table").</p></summary>
        [Pure]
        public static HelmHistorySettings ResetOutput(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmHistorySettings SetTls(this HelmHistorySettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTls(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmHistorySettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmHistorySettings EnableTls(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmHistorySettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmHistorySettings DisableTls(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmHistorySettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmHistorySettings ToggleTls(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings SetTlsCaCert(this HelmHistorySettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTlsCaCert(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings SetTlsCert(this HelmHistorySettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTlsCert(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmHistorySettings SetTlsHostname(this HelmHistorySettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTlsHostname(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings SetTlsKey(this HelmHistorySettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTlsKey(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmHistorySettings SetTlsVerify(this HelmHistorySettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmHistorySettings ResetTlsVerify(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmHistorySettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmHistorySettings EnableTlsVerify(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmHistorySettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmHistorySettings DisableTlsVerify(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmHistorySettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmHistorySettings ToggleTlsVerify(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmHistorySettings.ReleaseName"/>.</em></p><p>The name of the release to get the history for.</p></summary>
        [Pure]
        public static HelmHistorySettings SetReleaseName(this HelmHistorySettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHistorySettings.ReleaseName"/>.</em></p><p>The name of the release to get the history for.</p></summary>
        [Pure]
        public static HelmHistorySettings ResetReleaseName(this HelmHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmHomeSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmHomeSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmHomeSettings.Help"/>.</em></p><p>Help for home.</p></summary>
        [Pure]
        public static HelmHomeSettings SetHelp(this HelmHomeSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmHomeSettings.Help"/>.</em></p><p>Help for home.</p></summary>
        [Pure]
        public static HelmHomeSettings ResetHelp(this HelmHomeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmHomeSettings.Help"/>.</em></p><p>Help for home.</p></summary>
        [Pure]
        public static HelmHomeSettings EnableHelp(this HelmHomeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmHomeSettings.Help"/>.</em></p><p>Help for home.</p></summary>
        [Pure]
        public static HelmHomeSettings DisableHelp(this HelmHomeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmHomeSettings.Help"/>.</em></p><p>Help for home.</p></summary>
        [Pure]
        public static HelmHomeSettings ToggleHelp(this HelmHomeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInitSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInitSettingsExtensions
    {
        #region AutomountServiceAccountToken
        /// <summary><p><em>Sets <see cref="HelmInitSettings.AutomountServiceAccountToken"/>.</em></p><p>Auto-mount the given service account to tiller (default true).</p></summary>
        [Pure]
        public static HelmInitSettings SetAutomountServiceAccountToken(this HelmInitSettings toolSettings, bool? automountServiceAccountToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutomountServiceAccountToken = automountServiceAccountToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.AutomountServiceAccountToken"/>.</em></p><p>Auto-mount the given service account to tiller (default true).</p></summary>
        [Pure]
        public static HelmInitSettings ResetAutomountServiceAccountToken(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutomountServiceAccountToken = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.AutomountServiceAccountToken"/>.</em></p><p>Auto-mount the given service account to tiller (default true).</p></summary>
        [Pure]
        public static HelmInitSettings EnableAutomountServiceAccountToken(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutomountServiceAccountToken = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.AutomountServiceAccountToken"/>.</em></p><p>Auto-mount the given service account to tiller (default true).</p></summary>
        [Pure]
        public static HelmInitSettings DisableAutomountServiceAccountToken(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutomountServiceAccountToken = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.AutomountServiceAccountToken"/>.</em></p><p>Auto-mount the given service account to tiller (default true).</p></summary>
        [Pure]
        public static HelmInitSettings ToggleAutomountServiceAccountToken(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutomountServiceAccountToken = !toolSettings.AutomountServiceAccountToken;
            return toolSettings;
        }
        #endregion
        #region CanaryImage
        /// <summary><p><em>Sets <see cref="HelmInitSettings.CanaryImage"/>.</em></p><p>Use the canary Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings SetCanaryImage(this HelmInitSettings toolSettings, bool? canaryImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CanaryImage = canaryImage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.CanaryImage"/>.</em></p><p>Use the canary Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings ResetCanaryImage(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CanaryImage = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.CanaryImage"/>.</em></p><p>Use the canary Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings EnableCanaryImage(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CanaryImage = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.CanaryImage"/>.</em></p><p>Use the canary Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings DisableCanaryImage(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CanaryImage = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.CanaryImage"/>.</em></p><p>Use the canary Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleCanaryImage(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CanaryImage = !toolSettings.CanaryImage;
            return toolSettings;
        }
        #endregion
        #region ClientOnly
        /// <summary><p><em>Sets <see cref="HelmInitSettings.ClientOnly"/>.</em></p><p>If set does not install Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings SetClientOnly(this HelmInitSettings toolSettings, bool? clientOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientOnly = clientOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.ClientOnly"/>.</em></p><p>If set does not install Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings ResetClientOnly(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.ClientOnly"/>.</em></p><p>If set does not install Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings EnableClientOnly(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.ClientOnly"/>.</em></p><p>If set does not install Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings DisableClientOnly(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.ClientOnly"/>.</em></p><p>If set does not install Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleClientOnly(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientOnly = !toolSettings.ClientOnly;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary><p><em>Sets <see cref="HelmInitSettings.DryRun"/>.</em></p><p>Do not install local or remote.</p></summary>
        [Pure]
        public static HelmInitSettings SetDryRun(this HelmInitSettings toolSettings, bool? dryRun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.DryRun"/>.</em></p><p>Do not install local or remote.</p></summary>
        [Pure]
        public static HelmInitSettings ResetDryRun(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.DryRun"/>.</em></p><p>Do not install local or remote.</p></summary>
        [Pure]
        public static HelmInitSettings EnableDryRun(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.DryRun"/>.</em></p><p>Do not install local or remote.</p></summary>
        [Pure]
        public static HelmInitSettings DisableDryRun(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.DryRun"/>.</em></p><p>Do not install local or remote.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleDryRun(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region ForceUpgrade
        /// <summary><p><em>Sets <see cref="HelmInitSettings.ForceUpgrade"/>.</em></p><p>Force upgrade of Tiller to the current helm version.</p></summary>
        [Pure]
        public static HelmInitSettings SetForceUpgrade(this HelmInitSettings toolSettings, bool? forceUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpgrade = forceUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.ForceUpgrade"/>.</em></p><p>Force upgrade of Tiller to the current helm version.</p></summary>
        [Pure]
        public static HelmInitSettings ResetForceUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpgrade = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.ForceUpgrade"/>.</em></p><p>Force upgrade of Tiller to the current helm version.</p></summary>
        [Pure]
        public static HelmInitSettings EnableForceUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpgrade = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.ForceUpgrade"/>.</em></p><p>Force upgrade of Tiller to the current helm version.</p></summary>
        [Pure]
        public static HelmInitSettings DisableForceUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpgrade = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.ForceUpgrade"/>.</em></p><p>Force upgrade of Tiller to the current helm version.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleForceUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceUpgrade = !toolSettings.ForceUpgrade;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Help"/>.</em></p><p>Help for init.</p></summary>
        [Pure]
        public static HelmInitSettings SetHelp(this HelmInitSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.Help"/>.</em></p><p>Help for init.</p></summary>
        [Pure]
        public static HelmInitSettings ResetHelp(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.Help"/>.</em></p><p>Help for init.</p></summary>
        [Pure]
        public static HelmInitSettings EnableHelp(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.Help"/>.</em></p><p>Help for init.</p></summary>
        [Pure]
        public static HelmInitSettings DisableHelp(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.Help"/>.</em></p><p>Help for init.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleHelp(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region HistoryMax
        /// <summary><p><em>Sets <see cref="HelmInitSettings.HistoryMax"/>.</em></p><p>Limit the maximum number of revisions saved per release. Use 0 for no limit.</p></summary>
        [Pure]
        public static HelmInitSettings SetHistoryMax(this HelmInitSettings toolSettings, long? historyMax)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HistoryMax = historyMax;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.HistoryMax"/>.</em></p><p>Limit the maximum number of revisions saved per release. Use 0 for no limit.</p></summary>
        [Pure]
        public static HelmInitSettings ResetHistoryMax(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HistoryMax = null;
            return toolSettings;
        }
        #endregion
        #region LocalRepoUrl
        /// <summary><p><em>Sets <see cref="HelmInitSettings.LocalRepoUrl"/>.</em></p><p>URL for local repository (default "http://127.0.0.1:8879/charts").</p></summary>
        [Pure]
        public static HelmInitSettings SetLocalRepoUrl(this HelmInitSettings toolSettings, string localRepoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocalRepoUrl = localRepoUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.LocalRepoUrl"/>.</em></p><p>URL for local repository (default "http://127.0.0.1:8879/charts").</p></summary>
        [Pure]
        public static HelmInitSettings ResetLocalRepoUrl(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocalRepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region NetHost
        /// <summary><p><em>Sets <see cref="HelmInitSettings.NetHost"/>.</em></p><p>Install Tiller with net=host.</p></summary>
        [Pure]
        public static HelmInitSettings SetNetHost(this HelmInitSettings toolSettings, bool? netHost)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetHost = netHost;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.NetHost"/>.</em></p><p>Install Tiller with net=host.</p></summary>
        [Pure]
        public static HelmInitSettings ResetNetHost(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetHost = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.NetHost"/>.</em></p><p>Install Tiller with net=host.</p></summary>
        [Pure]
        public static HelmInitSettings EnableNetHost(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetHost = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.NetHost"/>.</em></p><p>Install Tiller with net=host.</p></summary>
        [Pure]
        public static HelmInitSettings DisableNetHost(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetHost = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.NetHost"/>.</em></p><p>Install Tiller with net=host.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleNetHost(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetHost = !toolSettings.NetHost;
            return toolSettings;
        }
        #endregion
        #region NodeSelectors
        /// <summary><p><em>Sets <see cref="HelmInitSettings.NodeSelectors"/>.</em></p><p>Labels to specify the node on which Tiller is installed (app=tiller,helm=rocks).</p></summary>
        [Pure]
        public static HelmInitSettings SetNodeSelectors(this HelmInitSettings toolSettings, string nodeSelectors)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeSelectors = nodeSelectors;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.NodeSelectors"/>.</em></p><p>Labels to specify the node on which Tiller is installed (app=tiller,helm=rocks).</p></summary>
        [Pure]
        public static HelmInitSettings ResetNodeSelectors(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeSelectors = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Output"/>.</em></p><p>Skip installation and output Tiller's manifest in specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmInitSettings SetOutput(this HelmInitSettings toolSettings, HelmOutputFormat output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.Output"/>.</em></p><p>Skip installation and output Tiller's manifest in specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmInitSettings ResetOutput(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Override
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Override"/> to a new dictionary.</em></p><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInitSettings SetOverride(this HelmInitSettings toolSettings, IDictionary<string, object> @override)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverrideInternal = @override.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmInitSettings.Override"/>.</em></p><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInitSettings ClearOverride(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverrideInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmInitSettings.Override"/>.</em></p><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInitSettings AddOverride(this HelmInitSettings toolSettings, string overrideKey, object overrideValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverrideInternal.Add(overrideKey, overrideValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmInitSettings.Override"/>.</em></p><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInitSettings RemoveOverride(this HelmInitSettings toolSettings, string overrideKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverrideInternal.Remove(overrideKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmInitSettings.Override"/>.</em></p><p>Override values for the Tiller Deployment manifest (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInitSettings SetOverride(this HelmInitSettings toolSettings, string overrideKey, object overrideValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverrideInternal[overrideKey] = overrideValue;
            return toolSettings;
        }
        #endregion
        #region Replicas
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Replicas"/>.</em></p><p>Amount of tiller instances to run on the cluster (default 1).</p></summary>
        [Pure]
        public static HelmInitSettings SetReplicas(this HelmInitSettings toolSettings, long? replicas)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replicas = replicas;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.Replicas"/>.</em></p><p>Amount of tiller instances to run on the cluster (default 1).</p></summary>
        [Pure]
        public static HelmInitSettings ResetReplicas(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replicas = null;
            return toolSettings;
        }
        #endregion
        #region ServiceAccount
        /// <summary><p><em>Sets <see cref="HelmInitSettings.ServiceAccount"/>.</em></p><p>Name of service account.</p></summary>
        [Pure]
        public static HelmInitSettings SetServiceAccount(this HelmInitSettings toolSettings, string serviceAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceAccount = serviceAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.ServiceAccount"/>.</em></p><p>Name of service account.</p></summary>
        [Pure]
        public static HelmInitSettings ResetServiceAccount(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceAccount = null;
            return toolSettings;
        }
        #endregion
        #region SkipRefresh
        /// <summary><p><em>Sets <see cref="HelmInitSettings.SkipRefresh"/>.</em></p><p>Do not refresh (download) the local repository cache.</p></summary>
        [Pure]
        public static HelmInitSettings SetSkipRefresh(this HelmInitSettings toolSettings, bool? skipRefresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = skipRefresh;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.SkipRefresh"/>.</em></p><p>Do not refresh (download) the local repository cache.</p></summary>
        [Pure]
        public static HelmInitSettings ResetSkipRefresh(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.SkipRefresh"/>.</em></p><p>Do not refresh (download) the local repository cache.</p></summary>
        [Pure]
        public static HelmInitSettings EnableSkipRefresh(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.SkipRefresh"/>.</em></p><p>Do not refresh (download) the local repository cache.</p></summary>
        [Pure]
        public static HelmInitSettings DisableSkipRefresh(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.SkipRefresh"/>.</em></p><p>Do not refresh (download) the local repository cache.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleSkipRefresh(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipRefresh = !toolSettings.SkipRefresh;
            return toolSettings;
        }
        #endregion
        #region StableRepoUrl
        /// <summary><p><em>Sets <see cref="HelmInitSettings.StableRepoUrl"/>.</em></p><p>URL for stable repository (default "https://kubernetes-charts.storage.googleapis.com").</p></summary>
        [Pure]
        public static HelmInitSettings SetStableRepoUrl(this HelmInitSettings toolSettings, string stableRepoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StableRepoUrl = stableRepoUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.StableRepoUrl"/>.</em></p><p>URL for stable repository (default "https://kubernetes-charts.storage.googleapis.com").</p></summary>
        [Pure]
        public static HelmInitSettings ResetStableRepoUrl(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StableRepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region TillerImage
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerImage"/>.</em></p><p>Override Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerImage(this HelmInitSettings toolSettings, string tillerImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerImage = tillerImage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerImage"/>.</em></p><p>Override Tiller image.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerImage(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerImage = null;
            return toolSettings;
        }
        #endregion
        #region TillerTls
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerTls"/>.</em></p><p>Install Tiller with TLS enabled.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerTls(this HelmInitSettings toolSettings, bool? tillerTls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTls = tillerTls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerTls"/>.</em></p><p>Install Tiller with TLS enabled.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerTls(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.TillerTls"/>.</em></p><p>Install Tiller with TLS enabled.</p></summary>
        [Pure]
        public static HelmInitSettings EnableTillerTls(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.TillerTls"/>.</em></p><p>Install Tiller with TLS enabled.</p></summary>
        [Pure]
        public static HelmInitSettings DisableTillerTls(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.TillerTls"/>.</em></p><p>Install Tiller with TLS enabled.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleTillerTls(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTls = !toolSettings.TillerTls;
            return toolSettings;
        }
        #endregion
        #region TillerTlsCert
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerTlsCert"/>.</em></p><p>Path to TLS certificate file to install with Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerTlsCert(this HelmInitSettings toolSettings, string tillerTlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsCert = tillerTlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerTlsCert"/>.</em></p><p>Path to TLS certificate file to install with Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerTlsCert(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TillerTlsHostname
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerTlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerTlsHostname(this HelmInitSettings toolSettings, string tillerTlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsHostname = tillerTlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerTlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerTlsHostname(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TillerTlsKey
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerTlsKey"/>.</em></p><p>Path to TLS key file to install with Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerTlsKey(this HelmInitSettings toolSettings, string tillerTlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsKey = tillerTlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerTlsKey"/>.</em></p><p>Path to TLS key file to install with Tiller.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerTlsKey(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TillerTlsVerify
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TillerTlsVerify"/>.</em></p><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        [Pure]
        public static HelmInitSettings SetTillerTlsVerify(this HelmInitSettings toolSettings, bool? tillerTlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsVerify = tillerTlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TillerTlsVerify"/>.</em></p><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTillerTlsVerify(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.TillerTlsVerify"/>.</em></p><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        [Pure]
        public static HelmInitSettings EnableTillerTlsVerify(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.TillerTlsVerify"/>.</em></p><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        [Pure]
        public static HelmInitSettings DisableTillerTlsVerify(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.TillerTlsVerify"/>.</em></p><p>Install Tiller with TLS enabled and to verify remote certificates.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleTillerTlsVerify(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerTlsVerify = !toolSettings.TillerTlsVerify;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmInitSettings.TlsCaCert"/>.</em></p><p>Path to CA root certificate.</p></summary>
        [Pure]
        public static HelmInitSettings SetTlsCaCert(this HelmInitSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.TlsCaCert"/>.</em></p><p>Path to CA root certificate.</p></summary>
        [Pure]
        public static HelmInitSettings ResetTlsCaCert(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region Upgrade
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Upgrade"/>.</em></p><p>Upgrade if Tiller is already installed.</p></summary>
        [Pure]
        public static HelmInitSettings SetUpgrade(this HelmInitSettings toolSettings, bool? upgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upgrade = upgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.Upgrade"/>.</em></p><p>Upgrade if Tiller is already installed.</p></summary>
        [Pure]
        public static HelmInitSettings ResetUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upgrade = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.Upgrade"/>.</em></p><p>Upgrade if Tiller is already installed.</p></summary>
        [Pure]
        public static HelmInitSettings EnableUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upgrade = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.Upgrade"/>.</em></p><p>Upgrade if Tiller is already installed.</p></summary>
        [Pure]
        public static HelmInitSettings DisableUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upgrade = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.Upgrade"/>.</em></p><p>Upgrade if Tiller is already installed.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleUpgrade(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upgrade = !toolSettings.Upgrade;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary><p><em>Sets <see cref="HelmInitSettings.Wait"/>.</em></p><p>Block until Tiller is running and ready to receive requests.</p></summary>
        [Pure]
        public static HelmInitSettings SetWait(this HelmInitSettings toolSettings, bool? wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInitSettings.Wait"/>.</em></p><p>Block until Tiller is running and ready to receive requests.</p></summary>
        [Pure]
        public static HelmInitSettings ResetWait(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInitSettings.Wait"/>.</em></p><p>Block until Tiller is running and ready to receive requests.</p></summary>
        [Pure]
        public static HelmInitSettings EnableWait(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInitSettings.Wait"/>.</em></p><p>Block until Tiller is running and ready to receive requests.</p></summary>
        [Pure]
        public static HelmInitSettings DisableWait(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInitSettings.Wait"/>.</em></p><p>Block until Tiller is running and ready to receive requests.</p></summary>
        [Pure]
        public static HelmInitSettings ToggleWait(this HelmInitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = !toolSettings.Wait;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInspectSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInspectSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings SetCaFile(this HelmInspectSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetCaFile(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectSettings SetCertFile(this HelmInspectSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetCertFile(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Help"/>.</em></p><p>Help for inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings SetHelp(this HelmInspectSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Help"/>.</em></p><p>Help for inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetHelp(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectSettings.Help"/>.</em></p><p>Help for inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings EnableHelp(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectSettings.Help"/>.</em></p><p>Help for inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings DisableHelp(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectSettings.Help"/>.</em></p><p>Help for inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings ToggleHelp(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectSettings SetKeyFile(this HelmInspectSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetKeyFile(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectSettings SetKeyring(this HelmInspectSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectSettings ResetKeyring(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings SetPassword(this HelmInspectSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetPassword(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings SetRepo(this HelmInspectSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetRepo(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings SetUsername(this HelmInspectSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetUsername(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectSettings SetVerify(this HelmInspectSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetVerify(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectSettings EnableVerify(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectSettings DisableVerify(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectSettings ToggleVerify(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectSettings SetVersion(this HelmInspectSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetVersion(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmInspectSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings SetChart(this HelmInspectSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectSettings ResetChart(this HelmInspectSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInspectChartSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInspectChartSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetCaFile(this HelmInspectChartSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetCaFile(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetCertFile(this HelmInspectChartSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetCertFile(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Help"/>.</em></p><p>Help for chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetHelp(this HelmInspectChartSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Help"/>.</em></p><p>Help for chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetHelp(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectChartSettings.Help"/>.</em></p><p>Help for chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings EnableHelp(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectChartSettings.Help"/>.</em></p><p>Help for chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings DisableHelp(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectChartSettings.Help"/>.</em></p><p>Help for chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ToggleHelp(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetKeyFile(this HelmInspectChartSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetKeyFile(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetKeyring(this HelmInspectChartSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetKeyring(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetPassword(this HelmInspectChartSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetPassword(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetRepo(this HelmInspectChartSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetRepo(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetUsername(this HelmInspectChartSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetUsername(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetVerify(this HelmInspectChartSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetVerify(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectChartSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings EnableVerify(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectChartSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings DisableVerify(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectChartSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ToggleVerify(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetVersion(this HelmInspectChartSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetVersion(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmInspectChartSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectChartSettings SetChart(this HelmInspectChartSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectChartSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectChartSettings ResetChart(this HelmInspectChartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInspectReadmeSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInspectReadmeSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetCaFile(this HelmInspectReadmeSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetCaFile(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetCertFile(this HelmInspectReadmeSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetCertFile(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Help"/>.</em></p><p>Help for readme.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetHelp(this HelmInspectReadmeSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Help"/>.</em></p><p>Help for readme.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetHelp(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectReadmeSettings.Help"/>.</em></p><p>Help for readme.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings EnableHelp(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectReadmeSettings.Help"/>.</em></p><p>Help for readme.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings DisableHelp(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectReadmeSettings.Help"/>.</em></p><p>Help for readme.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ToggleHelp(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetKeyFile(this HelmInspectReadmeSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetKeyFile(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetKeyring(this HelmInspectReadmeSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetKeyring(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetRepo(this HelmInspectReadmeSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetRepo(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetVerify(this HelmInspectReadmeSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetVerify(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectReadmeSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings EnableVerify(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectReadmeSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings DisableVerify(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectReadmeSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ToggleVerify(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetVersion(this HelmInspectReadmeSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetVersion(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmInspectReadmeSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings SetChart(this HelmInspectReadmeSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectReadmeSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectReadmeSettings ResetChart(this HelmInspectReadmeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInspectValuesSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInspectValuesSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetCaFile(this HelmInspectValuesSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.CaFile"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetCaFile(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetCertFile(this HelmInspectValuesSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.CertFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetCertFile(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetHelp(this HelmInspectValuesSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetHelp(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings EnableHelp(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings DisableHelp(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectValuesSettings.Help"/>.</em></p><p>Help for values.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ToggleHelp(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetKeyFile(this HelmInspectValuesSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetKeyFile(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetKeyring(this HelmInspectValuesSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Keyring"/>.</em></p><p>Path to the keyring containing public verification keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetKeyring(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetPassword(this HelmInspectValuesSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetPassword(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetRepo(this HelmInspectValuesSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetRepo(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetUsername(this HelmInspectValuesSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetUsername(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetVerify(this HelmInspectValuesSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetVerify(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInspectValuesSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings EnableVerify(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInspectValuesSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings DisableVerify(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInspectValuesSettings.Verify"/>.</em></p><p>Verify the provenance data for this chart.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ToggleVerify(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetVersion(this HelmInspectValuesSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Version"/>.</em></p><p>Version of the chart. By default, the newest chart is shown.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetVersion(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmInspectValuesSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings SetChart(this HelmInspectValuesSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInspectValuesSettings.Chart"/>.</em></p><p>The name of the chart to inspect.</p></summary>
        [Pure]
        public static HelmInspectValuesSettings ResetChart(this HelmInspectValuesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmInstallSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmInstallSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInstallSettings SetCaFile(this HelmInstallSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetCaFile(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmInstallSettings SetCertFile(this HelmInstallSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetCertFile(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region DepUp
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.DepUp"/>.</em></p><p>Run helm dependency update before installing the chart.</p></summary>
        [Pure]
        public static HelmInstallSettings SetDepUp(this HelmInstallSettings toolSettings, bool? depUp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DepUp = depUp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.DepUp"/>.</em></p><p>Run helm dependency update before installing the chart.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetDepUp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DepUp = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.DepUp"/>.</em></p><p>Run helm dependency update before installing the chart.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableDepUp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DepUp = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.DepUp"/>.</em></p><p>Run helm dependency update before installing the chart.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableDepUp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DepUp = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.DepUp"/>.</em></p><p>Run helm dependency update before installing the chart.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleDepUp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DepUp = !toolSettings.DepUp;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmInstallSettings SetDescription(this HelmInstallSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetDescription(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Devel
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmInstallSettings SetDevel(this HelmInstallSettings toolSettings, bool? devel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = devel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetDevel(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableDevel(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableDevel(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleDevel(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = !toolSettings.Devel;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.DryRun"/>.</em></p><p>Simulate an install.</p></summary>
        [Pure]
        public static HelmInstallSettings SetDryRun(this HelmInstallSettings toolSettings, bool? dryRun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.DryRun"/>.</em></p><p>Simulate an install.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetDryRun(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.DryRun"/>.</em></p><p>Simulate an install.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableDryRun(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.DryRun"/>.</em></p><p>Simulate an install.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableDryRun(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.DryRun"/>.</em></p><p>Simulate an install.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleDryRun(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmInstallSettings SetHelp(this HelmInstallSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetHelp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableHelp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableHelp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleHelp(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInstallSettings SetKeyFile(this HelmInstallSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetKeyFile(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Keyring"/>.</em></p><p>Location of public keys used for verification (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInstallSettings SetKeyring(this HelmInstallSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Keyring"/>.</em></p><p>Location of public keys used for verification (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmInstallSettings ResetKeyring(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Name"/>.</em></p><p>Release name. If unspecified, it will autogenerate one for you.</p></summary>
        [Pure]
        public static HelmInstallSettings SetName(this HelmInstallSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Name"/>.</em></p><p>Release name. If unspecified, it will autogenerate one for you.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetName(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NameTemplate
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.NameTemplate"/>.</em></p><p>Specify template used to name the release.</p></summary>
        [Pure]
        public static HelmInstallSettings SetNameTemplate(this HelmInstallSettings toolSettings, string nameTemplate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameTemplate = nameTemplate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.NameTemplate"/>.</em></p><p>Specify template used to name the release.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetNameTemplate(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameTemplate = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Namespace"/>.</em></p><p>Namespace to install the release into. Defaults to the current kube config namespace.</p></summary>
        [Pure]
        public static HelmInstallSettings SetNamespace(this HelmInstallSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Namespace"/>.</em></p><p>Namespace to install the release into. Defaults to the current kube config namespace.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetNamespace(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region NoCrdHook
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.NoCrdHook"/>.</em></p><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        [Pure]
        public static HelmInstallSettings SetNoCrdHook(this HelmInstallSettings toolSettings, bool? noCrdHook)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCrdHook = noCrdHook;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.NoCrdHook"/>.</em></p><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetNoCrdHook(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCrdHook = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.NoCrdHook"/>.</em></p><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableNoCrdHook(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCrdHook = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.NoCrdHook"/>.</em></p><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableNoCrdHook(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCrdHook = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.NoCrdHook"/>.</em></p><p>Prevent CRD hooks from running, but run other hooks.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleNoCrdHook(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoCrdHook = !toolSettings.NoCrdHook;
            return toolSettings;
        }
        #endregion
        #region NoHooks
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during install.</p></summary>
        [Pure]
        public static HelmInstallSettings SetNoHooks(this HelmInstallSettings toolSettings, bool? noHooks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = noHooks;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during install.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetNoHooks(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during install.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableNoHooks(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during install.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableNoHooks(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during install.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleNoHooks(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = !toolSettings.NoHooks;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings SetPassword(this HelmInstallSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetPassword(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Replace
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Replace"/>.</em></p><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        [Pure]
        public static HelmInstallSettings SetReplace(this HelmInstallSettings toolSettings, bool? replace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replace = replace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Replace"/>.</em></p><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetReplace(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replace = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Replace"/>.</em></p><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableReplace(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replace = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Replace"/>.</em></p><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableReplace(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replace = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Replace"/>.</em></p><p>Re-use the given name, even if that name is already used. This is unsafe in production.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleReplace(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Replace = !toolSettings.Replace;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings SetRepo(this HelmInstallSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetRepo(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Set"/> to a new dictionary.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSet(this HelmInstallSettings toolSettings, IDictionary<string, object> set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal = set.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmInstallSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings ClearSet(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmInstallSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings AddSet(this HelmInstallSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Add(setKey, setValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmInstallSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings RemoveSet(this HelmInstallSettings toolSettings, string setKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Remove(setKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmInstallSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSet(this HelmInstallSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal[setKey] = setValue;
            return toolSettings;
        }
        #endregion
        #region SetFile
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.SetFile"/> to a new dictionary.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSetFile(this HelmInstallSettings toolSettings, IDictionary<string, object> setFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal = setFile.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmInstallSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmInstallSettings ClearSetFile(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmInstallSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmInstallSettings AddSetFile(this HelmInstallSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Add(setFileKey, setFileValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmInstallSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmInstallSettings RemoveSetFile(this HelmInstallSettings toolSettings, string setFileKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Remove(setFileKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmInstallSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSetFile(this HelmInstallSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal[setFileKey] = setFileValue;
            return toolSettings;
        }
        #endregion
        #region SetString
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.SetString"/> to a new dictionary.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSetString(this HelmInstallSettings toolSettings, IDictionary<string, object> setString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal = setString.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmInstallSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings ClearSetString(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmInstallSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings AddSetString(this HelmInstallSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Add(setStringKey, setStringValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmInstallSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings RemoveSetString(this HelmInstallSettings toolSettings, string setStringKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Remove(setStringKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmInstallSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmInstallSettings SetSetString(this HelmInstallSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal[setStringKey] = setStringValue;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmInstallSettings SetTimeout(this HelmInstallSettings toolSettings, long? timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTimeout(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmInstallSettings SetTls(this HelmInstallSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTls(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableTls(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableTls(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleTls(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings SetTlsCaCert(this HelmInstallSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTlsCaCert(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings SetTlsCert(this HelmInstallSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTlsCert(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmInstallSettings SetTlsHostname(this HelmInstallSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTlsHostname(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings SetTlsKey(this HelmInstallSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTlsKey(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmInstallSettings SetTlsVerify(this HelmInstallSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetTlsVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableTlsVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableTlsVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleTlsVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings SetUsername(this HelmInstallSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetUsername(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Values
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings SetValues(this HelmInstallSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings SetValues(this HelmInstallSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmInstallSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings AddValues(this HelmInstallSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmInstallSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings AddValues(this HelmInstallSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmInstallSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings ClearValues(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmInstallSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings RemoveValues(this HelmInstallSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmInstallSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmInstallSettings RemoveValues(this HelmInstallSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Verify"/>.</em></p><p>Verify the package before installing it.</p></summary>
        [Pure]
        public static HelmInstallSettings SetVerify(this HelmInstallSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Verify"/>.</em></p><p>Verify the package before installing it.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Verify"/>.</em></p><p>Verify the package before installing it.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Verify"/>.</em></p><p>Verify the package before installing it.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Verify"/>.</em></p><p>Verify the package before installing it.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleVerify(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Version"/>.</em></p><p>Specify the exact chart version to install. If this is not specified, the latest version is installed.</p></summary>
        [Pure]
        public static HelmInstallSettings SetVersion(this HelmInstallSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Version"/>.</em></p><p>Specify the exact chart version to install. If this is not specified, the latest version is installed.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetVersion(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmInstallSettings SetWait(this HelmInstallSettings toolSettings, bool? wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetWait(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmInstallSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmInstallSettings EnableWait(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmInstallSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmInstallSettings DisableWait(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmInstallSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmInstallSettings ToggleWait(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = !toolSettings.Wait;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmInstallSettings.Chart"/>.</em></p><p>The name of the chart to install.</p></summary>
        [Pure]
        public static HelmInstallSettings SetChart(this HelmInstallSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmInstallSettings.Chart"/>.</em></p><p>The name of the chart to install.</p></summary>
        [Pure]
        public static HelmInstallSettings ResetChart(this HelmInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmLintSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmLintSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Help"/>.</em></p><p>Help for lint.</p></summary>
        [Pure]
        public static HelmLintSettings SetHelp(this HelmLintSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmLintSettings.Help"/>.</em></p><p>Help for lint.</p></summary>
        [Pure]
        public static HelmLintSettings ResetHelp(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmLintSettings.Help"/>.</em></p><p>Help for lint.</p></summary>
        [Pure]
        public static HelmLintSettings EnableHelp(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmLintSettings.Help"/>.</em></p><p>Help for lint.</p></summary>
        [Pure]
        public static HelmLintSettings DisableHelp(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmLintSettings.Help"/>.</em></p><p>Help for lint.</p></summary>
        [Pure]
        public static HelmLintSettings ToggleHelp(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Namespace"/>.</em></p><p>Namespace to put the release into (default "default").</p></summary>
        [Pure]
        public static HelmLintSettings SetNamespace(this HelmLintSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmLintSettings.Namespace"/>.</em></p><p>Namespace to put the release into (default "default").</p></summary>
        [Pure]
        public static HelmLintSettings ResetNamespace(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Set"/> to a new dictionary.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSet(this HelmLintSettings toolSettings, IDictionary<string, object> set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal = set.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmLintSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings ClearSet(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmLintSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings AddSet(this HelmLintSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Add(setKey, setValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmLintSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings RemoveSet(this HelmLintSettings toolSettings, string setKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Remove(setKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmLintSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSet(this HelmLintSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal[setKey] = setValue;
            return toolSettings;
        }
        #endregion
        #region SetFile
        /// <summary><p><em>Sets <see cref="HelmLintSettings.SetFile"/> to a new dictionary.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSetFile(this HelmLintSettings toolSettings, IDictionary<string, object> setFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal = setFile.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmLintSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmLintSettings ClearSetFile(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmLintSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmLintSettings AddSetFile(this HelmLintSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Add(setFileKey, setFileValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmLintSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmLintSettings RemoveSetFile(this HelmLintSettings toolSettings, string setFileKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Remove(setFileKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmLintSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSetFile(this HelmLintSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal[setFileKey] = setFileValue;
            return toolSettings;
        }
        #endregion
        #region SetString
        /// <summary><p><em>Sets <see cref="HelmLintSettings.SetString"/> to a new dictionary.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSetString(this HelmLintSettings toolSettings, IDictionary<string, object> setString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal = setString.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmLintSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings ClearSetString(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmLintSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings AddSetString(this HelmLintSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Add(setStringKey, setStringValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmLintSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings RemoveSetString(this HelmLintSettings toolSettings, string setStringKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Remove(setStringKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmLintSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmLintSettings SetSetString(this HelmLintSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal[setStringKey] = setStringValue;
            return toolSettings;
        }
        #endregion
        #region Strict
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Strict"/>.</em></p><p>Fail on lint warnings.</p></summary>
        [Pure]
        public static HelmLintSettings SetStrict(this HelmLintSettings toolSettings, bool? strict)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = strict;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmLintSettings.Strict"/>.</em></p><p>Fail on lint warnings.</p></summary>
        [Pure]
        public static HelmLintSettings ResetStrict(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmLintSettings.Strict"/>.</em></p><p>Fail on lint warnings.</p></summary>
        [Pure]
        public static HelmLintSettings EnableStrict(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmLintSettings.Strict"/>.</em></p><p>Fail on lint warnings.</p></summary>
        [Pure]
        public static HelmLintSettings DisableStrict(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmLintSettings.Strict"/>.</em></p><p>Fail on lint warnings.</p></summary>
        [Pure]
        public static HelmLintSettings ToggleStrict(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Strict = !toolSettings.Strict;
            return toolSettings;
        }
        #endregion
        #region Values
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings SetValues(this HelmLintSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings SetValues(this HelmLintSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmLintSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings AddValues(this HelmLintSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmLintSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings AddValues(this HelmLintSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmLintSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings ClearValues(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmLintSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings RemoveValues(this HelmLintSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmLintSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmLintSettings RemoveValues(this HelmLintSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="HelmLintSettings.Path"/>.</em></p><p>The Path to a chart.</p></summary>
        [Pure]
        public static HelmLintSettings SetPath(this HelmLintSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmLintSettings.Path"/>.</em></p><p>The Path to a chart.</p></summary>
        [Pure]
        public static HelmLintSettings ResetPath(this HelmLintSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmListSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmListSettingsExtensions
    {
        #region All
        /// <summary><p><em>Sets <see cref="HelmListSettings.All"/>.</em></p><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        [Pure]
        public static HelmListSettings SetAll(this HelmListSettings toolSettings, bool? all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.All"/>.</em></p><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        [Pure]
        public static HelmListSettings ResetAll(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.All"/>.</em></p><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        [Pure]
        public static HelmListSettings EnableAll(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.All"/>.</em></p><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        [Pure]
        public static HelmListSettings DisableAll(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.All"/>.</em></p><p>Show all releases, not just the ones marked DEPLOYED.</p></summary>
        [Pure]
        public static HelmListSettings ToggleAll(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = !toolSettings.All;
            return toolSettings;
        }
        #endregion
        #region ChartName
        /// <summary><p><em>Sets <see cref="HelmListSettings.ChartName"/>.</em></p><p>Sort by chart name.</p></summary>
        [Pure]
        public static HelmListSettings SetChartName(this HelmListSettings toolSettings, bool? chartName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartName = chartName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.ChartName"/>.</em></p><p>Sort by chart name.</p></summary>
        [Pure]
        public static HelmListSettings ResetChartName(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartName = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.ChartName"/>.</em></p><p>Sort by chart name.</p></summary>
        [Pure]
        public static HelmListSettings EnableChartName(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartName = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.ChartName"/>.</em></p><p>Sort by chart name.</p></summary>
        [Pure]
        public static HelmListSettings DisableChartName(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartName = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.ChartName"/>.</em></p><p>Sort by chart name.</p></summary>
        [Pure]
        public static HelmListSettings ToggleChartName(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartName = !toolSettings.ChartName;
            return toolSettings;
        }
        #endregion
        #region ColWidth
        /// <summary><p><em>Sets <see cref="HelmListSettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmListSettings SetColWidth(this HelmListSettings toolSettings, uint? colWidth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = colWidth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmListSettings ResetColWidth(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = null;
            return toolSettings;
        }
        #endregion
        #region Date
        /// <summary><p><em>Sets <see cref="HelmListSettings.Date"/>.</em></p><p>Sort by release date.</p></summary>
        [Pure]
        public static HelmListSettings SetDate(this HelmListSettings toolSettings, bool? date)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Date = date;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Date"/>.</em></p><p>Sort by release date.</p></summary>
        [Pure]
        public static HelmListSettings ResetDate(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Date = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Date"/>.</em></p><p>Sort by release date.</p></summary>
        [Pure]
        public static HelmListSettings EnableDate(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Date = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Date"/>.</em></p><p>Sort by release date.</p></summary>
        [Pure]
        public static HelmListSettings DisableDate(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Date = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Date"/>.</em></p><p>Sort by release date.</p></summary>
        [Pure]
        public static HelmListSettings ToggleDate(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Date = !toolSettings.Date;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="HelmListSettings.Deleted"/>.</em></p><p>Show deleted releases.</p></summary>
        [Pure]
        public static HelmListSettings SetDeleted(this HelmListSettings toolSettings, bool? deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Deleted"/>.</em></p><p>Show deleted releases.</p></summary>
        [Pure]
        public static HelmListSettings ResetDeleted(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Deleted"/>.</em></p><p>Show deleted releases.</p></summary>
        [Pure]
        public static HelmListSettings EnableDeleted(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Deleted"/>.</em></p><p>Show deleted releases.</p></summary>
        [Pure]
        public static HelmListSettings DisableDeleted(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Deleted"/>.</em></p><p>Show deleted releases.</p></summary>
        [Pure]
        public static HelmListSettings ToggleDeleted(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = !toolSettings.Deleted;
            return toolSettings;
        }
        #endregion
        #region Deleting
        /// <summary><p><em>Sets <see cref="HelmListSettings.Deleting"/>.</em></p><p>Show releases that are currently being deleted.</p></summary>
        [Pure]
        public static HelmListSettings SetDeleting(this HelmListSettings toolSettings, bool? deleting)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleting = deleting;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Deleting"/>.</em></p><p>Show releases that are currently being deleted.</p></summary>
        [Pure]
        public static HelmListSettings ResetDeleting(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleting = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Deleting"/>.</em></p><p>Show releases that are currently being deleted.</p></summary>
        [Pure]
        public static HelmListSettings EnableDeleting(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleting = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Deleting"/>.</em></p><p>Show releases that are currently being deleted.</p></summary>
        [Pure]
        public static HelmListSettings DisableDeleting(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleting = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Deleting"/>.</em></p><p>Show releases that are currently being deleted.</p></summary>
        [Pure]
        public static HelmListSettings ToggleDeleting(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleting = !toolSettings.Deleting;
            return toolSettings;
        }
        #endregion
        #region Deployed
        /// <summary><p><em>Sets <see cref="HelmListSettings.Deployed"/>.</em></p><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        [Pure]
        public static HelmListSettings SetDeployed(this HelmListSettings toolSettings, bool? deployed)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deployed = deployed;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Deployed"/>.</em></p><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        [Pure]
        public static HelmListSettings ResetDeployed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deployed = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Deployed"/>.</em></p><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        [Pure]
        public static HelmListSettings EnableDeployed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deployed = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Deployed"/>.</em></p><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        [Pure]
        public static HelmListSettings DisableDeployed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deployed = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Deployed"/>.</em></p><p>Show deployed releases. If no other is specified, this will be automatically enabled.</p></summary>
        [Pure]
        public static HelmListSettings ToggleDeployed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deployed = !toolSettings.Deployed;
            return toolSettings;
        }
        #endregion
        #region Failed
        /// <summary><p><em>Sets <see cref="HelmListSettings.Failed"/>.</em></p><p>Show failed releases.</p></summary>
        [Pure]
        public static HelmListSettings SetFailed(this HelmListSettings toolSettings, bool? failed)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Failed = failed;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Failed"/>.</em></p><p>Show failed releases.</p></summary>
        [Pure]
        public static HelmListSettings ResetFailed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Failed = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Failed"/>.</em></p><p>Show failed releases.</p></summary>
        [Pure]
        public static HelmListSettings EnableFailed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Failed = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Failed"/>.</em></p><p>Show failed releases.</p></summary>
        [Pure]
        public static HelmListSettings DisableFailed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Failed = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Failed"/>.</em></p><p>Show failed releases.</p></summary>
        [Pure]
        public static HelmListSettings ToggleFailed(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Failed = !toolSettings.Failed;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmListSettings SetHelp(this HelmListSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmListSettings ResetHelp(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmListSettings EnableHelp(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmListSettings DisableHelp(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmListSettings ToggleHelp(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Max
        /// <summary><p><em>Sets <see cref="HelmListSettings.Max"/>.</em></p><p>Maximum number of releases to fetch (default 256).</p></summary>
        [Pure]
        public static HelmListSettings SetMax(this HelmListSettings toolSettings, long? max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Max"/>.</em></p><p>Maximum number of releases to fetch (default 256).</p></summary>
        [Pure]
        public static HelmListSettings ResetMax(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="HelmListSettings.Namespace"/>.</em></p><p>Show releases within a specific namespace.</p></summary>
        [Pure]
        public static HelmListSettings SetNamespace(this HelmListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Namespace"/>.</em></p><p>Show releases within a specific namespace.</p></summary>
        [Pure]
        public static HelmListSettings ResetNamespace(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Offset
        /// <summary><p><em>Sets <see cref="HelmListSettings.Offset"/>.</em></p><p>Next release name in the list, used to offset from start value.</p></summary>
        [Pure]
        public static HelmListSettings SetOffset(this HelmListSettings toolSettings, string offset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = offset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Offset"/>.</em></p><p>Next release name in the list, used to offset from start value.</p></summary>
        [Pure]
        public static HelmListSettings ResetOffset(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offset = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="HelmListSettings.Output"/>.</em></p><p>Output the specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmListSettings SetOutput(this HelmListSettings toolSettings, HelmOutputFormat output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Output"/>.</em></p><p>Output the specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmListSettings ResetOutput(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Pending
        /// <summary><p><em>Sets <see cref="HelmListSettings.Pending"/>.</em></p><p>Show pending releases.</p></summary>
        [Pure]
        public static HelmListSettings SetPending(this HelmListSettings toolSettings, bool? pending)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Pending = pending;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Pending"/>.</em></p><p>Show pending releases.</p></summary>
        [Pure]
        public static HelmListSettings ResetPending(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Pending = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Pending"/>.</em></p><p>Show pending releases.</p></summary>
        [Pure]
        public static HelmListSettings EnablePending(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Pending = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Pending"/>.</em></p><p>Show pending releases.</p></summary>
        [Pure]
        public static HelmListSettings DisablePending(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Pending = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Pending"/>.</em></p><p>Show pending releases.</p></summary>
        [Pure]
        public static HelmListSettings TogglePending(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Pending = !toolSettings.Pending;
            return toolSettings;
        }
        #endregion
        #region Reverse
        /// <summary><p><em>Sets <see cref="HelmListSettings.Reverse"/>.</em></p><p>Reverse the sort order.</p></summary>
        [Pure]
        public static HelmListSettings SetReverse(this HelmListSettings toolSettings, bool? reverse)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reverse = reverse;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Reverse"/>.</em></p><p>Reverse the sort order.</p></summary>
        [Pure]
        public static HelmListSettings ResetReverse(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reverse = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Reverse"/>.</em></p><p>Reverse the sort order.</p></summary>
        [Pure]
        public static HelmListSettings EnableReverse(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reverse = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Reverse"/>.</em></p><p>Reverse the sort order.</p></summary>
        [Pure]
        public static HelmListSettings DisableReverse(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reverse = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Reverse"/>.</em></p><p>Reverse the sort order.</p></summary>
        [Pure]
        public static HelmListSettings ToggleReverse(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reverse = !toolSettings.Reverse;
            return toolSettings;
        }
        #endregion
        #region Short
        /// <summary><p><em>Sets <see cref="HelmListSettings.Short"/>.</em></p><p>Output short (quiet) listing format.</p></summary>
        [Pure]
        public static HelmListSettings SetShort(this HelmListSettings toolSettings, bool? @short)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = @short;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Short"/>.</em></p><p>Output short (quiet) listing format.</p></summary>
        [Pure]
        public static HelmListSettings ResetShort(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Short"/>.</em></p><p>Output short (quiet) listing format.</p></summary>
        [Pure]
        public static HelmListSettings EnableShort(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Short"/>.</em></p><p>Output short (quiet) listing format.</p></summary>
        [Pure]
        public static HelmListSettings DisableShort(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Short"/>.</em></p><p>Output short (quiet) listing format.</p></summary>
        [Pure]
        public static HelmListSettings ToggleShort(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = !toolSettings.Short;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmListSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmListSettings SetTls(this HelmListSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmListSettings ResetTls(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmListSettings EnableTls(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmListSettings DisableTls(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmListSettings ToggleTls(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmListSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmListSettings SetTlsCaCert(this HelmListSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmListSettings ResetTlsCaCert(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmListSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmListSettings SetTlsCert(this HelmListSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmListSettings ResetTlsCert(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmListSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmListSettings SetTlsHostname(this HelmListSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmListSettings ResetTlsHostname(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmListSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmListSettings SetTlsKey(this HelmListSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmListSettings ResetTlsKey(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmListSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmListSettings SetTlsVerify(this HelmListSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmListSettings ResetTlsVerify(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmListSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmListSettings EnableTlsVerify(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmListSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmListSettings DisableTlsVerify(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmListSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmListSettings ToggleTlsVerify(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="HelmListSettings.Filter"/>.</em></p><p>The filter to use.</p></summary>
        [Pure]
        public static HelmListSettings SetFilter(this HelmListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmListSettings.Filter"/>.</em></p><p>The filter to use.</p></summary>
        [Pure]
        public static HelmListSettings ResetFilter(this HelmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmPackageSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmPackageSettingsExtensions
    {
        #region AppVersion
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.AppVersion"/>.</em></p><p>Set the appVersion on the chart to this version.</p></summary>
        [Pure]
        public static HelmPackageSettings SetAppVersion(this HelmPackageSettings toolSettings, string appVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppVersion = appVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.AppVersion"/>.</em></p><p>Set the appVersion on the chart to this version.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetAppVersion(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppVersion = null;
            return toolSettings;
        }
        #endregion
        #region DependencyUpdate
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.DependencyUpdate"/>.</em></p><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        [Pure]
        public static HelmPackageSettings SetDependencyUpdate(this HelmPackageSettings toolSettings, bool? dependencyUpdate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DependencyUpdate = dependencyUpdate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.DependencyUpdate"/>.</em></p><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetDependencyUpdate(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DependencyUpdate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPackageSettings.DependencyUpdate"/>.</em></p><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        [Pure]
        public static HelmPackageSettings EnableDependencyUpdate(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DependencyUpdate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPackageSettings.DependencyUpdate"/>.</em></p><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        [Pure]
        public static HelmPackageSettings DisableDependencyUpdate(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DependencyUpdate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPackageSettings.DependencyUpdate"/>.</em></p><p>Update dependencies from "requirements.yaml" to dir "charts/" before packaging.</p></summary>
        [Pure]
        public static HelmPackageSettings ToggleDependencyUpdate(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DependencyUpdate = !toolSettings.DependencyUpdate;
            return toolSettings;
        }
        #endregion
        #region Destination
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Destination"/>.</em></p><p>Location to write the chart. (default ".").</p></summary>
        [Pure]
        public static HelmPackageSettings SetDestination(this HelmPackageSettings toolSettings, string destination)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = destination;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Destination"/>.</em></p><p>Location to write the chart. (default ".").</p></summary>
        [Pure]
        public static HelmPackageSettings ResetDestination(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Help"/>.</em></p><p>Help for package.</p></summary>
        [Pure]
        public static HelmPackageSettings SetHelp(this HelmPackageSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Help"/>.</em></p><p>Help for package.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetHelp(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPackageSettings.Help"/>.</em></p><p>Help for package.</p></summary>
        [Pure]
        public static HelmPackageSettings EnableHelp(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPackageSettings.Help"/>.</em></p><p>Help for package.</p></summary>
        [Pure]
        public static HelmPackageSettings DisableHelp(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPackageSettings.Help"/>.</em></p><p>Help for package.</p></summary>
        [Pure]
        public static HelmPackageSettings ToggleHelp(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Key"/>.</em></p><p>Name of the key to use when signing. Used if --sign is true.</p></summary>
        [Pure]
        public static HelmPackageSettings SetKey(this HelmPackageSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Key"/>.</em></p><p>Name of the key to use when signing. Used if --sign is true.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetKey(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Keyring"/>.</em></p><p>Location of a public keyring (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmPackageSettings SetKeyring(this HelmPackageSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Keyring"/>.</em></p><p>Location of a public keyring (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmPackageSettings ResetKeyring(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Save
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Save"/>.</em></p><p>Save packaged chart to local chart repository (default true).</p></summary>
        [Pure]
        public static HelmPackageSettings SetSave(this HelmPackageSettings toolSettings, bool? save)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Save = save;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Save"/>.</em></p><p>Save packaged chart to local chart repository (default true).</p></summary>
        [Pure]
        public static HelmPackageSettings ResetSave(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Save = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPackageSettings.Save"/>.</em></p><p>Save packaged chart to local chart repository (default true).</p></summary>
        [Pure]
        public static HelmPackageSettings EnableSave(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Save = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPackageSettings.Save"/>.</em></p><p>Save packaged chart to local chart repository (default true).</p></summary>
        [Pure]
        public static HelmPackageSettings DisableSave(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Save = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPackageSettings.Save"/>.</em></p><p>Save packaged chart to local chart repository (default true).</p></summary>
        [Pure]
        public static HelmPackageSettings ToggleSave(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Save = !toolSettings.Save;
            return toolSettings;
        }
        #endregion
        #region Sign
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Sign"/>.</em></p><p>Use a PGP private key to sign this package.</p></summary>
        [Pure]
        public static HelmPackageSettings SetSign(this HelmPackageSettings toolSettings, bool? sign)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sign = sign;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Sign"/>.</em></p><p>Use a PGP private key to sign this package.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetSign(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sign = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPackageSettings.Sign"/>.</em></p><p>Use a PGP private key to sign this package.</p></summary>
        [Pure]
        public static HelmPackageSettings EnableSign(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sign = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPackageSettings.Sign"/>.</em></p><p>Use a PGP private key to sign this package.</p></summary>
        [Pure]
        public static HelmPackageSettings DisableSign(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sign = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPackageSettings.Sign"/>.</em></p><p>Use a PGP private key to sign this package.</p></summary>
        [Pure]
        public static HelmPackageSettings ToggleSign(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sign = !toolSettings.Sign;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.Version"/>.</em></p><p>Set the version on the chart to this semver version.</p></summary>
        [Pure]
        public static HelmPackageSettings SetVersion(this HelmPackageSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPackageSettings.Version"/>.</em></p><p>Set the version on the chart to this semver version.</p></summary>
        [Pure]
        public static HelmPackageSettings ResetVersion(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region ChartPaths
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.ChartPaths"/> to a new list.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings SetChartPaths(this HelmPackageSettings toolSettings, params string[] chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartPathsInternal = chartPaths.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmPackageSettings.ChartPaths"/> to a new list.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings SetChartPaths(this HelmPackageSettings toolSettings, IEnumerable<string> chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartPathsInternal = chartPaths.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPackageSettings.ChartPaths"/>.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings AddChartPaths(this HelmPackageSettings toolSettings, params string[] chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartPathsInternal.AddRange(chartPaths);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPackageSettings.ChartPaths"/>.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings AddChartPaths(this HelmPackageSettings toolSettings, IEnumerable<string> chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartPathsInternal.AddRange(chartPaths);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmPackageSettings.ChartPaths"/>.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings ClearChartPaths(this HelmPackageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartPathsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPackageSettings.ChartPaths"/>.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings RemoveChartPaths(this HelmPackageSettings toolSettings, params string[] chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(chartPaths);
            toolSettings.ChartPathsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPackageSettings.ChartPaths"/>.</em></p><p>The paths to the charts to package.</p></summary>
        [Pure]
        public static HelmPackageSettings RemoveChartPaths(this HelmPackageSettings toolSettings, IEnumerable<string> chartPaths)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(chartPaths);
            toolSettings.ChartPathsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmPluginInstallSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmPluginInstallSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmPluginInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings SetHelp(this HelmPluginInstallSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings ResetHelp(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPluginInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings EnableHelp(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPluginInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings DisableHelp(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPluginInstallSettings.Help"/>.</em></p><p>Help for install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings ToggleHelp(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmPluginInstallSettings.Version"/>.</em></p><p>Specify a version constraint. If this is not specified, the latest version is installed.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings SetVersion(this HelmPluginInstallSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginInstallSettings.Version"/>.</em></p><p>Specify a version constraint. If this is not specified, the latest version is installed.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings ResetVersion(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Options
        /// <summary><p><em>Sets <see cref="HelmPluginInstallSettings.Options"/>.</em></p></summary>
        [Pure]
        public static HelmPluginInstallSettings SetOptions(this HelmPluginInstallSettings toolSettings, string options)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Options = options;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginInstallSettings.Options"/>.</em></p></summary>
        [Pure]
        public static HelmPluginInstallSettings ResetOptions(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Options = null;
            return toolSettings;
        }
        #endregion
        #region Paths
        /// <summary><p><em>Sets <see cref="HelmPluginInstallSettings.Paths"/> to a new list.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings SetPaths(this HelmPluginInstallSettings toolSettings, params string[] paths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PathsInternal = paths.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmPluginInstallSettings.Paths"/> to a new list.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings SetPaths(this HelmPluginInstallSettings toolSettings, IEnumerable<string> paths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PathsInternal = paths.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginInstallSettings.Paths"/>.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings AddPaths(this HelmPluginInstallSettings toolSettings, params string[] paths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PathsInternal.AddRange(paths);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginInstallSettings.Paths"/>.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings AddPaths(this HelmPluginInstallSettings toolSettings, IEnumerable<string> paths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PathsInternal.AddRange(paths);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmPluginInstallSettings.Paths"/>.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings ClearPaths(this HelmPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PathsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginInstallSettings.Paths"/>.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings RemovePaths(this HelmPluginInstallSettings toolSettings, params string[] paths)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(paths);
            toolSettings.PathsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginInstallSettings.Paths"/>.</em></p><p>List of paths or urls of packages to install.</p></summary>
        [Pure]
        public static HelmPluginInstallSettings RemovePaths(this HelmPluginInstallSettings toolSettings, IEnumerable<string> paths)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(paths);
            toolSettings.PathsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmPluginListSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmPluginListSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmPluginListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmPluginListSettings SetHelp(this HelmPluginListSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmPluginListSettings ResetHelp(this HelmPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPluginListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmPluginListSettings EnableHelp(this HelmPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPluginListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmPluginListSettings DisableHelp(this HelmPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPluginListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmPluginListSettings ToggleHelp(this HelmPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmPluginRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmPluginRemoveSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmPluginRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings SetHelp(this HelmPluginRemoveSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings ResetHelp(this HelmPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPluginRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings EnableHelp(this HelmPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPluginRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings DisableHelp(this HelmPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPluginRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings ToggleHelp(this HelmPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Plugins
        /// <summary><p><em>Sets <see cref="HelmPluginRemoveSettings.Plugins"/> to a new list.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings SetPlugins(this HelmPluginRemoveSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal = plugins.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmPluginRemoveSettings.Plugins"/> to a new list.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings SetPlugins(this HelmPluginRemoveSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal = plugins.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginRemoveSettings.Plugins"/>.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings AddPlugins(this HelmPluginRemoveSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.AddRange(plugins);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginRemoveSettings.Plugins"/>.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings AddPlugins(this HelmPluginRemoveSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.AddRange(plugins);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmPluginRemoveSettings.Plugins"/>.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings ClearPlugins(this HelmPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginRemoveSettings.Plugins"/>.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings RemovePlugins(this HelmPluginRemoveSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(plugins);
            toolSettings.PluginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginRemoveSettings.Plugins"/>.</em></p><p>List of plugins to remove.</p></summary>
        [Pure]
        public static HelmPluginRemoveSettings RemovePlugins(this HelmPluginRemoveSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(plugins);
            toolSettings.PluginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmPluginUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmPluginUpdateSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmPluginUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings SetHelp(this HelmPluginUpdateSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmPluginUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings ResetHelp(this HelmPluginUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmPluginUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings EnableHelp(this HelmPluginUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmPluginUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings DisableHelp(this HelmPluginUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmPluginUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings ToggleHelp(this HelmPluginUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Plugins
        /// <summary><p><em>Sets <see cref="HelmPluginUpdateSettings.Plugins"/> to a new list.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings SetPlugins(this HelmPluginUpdateSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal = plugins.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmPluginUpdateSettings.Plugins"/> to a new list.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings SetPlugins(this HelmPluginUpdateSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal = plugins.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginUpdateSettings.Plugins"/>.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings AddPlugins(this HelmPluginUpdateSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.AddRange(plugins);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmPluginUpdateSettings.Plugins"/>.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings AddPlugins(this HelmPluginUpdateSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.AddRange(plugins);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmPluginUpdateSettings.Plugins"/>.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings ClearPlugins(this HelmPluginUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PluginsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginUpdateSettings.Plugins"/>.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings RemovePlugins(this HelmPluginUpdateSettings toolSettings, params string[] plugins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(plugins);
            toolSettings.PluginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmPluginUpdateSettings.Plugins"/>.</em></p><p>List of plugins to update.</p></summary>
        [Pure]
        public static HelmPluginUpdateSettings RemovePlugins(this HelmPluginUpdateSettings toolSettings, IEnumerable<string> plugins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(plugins);
            toolSettings.PluginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRepoAddSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRepoAddSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetCaFile(this HelmRepoAddSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetCaFile(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetCertFile(this HelmRepoAddSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetCertFile(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.Help"/>.</em></p><p>Help for add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetHelp(this HelmRepoAddSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.Help"/>.</em></p><p>Help for add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetHelp(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoAddSettings.Help"/>.</em></p><p>Help for add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings EnableHelp(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoAddSettings.Help"/>.</em></p><p>Help for add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings DisableHelp(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoAddSettings.Help"/>.</em></p><p>Help for add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ToggleHelp(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetKeyFile(this HelmRepoAddSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetKeyFile(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region NoUpdate
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.NoUpdate"/>.</em></p><p>Raise error if repo is already registered.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetNoUpdate(this HelmRepoAddSettings toolSettings, bool? noUpdate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoUpdate = noUpdate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.NoUpdate"/>.</em></p><p>Raise error if repo is already registered.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetNoUpdate(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoUpdate = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoAddSettings.NoUpdate"/>.</em></p><p>Raise error if repo is already registered.</p></summary>
        [Pure]
        public static HelmRepoAddSettings EnableNoUpdate(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoUpdate = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoAddSettings.NoUpdate"/>.</em></p><p>Raise error if repo is already registered.</p></summary>
        [Pure]
        public static HelmRepoAddSettings DisableNoUpdate(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoUpdate = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoAddSettings.NoUpdate"/>.</em></p><p>Raise error if repo is already registered.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ToggleNoUpdate(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoUpdate = !toolSettings.NoUpdate;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.Password"/>.</em></p><p>Chart repository password.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetPassword(this HelmRepoAddSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.Password"/>.</em></p><p>Chart repository password.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetPassword(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.Username"/>.</em></p><p>Chart repository username.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetUsername(this HelmRepoAddSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.Username"/>.</em></p><p>Chart repository username.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetUsername(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.Name"/>.</em></p><p>The name of the repository to add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetName(this HelmRepoAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.Name"/>.</em></p><p>The name of the repository to add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetName(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Url
        /// <summary><p><em>Sets <see cref="HelmRepoAddSettings.Url"/>.</em></p><p>The url of the repository to add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings SetUrl(this HelmRepoAddSettings toolSettings, string url)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = url;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoAddSettings.Url"/>.</em></p><p>The url of the repository to add.</p></summary>
        [Pure]
        public static HelmRepoAddSettings ResetUrl(this HelmRepoAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRepoIndexSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRepoIndexSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRepoIndexSettings.Help"/>.</em></p><p>Help for index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings SetHelp(this HelmRepoIndexSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoIndexSettings.Help"/>.</em></p><p>Help for index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings ResetHelp(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoIndexSettings.Help"/>.</em></p><p>Help for index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings EnableHelp(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoIndexSettings.Help"/>.</em></p><p>Help for index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings DisableHelp(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoIndexSettings.Help"/>.</em></p><p>Help for index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings ToggleHelp(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Merge
        /// <summary><p><em>Sets <see cref="HelmRepoIndexSettings.Merge"/>.</em></p><p>Merge the generated index into the given index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings SetMerge(this HelmRepoIndexSettings toolSettings, string merge)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Merge = merge;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoIndexSettings.Merge"/>.</em></p><p>Merge the generated index into the given index.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings ResetMerge(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Merge = null;
            return toolSettings;
        }
        #endregion
        #region Url
        /// <summary><p><em>Sets <see cref="HelmRepoIndexSettings.Url"/>.</em></p><p>Url of chart repository.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings SetUrl(this HelmRepoIndexSettings toolSettings, string url)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = url;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoIndexSettings.Url"/>.</em></p><p>Url of chart repository.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings ResetUrl(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = null;
            return toolSettings;
        }
        #endregion
        #region Directory
        /// <summary><p><em>Sets <see cref="HelmRepoIndexSettings.Directory"/>.</em></p><p>The directory of the repository.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings SetDirectory(this HelmRepoIndexSettings toolSettings, string directory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Directory = directory;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoIndexSettings.Directory"/>.</em></p><p>The directory of the repository.</p></summary>
        [Pure]
        public static HelmRepoIndexSettings ResetDirectory(this HelmRepoIndexSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Directory = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRepoListSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRepoListSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRepoListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmRepoListSettings SetHelp(this HelmRepoListSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmRepoListSettings ResetHelp(this HelmRepoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmRepoListSettings EnableHelp(this HelmRepoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmRepoListSettings DisableHelp(this HelmRepoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoListSettings.Help"/>.</em></p><p>Help for list.</p></summary>
        [Pure]
        public static HelmRepoListSettings ToggleHelp(this HelmRepoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRepoRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRepoRemoveSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRepoRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings SetHelp(this HelmRepoRemoveSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings ResetHelp(this HelmRepoRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings EnableHelp(this HelmRepoRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings DisableHelp(this HelmRepoRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoRemoveSettings.Help"/>.</em></p><p>Help for remove.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings ToggleHelp(this HelmRepoRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="HelmRepoRemoveSettings.Name"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings SetName(this HelmRepoRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoRemoveSettings.Name"/>.</em></p><p>The name of the repository.</p></summary>
        [Pure]
        public static HelmRepoRemoveSettings ResetName(this HelmRepoRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRepoUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRepoUpdateSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRepoUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmRepoUpdateSettings SetHelp(this HelmRepoUpdateSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRepoUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmRepoUpdateSettings ResetHelp(this HelmRepoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRepoUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmRepoUpdateSettings EnableHelp(this HelmRepoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRepoUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmRepoUpdateSettings DisableHelp(this HelmRepoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRepoUpdateSettings.Help"/>.</em></p><p>Help for update.</p></summary>
        [Pure]
        public static HelmRepoUpdateSettings ToggleHelp(this HelmRepoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmResetSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmResetSettingsExtensions
    {
        #region Force
        /// <summary><p><em>Sets <see cref="HelmResetSettings.Force"/>.</em></p><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        [Pure]
        public static HelmResetSettings SetForce(this HelmResetSettings toolSettings, bool? force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.Force"/>.</em></p><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        [Pure]
        public static HelmResetSettings ResetForce(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmResetSettings.Force"/>.</em></p><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        [Pure]
        public static HelmResetSettings EnableForce(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmResetSettings.Force"/>.</em></p><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        [Pure]
        public static HelmResetSettings DisableForce(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmResetSettings.Force"/>.</em></p><p>Forces Tiller uninstall even if there are releases installed, or if Tiller is not in ready state. Releases are not deleted.).</p></summary>
        [Pure]
        public static HelmResetSettings ToggleForce(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmResetSettings.Help"/>.</em></p><p>Help for reset.</p></summary>
        [Pure]
        public static HelmResetSettings SetHelp(this HelmResetSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.Help"/>.</em></p><p>Help for reset.</p></summary>
        [Pure]
        public static HelmResetSettings ResetHelp(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmResetSettings.Help"/>.</em></p><p>Help for reset.</p></summary>
        [Pure]
        public static HelmResetSettings EnableHelp(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmResetSettings.Help"/>.</em></p><p>Help for reset.</p></summary>
        [Pure]
        public static HelmResetSettings DisableHelp(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmResetSettings.Help"/>.</em></p><p>Help for reset.</p></summary>
        [Pure]
        public static HelmResetSettings ToggleHelp(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region RemoveHelmHome
        /// <summary><p><em>Sets <see cref="HelmResetSettings.RemoveHelmHome"/>.</em></p><p>If set deletes $HELM_HOME.</p></summary>
        [Pure]
        public static HelmResetSettings SetRemoveHelmHome(this HelmResetSettings toolSettings, bool? removeHelmHome)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveHelmHome = removeHelmHome;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.RemoveHelmHome"/>.</em></p><p>If set deletes $HELM_HOME.</p></summary>
        [Pure]
        public static HelmResetSettings ResetRemoveHelmHome(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveHelmHome = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmResetSettings.RemoveHelmHome"/>.</em></p><p>If set deletes $HELM_HOME.</p></summary>
        [Pure]
        public static HelmResetSettings EnableRemoveHelmHome(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveHelmHome = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmResetSettings.RemoveHelmHome"/>.</em></p><p>If set deletes $HELM_HOME.</p></summary>
        [Pure]
        public static HelmResetSettings DisableRemoveHelmHome(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveHelmHome = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmResetSettings.RemoveHelmHome"/>.</em></p><p>If set deletes $HELM_HOME.</p></summary>
        [Pure]
        public static HelmResetSettings ToggleRemoveHelmHome(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RemoveHelmHome = !toolSettings.RemoveHelmHome;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmResetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmResetSettings SetTls(this HelmResetSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmResetSettings ResetTls(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmResetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmResetSettings EnableTls(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmResetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmResetSettings DisableTls(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmResetSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmResetSettings ToggleTls(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmResetSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmResetSettings SetTlsCaCert(this HelmResetSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmResetSettings ResetTlsCaCert(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmResetSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmResetSettings SetTlsCert(this HelmResetSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmResetSettings ResetTlsCert(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmResetSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmResetSettings SetTlsHostname(this HelmResetSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmResetSettings ResetTlsHostname(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmResetSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmResetSettings SetTlsKey(this HelmResetSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmResetSettings ResetTlsKey(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmResetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmResetSettings SetTlsVerify(this HelmResetSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmResetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmResetSettings ResetTlsVerify(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmResetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmResetSettings EnableTlsVerify(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmResetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmResetSettings DisableTlsVerify(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmResetSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmResetSettings ToggleTlsVerify(this HelmResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmRollbackSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmRollbackSettingsExtensions
    {
        #region Description
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetDescription(this HelmRollbackSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Description"/>.</em></p><p>Specify a description for the release.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetDescription(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.DryRun"/>.</em></p><p>Simulate a rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetDryRun(this HelmRollbackSettings toolSettings, bool? dryRun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.DryRun"/>.</em></p><p>Simulate a rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetDryRun(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.DryRun"/>.</em></p><p>Simulate a rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableDryRun(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.DryRun"/>.</em></p><p>Simulate a rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableDryRun(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.DryRun"/>.</em></p><p>Simulate a rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleDryRun(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetForce(this HelmRollbackSettings toolSettings, bool? force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetForce(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableForce(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableForce(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleForce(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Help"/>.</em></p><p>Help for rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetHelp(this HelmRollbackSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Help"/>.</em></p><p>Help for rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetHelp(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.Help"/>.</em></p><p>Help for rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableHelp(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.Help"/>.</em></p><p>Help for rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableHelp(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.Help"/>.</em></p><p>Help for rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleHelp(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region NoHooks
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetNoHooks(this HelmRollbackSettings toolSettings, bool? noHooks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = noHooks;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetNoHooks(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableNoHooks(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableNoHooks(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.NoHooks"/>.</em></p><p>Prevent hooks from running during rollback.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleNoHooks(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = !toolSettings.NoHooks;
            return toolSettings;
        }
        #endregion
        #region RecreatePods
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetRecreatePods(this HelmRollbackSettings toolSettings, bool? recreatePods)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = recreatePods;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetRecreatePods(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableRecreatePods(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableRecreatePods(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleRecreatePods(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = !toolSettings.RecreatePods;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTimeout(this HelmRollbackSettings toolSettings, long? timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTimeout(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTls(this HelmRollbackSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTls(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableTls(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableTls(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleTls(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTlsCaCert(this HelmRollbackSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTlsCaCert(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTlsCert(this HelmRollbackSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTlsCert(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTlsHostname(this HelmRollbackSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTlsHostname(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTlsKey(this HelmRollbackSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTlsKey(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetTlsVerify(this HelmRollbackSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetTlsVerify(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableTlsVerify(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableTlsVerify(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleTlsVerify(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetWait(this HelmRollbackSettings toolSettings, bool? wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetWait(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmRollbackSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmRollbackSettings EnableWait(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmRollbackSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmRollbackSettings DisableWait(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmRollbackSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmRollbackSettings ToggleWait(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = !toolSettings.Wait;
            return toolSettings;
        }
        #endregion
        #region Release
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Release"/>.</em></p><p>The name of the release.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetRelease(this HelmRollbackSettings toolSettings, string release)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = release;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Release"/>.</em></p><p>The name of the release.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetRelease(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = null;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmRollbackSettings.Revision"/>.</em></p><p>The revison to roll back.</p></summary>
        [Pure]
        public static HelmRollbackSettings SetRevision(this HelmRollbackSettings toolSettings, string revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmRollbackSettings.Revision"/>.</em></p><p>The revison to roll back.</p></summary>
        [Pure]
        public static HelmRollbackSettings ResetRevision(this HelmRollbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmSearchSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmSearchSettingsExtensions
    {
        #region ColWidth
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmSearchSettings SetColWidth(this HelmSearchSettings toolSettings, uint? colWidth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = colWidth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.ColWidth"/>.</em></p><p>Specifies the max column width of output (default 60).</p></summary>
        [Pure]
        public static HelmSearchSettings ResetColWidth(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ColWidth = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.Help"/>.</em></p><p>Help for search.</p></summary>
        [Pure]
        public static HelmSearchSettings SetHelp(this HelmSearchSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.Help"/>.</em></p><p>Help for search.</p></summary>
        [Pure]
        public static HelmSearchSettings ResetHelp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmSearchSettings.Help"/>.</em></p><p>Help for search.</p></summary>
        [Pure]
        public static HelmSearchSettings EnableHelp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmSearchSettings.Help"/>.</em></p><p>Help for search.</p></summary>
        [Pure]
        public static HelmSearchSettings DisableHelp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmSearchSettings.Help"/>.</em></p><p>Help for search.</p></summary>
        [Pure]
        public static HelmSearchSettings ToggleHelp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Regexp
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.Regexp"/>.</em></p><p>Use regular expressions for searching.</p></summary>
        [Pure]
        public static HelmSearchSettings SetRegexp(this HelmSearchSettings toolSettings, bool? regexp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Regexp = regexp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.Regexp"/>.</em></p><p>Use regular expressions for searching.</p></summary>
        [Pure]
        public static HelmSearchSettings ResetRegexp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Regexp = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmSearchSettings.Regexp"/>.</em></p><p>Use regular expressions for searching.</p></summary>
        [Pure]
        public static HelmSearchSettings EnableRegexp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Regexp = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmSearchSettings.Regexp"/>.</em></p><p>Use regular expressions for searching.</p></summary>
        [Pure]
        public static HelmSearchSettings DisableRegexp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Regexp = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmSearchSettings.Regexp"/>.</em></p><p>Use regular expressions for searching.</p></summary>
        [Pure]
        public static HelmSearchSettings ToggleRegexp(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Regexp = !toolSettings.Regexp;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.Version"/>.</em></p><p>Search using semantic versioning constraints.</p></summary>
        [Pure]
        public static HelmSearchSettings SetVersion(this HelmSearchSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.Version"/>.</em></p><p>Search using semantic versioning constraints.</p></summary>
        [Pure]
        public static HelmSearchSettings ResetVersion(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Versions
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.Versions"/>.</em></p><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        [Pure]
        public static HelmSearchSettings SetVersions(this HelmSearchSettings toolSettings, bool? versions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Versions = versions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.Versions"/>.</em></p><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        [Pure]
        public static HelmSearchSettings ResetVersions(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Versions = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmSearchSettings.Versions"/>.</em></p><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        [Pure]
        public static HelmSearchSettings EnableVersions(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Versions = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmSearchSettings.Versions"/>.</em></p><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        [Pure]
        public static HelmSearchSettings DisableVersions(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Versions = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmSearchSettings.Versions"/>.</em></p><p>Show the long listing, with each version of each chart on its own line.</p></summary>
        [Pure]
        public static HelmSearchSettings ToggleVersions(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Versions = !toolSettings.Versions;
            return toolSettings;
        }
        #endregion
        #region Keyword
        /// <summary><p><em>Sets <see cref="HelmSearchSettings.Keyword"/>.</em></p><p>The keyword to search for.</p></summary>
        [Pure]
        public static HelmSearchSettings SetKeyword(this HelmSearchSettings toolSettings, string keyword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyword = keyword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmSearchSettings.Keyword"/>.</em></p><p>The keyword to search for.</p></summary>
        [Pure]
        public static HelmSearchSettings ResetKeyword(this HelmSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyword = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmServeSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmServeSettingsExtensions
    {
        #region Address
        /// <summary><p><em>Sets <see cref="HelmServeSettings.Address"/>.</em></p><p>Address to listen on (default "127.0.0.1:8879").</p></summary>
        [Pure]
        public static HelmServeSettings SetAddress(this HelmServeSettings toolSettings, string address)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = address;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmServeSettings.Address"/>.</em></p><p>Address to listen on (default "127.0.0.1:8879").</p></summary>
        [Pure]
        public static HelmServeSettings ResetAddress(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmServeSettings.Help"/>.</em></p><p>Help for serve.</p></summary>
        [Pure]
        public static HelmServeSettings SetHelp(this HelmServeSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmServeSettings.Help"/>.</em></p><p>Help for serve.</p></summary>
        [Pure]
        public static HelmServeSettings ResetHelp(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmServeSettings.Help"/>.</em></p><p>Help for serve.</p></summary>
        [Pure]
        public static HelmServeSettings EnableHelp(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmServeSettings.Help"/>.</em></p><p>Help for serve.</p></summary>
        [Pure]
        public static HelmServeSettings DisableHelp(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmServeSettings.Help"/>.</em></p><p>Help for serve.</p></summary>
        [Pure]
        public static HelmServeSettings ToggleHelp(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region RepoPath
        /// <summary><p><em>Sets <see cref="HelmServeSettings.RepoPath"/>.</em></p><p>Local directory path from which to serve charts.</p></summary>
        [Pure]
        public static HelmServeSettings SetRepoPath(this HelmServeSettings toolSettings, string repoPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoPath = repoPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmServeSettings.RepoPath"/>.</em></p><p>Local directory path from which to serve charts.</p></summary>
        [Pure]
        public static HelmServeSettings ResetRepoPath(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoPath = null;
            return toolSettings;
        }
        #endregion
        #region Url
        /// <summary><p><em>Sets <see cref="HelmServeSettings.Url"/>.</em></p><p>External URL of chart repository.</p></summary>
        [Pure]
        public static HelmServeSettings SetUrl(this HelmServeSettings toolSettings, string url)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = url;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmServeSettings.Url"/>.</em></p><p>External URL of chart repository.</p></summary>
        [Pure]
        public static HelmServeSettings ResetUrl(this HelmServeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Url = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmStatusSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmStatusSettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.Help"/>.</em></p><p>Help for status.</p></summary>
        [Pure]
        public static HelmStatusSettings SetHelp(this HelmStatusSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.Help"/>.</em></p><p>Help for status.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetHelp(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmStatusSettings.Help"/>.</em></p><p>Help for status.</p></summary>
        [Pure]
        public static HelmStatusSettings EnableHelp(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmStatusSettings.Help"/>.</em></p><p>Help for status.</p></summary>
        [Pure]
        public static HelmStatusSettings DisableHelp(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmStatusSettings.Help"/>.</em></p><p>Help for status.</p></summary>
        [Pure]
        public static HelmStatusSettings ToggleHelp(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.Output"/>.</em></p><p>Output the status in the specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmStatusSettings SetOutput(this HelmStatusSettings toolSettings, HelmOutputFormat output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.Output"/>.</em></p><p>Output the status in the specified format (json or yaml).</p></summary>
        [Pure]
        public static HelmStatusSettings ResetOutput(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Revision
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.Revision"/>.</em></p><p>If set, display the status of the named release with revision.</p></summary>
        [Pure]
        public static HelmStatusSettings SetRevision(this HelmStatusSettings toolSettings, int? revision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = revision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.Revision"/>.</em></p><p>If set, display the status of the named release with revision.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetRevision(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Revision = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmStatusSettings SetTls(this HelmStatusSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTls(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmStatusSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmStatusSettings EnableTls(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmStatusSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmStatusSettings DisableTls(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmStatusSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmStatusSettings ToggleTls(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings SetTlsCaCert(this HelmStatusSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTlsCaCert(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings SetTlsCert(this HelmStatusSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTlsCert(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmStatusSettings SetTlsHostname(this HelmStatusSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTlsHostname(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings SetTlsKey(this HelmStatusSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTlsKey(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmStatusSettings SetTlsVerify(this HelmStatusSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetTlsVerify(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmStatusSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmStatusSettings EnableTlsVerify(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmStatusSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmStatusSettings DisableTlsVerify(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmStatusSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmStatusSettings ToggleTlsVerify(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region ReleaseName
        /// <summary><p><em>Sets <see cref="HelmStatusSettings.ReleaseName"/>.</em></p><p>The name of the release to get the status for.</p></summary>
        [Pure]
        public static HelmStatusSettings SetReleaseName(this HelmStatusSettings toolSettings, string releaseName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = releaseName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmStatusSettings.ReleaseName"/>.</em></p><p>The name of the release to get the status for.</p></summary>
        [Pure]
        public static HelmStatusSettings ResetReleaseName(this HelmStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseName = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmTemplateSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmTemplateSettingsExtensions
    {
        #region Execute
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Execute"/> to a new dictionary.</em></p><p>Only execute the given templates.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetExecute(this HelmTemplateSettings toolSettings, IDictionary<string, object> execute)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecuteInternal = execute.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmTemplateSettings.Execute"/>.</em></p><p>Only execute the given templates.</p></summary>
        [Pure]
        public static HelmTemplateSettings ClearExecute(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecuteInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmTemplateSettings.Execute"/>.</em></p><p>Only execute the given templates.</p></summary>
        [Pure]
        public static HelmTemplateSettings AddExecute(this HelmTemplateSettings toolSettings, string executeKey, object executeValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecuteInternal.Add(executeKey, executeValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmTemplateSettings.Execute"/>.</em></p><p>Only execute the given templates.</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveExecute(this HelmTemplateSettings toolSettings, string executeKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecuteInternal.Remove(executeKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmTemplateSettings.Execute"/>.</em></p><p>Only execute the given templates.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetExecute(this HelmTemplateSettings toolSettings, string executeKey, object executeValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecuteInternal[executeKey] = executeValue;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Help"/>.</em></p><p>Help for template.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetHelp(this HelmTemplateSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.Help"/>.</em></p><p>Help for template.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetHelp(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTemplateSettings.Help"/>.</em></p><p>Help for template.</p></summary>
        [Pure]
        public static HelmTemplateSettings EnableHelp(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTemplateSettings.Help"/>.</em></p><p>Help for template.</p></summary>
        [Pure]
        public static HelmTemplateSettings DisableHelp(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTemplateSettings.Help"/>.</em></p><p>Help for template.</p></summary>
        [Pure]
        public static HelmTemplateSettings ToggleHelp(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region IsUpgrade
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.IsUpgrade"/>.</em></p><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetIsUpgrade(this HelmTemplateSettings toolSettings, bool? isUpgrade)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsUpgrade = isUpgrade;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.IsUpgrade"/>.</em></p><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetIsUpgrade(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsUpgrade = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTemplateSettings.IsUpgrade"/>.</em></p><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        [Pure]
        public static HelmTemplateSettings EnableIsUpgrade(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsUpgrade = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTemplateSettings.IsUpgrade"/>.</em></p><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        [Pure]
        public static HelmTemplateSettings DisableIsUpgrade(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsUpgrade = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTemplateSettings.IsUpgrade"/>.</em></p><p>Set .Release.IsUpgrade instead of .Release.IsInstall.</p></summary>
        [Pure]
        public static HelmTemplateSettings ToggleIsUpgrade(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsUpgrade = !toolSettings.IsUpgrade;
            return toolSettings;
        }
        #endregion
        #region KubeVersion
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.KubeVersion"/>.</em></p><p>Kubernetes version used as Capabilities.KubeVersion.Major/Minor (default "1.9").</p></summary>
        [Pure]
        public static HelmTemplateSettings SetKubeVersion(this HelmTemplateSettings toolSettings, string kubeVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubeVersion = kubeVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.KubeVersion"/>.</em></p><p>Kubernetes version used as Capabilities.KubeVersion.Major/Minor (default "1.9").</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetKubeVersion(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubeVersion = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Name"/>.</em></p><p>Release name (default "RELEASE-NAME").</p></summary>
        [Pure]
        public static HelmTemplateSettings SetName(this HelmTemplateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.Name"/>.</em></p><p>Release name (default "RELEASE-NAME").</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetName(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NameTemplate
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.NameTemplate"/>.</em></p><p>Specify template used to name the release.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetNameTemplate(this HelmTemplateSettings toolSettings, string nameTemplate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameTemplate = nameTemplate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.NameTemplate"/>.</em></p><p>Specify template used to name the release.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetNameTemplate(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameTemplate = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Namespace"/>.</em></p><p>Namespace to install the release into.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetNamespace(this HelmTemplateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.Namespace"/>.</em></p><p>Namespace to install the release into.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetNamespace(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Notes"/>.</em></p><p>Show the computed NOTES.txt file as well.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetNotes(this HelmTemplateSettings toolSettings, bool? notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.Notes"/>.</em></p><p>Show the computed NOTES.txt file as well.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetNotes(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTemplateSettings.Notes"/>.</em></p><p>Show the computed NOTES.txt file as well.</p></summary>
        [Pure]
        public static HelmTemplateSettings EnableNotes(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTemplateSettings.Notes"/>.</em></p><p>Show the computed NOTES.txt file as well.</p></summary>
        [Pure]
        public static HelmTemplateSettings DisableNotes(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTemplateSettings.Notes"/>.</em></p><p>Show the computed NOTES.txt file as well.</p></summary>
        [Pure]
        public static HelmTemplateSettings ToggleNotes(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = !toolSettings.Notes;
            return toolSettings;
        }
        #endregion
        #region OutputDir
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.OutputDir"/>.</em></p><p>Writes the executed templates to files in output-dir instead of stdout.</p></summary>
        [Pure]
        public static HelmTemplateSettings SetOutputDir(this HelmTemplateSettings toolSettings, string outputDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = outputDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.OutputDir"/>.</em></p><p>Writes the executed templates to files in output-dir instead of stdout.</p></summary>
        [Pure]
        public static HelmTemplateSettings ResetOutputDir(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Set"/> to a new dictionary.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSet(this HelmTemplateSettings toolSettings, IDictionary<string, object> set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal = set.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmTemplateSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings ClearSet(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmTemplateSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings AddSet(this HelmTemplateSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Add(setKey, setValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmTemplateSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveSet(this HelmTemplateSettings toolSettings, string setKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Remove(setKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmTemplateSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSet(this HelmTemplateSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal[setKey] = setValue;
            return toolSettings;
        }
        #endregion
        #region SetFile
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.SetFile"/> to a new dictionary.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSetFile(this HelmTemplateSettings toolSettings, IDictionary<string, object> setFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal = setFile.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmTemplateSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmTemplateSettings ClearSetFile(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmTemplateSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmTemplateSettings AddSetFile(this HelmTemplateSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Add(setFileKey, setFileValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmTemplateSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveSetFile(this HelmTemplateSettings toolSettings, string setFileKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Remove(setFileKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmTemplateSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSetFile(this HelmTemplateSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal[setFileKey] = setFileValue;
            return toolSettings;
        }
        #endregion
        #region SetString
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.SetString"/> to a new dictionary.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSetString(this HelmTemplateSettings toolSettings, IDictionary<string, object> setString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal = setString.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmTemplateSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings ClearSetString(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmTemplateSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings AddSetString(this HelmTemplateSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Add(setStringKey, setStringValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmTemplateSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveSetString(this HelmTemplateSettings toolSettings, string setStringKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Remove(setStringKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmTemplateSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetSetString(this HelmTemplateSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal[setStringKey] = setStringValue;
            return toolSettings;
        }
        #endregion
        #region Values
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetValues(this HelmTemplateSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings SetValues(this HelmTemplateSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmTemplateSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings AddValues(this HelmTemplateSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmTemplateSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings AddValues(this HelmTemplateSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmTemplateSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings ClearValues(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmTemplateSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveValues(this HelmTemplateSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmTemplateSettings.Values"/>.</em></p><p>Specify values in a YAML file (can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmTemplateSettings RemoveValues(this HelmTemplateSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmTemplateSettings.Chart"/>.</em></p></summary>
        [Pure]
        public static HelmTemplateSettings SetChart(this HelmTemplateSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTemplateSettings.Chart"/>.</em></p></summary>
        [Pure]
        public static HelmTemplateSettings ResetChart(this HelmTemplateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmTestSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmTestSettingsExtensions
    {
        #region Cleanup
        /// <summary><p><em>Sets <see cref="HelmTestSettings.Cleanup"/>.</em></p><p>Delete test pods upon completion.</p></summary>
        [Pure]
        public static HelmTestSettings SetCleanup(this HelmTestSettings toolSettings, bool? cleanup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cleanup = cleanup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.Cleanup"/>.</em></p><p>Delete test pods upon completion.</p></summary>
        [Pure]
        public static HelmTestSettings ResetCleanup(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cleanup = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTestSettings.Cleanup"/>.</em></p><p>Delete test pods upon completion.</p></summary>
        [Pure]
        public static HelmTestSettings EnableCleanup(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cleanup = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTestSettings.Cleanup"/>.</em></p><p>Delete test pods upon completion.</p></summary>
        [Pure]
        public static HelmTestSettings DisableCleanup(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cleanup = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTestSettings.Cleanup"/>.</em></p><p>Delete test pods upon completion.</p></summary>
        [Pure]
        public static HelmTestSettings ToggleCleanup(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cleanup = !toolSettings.Cleanup;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmTestSettings.Help"/>.</em></p><p>Help for test.</p></summary>
        [Pure]
        public static HelmTestSettings SetHelp(this HelmTestSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.Help"/>.</em></p><p>Help for test.</p></summary>
        [Pure]
        public static HelmTestSettings ResetHelp(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTestSettings.Help"/>.</em></p><p>Help for test.</p></summary>
        [Pure]
        public static HelmTestSettings EnableHelp(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTestSettings.Help"/>.</em></p><p>Help for test.</p></summary>
        [Pure]
        public static HelmTestSettings DisableHelp(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTestSettings.Help"/>.</em></p><p>Help for test.</p></summary>
        [Pure]
        public static HelmTestSettings ToggleHelp(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="HelmTestSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmTestSettings SetTimeout(this HelmTestSettings toolSettings, long? timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmTestSettings ResetTimeout(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmTestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmTestSettings SetTls(this HelmTestSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmTestSettings ResetTls(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmTestSettings EnableTls(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmTestSettings DisableTls(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTestSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmTestSettings ToggleTls(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmTestSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmTestSettings SetTlsCaCert(this HelmTestSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmTestSettings ResetTlsCaCert(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmTestSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmTestSettings SetTlsCert(this HelmTestSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmTestSettings ResetTlsCert(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmTestSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmTestSettings SetTlsHostname(this HelmTestSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmTestSettings ResetTlsHostname(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmTestSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmTestSettings SetTlsKey(this HelmTestSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmTestSettings ResetTlsKey(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmTestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmTestSettings SetTlsVerify(this HelmTestSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmTestSettings ResetTlsVerify(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmTestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmTestSettings EnableTlsVerify(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmTestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmTestSettings DisableTlsVerify(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmTestSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmTestSettings ToggleTlsVerify(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region Release
        /// <summary><p><em>Sets <see cref="HelmTestSettings.Release"/>.</em></p><p>The name of the release to test.</p></summary>
        [Pure]
        public static HelmTestSettings SetRelease(this HelmTestSettings toolSettings, string release)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = release;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmTestSettings.Release"/>.</em></p><p>The name of the release to test.</p></summary>
        [Pure]
        public static HelmTestSettings ResetRelease(this HelmTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmUpgradeSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmUpgradeSettingsExtensions
    {
        #region CaFile
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetCaFile(this HelmUpgradeSettings toolSettings, string caFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = caFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.CaFile"/>.</em></p><p>Verify certificates of HTTPS-enabled servers using this CA bundle.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetCaFile(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CaFile = null;
            return toolSettings;
        }
        #endregion
        #region CertFile
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetCertFile(this HelmUpgradeSettings toolSettings, string certFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = certFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.CertFile"/>.</em></p><p>Identify HTTPS client using this SSL certificate file.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetCertFile(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertFile = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Description"/>.</em></p><p>Specify the description to use for the upgrade, rather than the default.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetDescription(this HelmUpgradeSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Description"/>.</em></p><p>Specify the description to use for the upgrade, rather than the default.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetDescription(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Devel
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetDevel(this HelmUpgradeSettings toolSettings, bool? devel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = devel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetDevel(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableDevel(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableDevel(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Devel"/>.</em></p><p>Use development versions, too. Equivalent to version '&gt;0.0.0-0'. If --version is set, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleDevel(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Devel = !toolSettings.Devel;
            return toolSettings;
        }
        #endregion
        #region DryRun
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.DryRun"/>.</em></p><p>Simulate an upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetDryRun(this HelmUpgradeSettings toolSettings, bool? dryRun)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.DryRun"/>.</em></p><p>Simulate an upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetDryRun(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.DryRun"/>.</em></p><p>Simulate an upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableDryRun(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.DryRun"/>.</em></p><p>Simulate an upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableDryRun(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.DryRun"/>.</em></p><p>Simulate an upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleDryRun(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetForce(this HelmUpgradeSettings toolSettings, bool? force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetForce(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableForce(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableForce(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Force"/>.</em></p><p>Force resource update through delete/recreate if needed.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleForce(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Help"/>.</em></p><p>Help for upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetHelp(this HelmUpgradeSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Help"/>.</em></p><p>Help for upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetHelp(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Help"/>.</em></p><p>Help for upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableHelp(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Help"/>.</em></p><p>Help for upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableHelp(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Help"/>.</em></p><p>Help for upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleHelp(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Install
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Install"/>.</em></p><p>If a release by this name doesn't already exist, run an install.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetInstall(this HelmUpgradeSettings toolSettings, bool? install)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Install = install;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Install"/>.</em></p><p>If a release by this name doesn't already exist, run an install.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetInstall(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Install = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Install"/>.</em></p><p>If a release by this name doesn't already exist, run an install.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableInstall(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Install = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Install"/>.</em></p><p>If a release by this name doesn't already exist, run an install.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableInstall(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Install = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Install"/>.</em></p><p>If a release by this name doesn't already exist, run an install.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleInstall(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Install = !toolSettings.Install;
            return toolSettings;
        }
        #endregion
        #region KeyFile
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetKeyFile(this HelmUpgradeSettings toolSettings, string keyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = keyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.KeyFile"/>.</em></p><p>Identify HTTPS client using this SSL key file.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetKeyFile(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Keyring"/>.</em></p><p>Path to the keyring that contains public signing keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetKeyring(this HelmUpgradeSettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Keyring"/>.</em></p><p>Path to the keyring that contains public signing keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetKeyring(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Namespace"/>.</em></p><p>Namespace to install the release into (only used if --install is set). Defaults to the current kube config namespace.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetNamespace(this HelmUpgradeSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Namespace"/>.</em></p><p>Namespace to install the release into (only used if --install is set). Defaults to the current kube config namespace.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetNamespace(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region NoHooks
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.NoHooks"/>.</em></p><p>Disable pre/post upgrade hooks.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetNoHooks(this HelmUpgradeSettings toolSettings, bool? noHooks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = noHooks;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.NoHooks"/>.</em></p><p>Disable pre/post upgrade hooks.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetNoHooks(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.NoHooks"/>.</em></p><p>Disable pre/post upgrade hooks.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableNoHooks(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.NoHooks"/>.</em></p><p>Disable pre/post upgrade hooks.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableNoHooks(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.NoHooks"/>.</em></p><p>Disable pre/post upgrade hooks.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleNoHooks(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHooks = !toolSettings.NoHooks;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetPassword(this HelmUpgradeSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Password"/>.</em></p><p>Chart repository password where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetPassword(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region RecreatePods
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetRecreatePods(this HelmUpgradeSettings toolSettings, bool? recreatePods)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = recreatePods;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetRecreatePods(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableRecreatePods(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableRecreatePods(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.RecreatePods"/>.</em></p><p>Performs pods restart for the resource if applicable.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleRecreatePods(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RecreatePods = !toolSettings.RecreatePods;
            return toolSettings;
        }
        #endregion
        #region Repo
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetRepo(this HelmUpgradeSettings toolSettings, string repo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = repo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Repo"/>.</em></p><p>Chart repository url where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetRepo(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Repo = null;
            return toolSettings;
        }
        #endregion
        #region ResetValues
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.ResetValues"/>.</em></p><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetResetValues(this HelmUpgradeSettings toolSettings, bool? resetValues)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetValues = resetValues;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.ResetValues"/>.</em></p><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetResetValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetValues = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.ResetValues"/>.</em></p><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableResetValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetValues = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.ResetValues"/>.</em></p><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableResetValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetValues = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.ResetValues"/>.</em></p><p>When upgrading, reset the values to the ones built into the chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleResetValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetValues = !toolSettings.ResetValues;
            return toolSettings;
        }
        #endregion
        #region ReuseValues
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.ReuseValues"/>.</em></p><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetReuseValues(this HelmUpgradeSettings toolSettings, bool? reuseValues)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReuseValues = reuseValues;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.ReuseValues"/>.</em></p><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetReuseValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReuseValues = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.ReuseValues"/>.</em></p><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableReuseValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReuseValues = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.ReuseValues"/>.</em></p><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableReuseValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReuseValues = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.ReuseValues"/>.</em></p><p>When upgrading, reuse the last release's values and merge in any overrides from the command line via --set and -f. If '--reset-values' is specified, this is ignored.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleReuseValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReuseValues = !toolSettings.ReuseValues;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Set"/> to a new dictionary.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSet(this HelmUpgradeSettings toolSettings, IDictionary<string, object> set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal = set.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmUpgradeSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings ClearSet(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmUpgradeSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings AddSet(this HelmUpgradeSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Add(setKey, setValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmUpgradeSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings RemoveSet(this HelmUpgradeSettings toolSettings, string setKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal.Remove(setKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmUpgradeSettings.Set"/>.</em></p><p>Set values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSet(this HelmUpgradeSettings toolSettings, string setKey, object setValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetInternal[setKey] = setValue;
            return toolSettings;
        }
        #endregion
        #region SetFile
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.SetFile"/> to a new dictionary.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSetFile(this HelmUpgradeSettings toolSettings, IDictionary<string, object> setFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal = setFile.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmUpgradeSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings ClearSetFile(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmUpgradeSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings AddSetFile(this HelmUpgradeSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Add(setFileKey, setFileValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmUpgradeSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings RemoveSetFile(this HelmUpgradeSettings toolSettings, string setFileKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal.Remove(setFileKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmUpgradeSettings.SetFile"/>.</em></p><p>Set values from respective files specified via the command line (can specify multiple or separate values with commas: key1=path1,key2=path2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSetFile(this HelmUpgradeSettings toolSettings, string setFileKey, object setFileValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetFileInternal[setFileKey] = setFileValue;
            return toolSettings;
        }
        #endregion
        #region SetString
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.SetString"/> to a new dictionary.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSetString(this HelmUpgradeSettings toolSettings, IDictionary<string, object> setString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal = setString.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmUpgradeSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings ClearSetString(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="HelmUpgradeSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings AddSetString(this HelmUpgradeSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Add(setStringKey, setStringValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="HelmUpgradeSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings RemoveSetString(this HelmUpgradeSettings toolSettings, string setStringKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal.Remove(setStringKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="HelmUpgradeSettings.SetString"/>.</em></p><p>Set STRING values on the command line (can specify multiple or separate values with commas: key1=val1,key2=val2).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetSetString(this HelmUpgradeSettings toolSettings, string setStringKey, object setStringValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetStringInternal[setStringKey] = setStringValue;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTimeout(this HelmUpgradeSettings toolSettings, long? timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Timeout"/>.</em></p><p>Time in seconds to wait for any individual Kubernetes operation (like Jobs for hooks) (default 300).</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTimeout(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTls(this HelmUpgradeSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTls(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableTls(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableTls(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleTls(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTlsCaCert(this HelmUpgradeSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTlsCaCert(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTlsCert(this HelmUpgradeSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTlsCert(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTlsHostname(this HelmUpgradeSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTlsHostname(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTlsKey(this HelmUpgradeSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTlsKey(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetTlsVerify(this HelmUpgradeSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetTlsVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableTlsVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableTlsVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleTlsVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetUsername(this HelmUpgradeSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Username"/>.</em></p><p>Chart repository username where to locate the requested chart.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetUsername(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Values
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetValues(this HelmUpgradeSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Values"/> to a new list.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetValues(this HelmUpgradeSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal = values.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmUpgradeSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings AddValues(this HelmUpgradeSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="HelmUpgradeSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings AddValues(this HelmUpgradeSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.AddRange(values);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="HelmUpgradeSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings ClearValues(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ValuesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmUpgradeSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings RemoveValues(this HelmUpgradeSettings toolSettings, params string[] values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="HelmUpgradeSettings.Values"/>.</em></p><p>Specify values in a YAML file or a URL(can specify multiple) (default []).</p></summary>
        [Pure]
        public static HelmUpgradeSettings RemoveValues(this HelmUpgradeSettings toolSettings, IEnumerable<string> values)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(values);
            toolSettings.ValuesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Verify
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Verify"/>.</em></p><p>Verify the provenance of the chart before upgrading.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetVerify(this HelmUpgradeSettings toolSettings, bool? verify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = verify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Verify"/>.</em></p><p>Verify the provenance of the chart before upgrading.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Verify"/>.</em></p><p>Verify the provenance of the chart before upgrading.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Verify"/>.</em></p><p>Verify the provenance of the chart before upgrading.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Verify"/>.</em></p><p>Verify the provenance of the chart before upgrading.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleVerify(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verify = !toolSettings.Verify;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Version"/>.</em></p><p>Specify the exact chart version to use. If this is not specified, the latest version is used.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetVersion(this HelmUpgradeSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Version"/>.</em></p><p>Specify the exact chart version to use. If this is not specified, the latest version is used.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetVersion(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetWait(this HelmUpgradeSettings toolSettings, bool? wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetWait(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmUpgradeSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmUpgradeSettings EnableWait(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmUpgradeSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmUpgradeSettings DisableWait(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmUpgradeSettings.Wait"/>.</em></p><p>If set, will wait until all Pods, PVCs, Services, and minimum number of Pods of a Deployment are in a ready state before marking the release as successful. It will wait for as long as --timeout.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ToggleWait(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = !toolSettings.Wait;
            return toolSettings;
        }
        #endregion
        #region Release
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Release"/>.</em></p><p>The name of the release to upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetRelease(this HelmUpgradeSettings toolSettings, string release)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = release;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Release"/>.</em></p><p>The name of the release to upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetRelease(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Release = null;
            return toolSettings;
        }
        #endregion
        #region Chart
        /// <summary><p><em>Sets <see cref="HelmUpgradeSettings.Chart"/>.</em></p><p>The name of the chart to upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings SetChart(this HelmUpgradeSettings toolSettings, string chart)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = chart;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmUpgradeSettings.Chart"/>.</em></p><p>The name of the chart to upgrade.</p></summary>
        [Pure]
        public static HelmUpgradeSettings ResetChart(this HelmUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Chart = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmVerifySettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmVerifySettingsExtensions
    {
        #region Help
        /// <summary><p><em>Sets <see cref="HelmVerifySettings.Help"/>.</em></p><p>Help for verify.</p></summary>
        [Pure]
        public static HelmVerifySettings SetHelp(this HelmVerifySettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVerifySettings.Help"/>.</em></p><p>Help for verify.</p></summary>
        [Pure]
        public static HelmVerifySettings ResetHelp(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVerifySettings.Help"/>.</em></p><p>Help for verify.</p></summary>
        [Pure]
        public static HelmVerifySettings EnableHelp(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVerifySettings.Help"/>.</em></p><p>Help for verify.</p></summary>
        [Pure]
        public static HelmVerifySettings DisableHelp(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVerifySettings.Help"/>.</em></p><p>Help for verify.</p></summary>
        [Pure]
        public static HelmVerifySettings ToggleHelp(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Keyring
        /// <summary><p><em>Sets <see cref="HelmVerifySettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmVerifySettings SetKeyring(this HelmVerifySettings toolSettings, string keyring)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = keyring;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVerifySettings.Keyring"/>.</em></p><p>Keyring containing public keys (default "~/.gnupg/pubring.gpg").</p></summary>
        [Pure]
        public static HelmVerifySettings ResetKeyring(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyring = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="HelmVerifySettings.Path"/>.</em></p><p>The path to the chart to verify.</p></summary>
        [Pure]
        public static HelmVerifySettings SetPath(this HelmVerifySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVerifySettings.Path"/>.</em></p><p>The path to the chart to verify.</p></summary>
        [Pure]
        public static HelmVerifySettings ResetPath(this HelmVerifySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmVersionSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmVersionSettingsExtensions
    {
        #region Client
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Client"/>.</em></p><p>Client version only.</p></summary>
        [Pure]
        public static HelmVersionSettings SetClient(this HelmVersionSettings toolSettings, bool? client)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Client = client;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Client"/>.</em></p><p>Client version only.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetClient(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Client = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.Client"/>.</em></p><p>Client version only.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableClient(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Client = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.Client"/>.</em></p><p>Client version only.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableClient(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Client = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.Client"/>.</em></p><p>Client version only.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleClient(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Client = !toolSettings.Client;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Help"/>.</em></p><p>Help for version.</p></summary>
        [Pure]
        public static HelmVersionSettings SetHelp(this HelmVersionSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Help"/>.</em></p><p>Help for version.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetHelp(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.Help"/>.</em></p><p>Help for version.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableHelp(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.Help"/>.</em></p><p>Help for version.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableHelp(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.Help"/>.</em></p><p>Help for version.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleHelp(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Server
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Server"/>.</em></p><p>Server version only.</p></summary>
        [Pure]
        public static HelmVersionSettings SetServer(this HelmVersionSettings toolSettings, bool? server)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = server;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Server"/>.</em></p><p>Server version only.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetServer(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.Server"/>.</em></p><p>Server version only.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableServer(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.Server"/>.</em></p><p>Server version only.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableServer(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.Server"/>.</em></p><p>Server version only.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleServer(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = !toolSettings.Server;
            return toolSettings;
        }
        #endregion
        #region Short
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Short"/>.</em></p><p>Print the version number.</p></summary>
        [Pure]
        public static HelmVersionSettings SetShort(this HelmVersionSettings toolSettings, bool? @short)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = @short;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Short"/>.</em></p><p>Print the version number.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetShort(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.Short"/>.</em></p><p>Print the version number.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableShort(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.Short"/>.</em></p><p>Print the version number.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableShort(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.Short"/>.</em></p><p>Print the version number.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleShort(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = !toolSettings.Short;
            return toolSettings;
        }
        #endregion
        #region Template
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Template"/>.</em></p><p>Template for version string format.</p></summary>
        [Pure]
        public static HelmVersionSettings SetTemplate(this HelmVersionSettings toolSettings, string template)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Template = template;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Template"/>.</em></p><p>Template for version string format.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTemplate(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Template = null;
            return toolSettings;
        }
        #endregion
        #region Tls
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmVersionSettings SetTls(this HelmVersionSettings toolSettings, bool? tls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = tls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTls(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableTls(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableTls(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.Tls"/>.</em></p><p>Enable TLS for request.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleTls(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tls = !toolSettings.Tls;
            return toolSettings;
        }
        #endregion
        #region TlsCaCert
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings SetTlsCaCert(this HelmVersionSettings toolSettings, string tlsCaCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = tlsCaCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.TlsCaCert"/>.</em></p><p>Path to TLS CA certificate file (default "$HELM_HOME/ca.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTlsCaCert(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCaCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsCert
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings SetTlsCert(this HelmVersionSettings toolSettings, string tlsCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = tlsCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.TlsCert"/>.</em></p><p>Path to TLS certificate file (default "$HELM_HOME/cert.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTlsCert(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsCert = null;
            return toolSettings;
        }
        #endregion
        #region TlsHostname
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmVersionSettings SetTlsHostname(this HelmVersionSettings toolSettings, string tlsHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = tlsHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.TlsHostname"/>.</em></p><p>The server name used to verify the hostname on the returned certificates from the server.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTlsHostname(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsHostname = null;
            return toolSettings;
        }
        #endregion
        #region TlsKey
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings SetTlsKey(this HelmVersionSettings toolSettings, string tlsKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = tlsKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.TlsKey"/>.</em></p><p>Path to TLS key file (default "$HELM_HOME/key.pem").</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTlsKey(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsKey = null;
            return toolSettings;
        }
        #endregion
        #region TlsVerify
        /// <summary><p><em>Sets <see cref="HelmVersionSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmVersionSettings SetTlsVerify(this HelmVersionSettings toolSettings, bool? tlsVerify)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = tlsVerify;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmVersionSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmVersionSettings ResetTlsVerify(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmVersionSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmVersionSettings EnableTlsVerify(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmVersionSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmVersionSettings DisableTlsVerify(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmVersionSettings.TlsVerify"/>.</em></p><p>Enable TLS for request and verify remote.</p></summary>
        [Pure]
        public static HelmVersionSettings ToggleTlsVerify(this HelmVersionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TlsVerify = !toolSettings.TlsVerify;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmCommonSettingsExtensions
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class HelmCommonSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.Debug"/>.</em></p><p>Enable verbose output.</p></summary>
        [Pure]
        public static HelmCommonSettings SetDebug(this HelmCommonSettings toolSettings, bool? debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.Debug"/>.</em></p><p>Enable verbose output.</p></summary>
        [Pure]
        public static HelmCommonSettings ResetDebug(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmCommonSettings.Debug"/>.</em></p><p>Enable verbose output.</p></summary>
        [Pure]
        public static HelmCommonSettings EnableDebug(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmCommonSettings.Debug"/>.</em></p><p>Enable verbose output.</p></summary>
        [Pure]
        public static HelmCommonSettings DisableDebug(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmCommonSettings.Debug"/>.</em></p><p>Enable verbose output.</p></summary>
        [Pure]
        public static HelmCommonSettings ToggleDebug(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.Help"/>.</em></p><p>Help for helm.</p></summary>
        [Pure]
        public static HelmCommonSettings SetHelp(this HelmCommonSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.Help"/>.</em></p><p>Help for helm.</p></summary>
        [Pure]
        public static HelmCommonSettings ResetHelp(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="HelmCommonSettings.Help"/>.</em></p><p>Help for helm.</p></summary>
        [Pure]
        public static HelmCommonSettings EnableHelp(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="HelmCommonSettings.Help"/>.</em></p><p>Help for helm.</p></summary>
        [Pure]
        public static HelmCommonSettings DisableHelp(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="HelmCommonSettings.Help"/>.</em></p><p>Help for helm.</p></summary>
        [Pure]
        public static HelmCommonSettings ToggleHelp(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Home
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.Home"/>.</em></p><p>Location of your Helm config. Overrides $HELM_HOME (default "~/.helm").</p></summary>
        [Pure]
        public static HelmCommonSettings SetHome(this HelmCommonSettings toolSettings, string home)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Home = home;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.Home"/>.</em></p><p>Location of your Helm config. Overrides $HELM_HOME (default "~/.helm").</p></summary>
        [Pure]
        public static HelmCommonSettings ResetHome(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Home = null;
            return toolSettings;
        }
        #endregion
        #region Host
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.Host"/>.</em></p><p>Address of Tiller. Overrides $HELM_HOST.</p></summary>
        [Pure]
        public static HelmCommonSettings SetHost(this HelmCommonSettings toolSettings, string host)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Host = host;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.Host"/>.</em></p><p>Address of Tiller. Overrides $HELM_HOST.</p></summary>
        [Pure]
        public static HelmCommonSettings ResetHost(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Host = null;
            return toolSettings;
        }
        #endregion
        #region KubeContext
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.KubeContext"/>.</em></p><p>Name of the kubeconfig context to use.</p></summary>
        [Pure]
        public static HelmCommonSettings SetKubeContext(this HelmCommonSettings toolSettings, string kubeContext)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubeContext = kubeContext;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.KubeContext"/>.</em></p><p>Name of the kubeconfig context to use.</p></summary>
        [Pure]
        public static HelmCommonSettings ResetKubeContext(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubeContext = null;
            return toolSettings;
        }
        #endregion
        #region Kubeconfig
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.Kubeconfig"/>.</em></p><p>Absolute path to the kubeconfig file to use.</p></summary>
        [Pure]
        public static HelmCommonSettings SetKubeconfig(this HelmCommonSettings toolSettings, string kubeconfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kubeconfig = kubeconfig;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.Kubeconfig"/>.</em></p><p>Absolute path to the kubeconfig file to use.</p></summary>
        [Pure]
        public static HelmCommonSettings ResetKubeconfig(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kubeconfig = null;
            return toolSettings;
        }
        #endregion
        #region TillerConnectionTimeout
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.TillerConnectionTimeout"/>.</em></p><p>The duration (in seconds) Helm will wait to establish a connection to tiller (default 300).</p></summary>
        [Pure]
        public static HelmCommonSettings SetTillerConnectionTimeout(this HelmCommonSettings toolSettings, long? tillerConnectionTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerConnectionTimeout = tillerConnectionTimeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.TillerConnectionTimeout"/>.</em></p><p>The duration (in seconds) Helm will wait to establish a connection to tiller (default 300).</p></summary>
        [Pure]
        public static HelmCommonSettings ResetTillerConnectionTimeout(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerConnectionTimeout = null;
            return toolSettings;
        }
        #endregion
        #region TillerNamespace
        /// <summary><p><em>Sets <see cref="HelmCommonSettings.TillerNamespace"/>.</em></p><p>Namespace of Tiller (default "kube-system").</p></summary>
        [Pure]
        public static HelmCommonSettings SetTillerNamespace(this HelmCommonSettings toolSettings, string tillerNamespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerNamespace = tillerNamespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="HelmCommonSettings.TillerNamespace"/>.</em></p><p>Namespace of Tiller (default "kube-system").</p></summary>
        [Pure]
        public static HelmCommonSettings ResetTillerNamespace(this HelmCommonSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TillerNamespace = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HelmOutputFormat
    /// <summary><p>Used within <see cref="HelmTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class HelmOutputFormat : Enumeration
    {
        public static HelmOutputFormat json = new HelmOutputFormat { Value = "json" };
        public static HelmOutputFormat yaml = new HelmOutputFormat { Value = "yaml" };
    }
    #endregion
}
