// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Helm.Generator.Parsing
{
    internal struct TypeReference
    {
        public string Type { get; set; }
        public char? Separator { get; set; }
        public string ItemFormat { get; set; }
    }
}
