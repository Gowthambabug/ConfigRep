// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of ServiceBusNamespaces in the ServiceBusNamespace. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServiceBusNamespaces and their operations over a ServiceBusNamespace. </returns>
        public static ServiceBusNamespaceCollection GetServiceBusNamespaces(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetServiceBusNamespaces();
        }
    }
}
