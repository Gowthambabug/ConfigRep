// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> An instance of a STUN/TURN server with credentials to be used for ICE negotiation. </summary>
    public partial class CommunicationIceServer
    {
        /// <summary> Initializes a new instance of CommunicationIceServer. </summary>
        /// <param name="urls"> List of STUN/TURN server URLs. </param>
        /// <param name="username"> User account name which uniquely identifies the credentials. </param>
        /// <param name="credential"> Credential for the server. </param>
        /// <param name="routeType"> The routing methodology to where the ICE server will be located from the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="urls"/>, <paramref name="username"/>, or <paramref name="credential"/> is null. </exception>
        internal CommunicationIceServer(IEnumerable<string> urls, string username, string credential, RouteType routeType)
        {
            if (urls == null)
            {
                throw new ArgumentNullException(nameof(urls));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            Urls = urls.ToList();
            Username = username;
            Credential = credential;
            RouteType = routeType;
        }

        /// <summary> Initializes a new instance of CommunicationIceServer. </summary>
        /// <param name="urls"> List of STUN/TURN server URLs. </param>
        /// <param name="username"> User account name which uniquely identifies the credentials. </param>
        /// <param name="credential"> Credential for the server. </param>
        /// <param name="routeType"> The routing methodology to where the ICE server will be located from the client. </param>
        internal CommunicationIceServer(IReadOnlyList<string> urls, string username, string credential, RouteType routeType)
        {
            Urls = urls;
            Username = username;
            Credential = credential;
            RouteType = routeType;
        }

        /// <summary> List of STUN/TURN server URLs. </summary>
        public IReadOnlyList<string> Urls { get; }
        /// <summary> User account name which uniquely identifies the credentials. </summary>
        public string Username { get; }
        /// <summary> Credential for the server. </summary>
        public string Credential { get; }
        /// <summary> The routing methodology to where the ICE server will be located from the client. </summary>
        public RouteType RouteType { get; }
    }
}