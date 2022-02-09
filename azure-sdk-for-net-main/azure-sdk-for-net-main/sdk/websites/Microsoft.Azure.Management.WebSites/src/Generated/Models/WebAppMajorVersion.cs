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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web App stack major version.
    /// </summary>
    public partial class WebAppMajorVersion
    {
        /// <summary>
        /// Initializes a new instance of the WebAppMajorVersion class.
        /// </summary>
        public WebAppMajorVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebAppMajorVersion class.
        /// </summary>
        /// <param name="displayText">Web App stack major version (display
        /// only).</param>
        /// <param name="value">Web App stack major version name.</param>
        /// <param name="minorVersions">Minor versions associated with the
        /// major version.</param>
        public WebAppMajorVersion(string displayText = default(string), string value = default(string), IList<WebAppMinorVersion> minorVersions = default(IList<WebAppMinorVersion>))
        {
            DisplayText = displayText;
            Value = value;
            MinorVersions = minorVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets web App stack major version (display only).
        /// </summary>
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; private set; }

        /// <summary>
        /// Gets web App stack major version name.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Gets minor versions associated with the major version.
        /// </summary>
        [JsonProperty(PropertyName = "minorVersions")]
        public IList<WebAppMinorVersion> MinorVersions { get; private set; }

    }
}