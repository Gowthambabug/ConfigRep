// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the DDoS protection settings of the public IP.
    /// </summary>
    public partial class DdosSettings
    {
        /// <summary>
        /// Initializes a new instance of the DdosSettings class.
        /// </summary>
        public DdosSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DdosSettings class.
        /// </summary>
        /// <param name="ddosCustomPolicy">The DDoS custom policy associated
        /// with the public IP.</param>
        /// <param name="protectionCoverage">The DDoS protection policy
        /// customizability of the public IP. Only standard coverage will have
        /// the ability to be customized. Possible values include: 'Basic',
        /// 'Standard'</param>
        /// <param name="protectedIP">Enables DDoS protection on the public
        /// IP.</param>
        public DdosSettings(SubResource ddosCustomPolicy = default(SubResource), string protectionCoverage = default(string), bool? protectedIP = default(bool?))
        {
            DdosCustomPolicy = ddosCustomPolicy;
            ProtectionCoverage = protectionCoverage;
            ProtectedIP = protectedIP;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the DDoS custom policy associated with the public IP.
        /// </summary>
        [JsonProperty(PropertyName = "ddosCustomPolicy")]
        public SubResource DdosCustomPolicy { get; set; }

        /// <summary>
        /// Gets or sets the DDoS protection policy customizability of the
        /// public IP. Only standard coverage will have the ability to be
        /// customized. Possible values include: 'Basic', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "protectionCoverage")]
        public string ProtectionCoverage { get; set; }

        /// <summary>
        /// Gets or sets enables DDoS protection on the public IP.
        /// </summary>
        [JsonProperty(PropertyName = "protectedIP")]
        public bool? ProtectedIP { get; set; }

    }
}