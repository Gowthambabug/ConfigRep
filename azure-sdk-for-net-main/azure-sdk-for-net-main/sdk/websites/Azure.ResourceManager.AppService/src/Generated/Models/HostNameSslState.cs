// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SSL-enabled hostname. </summary>
    public partial class HostNameSslState
    {
        /// <summary> Initializes a new instance of HostNameSslState. </summary>
        public HostNameSslState()
        {
        }

        /// <summary> Initializes a new instance of HostNameSslState. </summary>
        /// <param name="name"> Hostname. </param>
        /// <param name="sslState"> SSL type. </param>
        /// <param name="virtualIP"> Virtual IP address assigned to the hostname if IP based SSL is enabled. </param>
        /// <param name="thumbprint"> SSL certificate thumbprint. </param>
        /// <param name="toUpdate"> Set to &lt;code&gt;true&lt;/code&gt; to update existing hostname. </param>
        /// <param name="hostType"> Indicates whether the hostname is a standard or repository hostname. </param>
        internal HostNameSslState(string name, SslState? sslState, string virtualIP, string thumbprint, bool? toUpdate, HostType? hostType)
        {
            Name = name;
            SslState = sslState;
            VirtualIP = virtualIP;
            Thumbprint = thumbprint;
            ToUpdate = toUpdate;
            HostType = hostType;
        }

        /// <summary> Hostname. </summary>
        public string Name { get; set; }
        /// <summary> SSL type. </summary>
        public SslState? SslState { get; set; }
        /// <summary> Virtual IP address assigned to the hostname if IP based SSL is enabled. </summary>
        public string VirtualIP { get; set; }
        /// <summary> SSL certificate thumbprint. </summary>
        public string Thumbprint { get; set; }
        /// <summary> Set to &lt;code&gt;true&lt;/code&gt; to update existing hostname. </summary>
        public bool? ToUpdate { get; set; }
        /// <summary> Indicates whether the hostname is a standard or repository hostname. </summary>
        public HostType? HostType { get; set; }
    }
}