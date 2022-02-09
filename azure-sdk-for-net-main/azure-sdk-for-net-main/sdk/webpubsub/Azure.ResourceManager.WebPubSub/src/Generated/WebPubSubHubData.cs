// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing the WebPubSubHub data model. </summary>
    public partial class WebPubSubHubData : Resource
    {
        /// <summary> Initializes a new instance of WebPubSubHubData. </summary>
        /// <param name="properties"> Properties of the hub setting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public WebPubSubHubData(WebPubSubHubProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of WebPubSubHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the hub setting. </param>
        internal WebPubSubHubData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, WebPubSubHubProperties properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the hub setting. </summary>
        public WebPubSubHubProperties Properties { get; set; }
    }
}