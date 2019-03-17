// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Helm.Generator.Utilities
{
    internal static class StringUtils
    {
        [CanBeNull]
        public static string RemoveNewLines([CanBeNull] this string value)
        {
            return value?.Replace("\r", string.Empty).Replace("\n", string.Empty);
        }

        [CanBeNull]
        public static string ToCamelCase([CanBeNull] this string value, char separator)
        {
            if (value == null)
                return null;

            var index = value.IndexOf(separator);
            while (index > 0)
            {
                value = value.Substring(startIndex: 0, length: index) + char.ToUpper(value[index + 1]) + value.Substring(index + 2);
                index = value.IndexOf(separator);
            }

            return value;
        }

        [CanBeNull]
        public static string ToCamelCase([CanBeNull] this string value, params char[] separators)
        {
            return separators.Aggregate(value, (current, separator) => current.ToCamelCase(separator));
        }

        [CanBeNull]
        public static string ToPascalCase([CanBeNull] this string value, char separator)
        {
            var camelCase = value.ToCamelCase(separator);
            if (string.IsNullOrEmpty(camelCase))
                return camelCase;
            return char.ToUpper(camelCase[index: 0]) + camelCase.Substring(startIndex: 1);
        }

        [CanBeNull]
        public static string ToPascalCase([CanBeNull] this string value, params char[] separators)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            if (separators.Length == 0)
                return char.ToUpper(value[index: 0]) + (value.Length > 1 ? value.Substring(startIndex: 1) : string.Empty);
            return separators.Aggregate(value, (current, separator) => current.ToPascalCase(separator));
        }

        [Pure]
        [CanBeNull]
        public static string AddTailingPeriodIfNeeded([CanBeNull] this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value[value.Length - 1] == '.' ? value : value + '.';
        }

        [Pure]
        [CanBeNull]
        public static string EscapeForXmlDoc([CanBeNull] this string value)
        {
            return string.IsNullOrEmpty(value) ? value : value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
        }

        [Pure]
        [CanBeNull]
        public static string FormatForXmlDoc([CanBeNull] this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value
                .Replace(oldChar: '‘', newChar: '\'')
                .Replace(oldChar: '’', newChar: '\'')
                .Replace("\r\n", " ").Replace("\n", " ")
                .EscapeForXmlDoc()
                .AddTailingPeriodIfNeeded();
        }
    }
}
