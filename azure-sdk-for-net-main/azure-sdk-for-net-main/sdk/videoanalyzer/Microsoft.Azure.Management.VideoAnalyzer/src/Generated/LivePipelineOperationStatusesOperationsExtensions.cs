// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LivePipelineOperationStatusesOperations.
    /// </summary>
    public static partial class LivePipelineOperationStatusesOperationsExtensions
    {
            /// <summary>
            /// Get the operation status
            /// </summary>
            /// <remarks>
            /// Get the operation status of a live pipeline.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='livePipelineName'>
            /// Live pipeline unique identifier.
            /// </param>
            /// <param name='operationId'>
            /// The operation ID.
            /// </param>
            public static LivePipelineOperationStatus Get(this ILivePipelineOperationStatusesOperations operations, string resourceGroupName, string accountName, string livePipelineName, string operationId)
            {
                return operations.GetAsync(resourceGroupName, accountName, livePipelineName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the operation status
            /// </summary>
            /// <remarks>
            /// Get the operation status of a live pipeline.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='livePipelineName'>
            /// Live pipeline unique identifier.
            /// </param>
            /// <param name='operationId'>
            /// The operation ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivePipelineOperationStatus> GetAsync(this ILivePipelineOperationStatusesOperations operations, string resourceGroupName, string accountName, string livePipelineName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, livePipelineName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
