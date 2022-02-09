// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableCluster> GetAvailableClusterRegionClustersAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailableClusterRegionClustersAsync(cancellationToken);
        }

        /// <summary> List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableCluster> GetAvailableClusterRegionClusters(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailableClusterRegionClusters(cancellationToken);
        }

        /// <summary> Lists the available Event Hubs Clusters within an ARM resource group. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubCluster> GetEventHubClustersAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubClustersAsync(cancellationToken);
        }

        /// <summary> Lists the available Event Hubs Clusters within an ARM resource group. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubCluster> GetEventHubClusters(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubClusters(cancellationToken);
        }

        /// <summary> Lists all the available Namespaces within a subscription, irrespective of the resource groups. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubNamespace> GetEventHubNamespacesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubNamespacesAsync(cancellationToken);
        }

        /// <summary> Lists all the available Namespaces within a subscription, irrespective of the resource groups. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubNamespace> GetEventHubNamespaces(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubNamespaces(cancellationToken);
        }

        /// <summary> Check the give Namespace name availability. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async static Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityNamespaceAsync(this Subscription subscription, CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await GetExtensionClient(subscription).CheckNameAvailabilityNamespaceAsync(parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Check the give Namespace name availability. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckNameAvailabilityNamespace(this Subscription subscription, CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return GetExtensionClient(subscription).CheckNameAvailabilityNamespace(parameters, cancellationToken);
        }
    }
}