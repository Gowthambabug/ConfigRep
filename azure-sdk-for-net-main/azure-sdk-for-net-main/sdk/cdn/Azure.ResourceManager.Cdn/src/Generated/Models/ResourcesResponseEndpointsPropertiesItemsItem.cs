// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ResourcesResponseEndpointsPropertiesItemsItem. </summary>
    public partial class ResourcesResponseEndpointsPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of ResourcesResponseEndpointsPropertiesItemsItem. </summary>
        internal ResourcesResponseEndpointsPropertiesItemsItem()
        {
        }

        /// <summary> Initializes a new instance of ResourcesResponseEndpointsPropertiesItemsItem. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="endpointId"></param>
        /// <param name="history"></param>
        internal ResourcesResponseEndpointsPropertiesItemsItem(string id, string name, string endpointId, bool? history)
        {
            Id = id;
            Name = name;
            EndpointId = endpointId;
            History = history;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the endpoint id. </summary>
        public string EndpointId { get; }
        /// <summary> Gets the history. </summary>
        public bool? History { get; }
    }
}