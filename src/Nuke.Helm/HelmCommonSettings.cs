using System;
using System.Linq;
using Nuke.Common.Tooling;

namespace Nuke.Helm
{
    public partial class HelmCommonSettings
    {
        internal Arguments CreateArguments()
        {
            return ConfigureArguments(new Arguments());
        }
    }
}
