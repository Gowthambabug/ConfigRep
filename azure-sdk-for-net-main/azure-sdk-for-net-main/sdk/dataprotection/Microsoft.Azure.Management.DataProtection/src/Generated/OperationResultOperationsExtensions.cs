// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OperationResultOperations.
    /// </summary>
    public static partial class OperationResultOperationsExtensions
    {
            /// <summary>
            /// Gets the operation status for a resource.
            /// </summary>
            /// <remarks>
            /// Gets the operation result for a resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='location'>
            /// </param>
            public static OperationJobExtendedInfo Get(this IOperationResultOperations operations, string operationId, string location)
            {
                return operations.GetAsync(operationId, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the operation status for a resource.
            /// </summary>
            /// <remarks>
            /// Gets the operation result for a resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationJobExtendedInfo> GetAsync(this IOperationResultOperations operations, string operationId, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(operationId, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}