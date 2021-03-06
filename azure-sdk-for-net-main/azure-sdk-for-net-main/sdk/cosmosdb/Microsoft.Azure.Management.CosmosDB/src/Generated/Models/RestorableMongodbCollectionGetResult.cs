// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB MongoDB collection event
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RestorableMongodbCollectionGetResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableMongodbCollectionGetResult class.
        /// </summary>
        public RestorableMongodbCollectionGetResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RestorableMongodbCollectionGetResult class.
        /// </summary>
        /// <param name="resource">The resource of an Azure Cosmos DB MongoDB
        /// collection event</param>
        /// <param name="id">The unique resource Identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        public RestorableMongodbCollectionGetResult(RestorableMongodbCollectionPropertiesResource resource = default(RestorableMongodbCollectionPropertiesResource), string id = default(string), string name = default(string), string type = default(string))
        {
            Resource = resource;
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
        /// Gets or sets the resource of an Azure Cosmos DB MongoDB collection
        /// event
        /// </summary>
        [JsonProperty(PropertyName = "properties.resource")]
        public RestorableMongodbCollectionPropertiesResource Resource { get; set; }

        /// <summary>
        /// Gets the unique resource Identifier of the ARM resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the ARM resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of Azure resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
