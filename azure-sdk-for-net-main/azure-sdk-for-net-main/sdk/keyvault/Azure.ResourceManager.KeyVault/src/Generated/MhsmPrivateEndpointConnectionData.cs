// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the MhsmPrivateEndpointConnection data model. </summary>
    public partial class MhsmPrivateEndpointConnectionData : ManagedHsmResource
    {
        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionData. </summary>
        /// <param name="location"> The location. </param>
        public MhsmPrivateEndpointConnectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpoint"> Properties of the private endpoint object. </param>
        /// <param name="privateLinkServiceConnectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        internal MhsmPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedHsmSku sku, string etag, SubResource privateEndpoint, MhsmPrivateLinkServiceConnectionState privateLinkServiceConnectionState, PrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, type, systemData, tags, location, sku)
        {
            Etag = etag;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Modified whenever there is a change in the state of private endpoint connection. </summary>
        public string Etag { get; set; }
        /// <summary> Properties of the private endpoint object. </summary>
        public SubResource PrivateEndpoint { get; set; }
        /// <summary> Approval state of the private link connection. </summary>
        public MhsmPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public PrivateEndpointConnectionProvisioningState? ProvisioningState { get; set; }
    }
}
