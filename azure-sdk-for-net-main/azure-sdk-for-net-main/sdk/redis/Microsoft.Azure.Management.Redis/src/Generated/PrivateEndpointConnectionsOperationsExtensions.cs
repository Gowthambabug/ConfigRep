// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// List all the private endpoint connections associated with the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            public static IEnumerable<PrivateEndpointConnection> List(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName)
            {
                return operations.ListAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the private endpoint connections associated with the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PrivateEndpointConnection>> ListAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified private endpoint connection associated with the redis
            /// cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, cacheName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified private endpoint connection associated with the redis
            /// cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, cacheName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            public static PrivateEndpointConnection Put(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, PrivateEndpointConnection properties)
            {
                return operations.PutAsync(resourceGroupName, cacheName, privateEndpointConnectionName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> PutAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(resourceGroupName, cacheName, privateEndpointConnectionName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the redis
            /// cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, cacheName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the redis
            /// cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, cacheName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            public static PrivateEndpointConnection BeginPut(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, PrivateEndpointConnection properties)
            {
                return operations.BeginPutAsync(resourceGroupName, cacheName, privateEndpointConnectionName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cacheName'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginPutAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string cacheName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPutWithHttpMessagesAsync(resourceGroupName, cacheName, privateEndpointConnectionName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}