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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BookmarkRelationsOperations.
    /// </summary>
    public static partial class BookmarkRelationsOperationsExtensions
    {
            /// <summary>
            /// Gets all bookmark relations.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            public static IPage<Relation> List(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, ODataQuery<Relation> odataQuery = default(ODataQuery<Relation>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, bookmarkId, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all bookmark relations.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
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
            public static async Task<IPage<Relation>> ListAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, ODataQuery<Relation> odataQuery = default(ODataQuery<Relation>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, bookmarkId, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            public static Relation Get(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, bookmarkId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Relation> GetAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, bookmarkId, relationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relatedResourceId'>
            /// The resource ID of the related resource
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            public static Relation CreateOrUpdate(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName, string relatedResourceId, string etag = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, bookmarkId, relationName, relatedResourceId, etag).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relatedResourceId'>
            /// The resource ID of the related resource
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Relation> CreateOrUpdateAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName, string relatedResourceId, string etag = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, bookmarkId, relationName, relatedResourceId, etag, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            public static void Delete(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, bookmarkId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the bookmark relation.
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
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, bookmarkId, relationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all bookmark relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Relation> ListNext(this IBookmarkRelationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all bookmark relations.
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
            public static async Task<IPage<Relation>> ListNextAsync(this IBookmarkRelationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
