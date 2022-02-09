// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStackHCI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ArcSetting details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ArcSetting : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ArcSetting class.
        /// </summary>
        public ArcSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArcSetting class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="createdBy">The identity that created the
        /// resource.</param>
        /// <param name="createdByType">The type of identity that created the
        /// resource. Possible values include: 'User', 'Application',
        /// 'ManagedIdentity', 'Key'</param>
        /// <param name="createdAt">The timestamp of resource creation
        /// (UTC).</param>
        /// <param name="lastModifiedBy">The identity that last modified the
        /// resource.</param>
        /// <param name="lastModifiedByType">The type of identity that last
        /// modified the resource. Possible values include: 'User',
        /// 'Application', 'ManagedIdentity', 'Key'</param>
        /// <param name="lastModifiedAt">The timestamp of resource last
        /// modification (UTC)</param>
        /// <param name="provisioningState">Provisioning state of the
        /// ArcSetting proxy resource. Possible values include: 'Succeeded',
        /// 'Failed', 'Canceled', 'Accepted', 'Provisioning'</param>
        /// <param name="arcInstanceResourceGroup">The resource group that
        /// hosts the Arc agents, ie. Hybrid Compute Machine resources.</param>
        /// <param name="aggregateState">Aggregate state of Arc agent across
        /// the nodes in this HCI cluster. Possible values include:
        /// 'NotSpecified', 'Error', 'Succeeded', 'Canceled', 'Failed',
        /// 'Connected', 'Disconnected', 'Deleted', 'Creating', 'Updating',
        /// 'Deleting', 'Moving', 'PartiallySucceeded', 'PartiallyConnected',
        /// 'InProgress'</param>
        /// <param name="perNodeDetails">State of Arc agent in each of the
        /// nodes.</param>
        public ArcSetting(string id = default(string), string name = default(string), string type = default(string), string createdBy = default(string), string createdByType = default(string), System.DateTime? createdAt = default(System.DateTime?), string lastModifiedBy = default(string), string lastModifiedByType = default(string), System.DateTime? lastModifiedAt = default(System.DateTime?), string provisioningState = default(string), string arcInstanceResourceGroup = default(string), string aggregateState = default(string), IList<PerNodeState> perNodeDetails = default(IList<PerNodeState>))
            : base(id, name, type)
        {
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedAt = createdAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedAt = lastModifiedAt;
            ProvisioningState = provisioningState;
            ArcInstanceResourceGroup = arcInstanceResourceGroup;
            AggregateState = aggregateState;
            PerNodeDetails = perNodeDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identity that created the resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData.createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the type of identity that created the resource.
        /// Possible values include: 'User', 'Application', 'ManagedIdentity',
        /// 'Key'
        /// </summary>
        [JsonProperty(PropertyName = "systemData.createdByType")]
        public string CreatedByType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of resource creation (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "systemData.createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the identity that last modified the resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData.lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the type of identity that last modified the resource.
        /// Possible values include: 'User', 'Application', 'ManagedIdentity',
        /// 'Key'
        /// </summary>
        [JsonProperty(PropertyName = "systemData.lastModifiedByType")]
        public string LastModifiedByType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of resource last modification (UTC)
        /// </summary>
        [JsonProperty(PropertyName = "systemData.lastModifiedAt")]
        public System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Gets provisioning state of the ArcSetting proxy resource. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'Accepted',
        /// 'Provisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the resource group that hosts the Arc agents, ie. Hybrid
        /// Compute Machine resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.arcInstanceResourceGroup")]
        public string ArcInstanceResourceGroup { get; private set; }

        /// <summary>
        /// Gets aggregate state of Arc agent across the nodes in this HCI
        /// cluster. Possible values include: 'NotSpecified', 'Error',
        /// 'Succeeded', 'Canceled', 'Failed', 'Connected', 'Disconnected',
        /// 'Deleted', 'Creating', 'Updating', 'Deleting', 'Moving',
        /// 'PartiallySucceeded', 'PartiallyConnected', 'InProgress'
        /// </summary>
        [JsonProperty(PropertyName = "properties.aggregateState")]
        public string AggregateState { get; private set; }

        /// <summary>
        /// Gets state of Arc agent in each of the nodes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.perNodeDetails")]
        public IList<PerNodeState> PerNodeDetails { get; private set; }

    }
}