// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ThreatIntelligenceIndicatorsOperations.
    /// </summary>
    public static partial class ThreatIntelligenceIndicatorsOperationsExtensions
    {
            /// <summary>
            /// Get all threat intelligence indicators.
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
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition. Optional.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results. Optional.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. Optional.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            public static IPage<ThreatIntelligenceInformation> List(this IThreatIntelligenceIndicatorsOperations operations, string resourceGroupName, string workspaceName, string filter = default(string), string orderby = default(string), int? top = default(int?), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, filter, orderby, top, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all threat intelligence indicators.
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
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition. Optional.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results. Optional.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. Optional.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ThreatIntelligenceInformation>> ListAsync(this IThreatIntelligenceIndicatorsOperations operations, string resourceGroupName, string workspaceName, string filter = default(string), string orderby = default(string), int? top = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, filter, orderby, top, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all threat intelligence indicators.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ThreatIntelligenceInformation> ListNext(this IThreatIntelligenceIndicatorsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all threat intelligence indicators.
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
            public static async Task<IPage<ThreatIntelligenceInformation>> ListNextAsync(this IThreatIntelligenceIndicatorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}