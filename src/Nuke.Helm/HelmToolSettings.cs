using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Nuke.Common.Tooling;

namespace Nuke.Helm
{
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class HelmToolSettings : ToolSettings
    {
        /// <summary>
        /// Common settings for Helm, like kubecontext, Tiller namespace ...
        /// </summary>
        public HelmCommonSettings CommonSettings { get; internal set; }
        protected override Arguments ConfigureArguments([NotNull] Arguments arguments)
        {
            if (CommonSettings != null)
                arguments.Concatenate(CommonSettings.CreateArguments());
            return base.ConfigureArguments(arguments);
        }
    }
}
