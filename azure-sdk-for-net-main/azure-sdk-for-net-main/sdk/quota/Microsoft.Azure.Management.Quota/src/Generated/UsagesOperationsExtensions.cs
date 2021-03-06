// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsagesOperations.
    /// </summary>
    public static partial class UsagesOperationsExtensions
    {
            /// <summary>
            /// Get the current usage of a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceName'>
            /// Resource name for a given resource provider. For example:
            /// - SKU name for Microsoft.Compute
            /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
            /// For Microsoft.Network PublicIPAddresses.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotas`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            public static CurrentUsagesBase Get(this IUsagesOperations operations, string resourceName, string scope)
            {
                return operations.GetAsync(resourceName, scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the current usage of a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceName'>
            /// Resource name for a given resource provider. For example:
            /// - SKU name for Microsoft.Compute
            /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
            /// For Microsoft.Network PublicIPAddresses.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotas`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CurrentUsagesBase> GetAsync(this IUsagesOperations operations, string resourceName, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceName, scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of current usage for all resources for the scope specified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotas`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            public static IPage<CurrentUsagesBase> List(this IUsagesOperations operations, string scope)
            {
                return operations.ListAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of current usage for all resources for the scope specified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotas`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CurrentUsagesBase>> ListAsync(this IUsagesOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of current usage for all resources for the scope specified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CurrentUsagesBase> ListNext(this IUsagesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of current usage for all resources for the scope specified.
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
            public static async Task<IPage<CurrentUsagesBase>> ListNextAsync(this IUsagesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
