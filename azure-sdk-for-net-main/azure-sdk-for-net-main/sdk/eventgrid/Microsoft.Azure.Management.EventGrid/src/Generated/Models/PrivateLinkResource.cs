// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information of the private link resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        public PrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        public PrivateLinkResource(string groupId = default(string), string displayName = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>), string id = default(string), string name = default(string), string type = default(string))
        {
            GroupId = groupId;
            DisplayName = displayName;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            Id = id;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredMembers")]
        public IList<string> RequiredMembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; set; }

        /// <summary>
        /// Gets or sets fully qualified identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}