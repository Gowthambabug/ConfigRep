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
    /// Extension methods for WatchlistItemsOperations.
    /// </summary>
    public static partial class WatchlistItemsOperationsExtensions
    {
            /// <summary>
            /// Gets all watchlist Items.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            public static IPage<WatchlistItem> List(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias)
            {
                return operations.ListAsync(resourceGroupName, workspaceName, watchlistAlias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all watchlist Items.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WatchlistItem>> ListAsync(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, watchlistAlias, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a watchlist, without its watchlist items.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            public static WatchlistItem Get(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a watchlist, without its watchlist items.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WatchlistItem> GetAsync(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a watchlist item.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            public static void Delete(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a watchlist item.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a watchlist item.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            /// <param name='watchlistItem'>
            /// The watchlist item
            /// </param>
            public static WatchlistItem CreateOrUpdate(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, WatchlistItem watchlistItem)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, watchlistItem).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a watchlist item.
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
            /// <param name='watchlistAlias'>
            /// Watchlist Alias
            /// </param>
            /// <param name='watchlistItemId'>
            /// Watchlist Item Id (GUID)
            /// </param>
            /// <param name='watchlistItem'>
            /// The watchlist item
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WatchlistItem> CreateOrUpdateAsync(this IWatchlistItemsOperations operations, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, WatchlistItem watchlistItem, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, watchlistItem, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all watchlist Items.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WatchlistItem> ListNext(this IWatchlistItemsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all watchlist Items.
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
            public static async Task<IPage<WatchlistItem>> ListNextAsync(this IWatchlistItemsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
