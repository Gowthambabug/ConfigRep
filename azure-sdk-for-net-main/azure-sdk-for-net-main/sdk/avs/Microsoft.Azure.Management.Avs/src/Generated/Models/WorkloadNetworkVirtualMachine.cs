// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NSX Virtual Machine
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkloadNetworkVirtualMachine : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkVirtualMachine
        /// class.
        /// </summary>
        public WorkloadNetworkVirtualMachine()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkVirtualMachine
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Display name of the VM.</param>
        /// <param name="vmType">Virtual machine type. Possible values include:
        /// 'REGULAR', 'EDGE', 'SERVICE'</param>
        public WorkloadNetworkVirtualMachine(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string vmType = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            VmType = vmType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets virtual machine type. Possible values include: 'REGULAR',
        /// 'EDGE', 'SERVICE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmType")]
        public string VmType { get; private set; }

    }
}