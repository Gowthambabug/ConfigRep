// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// storage edition capability
    /// </summary>
    public partial class StorageEditionCapability
    {
        /// <summary>
        /// Initializes a new instance of the StorageEditionCapability class.
        /// </summary>
        public StorageEditionCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageEditionCapability class.
        /// </summary>
        /// <param name="name">storage edition name</param>
        /// <param name="status">The status</param>
        public StorageEditionCapability(string name = default(string), IList<StorageMBCapability> supportedStorageMB = default(IList<StorageMBCapability>), string status = default(string))
        {
            Name = name;
            SupportedStorageMB = supportedStorageMB;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets storage edition name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedStorageMB")]
        public IList<StorageMBCapability> SupportedStorageMB { get; private set; }

        /// <summary>
        /// Gets the status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}