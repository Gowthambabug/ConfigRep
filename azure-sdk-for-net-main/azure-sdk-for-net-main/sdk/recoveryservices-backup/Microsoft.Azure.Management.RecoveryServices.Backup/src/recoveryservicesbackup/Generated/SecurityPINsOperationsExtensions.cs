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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecurityPINsOperations.
    /// </summary>
    public static partial class SecurityPINsOperationsExtensions
    {
            /// <summary>
            /// Get the security PIN.
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
            /// <param name='resourceGuardOperationRequests'>
            /// ResourceGuard Operation Requests
            /// </param>
            public static TokenInformation Get(this ISecurityPINsOperations operations, string vaultName, string resourceGroupName, IList<string> resourceGuardOperationRequests = default(IList<string>))
            {
                return operations.GetAsync(vaultName, resourceGroupName, resourceGuardOperationRequests).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the security PIN.
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
            /// <param name='resourceGuardOperationRequests'>
            /// ResourceGuard Operation Requests
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TokenInformation> GetAsync(this ISecurityPINsOperations operations, string vaultName, string resourceGroupName, IList<string> resourceGuardOperationRequests = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, resourceGuardOperationRequests, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
