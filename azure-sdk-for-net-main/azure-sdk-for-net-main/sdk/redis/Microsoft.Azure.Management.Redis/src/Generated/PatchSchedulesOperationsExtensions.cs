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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PatchSchedulesOperations.
    /// </summary>
    public static partial class PatchSchedulesOperationsExtensions
    {
            /// <summary>
            /// Gets all patch schedules in the specified redis cache (there is only one).
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
            public static IPage<RedisPatchSchedule> ListByRedisResource(this IPatchSchedulesOperations operations, string resourceGroupName, string cacheName)
            {
                return operations.ListByRedisResourceAsync(resourceGroupName, cacheName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all patch schedules in the specified redis cache (there is only one).
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
            public static async Task<IPage<RedisPatchSchedule>> ListByRedisResourceAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string cacheName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRedisResourceWithHttpMessagesAsync(resourceGroupName, cacheName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace the patching schedule for Redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to set the patching schedule for Redis cache.
            /// </param>
            public static RedisPatchSchedule CreateOrUpdate(this IPatchSchedulesOperations operations, string resourceGroupName, string name, RedisPatchSchedule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace the patching schedule for Redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to set the patching schedule for Redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RedisPatchSchedule> CreateOrUpdateAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, RedisPatchSchedule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the patching schedule of a redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            public static void Delete(this IPatchSchedulesOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the patching schedule of a redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the patching schedule of a redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            public static RedisPatchSchedule Get(this IPatchSchedulesOperations operations, string resourceGroupName, string name)
            {
                return operations.GetAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the patching schedule of a redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RedisPatchSchedule> GetAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all patch schedules in the specified redis cache (there is only one).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RedisPatchSchedule> ListByRedisResourceNext(this IPatchSchedulesOperations operations, string nextPageLink)
            {
                return operations.ListByRedisResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all patch schedules in the specified redis cache (there is only one).
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
            public static async Task<IPage<RedisPatchSchedule>> ListByRedisResourceNextAsync(this IPatchSchedulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRedisResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}