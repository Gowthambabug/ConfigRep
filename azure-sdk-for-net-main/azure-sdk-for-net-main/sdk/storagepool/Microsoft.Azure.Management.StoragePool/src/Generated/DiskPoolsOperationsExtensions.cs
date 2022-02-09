// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiskPoolsOperations.
    /// </summary>
    public static partial class DiskPoolsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of Disk Pools in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DiskPool> ListBySubscription(this IDiskPoolsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Disk Pools in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskPool>> ListBySubscriptionAsync(this IDiskPoolsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of DiskPools in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<DiskPool> ListByResourceGroup(this IDiskPoolsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of DiskPools in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskPool>> ListByResourceGroupAsync(this IDiskPoolsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='diskPoolCreatePayload'>
            /// Request payload for Disk Pool create operation
            /// </param>
            public static DiskPool CreateOrUpdate(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, DiskPoolCreate diskPoolCreatePayload)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, diskPoolName, diskPoolCreatePayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='diskPoolCreatePayload'>
            /// Request payload for Disk Pool create operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskPool> CreateOrUpdateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, DiskPoolCreate diskPoolCreatePayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, diskPoolCreatePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='disks'>
            /// List of Azure Managed Disks to attach to a Disk Pool.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static DiskPool Update(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, IList<Disk> disks = default(IList<Disk>), IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, diskPoolName, disks, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='disks'>
            /// List of Azure Managed Disks to attach to a Disk Pool.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskPool> UpdateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, IList<Disk> disks = default(IList<Disk>), IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, disks, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void Delete(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.DeleteAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static DiskPool Get(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                return operations.GetAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskPool> GetAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the network endpoints of all outbound dependencies of a Disk Pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static IPage<OutboundEnvironmentEndpoint> ListOutboundNetworkDependenciesEndpoints(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                return operations.ListOutboundNetworkDependenciesEndpointsAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the network endpoints of all outbound dependencies of a Disk Pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<OutboundEnvironmentEndpoint>> ListOutboundNetworkDependenciesEndpointsAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOutboundNetworkDependenciesEndpointsWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to start a Disk Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void Start(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.StartAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a Disk Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Shuts down the Disk Pool and releases the compute resources. You are not
            /// billed for the compute resources that this Disk Pool uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void Deallocate(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.DeallocateAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Shuts down the Disk Pool and releases the compute resources. You are not
            /// billed for the compute resources that this Disk Pool uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeallocateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or Update Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='diskPoolCreatePayload'>
            /// Request payload for Disk Pool create operation
            /// </param>
            public static DiskPool BeginCreateOrUpdate(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, DiskPoolCreate diskPoolCreatePayload)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, diskPoolName, diskPoolCreatePayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='diskPoolCreatePayload'>
            /// Request payload for Disk Pool create operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskPool> BeginCreateOrUpdateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, DiskPoolCreate diskPoolCreatePayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, diskPoolCreatePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='disks'>
            /// List of Azure Managed Disks to attach to a Disk Pool.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static DiskPool BeginUpdate(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, IList<Disk> disks = default(IList<Disk>), IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateAsync(resourceGroupName, diskPoolName, disks, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='disks'>
            /// List of Azure Managed Disks to attach to a Disk Pool.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiskPool> BeginUpdateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, IList<Disk> disks = default(IList<Disk>), IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, disks, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void BeginDelete(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.BeginDeleteAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to start a Disk Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void BeginStart(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.BeginStartAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a Disk Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Shuts down the Disk Pool and releases the compute resources. You are not
            /// billed for the compute resources that this Disk Pool uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            public static void BeginDeallocate(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName)
            {
                operations.BeginDeallocateAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Shuts down the Disk Pool and releases the compute resources. You are not
            /// billed for the compute resources that this Disk Pool uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeallocateAsync(this IDiskPoolsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of Disk Pools in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DiskPool> ListBySubscriptionNext(this IDiskPoolsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Disk Pools in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskPool>> ListBySubscriptionNextAsync(this IDiskPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of DiskPools in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DiskPool> ListByResourceGroupNext(this IDiskPoolsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of DiskPools in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiskPool>> ListByResourceGroupNextAsync(this IDiskPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the network endpoints of all outbound dependencies of a Disk Pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<OutboundEnvironmentEndpoint> ListOutboundNetworkDependenciesEndpointsNext(this IDiskPoolsOperations operations, string nextPageLink)
            {
                return operations.ListOutboundNetworkDependenciesEndpointsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the network endpoints of all outbound dependencies of a Disk Pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<OutboundEnvironmentEndpoint>> ListOutboundNetworkDependenciesEndpointsNextAsync(this IDiskPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOutboundNetworkDependenciesEndpointsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}