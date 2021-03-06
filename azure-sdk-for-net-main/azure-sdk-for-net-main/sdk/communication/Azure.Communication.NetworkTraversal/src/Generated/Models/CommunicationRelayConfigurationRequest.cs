// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> Request for a CommunicationRelayConfiguration. </summary>
    internal partial class CommunicationRelayConfigurationRequest
    {
        /// <summary> Initializes a new instance of CommunicationRelayConfigurationRequest. </summary>
        public CommunicationRelayConfigurationRequest()
        {
        }

        /// <summary> An existing ACS identity. </summary>
        public string Id { get; set; }
        /// <summary> The routing methodology to where the ICE server will be located from the client. </summary>
        public RouteType? RouteType { get; set; }
    }
}
