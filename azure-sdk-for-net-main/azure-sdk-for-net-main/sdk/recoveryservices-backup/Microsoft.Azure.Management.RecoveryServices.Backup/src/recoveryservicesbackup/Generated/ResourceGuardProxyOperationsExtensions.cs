// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ResourceGuardProxyOperations.
    /// </summary>
    public static partial class ResourceGuardProxyOperationsExtensions
    {
            /// <summary>
            /// Returns ResourceGuardProxy under vault and with the name referenced in
            /// request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            public static ResourceGuardProxyBaseResource Get(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName)
            {
                return operations.GetAsync(vaultName, resourceGroupName, resourceGuardProxyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns ResourceGuardProxy under vault and with the name referenced in
            /// request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceGuardProxyBaseResource> GetAsync(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, resourceGuardProxyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add or Update ResourceGuardProxy under vault
            /// Secures vault critical operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            public static ResourceGuardProxyBaseResource Put(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName)
            {
                return operations.PutAsync(vaultName, resourceGroupName, resourceGuardProxyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add or Update ResourceGuardProxy under vault
            /// Secures vault critical operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceGuardProxyBaseResource> PutAsync(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(vaultName, resourceGroupName, resourceGuardProxyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete ResourceGuardProxy under vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            public static void Delete(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName)
            {
                operations.DeleteAsync(vaultName, resourceGroupName, resourceGuardProxyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete ResourceGuardProxy under vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(vaultName, resourceGroupName, resourceGuardProxyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Secures delete ResourceGuardProxy operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static UnlockDeleteResponse UnlockDelete(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName, UnlockDeleteRequest parameters)
            {
                return operations.UnlockDeleteAsync(vaultName, resourceGroupName, resourceGuardProxyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Secures delete ResourceGuardProxy operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='resourceGuardProxyName'>
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UnlockDeleteResponse> UnlockDeleteAsync(this IResourceGuardProxyOperations operations, string vaultName, string resourceGroupName, string resourceGuardProxyName, UnlockDeleteRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnlockDeleteWithHttpMessagesAsync(vaultName, resourceGroupName, resourceGuardProxyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}