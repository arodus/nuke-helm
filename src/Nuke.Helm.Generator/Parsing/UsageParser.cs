// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Nuke.Common;
using Nuke.Helm.Generator.Utilities;

namespace Nuke.Helm.Generator.Parsing
{
    internal class UsageParameter
    {
        public string RawValue { get; internal set; }

        public bool IsArgument => IsList || IsDictionary || RawValue.EndsWith("]") || RawValue.Contains(value: '|')
                                  || RawValue.All(x => char.IsUpper(x) || x == '_' || x == '-' || RawValue.StartsWith("<"));

        public bool IsList { get; internal set; }
        public bool IsDictionary { get; internal set; }

        public string Name
        {
            get
            {
                if (IsDictionary)
                    return TrimmedValue.ToLowerInvariant().ToPascalCase(separator: '=').NotNull();

                var value = TrimmedValue.Split(new[] { ':', '|', '[' }, StringSplitOptions.RemoveEmptyEntries).First().ToLowerInvariant()
                    .ToPascalCase('-', '_');
                if (IsList)
                    value += 's';
                return value.NotNull();
            }
        }

        private string TrimmedValue => RawValue.Trim('[', ']', '.', ':', '@', '/', '(', ')', '<', '>');
    }

    internal static class UsageParser
    {
        public static List<UsageParameter> Parse(string usage)
        {
            return Parse(usage.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static List<UsageParameter> Parse(string[] parameters)
        {
            var usageParameters = new List<UsageParameter>();

            for (var i = 0; i < parameters.Length; i++)
            {
                var value = parameters[i];
                while (parameters.Length > i + 1 && parameters[i + 1] == "|")
                {
                    value += parameters[i + 1] + parameters[i + 2];
                    i += 2;
                }

                var usage = new UsageParameter();

                var match = Regex.Match(value, @"^\[?([A-Z]+)=([A-Z]+)(?:\.\.\.\])?$");
                if (match.Success)
                {
                    usage.IsDictionary = true;
                    if (!value.StartsWith("[") && parameters.Length > i + 1
                                               && parameters[i + 1]
                                               == $"[{match.Groups[groupnum: 1].Value}={match.Groups[groupnum: 2].Value}...]")
                        i++;
                }

                else if (value.StartsWith("[") && value.EndsWith("...]") || value.StartsWith("{") || value.EndsWith(">..."))
                    usage.IsList = true;
                else if (parameters.Length > i + 1)
                {
                    if (parameters[i + 1] == $"[{value}...]"
                        || value.Contains(value: '|') && parameters[i + 1] == $"[{value.Split(separator: '|').Last()}...]")
                    {
                        usage.IsList = true;
                        i++;
                    }
                    else if (parameters[i + 1] == "[...]")
                    {
                        usage.IsList = true;
                        i++;
                    }
                }

                usage.RawValue = value;
                usageParameters.Add(usage);
            }

            return usageParameters;
        }
    }
}
