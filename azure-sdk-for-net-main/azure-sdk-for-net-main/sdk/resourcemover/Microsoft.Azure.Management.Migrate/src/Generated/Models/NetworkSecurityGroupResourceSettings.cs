// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the NSG resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Network/networkSecurityGroups")]
    public partial class NetworkSecurityGroupResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkSecurityGroupResourceSettings class.
        /// </summary>
        public NetworkSecurityGroupResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkSecurityGroupResourceSettings class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        /// <param name="tags">Gets or sets the Resource tags.</param>
        /// <param name="securityRules">Gets or sets Security rules of network
        /// security group.</param>
        public NetworkSecurityGroupResourceSettings(string targetResourceName, IDictionary<string, string> tags = default(IDictionary<string, string>), IList<NsgSecurityRule> securityRules = default(IList<NsgSecurityRule>))
            : base(targetResourceName)
        {
            Tags = tags;
            SecurityRules = securityRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets Security rules of network security group.
        /// </summary>
        [JsonProperty(PropertyName = "securityRules")]
        public IList<NsgSecurityRule> SecurityRules { get; set; }

    }
}