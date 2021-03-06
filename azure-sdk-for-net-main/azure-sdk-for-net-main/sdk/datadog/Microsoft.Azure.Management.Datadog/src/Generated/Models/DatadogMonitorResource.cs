// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DatadogMonitorResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DatadogMonitorResource class.
        /// </summary>
        public DatadogMonitorResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatadogMonitorResource class.
        /// </summary>
        /// <param name="id">ARM id of the monitor resource.</param>
        /// <param name="name">Name of the monitor resource.</param>
        /// <param name="type">The type of the monitor resource.</param>
        public DatadogMonitorResource(string location, string id = default(string), string name = default(string), string type = default(string), ResourceSku sku = default(ResourceSku), MonitorProperties properties = default(MonitorProperties), IdentityProperties identity = default(IdentityProperties), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData))
        {
            Id = id;
            Name = name;
            Type = type;
            Sku = sku;
            Properties = properties;
            Identity = identity;
            Tags = tags;
            Location = location;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ARM id of the monitor resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the monitor resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the monitor resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MonitorProperties Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityProperties Identity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
