// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.CodeGeneration.Model;
using Nuke.Common.Utilities.Collections;
using Nuke.Helm.Generator.Utilities;

namespace Nuke.Helm.Generator.Overwrite
{
    internal class SpecificationModifier
    {
        private readonly Overwrite _overwrite;
        private readonly Tool _tool;

        private SpecificationModifier(Tool tool, Overwrite overwrite)
        {
            _overwrite = overwrite;
            _tool = tool;
        }

        public static void Overwrite(Tool tool, [CanBeNull] Overwrite overwrite)
        {
            if (overwrite == null)
                return;
            var overwriter = new SpecificationModifier(tool, overwrite);

            overwriter.OverwriteTasks();
            overwriter.OverwriteProperties();
            overwriter.AddAdditionalProperties();
            overwriter.AddAdditionalEnumerations();
        }

        private void OverwriteTasks()
        {
            _tool.Tasks
                .Select(x => new { Task = x, Overwrite = GetTaskOverwrite(x) })
                .Where(x => x.Overwrite != null)
                .ForEachLazy(x => Console.WriteLine($"Overwriting task: {x.Task.Postfix ?? x.Task.Tool.Name}..."))
                .ForEach(x => Overwrite(x.Task, x.Overwrite));
        }

        private void OverwriteProperties()
        {
            _tool.Tasks
                .SelectMany(x => x.SettingsClass.Properties)
                .Select(x => new { Property = x, Overwrite = GetPropertyOverwrite(x) })
                .Where(x => x.Overwrite != null)
                .ForEachLazy(x => Console.WriteLine($"Overwriting property: {x.Property.DataClass.Name}.{x.Property.Name}..."))
                .ForEach(x => Overwrite(x.Property, x.Overwrite));
        }

        private void AddAdditionalEnumerations()
        {
            _overwrite.Enumerations
                .ForEachLazy(x => Console.WriteLine($"Appending additional enumeration: {x.Name}..."))
                .ForEach(_tool.Enumerations.Add);
        }

        private void AddAdditionalProperties()
        {
            _overwrite.AdditionalProperties
                .ForEachLazy(x => Console.WriteLine($"Appending additional properties to task: {x.Key}..."))
                .ForEach(x =>
                {
                    var settingsClass = _tool.Tasks.Single(y => y.Postfix == x.Key.ToPascalCase(separator: '-')).SettingsClass;
                    var propertyGroups = x.Value.GroupBy(y => y.Position, y => y)
                        .ToDictionary(y => y.Key, y => y.ToArray());

                    var newProperties = GetPropertiesAtPosition(Position.Start, propertyGroups)
                        .Concat(settingsClass.Properties)
                        .Concat(GetPropertiesAtPosition(Position.End, propertyGroups))
                        .ToList();

                    settingsClass.Properties = newProperties;
                });

            IEnumerable<Property> GetPropertiesAtPosition(Position position, Dictionary<Position, AdditionalProperty[]> properties)
            {
                if (properties.TryGetValue(position, out var additionalProperties))
                    return additionalProperties.Cast<Property>().AsEnumerable();

                return new Property[0];
            }
        }

        private static void Overwrite(Property property, PropertyOverwrite overwrite)
        {
            property.Type = overwrite.Type ?? property.Type;
            property.Name = overwrite.Name ?? property.Name;
            property.Secret = overwrite.Secret ?? property.Secret;
            property.ItemFormat = overwrite.ItemFormat ?? property.ItemFormat;
            property.Separator = overwrite.Separator ?? property.Separator;
            property.Format = overwrite.Format ?? property.Format;
            property.Help = overwrite.Help ?? property.Help;
            property.CustomImpl = overwrite.CustomImpl ?? property.CustomImpl;
            property.NoArgument = overwrite.NoArgument ?? property.NoArgument;
        }

        private static void Overwrite(Task task, TaskOverwrite overwrite)
        {
            task.SettingsClass.BaseClass = overwrite.BaseClass ?? task.SettingsClass.BaseClass;
        }

        [CanBeNull]
        private PropertyOverwrite GetPropertyOverwrite(Property property)
        {
            return CollectionExtensions.GetValueOrDefault(_overwrite.PropertyOverwrites,
                $"{property.DataClass.Name}.{property.Name}",
                defaultValue: null);
        }

        [CanBeNull]
        private TaskOverwrite GetTaskOverwrite(Task task)
        {
            var overwriteName = task.Postfix == null ? string.Empty : char.ToLower(task.Postfix[index: 0]) + task.Postfix.Substring(startIndex: 1);
            return CollectionExtensions.GetValueOrDefault(_overwrite.TaskOverwrites, overwriteName, defaultValue: null);
        }
    }
}
