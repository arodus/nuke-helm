// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Helm.Generator
{
    internal class Programm
    {
        public static void Main(string[] args)
        {
            SpecificationGenerator.GenerateSpecifications(new SpecificationGeneratorSettings
                                                          {
                                                              DefinitionFolder = args[0],
                                                              OutputFolder = args[1],
                                                              OverwriteFile = args[2],
                                                              Reference = args[3]
                                                          });
        }
    }
}
