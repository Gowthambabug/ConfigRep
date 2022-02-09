// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP Configuration of a VPN Gateway Resource. </summary>
    public partial class VpnGatewayIpConfiguration
    {
        /// <summary> Initializes a new instance of VpnGatewayIpConfiguration. </summary>
        internal VpnGatewayIpConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VpnGatewayIpConfiguration. </summary>
        /// <param name="id"> The identifier of the IP configuration for a VPN Gateway. </param>
        /// <param name="publicIpAddress"> The public IP address of this IP configuration. </param>
        /// <param name="privateIpAddress"> The private IP address of this IP configuration. </param>
        internal VpnGatewayIpConfiguration(string id, string publicIpAddress, string privateIpAddress)
        {
            Id = id;
            PublicIpAddress = publicIpAddress;
            PrivateIpAddress = privateIpAddress;
        }

        /// <summary> The identifier of the IP configuration for a VPN Gateway. </summary>
        public string Id { get; }
        /// <summary> The public IP address of this IP configuration. </summary>
        public string PublicIpAddress { get; }
        /// <summary> The private IP address of this IP configuration. </summary>
        public string PrivateIpAddress { get; }
    }
}