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
    /// Individual port mappings for inbound NAT rule created for backend pool.
    /// </summary>
    public partial class InboundNatRulePortMapping
    {
        /// <summary>
        /// Initializes a new instance of the InboundNatRulePortMapping class.
        /// </summary>
        public InboundNatRulePortMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundNatRulePortMapping class.
        /// </summary>
        /// <param name="inboundNatRuleName">Name of inbound NAT rule.</param>
        /// <param name="protocol">The reference to the transport protocol used
        /// by the inbound NAT rule. Possible values include: 'Udp', 'Tcp',
        /// 'All'</param>
        /// <param name="frontendPort">Frontend port.</param>
        /// <param name="backendPort">Backend port.</param>
        public InboundNatRulePortMapping(string inboundNatRuleName = default(string), string protocol = default(string), int? frontendPort = default(int?), int? backendPort = default(int?))
        {
            InboundNatRuleName = inboundNatRuleName;
            Protocol = protocol;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of inbound NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "inboundNatRuleName")]
        public string InboundNatRuleName { get; private set; }

        /// <summary>
        /// Gets the reference to the transport protocol used by the inbound
        /// NAT rule. Possible values include: 'Udp', 'Tcp', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; private set; }

        /// <summary>
        /// Gets frontend port.
        /// </summary>
        [JsonProperty(PropertyName = "frontendPort")]
        public int? FrontendPort { get; private set; }

        /// <summary>
        /// Gets backend port.
        /// </summary>
        [JsonProperty(PropertyName = "backendPort")]
        public int? BackendPort { get; private set; }

    }
}