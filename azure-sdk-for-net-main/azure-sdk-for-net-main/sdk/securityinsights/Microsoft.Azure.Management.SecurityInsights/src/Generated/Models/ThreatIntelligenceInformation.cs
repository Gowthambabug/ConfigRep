// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Threat intelligence information object.
    /// </summary>
    public partial class ThreatIntelligenceInformation : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceInformation
        /// class.
        /// </summary>
        public ThreatIntelligenceInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceInformation
        /// class.
        /// </summary>
        /// <param name="etag">Etag of the azure resource</param>
        public ThreatIntelligenceInformation(string etag = default(string))
        {
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets etag of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
