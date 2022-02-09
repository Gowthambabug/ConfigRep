// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the network interfaces or the networking configuration of the
    /// virtual machine.
    /// </summary>
    public partial class NetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        public NetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        /// <param name="networkInterfaces">Specifies the list of resource Ids
        /// for the network interfaces associated with the virtual
        /// machine.</param>
        /// <param name="networkApiVersion">specifies the Microsoft.Network API
        /// version used when creating networking resources in the Network
        /// Interface Configurations. Possible values include:
        /// '2020-11-01'</param>
        /// <param name="networkInterfaceConfigurations">Specifies the
        /// networking configurations that will be used to create the virtual
        /// machine networking resources.</param>
        public NetworkProfile(IList<NetworkInterfaceReference> networkInterfaces = default(IList<NetworkInterfaceReference>), string networkApiVersion = default(string), IList<VirtualMachineNetworkInterfaceConfiguration> networkInterfaceConfigurations = default(IList<VirtualMachineNetworkInterfaceConfiguration>))
        {
            NetworkInterfaces = networkInterfaces;
            NetworkApiVersion = networkApiVersion;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the list of resource Ids for the network
        /// interfaces associated with the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaces")]
        public IList<NetworkInterfaceReference> NetworkInterfaces { get; set; }

        /// <summary>
        /// Gets or sets specifies the Microsoft.Network API version used when
        /// creating networking resources in the Network Interface
        /// Configurations. Possible values include: '2020-11-01'
        /// </summary>
        [JsonProperty(PropertyName = "networkApiVersion")]
        public string NetworkApiVersion { get; set; }

        /// <summary>
        /// Gets or sets specifies the networking configurations that will be
        /// used to create the virtual machine networking resources.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceConfigurations")]
        public IList<VirtualMachineNetworkInterfaceConfiguration> NetworkInterfaceConfigurations { get; set; }

    }
}