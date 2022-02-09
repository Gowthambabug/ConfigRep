// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the DdosCustomPolicy data model. </summary>
    public partial class DdosCustomPolicyData : Resource
    {
        /// <summary> Initializes a new instance of DdosCustomPolicyData. </summary>
        public DdosCustomPolicyData()
        {
            PublicIPAddresses = new ChangeTrackingList<WritableSubResource>();
            ProtocolCustomSettings = new ChangeTrackingList<ProtocolCustomSettingsFormat>();
        }

        /// <summary> Initializes a new instance of DdosCustomPolicyData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </param>
        /// <param name="provisioningState"> The provisioning state of the DDoS custom policy resource. </param>
        /// <param name="publicIPAddresses"> The list of public IPs associated with the DDoS custom policy resource. This list is read-only. </param>
        /// <param name="protocolCustomSettings"> The protocol-specific DDoS policy customization parameters. </param>
        internal DdosCustomPolicyData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, string resourceGuid, ProvisioningState? provisioningState, IReadOnlyList<WritableSubResource> publicIPAddresses, IList<ProtocolCustomSettingsFormat> protocolCustomSettings) : base(id, name, type, location, tags)
        {
            Etag = etag;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            PublicIPAddresses = publicIPAddresses;
            ProtocolCustomSettings = protocolCustomSettings;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the DDoS custom policy resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The list of public IPs associated with the DDoS custom policy resource. This list is read-only. </summary>
        public IReadOnlyList<WritableSubResource> PublicIPAddresses { get; }
        /// <summary> The protocol-specific DDoS policy customization parameters. </summary>
        public IList<ProtocolCustomSettingsFormat> ProtocolCustomSettings { get; }
    }
}