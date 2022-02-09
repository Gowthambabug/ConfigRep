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
    /// <summary> A class representing the NetworkVirtualAppliance data model. </summary>
    public partial class NetworkVirtualApplianceData : Models.Resource
    {
        /// <summary> Initializes a new instance of NetworkVirtualApplianceData. </summary>
        public NetworkVirtualApplianceData()
        {
            BootStrapConfigurationBlobs = new ChangeTrackingList<string>();
            CloudInitConfigurationBlobs = new ChangeTrackingList<string>();
            VirtualApplianceNics = new ChangeTrackingList<VirtualApplianceNicProperties>();
            VirtualApplianceSites = new ChangeTrackingList<WritableSubResource>();
            InboundSecurityRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of NetworkVirtualApplianceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The service principal that has read access to cloud-init and config blob. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="nvaSku"> Network Virtual Appliance SKU. </param>
        /// <param name="addressPrefix"> Address Prefix. </param>
        /// <param name="bootStrapConfigurationBlobs"> BootStrapConfigurationBlobs storage URLs. </param>
        /// <param name="virtualHub"> The Virtual Hub where Network Virtual Appliance is being deployed. </param>
        /// <param name="cloudInitConfigurationBlobs"> CloudInitConfigurationBlob storage URLs. </param>
        /// <param name="cloudInitConfiguration"> CloudInitConfiguration string in plain text. </param>
        /// <param name="virtualApplianceAsn"> VirtualAppliance ASN. </param>
        /// <param name="virtualApplianceNics"> List of Virtual Appliance Network Interfaces. </param>
        /// <param name="virtualApplianceSites"> List of references to VirtualApplianceSite. </param>
        /// <param name="inboundSecurityRules"> List of references to InboundSecurityRules. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal NetworkVirtualApplianceData(string id, string name, string type, string location, IDictionary<string, string> tags, ManagedServiceIdentity identity, string etag, VirtualApplianceSkuProperties nvaSku, string addressPrefix, IList<string> bootStrapConfigurationBlobs, WritableSubResource virtualHub, IList<string> cloudInitConfigurationBlobs, string cloudInitConfiguration, long? virtualApplianceAsn, IReadOnlyList<VirtualApplianceNicProperties> virtualApplianceNics, IReadOnlyList<WritableSubResource> virtualApplianceSites, IReadOnlyList<WritableSubResource> inboundSecurityRules, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Identity = identity;
            Etag = etag;
            NvaSku = nvaSku;
            AddressPrefix = addressPrefix;
            BootStrapConfigurationBlobs = bootStrapConfigurationBlobs;
            VirtualHub = virtualHub;
            CloudInitConfigurationBlobs = cloudInitConfigurationBlobs;
            CloudInitConfiguration = cloudInitConfiguration;
            VirtualApplianceAsn = virtualApplianceAsn;
            VirtualApplianceNics = virtualApplianceNics;
            VirtualApplianceSites = virtualApplianceSites;
            InboundSecurityRules = inboundSecurityRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> The service principal that has read access to cloud-init and config blob. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Network Virtual Appliance SKU. </summary>
        public VirtualApplianceSkuProperties NvaSku { get; set; }
        /// <summary> Address Prefix. </summary>
        public string AddressPrefix { get; }
        /// <summary> BootStrapConfigurationBlobs storage URLs. </summary>
        public IList<string> BootStrapConfigurationBlobs { get; }
        /// <summary> The Virtual Hub where Network Virtual Appliance is being deployed. </summary>
        public WritableSubResource VirtualHub { get; set; }
        /// <summary> CloudInitConfigurationBlob storage URLs. </summary>
        public IList<string> CloudInitConfigurationBlobs { get; }
        /// <summary> CloudInitConfiguration string in plain text. </summary>
        public string CloudInitConfiguration { get; set; }
        /// <summary> VirtualAppliance ASN. </summary>
        public long? VirtualApplianceAsn { get; set; }
        /// <summary> List of Virtual Appliance Network Interfaces. </summary>
        public IReadOnlyList<VirtualApplianceNicProperties> VirtualApplianceNics { get; }
        /// <summary> List of references to VirtualApplianceSite. </summary>
        public IReadOnlyList<WritableSubResource> VirtualApplianceSites { get; }
        /// <summary> List of references to InboundSecurityRules. </summary>
        public IReadOnlyList<WritableSubResource> InboundSecurityRules { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
