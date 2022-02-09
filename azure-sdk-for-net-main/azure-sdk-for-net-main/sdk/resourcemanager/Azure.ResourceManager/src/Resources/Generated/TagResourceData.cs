// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the TagResource data model. </summary>
    public partial class TagResourceData : Resource
    {
        /// <summary> Initializes a new instance of TagResourceData. </summary>
        /// <param name="properties"> The set of tags. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public TagResourceData(Tag properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of TagResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The set of tags. </param>
        internal TagResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, Tag properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> The set of tags. </summary>
        public Tag Properties { get; set; }
    }
}