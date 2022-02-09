// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateCloudsOperations.
    /// </summary>
    public static partial class PrivateCloudsOperationsExtensions
    {
            /// <summary>
            /// List private clouds in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<PrivateCloud> List(this IPrivateCloudsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private clouds in a resource group
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
            public static async Task<IPage<PrivateCloud>> ListAsync(this IPrivateCloudsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List private clouds in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateCloud> ListInSubscription(this IPrivateCloudsOperations operations)
            {
                return operations.ListInSubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private clouds in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateCloud>> ListInSubscriptionAsync(this IPrivateCloudsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInSubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static PrivateCloud Get(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateCloud> GetAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloud'>
            /// The private cloud
            /// </param>
            public static PrivateCloud CreateOrUpdate(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloud privateCloud)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateCloudName, privateCloud).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloud'>
            /// The private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateCloud> CreateOrUpdateAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloud privateCloud, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, privateCloud, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloudUpdate'>
            /// The private cloud properties to be updated
            /// </param>
            public static PrivateCloud Update(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloudUpdate privateCloudUpdate)
            {
                return operations.UpdateAsync(resourceGroupName, privateCloudName, privateCloudUpdate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloudUpdate'>
            /// The private cloud properties to be updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateCloud> UpdateAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloudUpdate privateCloudUpdate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, privateCloudUpdate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void Delete(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.DeleteAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Rotate the vCenter password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void RotateVcenterPassword(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.RotateVcenterPasswordAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rotate the vCenter password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RotateVcenterPasswordAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RotateVcenterPasswordWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Rotate the NSX-T Manager password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void RotateNsxtPassword(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.RotateNsxtPasswordAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rotate the NSX-T Manager password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RotateNsxtPasswordAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RotateNsxtPasswordWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List the admin credentials for the private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static AdminCredentials ListAdminCredentials(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                return operations.ListAdminCredentialsAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the admin credentials for the private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdminCredentials> ListAdminCredentialsAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAdminCredentialsWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloud'>
            /// The private cloud
            /// </param>
            public static PrivateCloud BeginCreateOrUpdate(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloud privateCloud)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, privateCloudName, privateCloud).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloud'>
            /// The private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateCloud> BeginCreateOrUpdateAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloud privateCloud, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, privateCloud, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloudUpdate'>
            /// The private cloud properties to be updated
            /// </param>
            public static PrivateCloud BeginUpdate(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloudUpdate privateCloudUpdate)
            {
                return operations.BeginUpdateAsync(resourceGroupName, privateCloudName, privateCloudUpdate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='privateCloudUpdate'>
            /// The private cloud properties to be updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateCloud> BeginUpdateAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, PrivateCloudUpdate privateCloudUpdate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, privateCloudUpdate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void BeginDelete(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.BeginDeleteAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Rotate the vCenter password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void BeginRotateVcenterPassword(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.BeginRotateVcenterPasswordAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rotate the vCenter password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRotateVcenterPasswordAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRotateVcenterPasswordWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Rotate the NSX-T Manager password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static void BeginRotateNsxtPassword(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName)
            {
                operations.BeginRotateNsxtPasswordAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rotate the NSX-T Manager password
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRotateNsxtPasswordAsync(this IPrivateCloudsOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRotateNsxtPasswordWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List private clouds in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateCloud> ListNext(this IPrivateCloudsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private clouds in a resource group
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
            public static async Task<IPage<PrivateCloud>> ListNextAsync(this IPrivateCloudsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List private clouds in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateCloud> ListInSubscriptionNext(this IPrivateCloudsOperations operations, string nextPageLink)
            {
                return operations.ListInSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private clouds in a subscription
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
            public static async Task<IPage<PrivateCloud>> ListInSubscriptionNextAsync(this IPrivateCloudsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}