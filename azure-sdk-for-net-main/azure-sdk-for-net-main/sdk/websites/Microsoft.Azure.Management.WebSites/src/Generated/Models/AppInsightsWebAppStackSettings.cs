// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// App Insights Web App stack settings.
    /// </summary>
    public partial class AppInsightsWebAppStackSettings
    {
        /// <summary>
        /// Initializes a new instance of the AppInsightsWebAppStackSettings
        /// class.
        /// </summary>
        public AppInsightsWebAppStackSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppInsightsWebAppStackSettings
        /// class.
        /// </summary>
        /// <param name="isSupported">&lt;code&gt;true&lt;/code&gt; if remote
        /// Application Insights is supported for the stack; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="isDefaultOff">&lt;code&gt;true&lt;/code&gt; if
        /// Application Insights is disabled by default for the stack;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        public AppInsightsWebAppStackSettings(bool? isSupported = default(bool?), bool? isDefaultOff = default(bool?))
        {
            IsSupported = isSupported;
            IsDefaultOff = isDefaultOff;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if remote
        /// Application Insights is supported for the stack; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "isSupported")]
        public bool? IsSupported { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if Application
        /// Insights is disabled by default for the stack; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "isDefaultOff")]
        public bool? IsDefaultOff { get; private set; }

    }
}
