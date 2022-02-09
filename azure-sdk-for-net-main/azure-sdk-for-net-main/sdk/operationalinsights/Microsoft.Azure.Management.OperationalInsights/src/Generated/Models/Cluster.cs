// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level Log Analytics cluster resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="sku">The sku properties.</param>
        /// <param name="clusterId">The ID associated with the cluster.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// cluster. Possible values include: 'Creating', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleting', 'ProvisioningAccount',
        /// 'Updating'</param>
        /// <param name="isDoubleEncryptionEnabled">Configures whether cluster
        /// will use double encryption. This Property can not be modified after
        /// cluster creation. Default value is 'true'</param>
        /// <param name="isAvailabilityZonesEnabled">Sets whether the cluster
        /// will support availability zones. This can be set as true only in
        /// regions where Azure Data Explorer support Availability Zones. This
        /// Property can not be modified after cluster creation. Default value
        /// is 'true' if region supports Availability Zones.</param>
        /// <param name="billingType">The cluster's billing type. Possible
        /// values include: 'Cluster', 'Workspaces'</param>
        /// <param name="keyVaultProperties">The associated key
        /// properties.</param>
        /// <param name="lastModifiedDate">The last time the cluster was
        /// updated.</param>
        /// <param name="createdDate">The cluster creation time</param>
        /// <param name="associatedWorkspaces">The list of Log Analytics
        /// workspaces associated with the cluster</param>
        /// <param name="capacityReservationProperties">Additional properties
        /// for capacity reservation</param>
        public Cluster(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), ClusterSku sku = default(ClusterSku), string clusterId = default(string), string provisioningState = default(string), bool? isDoubleEncryptionEnabled = default(bool?), bool? isAvailabilityZonesEnabled = default(bool?), string billingType = default(string), KeyVaultProperties keyVaultProperties = default(KeyVaultProperties), string lastModifiedDate = default(string), string createdDate = default(string), IList<AssociatedWorkspace> associatedWorkspaces = default(IList<AssociatedWorkspace>), CapacityReservationProperties capacityReservationProperties = default(CapacityReservationProperties))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Sku = sku;
            ClusterId = clusterId;
            ProvisioningState = provisioningState;
            IsDoubleEncryptionEnabled = isDoubleEncryptionEnabled;
            IsAvailabilityZonesEnabled = isAvailabilityZonesEnabled;
            BillingType = billingType;
            KeyVaultProperties = keyVaultProperties;
            LastModifiedDate = lastModifiedDate;
            CreatedDate = createdDate;
            AssociatedWorkspaces = associatedWorkspaces;
            CapacityReservationProperties = capacityReservationProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the sku properties.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ClusterSku Sku { get; set; }

        /// <summary>
        /// Gets the ID associated with the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterId")]
        public string ClusterId { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the cluster. Possible values
        /// include: 'Creating', 'Succeeded', 'Failed', 'Canceled', 'Deleting',
        /// 'ProvisioningAccount', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets configures whether cluster will use double encryption.
        /// This Property can not be modified after cluster creation. Default
        /// value is 'true'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDoubleEncryptionEnabled")]
        public bool? IsDoubleEncryptionEnabled { get; set; }

        /// <summary>
        /// Gets or sets sets whether the cluster will support availability
        /// zones. This can be set as true only in regions where Azure Data
        /// Explorer support Availability Zones. This Property can not be
        /// modified after cluster creation. Default value is 'true' if region
        /// supports Availability Zones.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAvailabilityZonesEnabled")]
        public bool? IsAvailabilityZonesEnabled { get; set; }

        /// <summary>
        /// Gets or sets the cluster's billing type. Possible values include:
        /// 'Cluster', 'Workspaces'
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingType")]
        public string BillingType { get; set; }

        /// <summary>
        /// Gets or sets the associated key properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultProperties")]
        public KeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// Gets the last time the cluster was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedDate")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Gets the cluster creation time
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets the list of Log Analytics workspaces associated with
        /// the cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.associatedWorkspaces")]
        public IList<AssociatedWorkspace> AssociatedWorkspaces { get; set; }

        /// <summary>
        /// Gets or sets additional properties for capacity reservation
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacityReservationProperties")]
        public CapacityReservationProperties CapacityReservationProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}