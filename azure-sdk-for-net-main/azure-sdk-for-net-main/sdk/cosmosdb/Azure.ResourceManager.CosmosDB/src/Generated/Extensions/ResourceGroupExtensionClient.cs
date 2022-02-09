// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            Client.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DatabaseAccounts in the DatabaseAccount. </summary>
        /// <returns> An object representing collection of DatabaseAccounts and their operations over a DatabaseAccount. </returns>
        public virtual DatabaseAccountCollection GetDatabaseAccounts()
        {
            return new DatabaseAccountCollection(Client, Id);
        }

        /// <summary> Gets a collection of ClusterResources in the ClusterResource. </summary>
        /// <returns> An object representing collection of ClusterResources and their operations over a ClusterResource. </returns>
        public virtual ClusterResourceCollection GetClusterResources()
        {
            return new ClusterResourceCollection(Client, Id);
        }
    }
}