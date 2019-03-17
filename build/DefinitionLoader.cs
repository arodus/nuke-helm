// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Helm.Generator.Parsing;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Nuke.Helm.Generator
{
    internal static class DefinitionLoader
    {
        public static IReadOnlyCollection<Definition> LoadDefinitions(string definitionPath)
        {
            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();
            var definitions = Directory.GetFiles(definitionPath)
                .ForEachLazy(x => Console.WriteLine($"Reading {x}..."))
                .Select(File.ReadAllLines)
                .Select(DefinitionMarkdownParser.Parse)
                .ToArray();

            //definitions.ForEach(x => x.Options.Concat(x.InheritedOptions).ForEach(y => y.Definition = x));
            return definitions;
        }

        [CanBeNull]
        public static Overwrite.Overwrite LoadOverwrites(string overwriteFile)
        {
            if (!File.Exists(overwriteFile))
                return null;
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .IgnoreUnmatchedProperties()
                .Build();
            return deserializer.Deserialize<Overwrite.Overwrite>(TextTasks.ReadAllText(overwriteFile));
        }
    }

    internal static class DefinitionMarkdownParser
    {
        public static Definition Parse(IReadOnlyList<string> definitionLines)
        {
            string regionName = null;
            var regionFirstLine = 0;
            var regions = new Dictionary<string, IReadOnlyList<string>>();
            for (var i = 0; i < definitionLines.Count; i++)
            {
                var line = definitionLines[i];
                if (line.StartsWith("##"))
                {
                    if (regionName != null)
                        regions.Add(regionName, definitionLines.Skip(regionFirstLine).Take(i - regionFirstLine).ToArray());

                    regionName = line.Trim(' ', '#');
                    regionFirstLine = i + 1;
                }
            }

            return ParseRegions(regions);
        }

        private static Definition ParseRegions(IReadOnlyDictionary<string, IReadOnlyList<string>> regions)
        {
            var definition = new Definition();
            var firstRegion = regions.First();
            definition.Name = firstRegion.Key;
            definition.Description = firstRegion.Value.Single(x => !string.IsNullOrWhiteSpace(x));

            var synopsisRegion = regions["Synopsis"];
            definition.Description = synopsisRegion.TakeWhile(x => !x.StartsWith("```")).Where(x => !string.IsNullOrWhiteSpace(x))
                .JoinNewLine(PlatformFamily.Linux);
            definition.Synopsis = synopsisRegion
                .SkipWhile(x => !x.StartsWith("```"))
                .Skip(count: 1)
                .TakeWhile(x => !x.StartsWith("```"))
                .JoinNewLine(PlatformFamily.Linux);
            definition.Options = ParseOptions(regions.GetValueOrDefault("Options", new string[0]));
            definition.InheritedOptions = ParseOptions(regions.GetValueOrDefault("Options inherited from parent commands", new string[0]));
            definition.SeeAlso = regions["SEE ALSO"].ToArray();

            definition.Options.Concat(definition.InheritedOptions).ForEach(x => x.Definition = definition);
            return definition;
        }

        private static Option[] ParseOptions(IEnumerable<string> lines)
        {
            var regex = new Regex(
                @"^\s+(?>(?'shorthand'-[A-Za-z]+),)?\s+(?'flag'--[a-z\-]+)\s(?'type'[a-zA-Z0-9]+|tristate\[=true\])?\s+(?'description'.*?(?>\(default \""?(?'default'.*?)\""?\))?)$");

            var options = new List<Option>();
            lines.Where(x => !string.IsNullOrWhiteSpace(x) && !x.StartsWith("```"))
                .ToArray()
                .ForEach((line, index) =>
                {
                    var match = regex.Match(line);
                    if (!match.Success)
                    {
                        Console.WriteLine($"Could not parse option in line {index}: {line}");
                        return;
                    }

                    var option = new Option();
                    option.Shorthand = match.Groups["shorthand"].Value;
                    option.DefaultValue = match.Groups["default"].Value;
                    option.Type = match.Groups["type"].Value;
                    option.Flag = match.Groups["flag"].Value;
                    option.Usage = match.Groups["description"].Value;
                    options.Add(option);
                });

            return options.ToArray();
        }
    }
}
