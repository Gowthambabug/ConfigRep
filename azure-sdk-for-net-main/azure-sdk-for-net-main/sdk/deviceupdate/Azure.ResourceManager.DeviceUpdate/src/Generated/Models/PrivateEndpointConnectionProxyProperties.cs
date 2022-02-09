// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private endpoint connection proxy object properties. </summary>
    public partial class PrivateEndpointConnectionProxyProperties
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyProperties. </summary>
        public PrivateEndpointConnectionProxyProperties()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyProperties. </summary>
        /// <param name="eTag"> ETag from NRP. </param>
        /// <param name="remotePrivateEndpoint"> Remote private endpoint details. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection proxy resource. </param>
        /// <param name="status"> Operation status. </param>
        internal PrivateEndpointConnectionProxyProperties(string eTag, RemotePrivateEndpoint remotePrivateEndpoint, PrivateEndpointConnectionProxyProvisioningState? provisioningState, string status)
        {
            ETag = eTag;
            RemotePrivateEndpoint = remotePrivateEndpoint;
            ProvisioningState = provisioningState;
            Status = status;
        }

        /// <summary> ETag from NRP. </summary>
        public string ETag { get; }
        /// <summary> Remote private endpoint details. </summary>
        public RemotePrivateEndpoint RemotePrivateEndpoint { get; set; }
        /// <summary> The provisioning state of the private endpoint connection proxy resource. </summary>
        public PrivateEndpointConnectionProxyProvisioningState? ProvisioningState { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; set; }
    }
}