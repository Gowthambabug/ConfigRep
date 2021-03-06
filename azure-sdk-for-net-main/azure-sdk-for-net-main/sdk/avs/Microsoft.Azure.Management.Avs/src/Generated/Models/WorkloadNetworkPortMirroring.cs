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
    /// NSX Port Mirroring
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkloadNetworkPortMirroring : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkPortMirroring
        /// class.
        /// </summary>
        public WorkloadNetworkPortMirroring()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkPortMirroring
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Display name of the port mirroring
        /// profile.</param>
        /// <param name="direction">Direction of port mirroring profile.
        /// Possible values include: 'INGRESS', 'EGRESS',
        /// 'BIDIRECTIONAL'</param>
        /// <param name="source">Source VM Group.</param>
        /// <param name="destination">Destination VM Group.</param>
        /// <param name="status">Port Mirroring Status. Possible values
        /// include: 'SUCCESS', 'FAILURE'</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Succeeded', 'Failed', 'Building', 'Deleting',
        /// 'Updating'</param>
        /// <param name="revision">NSX revision number.</param>
        public WorkloadNetworkPortMirroring(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string direction = default(string), string source = default(string), string destination = default(string), string status = default(string), string provisioningState = default(string), long? revision = default(long?))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Direction = direction;
            Source = source;
            Destination = destination;
            Status = status;
            ProvisioningState = provisioningState;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the port mirroring profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets direction of port mirroring profile. Possible values
        /// include: 'INGRESS', 'EGRESS', 'BIDIRECTIONAL'
        /// </summary>
        [JsonProperty(PropertyName = "properties.direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets source VM Group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets destination VM Group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets port Mirroring Status. Possible values include: 'SUCCESS',
        /// 'FAILURE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the provisioning state. Possible values include: 'Succeeded',
        /// 'Failed', 'Building', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets NSX revision number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.revision")]
        public long? Revision { get; set; }

    }
}
