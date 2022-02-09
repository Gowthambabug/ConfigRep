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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An update of a DRS placement policy resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PlacementPolicyUpdate
    {
        /// <summary>
        /// Initializes a new instance of the PlacementPolicyUpdate class.
        /// </summary>
        public PlacementPolicyUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlacementPolicyUpdate class.
        /// </summary>
        /// <param name="state">Whether the placement policy is enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="vmMembers">Virtual machine members list</param>
        /// <param name="hostMembers">Host members list</param>
        public PlacementPolicyUpdate(string state = default(string), IList<string> vmMembers = default(IList<string>), IList<string> hostMembers = default(IList<string>))
        {
            State = state;
            VmMembers = vmMembers;
            HostMembers = hostMembers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the placement policy is enabled or disabled.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets virtual machine members list
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmMembers")]
        public IList<string> VmMembers { get; set; }

        /// <summary>
        /// Gets or sets host members list
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostMembers")]
        public IList<string> HostMembers { get; set; }

    }
}