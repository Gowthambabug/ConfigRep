// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> String dictionary resource. </summary>
    public partial class ConnectionStringDictionary : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ConnectionStringDictionary. </summary>
        public ConnectionStringDictionary()
        {
            Properties = new ChangeTrackingDictionary<string, ConnStringValueTypePair>();
        }

        /// <summary> Initializes a new instance of ConnectionStringDictionary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="properties"> Connection strings. </param>
        internal ConnectionStringDictionary(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, IDictionary<string, ConnStringValueTypePair> properties) : base(id, name, type, systemData, kind)
        {
            Properties = properties;
        }

        /// <summary> Connection strings. </summary>
        public IDictionary<string, ConnStringValueTypePair> Properties { get; }
    }
}
