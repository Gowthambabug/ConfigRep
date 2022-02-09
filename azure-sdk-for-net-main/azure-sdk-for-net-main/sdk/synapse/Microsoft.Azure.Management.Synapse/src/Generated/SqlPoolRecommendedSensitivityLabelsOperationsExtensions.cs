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
    /// Extension methods for SqlPoolRecommendedSensitivityLabelsOperations.
    /// </summary>
    public static partial class SqlPoolRecommendedSensitivityLabelsOperationsExtensions
    {
            /// <summary>
            /// Update recommended sensitivity labels states of a given SQL Pool using an
            /// operations batch.
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
            /// <param name='parameters'>
            /// </param>
            public static void Update(this ISqlPoolRecommendedSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, RecommendedSensitivityLabelUpdateList parameters)
            {
                operations.UpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update recommended sensitivity labels states of a given SQL Pool using an
            /// operations batch.
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
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISqlPoolRecommendedSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, RecommendedSensitivityLabelUpdateList parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}