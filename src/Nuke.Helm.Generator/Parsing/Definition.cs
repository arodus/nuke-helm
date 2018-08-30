// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Helm.Generator.Utilities;

namespace Nuke.Helm.Generator.Parsing
{
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    internal class Definition
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; } = new Option[0];

        [JsonProperty("inherited_options")]
        public Option[] InheritedOptions { get; set; } = new Option[0];

        [JsonProperty("see_also")]
        public string[] SeeAlso { get; set; } = new string[0];

        public string InstanceName => Name == "helm" ? "Helm" : Name.Substring(startIndex: 5).ToPascalCase(separator: ' ').NotNull();
    }
}
