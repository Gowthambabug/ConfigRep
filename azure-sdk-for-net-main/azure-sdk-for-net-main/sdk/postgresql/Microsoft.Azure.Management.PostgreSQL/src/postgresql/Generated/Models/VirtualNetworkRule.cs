// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A virtual network rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkRule : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        public VirtualNetworkRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        /// <param name="virtualNetworkSubnetId">The ARM resource id of the
        /// virtual network subnet.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="ignoreMissingVnetServiceEndpoint">Create firewall rule
        /// before the virtual network has vnet service endpoint
        /// enabled.</param>
        /// <param name="state">Virtual Network Rule State. Possible values
        /// include: 'Initializing', 'InProgress', 'Ready', 'Deleting',
        /// 'Unknown'</param>
        public VirtualNetworkRule(string virtualNetworkSubnetId, string id = default(string), string name = default(string), string type = default(string), bool? ignoreMissingVnetServiceEndpoint = default(bool?), string state = default(string))
            : base(id, name, type)
        {
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource id of the virtual network subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkSubnetId")]
        public string VirtualNetworkSubnetId { get; set; }

        /// <summary>
        /// Gets or sets create firewall rule before the virtual network has
        /// vnet service endpoint enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ignoreMissingVnetServiceEndpoint")]
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

        /// <summary>
        /// Gets virtual Network Rule State. Possible values include:
        /// 'Initializing', 'InProgress', 'Ready', 'Deleting', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkSubnetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkSubnetId");
            }
        }
    }
}
