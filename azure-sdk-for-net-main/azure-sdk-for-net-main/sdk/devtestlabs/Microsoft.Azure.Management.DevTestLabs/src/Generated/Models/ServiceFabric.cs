// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Service Fabric.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceFabric : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceFabric class.
        /// </summary>
        public ServiceFabric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceFabric class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="externalServiceFabricId">The backing service fabric
        /// resource's id</param>
        /// <param name="environmentId">The resource id of the environment
        /// under which the service fabric resource is present</param>
        /// <param name="applicableSchedule">The applicable schedule for the
        /// virtual machine.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public ServiceFabric(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string externalServiceFabricId = default(string), string environmentId = default(string), ApplicableSchedule applicableSchedule = default(ApplicableSchedule), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            ExternalServiceFabricId = externalServiceFabricId;
            EnvironmentId = environmentId;
            ApplicableSchedule = applicableSchedule;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the backing service fabric resource's id
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalServiceFabricId")]
        public string ExternalServiceFabricId { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the environment under which the
        /// service fabric resource is present
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentId")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Gets the applicable schedule for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicableSchedule")]
        public ApplicableSchedule ApplicableSchedule { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; private set; }

    }
}
