// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

namespace Nuke.Helm.Generator.Parsing
{
    [DebuggerDisplay("{" + nameof(Flag) + "}")]
    internal class Option
    {
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Flag { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        public string Shorthand { get; set; }

        [JsonIgnore]
        public Definition Definition { get; set; }
    }
}
