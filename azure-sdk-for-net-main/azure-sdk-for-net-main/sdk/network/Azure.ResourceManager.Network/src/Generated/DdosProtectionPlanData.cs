// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the DdosProtectionPlan data model. </summary>
    public partial class DdosProtectionPlanData : TrackedResource
    {
        /// <summary> Initializes a new instance of DdosProtectionPlanData. </summary>
        /// <param name="location"> The location. </param>
        public DdosProtectionPlanData(AzureLocation location) : base(location)
        {
            VirtualNetworks = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of DdosProtectionPlanData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DDoS protection plan resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </param>
        /// <param name="provisioningState"> The provisioning state of the DDoS protection plan resource. </param>
        /// <param name="virtualNetworks"> The list of virtual networks associated with the DDoS protection plan resource. This list is read-only. </param>
        internal DdosProtectionPlanData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string etag, string resourceGuid, ProvisioningState? provisioningState, IReadOnlyList<WritableSubResource> virtualNetworks) : base(id, name, type, systemData, tags, location)
        {
            Etag = etag;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            VirtualNetworks = virtualNetworks;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource GUID property of the DDoS protection plan resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the DDoS protection plan resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The list of virtual networks associated with the DDoS protection plan resource. This list is read-only. </summary>
        public IReadOnlyList<WritableSubResource> VirtualNetworks { get; }
    }
}