// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto
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
            /// Returns the list of private endpoint connections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            public static IEnumerable<PrivateEndpointConnection> List(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of private endpoint connections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PrivateEndpointConnection>> ListAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection BeginCreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginCreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string clusterName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
