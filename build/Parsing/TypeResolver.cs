// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.CodeGeneration.Model;

namespace Nuke.Helm.Generator.Parsing
{
    internal class TypeResolver
    {
        public Dictionary<Option, string> EnumerationOptionTypes { get; set; }

        public void PopulateTypeInformation(Option option, ref Property property)
        {
            var typeReference = GetType(option);
            property.Type = typeReference.Type;
            property.ItemFormat = typeReference.ItemFormat;
            property.Separator = typeReference.Separator;
            property.Format = typeReference.Type == "bool" ? option.Flag : property.Format;
        }

        //Todo: load mapping from file
        public TypeReference GetType(Option option)
        {
            if (EnumerationOptionTypes == null)
                throw new InvalidOperationException($"{nameof(EnumerationOptionTypes)} has to be set before types can be resolved.");

            if (EnumerationOptionTypes.TryGetValue(option, out var enumerationName))
                return new TypeReference { Type = enumerationName };

            var reference = new TypeReference();
            switch (option.Type)
            {
                case "":
                    reference.Type = "bool";
                    break;
                case "uint":
                    reference.Type = "uint?";
                    break;
                case "int":
                    reference.Type = "long?";
                    break;
                case "int32":
                    reference.Type = "int";
                    break;
                case "string":
                    reference.Type = "string";
                    break;
                case "stringArray":
                    reference.Type = "Dictionary<string, object>";
                    reference.ItemFormat = "{key}={value}";
                    reference.Separator = ',';
                    break;
                case "valueFiles":
                    reference.Type = "List<string>";
                    reference.Separator = null;
                    break;
                case "OutputFormat":
                    reference.Type = "HelmOutputFormat";
                    break;
                default:
                    throw new NotImplementedException($"Type {option.Type} in {option.Definition.Name} {option.Flag} is not implemented yet.");
            }

            return reference;
        }
    }
}
