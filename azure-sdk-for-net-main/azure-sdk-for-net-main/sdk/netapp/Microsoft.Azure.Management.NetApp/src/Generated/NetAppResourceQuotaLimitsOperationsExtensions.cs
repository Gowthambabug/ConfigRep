// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NetAppResourceQuotaLimitsOperations.
    /// </summary>
    public static partial class NetAppResourceQuotaLimitsOperationsExtensions
    {
            /// <summary>
            /// Get quota limits
            /// </summary>
            /// <remarks>
            /// Get the default and current limits for quotas
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            public static IEnumerable<SubscriptionQuotaItem> List(this INetAppResourceQuotaLimitsOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get quota limits
            /// </summary>
            /// <remarks>
            /// Get the default and current limits for quotas
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<SubscriptionQuotaItem>> ListAsync(this INetAppResourceQuotaLimitsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get quota limits
            /// </summary>
            /// <remarks>
            /// Get the default and current subscription quota limit
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            /// <param name='quotaLimitName'>
            /// The name of the Quota Limit
            /// </param>
            public static SubscriptionQuotaItem Get(this INetAppResourceQuotaLimitsOperations operations, string location, string quotaLimitName)
            {
                return operations.GetAsync(location, quotaLimitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get quota limits
            /// </summary>
            /// <remarks>
            /// Get the default and current subscription quota limit
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            /// <param name='quotaLimitName'>
            /// The name of the Quota Limit
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionQuotaItem> GetAsync(this INetAppResourceQuotaLimitsOperations operations, string location, string quotaLimitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, quotaLimitName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}