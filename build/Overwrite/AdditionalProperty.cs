// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.CodeGeneration.Model;

namespace Nuke.Helm.Generator.Overwrite
{
    internal class AdditionalProperty : Property
    {
        public Position Position { get; set; }
    }
}
