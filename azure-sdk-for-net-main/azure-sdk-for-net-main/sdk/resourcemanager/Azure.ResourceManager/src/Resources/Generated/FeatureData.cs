// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the Feature data model. </summary>
    public partial class FeatureData : Resource
    {
        /// <summary> Initializes a new instance of FeatureData. </summary>
        internal FeatureData()
        {
        }

        /// <summary> Initializes a new instance of FeatureData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the previewed feature. </param>
        internal FeatureData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, FeatureProperties properties) : base(id, name, type, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the previewed feature. </summary>
        public FeatureProperties Properties { get; }
    }
}