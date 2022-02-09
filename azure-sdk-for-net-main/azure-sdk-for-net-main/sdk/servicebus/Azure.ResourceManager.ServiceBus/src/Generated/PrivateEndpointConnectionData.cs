// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the PrivateEndpointConnection data model. </summary>
    public partial class PrivateEndpointConnectionData : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        public PrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The Private Endpoint resource for this Connection. </param>
        /// <param name="privateLinkServiceConnectionState"> Details about the state of the connection. </param>
        /// <param name="provisioningState"> Provisioning state of the Private Endpoint Connection. </param>
        internal PrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, WritableSubResource privateEndpoint, ConnectionState privateLinkServiceConnectionState, EndpointProvisioningState? provisioningState) : base(id, name, type, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The Private Endpoint resource for this Connection. </summary>
        public WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Details about the state of the connection. </summary>
        public ConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Provisioning state of the Private Endpoint Connection. </summary>
        public EndpointProvisioningState? ProvisioningState { get; set; }
    }
}