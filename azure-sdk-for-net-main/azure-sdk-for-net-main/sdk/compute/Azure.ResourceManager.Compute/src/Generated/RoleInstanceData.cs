// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the RoleInstance data model. </summary>
    public partial class RoleInstanceData : Resource
    {
        /// <summary> Initializes a new instance of RoleInstanceData. </summary>
        internal RoleInstanceData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of RoleInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"></param>
        /// <param name="properties"></param>
        internal RoleInstanceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, IReadOnlyDictionary<string, string> tags, InstanceSku sku, RoleInstanceProperties properties) : base(id, name, type, systemData)
        {
            Location = location;
            Tags = tags;
            Sku = sku;
            Properties = properties;
        }

        /// <summary> Resource Location. </summary>
        public string Location { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Gets the sku. </summary>
        public InstanceSku Sku { get; }
        /// <summary> Gets the properties. </summary>
        public RoleInstanceProperties Properties { get; }
    }
}