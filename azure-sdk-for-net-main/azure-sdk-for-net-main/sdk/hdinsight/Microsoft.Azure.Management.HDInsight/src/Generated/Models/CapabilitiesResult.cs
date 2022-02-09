// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Get Capabilities operation response.
    /// </summary>
    public partial class CapabilitiesResult
    {
        /// <summary>
        /// Initializes a new instance of the CapabilitiesResult class.
        /// </summary>
        public CapabilitiesResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapabilitiesResult class.
        /// </summary>
        /// <param name="versions">The version capability.</param>
        /// <param name="regions">The virtual machine size compatibility
        /// features.</param>
        /// <param name="features">The capability features.</param>
        /// <param name="quota">The quota capability.</param>
        public CapabilitiesResult(IDictionary<string, VersionsCapability> versions = default(IDictionary<string, VersionsCapability>), IDictionary<string, RegionsCapability> regions = default(IDictionary<string, RegionsCapability>), IList<string> features = default(IList<string>), QuotaCapability quota = default(QuotaCapability))
        {
            Versions = versions;
            Regions = regions;
            Features = features;
            Quota = quota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version capability.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IDictionary<string, VersionsCapability> Versions { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine size compatibility features.
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IDictionary<string, RegionsCapability> Regions { get; set; }

        /// <summary>
        /// Gets or sets the capability features.
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<string> Features { get; set; }

        /// <summary>
        /// Gets or sets the quota capability.
        /// </summary>
        [JsonProperty(PropertyName = "quota")]
        public QuotaCapability Quota { get; set; }

    }
}
