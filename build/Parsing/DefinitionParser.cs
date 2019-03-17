// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.CodeGeneration.Model;
using Nuke.Helm.Generator.Utilities;

namespace Nuke.Helm.Generator.Parsing
{
    internal class DefinitionParser
    {
        private readonly IReadOnlyCollection<Definition> _definitions;
        private readonly string _reference;
        private readonly TypeResolver _typeResolver;
        private readonly Tool _tool;

        private DefinitionParser(IReadOnlyCollection<Definition> definitions, string reference)
        {
            _definitions = definitions;
            _reference = reference;
            _tool = CreateTool();
            _typeResolver = new TypeResolver();
        }

        public static Tool Parse(IReadOnlyCollection<Definition> definitions, string reference)
        {
            var parser = new DefinitionParser(definitions, reference);
            parser.PopulateEnumerations();
            parser.PopulateCommonSettings();
            parser.PopulateTasks();
            return parser._tool;
        }

        private Task ParseTask(Definition definition)
        {
            var dataClass = CreateSettingsClass();
            dataClass.Properties = definition.InheritedOptions.Length != 0
                ? definition.Options.Select(x => CreateProperty(x, dataClass)).ToList()
                : new List<Property>();
            var usageParameters = UsageParser.Parse(definition.Synopsis);
            dataClass.Properties.AddRange(usageParameters
                .Where(x => x.IsArgument && x.Name != "Flags")
                .Select(x =>
                {
                    var type = "string";
                    if (x.IsList)
                        type = "List<string>";
                    else if (x.IsDictionary)
                        type = "Dictionary<string, object>";

                    return new Property
                           {
                               Name = x.Name,
                               DataClass = dataClass,
                               Type = type,
                               Format = "{value}",
                               Separator = x.IsDictionary || x.IsList ? ' ' : default(char?),
                               ItemFormat = x.IsDictionary ? "{key}={value}" : default(string)
                           };
                }));

            var task = CreateTask(definition, dataClass);

            return task;
        }

        private Property ParseProperty(Option option)
        {
            var propertyName = option.Flag.Trim(trimChar: '-').ToPascalCase(separator: '-');
            var property = new Property
                           {
                               Name = propertyName,
                               Help = (char.ToUpper(option.Usage[index: 0]) + option.Usage.Substring(startIndex: 1)).FormatForXmlDoc(),
                               Format = $"{option.Flag} {{value}}",
                               Secret = propertyName == "Password"
                           };
            _typeResolver.PopulateTypeInformation(option, ref property);
            return property;
        }

        private void PopulateEnumerations()
        {
            _typeResolver.EnumerationOptionTypes = new Dictionary<Option, string>();
        }

        private void PopulateTasks()
        {
            _tool.Tasks = _definitions
                .Where(x => x.InheritedOptions.Any() && !string.IsNullOrEmpty(x.Synopsis))
                .Select(ParseTask)
                .ToList();
        }

        private void PopulateCommonSettings()
        {
            var dataClass = new DataClass
                            {
                                Name = "HelmCommonSettings",
                                Tool = _tool,
                                ExtensionMethods = true
                            };
            dataClass.Properties = _definitions
                .Single(x => !x.InheritedOptions.Any())
                .Options.Select(x => CreateProperty(x, dataClass))
                .ToList();
            _tool.DataClasses.Add(dataClass);
        }

        private Tool CreateTool()
        {
            return new Tool
                   {
                       Name = "Helm",
                       PathExecutable = "helm",
                       OfficialUrl = "https://helm.sh/",
                       References = _definitions
                           .Select(x => x.Name.Replace(oldChar: ' ', newChar: '_'))
                           .Select(x => $"https://raw.githubusercontent.com/helm/helm/{_reference}/docs/helm/{x}.md")
                           .OrderBy(x => x)
                           .ToList()
                   };
        }

        private SettingsClass CreateSettingsClass()
        {
            return new SettingsClass
                   {
                       Tool = _tool,
                       BaseClass = "HelmToolSettings"
                   };
        }

        private Task CreateTask(Definition definition, SettingsClass settingsClass)
        {
            var isRootTask = definition.Name == "helm";
            var help = (char.ToUpper(definition.Description[index: 0]) + definition.Description.Substring(startIndex: 1))
                .FormatForXmlDoc();
            var task = new Task
                       {
                           Postfix = isRootTask ? null : definition.InstanceName,
                           Help = help,
                           DefiniteArgument = definition.Name.Replace("helm", string.Empty).Trim(),
                           Tool = _tool,
                           SettingsClass = settingsClass
                       };
            settingsClass.Task = task;
            return task;
        }

        private Property CreateProperty(Option option, [CanBeNull] DataClass dataClass)
        {
            var property = ParseProperty(option);
            property.DataClass = dataClass;
            return property;
        }
    }
}
