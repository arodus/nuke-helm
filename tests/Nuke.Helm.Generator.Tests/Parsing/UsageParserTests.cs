// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using Nuke.Helm.Generator.Parsing;
using Xunit;

namespace Nuke.Helm.Generator.Tests.Parsing
{
    public class UsageParserTests
    {
        // usage, number of non argument parameters, number of arguments
        public static readonly IEnumerable<object[]> UsageStrings = new[]
                                                                    {
                                                                        new object[] { "helm create NAME", 2, 1 },
                                                                        new object[] { "helm delete [flags] RELEASE_NAME [...]", 2, 2 },
                                                                        new object[] { "helm dependency build [flags] CHART", 3, 2 },
                                                                        new object[] { "helm dependency list [flags] CHART", 3, 2 },
                                                                        new object[] { "helm dependency update [flags] CHART", 3, 2 },
                                                                        new object[] { "helm get [flags] RELEASE_NAME", 2, 2 },
                                                                        new object[] { "helm get hooks [flags] RELEASE_NAME", 3, 2 },
                                                                        new object[] { "helm get manifest [flags] RELEASE_NAME", 3, 2 },
                                                                        new object[] { "helm get values [flags] RELEASE_NAME", 3, 2 },
                                                                        new object[] { "helm history [flags] RELEASE_NAME", 2, 2 },
                                                                        new object[] { "helm home", 2, 0 },
                                                                        new object[] { "helm init", 2, 0 },
                                                                        new object[] { "helm inspect [CHART]", 2, 1 },
                                                                        new object[] { "helm inspect chart [CHART]", 3, 1 },
                                                                        new object[] { "helm inspect readme [CHART]", 3, 1 },
                                                                        new object[] { "helm inspect values [CHART]", 3, 1 },
                                                                        new object[] { "helm install [CHART]", 2, 1 },
                                                                        new object[] { "helm lint [flags] PATH", 2, 2 },
                                                                        new object[] { "helm list [flags] [FILTER]", 2, 2 },
                                                                        new object[] { "helm package [flags] [CHART_PATH] [...]", 2, 2 },
                                                                        new object[] { "helm plugin install [options] <path|url>...", 3, 2 },
                                                                        new object[] { "helm plugin list", 3, 0 },
                                                                        new object[] { "helm plugin remove <plugin>...", 3, 1 },
                                                                        new object[] { "helm plugin update <plugin>...", 3, 1 },
                                                                        new object[] { "helm repo add [flags] [NAME] [URL]", 3, 3 },
                                                                        new object[] { "helm repo index [flags] [DIR]", 3, 2 },
                                                                        new object[] { "helm repo list [flags]", 3, 1 },
                                                                        new object[] { "helm repo remove [flags] [NAME]", 3, 2 },
                                                                        new object[] { "helm repo update", 3, 0 },
                                                                        new object[] { "helm reset", 2, 0 },
                                                                        new object[] { "helm rollback [flags] [RELEASE] [REVISION]", 2, 3 },
                                                                        new object[] { "helm search [keyword]", 2, 1 },
                                                                        new object[] { "helm serve", 2, 0 },
                                                                        new object[] { "helm status [flags] RELEASE_NAME", 2, 2 },
                                                                        new object[] { "helm template [flags] CHART", 2, 2 },
                                                                        new object[] { "helm test [RELEASE]", 2, 1 },
                                                                        new object[] { "helm upgrade [RELEASE] [CHART]", 2, 2 },
                                                                        new object[] { "helm verify [flags] PATH", 2, 2 },
                                                                        new object[] { "helm version", 2, 0 }
                                                                    };

        [Theory]
        [MemberData(nameof(UsageStrings))]
        public void Should_Parse(string usage, int fixedArguments, int arguments)
        {
            // if(!usage.Contains(">")) return;
            var parameters = UsageParser.Parse(usage);

            using (new AssertionScope())
            {
                parameters
                    .Should()
                    .HaveCount(fixedArguments + arguments);

                parameters.Where(x => !x.IsArgument).Should().HaveCount(fixedArguments);
                parameters.Where(x => x.IsArgument).Should().HaveCount(arguments);
            }
        }

        [Fact]
        public void Should_DetectNonArguments()
        {
            var usageParameters = UsageParser.Parse("flags path");
            usageParameters.Should()
                .HaveCount(expected: 2);

            foreach (var usageParameter in usageParameters)
                usageParameter.IsArgument.Should().BeFalse();
        }

        [Theory]
        [InlineData("PATH")]
        [InlineData("[optional]")]
        public void Should_DetectArguments(string usageString)
        {
            var usageParameters = UsageParser.Parse(usageString);
            AssertSingleUsageParameter(usageParameters, shouldBeArgument: true);
        }

        [Theory]
        [InlineData("PATH [...]")]
        [InlineData("<required>...")]
        public void Should_DetectList(string usageString)
        {
            var usageParameters = UsageParser.Parse(usageString);
            AssertSingleUsageParameter(usageParameters, shouldBeArgument: true, shouldBeList: true);
        }

        private void AssertSingleUsageParameter(IEnumerable<UsageParameter> parameters, bool shouldBeArgument, bool shouldBeList = false)
        {
            using (new AssertionScope())
            {
                parameters
                    .Should()
                    .HaveCount(expected: 1);

                var firstParameter = parameters.Single();
                firstParameter.IsArgument.Should().Be(shouldBeArgument);
                firstParameter.IsList.Should().Be(shouldBeList);
            }
        }
    }
}
