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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataMaskingRulesOperations.
    /// </summary>
    public static partial class DataMaskingRulesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a Sql pool data masking rule.
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
            /// <param name='dataMaskingRuleName'>
            /// The name of the data masking rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a data masking rule.
            /// </param>
            public static DataMaskingRule CreateOrUpdate(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string dataMaskingRuleName, DataMaskingRule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, dataMaskingRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Sql pool data masking rule.
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
            /// <param name='dataMaskingRuleName'>
            /// The name of the data masking rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a data masking rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataMaskingRule> CreateOrUpdateAsync(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string dataMaskingRuleName, DataMaskingRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, dataMaskingRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specific Sql pool data masking rule.
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
            /// <param name='dataMaskingRuleName'>
            /// The name of the data masking rule.
            /// </param>
            public static DataMaskingRule Get(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string dataMaskingRuleName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, dataMaskingRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specific Sql pool data masking rule.
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
            /// <param name='dataMaskingRuleName'>
            /// The name of the data masking rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataMaskingRule> GetAsync(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string dataMaskingRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, dataMaskingRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of Sql pool data masking rules.
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
            public static IEnumerable<DataMaskingRule> ListBySqlPool(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.ListBySqlPoolAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Sql pool data masking rules.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DataMaskingRule>> ListBySqlPoolAsync(this IDataMaskingRulesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySqlPoolWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
