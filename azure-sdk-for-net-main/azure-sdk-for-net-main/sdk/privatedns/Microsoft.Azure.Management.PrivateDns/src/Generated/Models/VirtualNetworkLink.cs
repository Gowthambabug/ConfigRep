// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PrivateDns.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a link to virtual network for a Private DNS zone.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkLink : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkLink class.
        /// </summary>
        public VirtualNetworkLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkLink class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource.
        /// Example -
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateDnsZoneName}'.</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Example -
        /// 'Microsoft.Network/privateDnsZones'.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The Azure Region where the resource
        /// lives</param>
        /// <param name="etag">The ETag of the virtual network link.</param>
        /// <param name="virtualNetwork">The reference of the virtual
        /// network.</param>
        /// <param name="registrationEnabled">Is auto-registration of virtual
        /// machine records in the virtual network in the Private DNS zone
        /// enabled?</param>
        /// <param name="virtualNetworkLinkState">The status of the virtual
        /// network link to the Private DNS zone. Possible values are
        /// 'InProgress' and 'Done'. This is a read-only property and any
        /// attempt to set this value will be ignored. Possible values include:
        /// 'InProgress', 'Completed'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. This is a read-only property and any attempt to set this
        /// value will be ignored. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'</param>
        public VirtualNetworkLink(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string etag = default(string), SubResource virtualNetwork = default(SubResource), bool? registrationEnabled = default(bool?), string virtualNetworkLinkState = default(string), string provisioningState = default(string))
            : base(id, name, type, tags, location)
        {
            Etag = etag;
            VirtualNetwork = virtualNetwork;
            RegistrationEnabled = registrationEnabled;
            VirtualNetworkLinkState = virtualNetworkLinkState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ETag of the virtual network link.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the reference of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetwork")]
        public SubResource VirtualNetwork { get; set; }

        /// <summary>
        /// Gets or sets is auto-registration of virtual machine records in the
        /// virtual network in the Private DNS zone enabled?
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationEnabled")]
        public bool? RegistrationEnabled { get; set; }

        /// <summary>
        /// Gets the status of the virtual network link to the Private DNS
        /// zone. Possible values are 'InProgress' and 'Done'. This is a
        /// read-only property and any attempt to set this value will be
        /// ignored. Possible values include: 'InProgress', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkLinkState")]
        public string VirtualNetworkLinkState { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the resource. This is a read-only
        /// property and any attempt to set this value will be ignored.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
