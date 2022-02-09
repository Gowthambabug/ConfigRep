// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolBlobAuditingPoliciesOperations.
    /// </summary>
    public static partial class SqlPoolBlobAuditingPoliciesOperationsExtensions
    {
            /// <summary>
            /// Get a SQL pool's blob auditing policy
            /// </summary>
            /// <remarks>
            /// Get a SQL pool's blob auditing policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            public static SqlPoolBlobAuditingPolicy Get(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a SQL pool's blob auditing policy
            /// </summary>
            /// <remarks>
            /// Get a SQL pool's blob auditing policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolBlobAuditingPolicy> GetAsync(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a SQL pool's blob auditing policy
            /// </summary>
            /// <remarks>
            /// Creates or updates a SQL pool's blob auditing policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// The database blob auditing policy.
            /// </param>
            public static SqlPoolBlobAuditingPolicy CreateOrUpdate(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolBlobAuditingPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a SQL pool's blob auditing policy
            /// </summary>
            /// <remarks>
            /// Creates or updates a SQL pool's blob auditing policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// The database blob auditing policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolBlobAuditingPolicy> CreateOrUpdateAsync(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolBlobAuditingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists auditing settings of a Sql pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            public static IPage<SqlPoolBlobAuditingPolicy> ListBySqlPool(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.ListBySqlPoolAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists auditing settings of a Sql pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlPoolBlobAuditingPolicy>> ListBySqlPoolAsync(this ISqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySqlPoolWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists auditing settings of a Sql pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlPoolBlobAuditingPolicy> ListBySqlPoolNext(this ISqlPoolBlobAuditingPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListBySqlPoolNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists auditing settings of a Sql pool.
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
            public static async Task<IPage<SqlPoolBlobAuditingPolicy>> ListBySqlPoolNextAsync(this ISqlPoolBlobAuditingPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySqlPoolNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
