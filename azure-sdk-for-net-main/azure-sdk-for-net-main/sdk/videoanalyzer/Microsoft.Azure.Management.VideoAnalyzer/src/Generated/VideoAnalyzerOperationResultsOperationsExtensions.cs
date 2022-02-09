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
    /// Extension methods for VideoAnalyzerOperationResultsOperations.
    /// </summary>
    public static partial class VideoAnalyzerOperationResultsOperationsExtensions
    {
            /// <summary>
            /// Get operation result.
            /// </summary>
            /// <remarks>
            /// Get video analyzer operation result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// Location name.
            /// </param>
            /// <param name='operationId'>
            /// Operation Id.
            /// </param>
            public static VideoAnalyzerAccount Get(this IVideoAnalyzerOperationResultsOperations operations, string locationName, string operationId)
            {
                return operations.GetAsync(locationName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get operation result.
            /// </summary>
            /// <remarks>
            /// Get video analyzer operation result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// Location name.
            /// </param>
            /// <param name='operationId'>
            /// Operation Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> GetAsync(this IVideoAnalyzerOperationResultsOperations operations, string locationName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(locationName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}