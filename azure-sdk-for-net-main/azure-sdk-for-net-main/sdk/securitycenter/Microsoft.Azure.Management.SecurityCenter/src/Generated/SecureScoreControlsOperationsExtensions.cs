// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecureScoreControlsOperations.
    /// </summary>
    public static partial class SecureScoreControlsOperationsExtensions
    {
            /// <summary>
            /// Get all security controls for a specific initiative within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='secureScoreName'>
            /// The initiative name. For the ASC Default initiative, use 'ascScore' as in
            /// the sample request below.
            /// </param>
            /// <param name='expand'>
            /// OData expand. Optional. Possible values include: 'definition'
            /// </param>
            public static IPage<SecureScoreControlDetails> ListBySecureScore(this ISecureScoreControlsOperations operations, string secureScoreName, string expand = default(string))
            {
                return operations.ListBySecureScoreAsync(secureScoreName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all security controls for a specific initiative within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='secureScoreName'>
            /// The initiative name. For the ASC Default initiative, use 'ascScore' as in
            /// the sample request below.
            /// </param>
            /// <param name='expand'>
            /// OData expand. Optional. Possible values include: 'definition'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecureScoreControlDetails>> ListBySecureScoreAsync(this ISecureScoreControlsOperations operations, string secureScoreName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySecureScoreWithHttpMessagesAsync(secureScoreName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all security controls within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// OData expand. Optional. Possible values include: 'definition'
            /// </param>
            public static IPage<SecureScoreControlDetails> List(this ISecureScoreControlsOperations operations, string expand = default(string))
            {
                return operations.ListAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all security controls within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// OData expand. Optional. Possible values include: 'definition'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecureScoreControlDetails>> ListAsync(this ISecureScoreControlsOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all security controls for a specific initiative within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecureScoreControlDetails> ListBySecureScoreNext(this ISecureScoreControlsOperations operations, string nextPageLink)
            {
                return operations.ListBySecureScoreNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all security controls for a specific initiative within a scope
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
            public static async Task<IPage<SecureScoreControlDetails>> ListBySecureScoreNextAsync(this ISecureScoreControlsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySecureScoreNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all security controls within a scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecureScoreControlDetails> ListNext(this ISecureScoreControlsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all security controls within a scope
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
            public static async Task<IPage<SecureScoreControlDetails>> ListNextAsync(this ISecureScoreControlsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
