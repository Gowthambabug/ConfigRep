// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PlatformImagesOperations.
    /// </summary>
    public static partial class PlatformImagesOperationsExtensions
    {
            /// <summary>
            /// Returns all platform images.
            /// </summary>
            /// <remarks>
            /// Returns a list of all platform images.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            public static IList<PlatformImage> List(this IPlatformImagesOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all platform images.
            /// </summary>
            /// <remarks>
            /// Returns a list of all platform images.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PlatformImage>> ListAsync(this IPlatformImagesOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the requested platform image.
            /// </summary>
            /// <remarks>
            /// Returns the specific platform image matching publisher, offer, skus and
            /// version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            public static PlatformImage Get(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version)
            {
                return operations.GetAsync(location, publisher, offer, sku, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the requested platform image.
            /// </summary>
            /// <remarks>
            /// Returns the specific platform image matching publisher, offer, skus and
            /// version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlatformImage> GetAsync(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, publisher, offer, sku, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a platform image.
            /// </summary>
            /// <remarks>
            /// Creates a new platform image with given publisher, offer, skus and version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='newImage'>
            /// New platform image.
            /// </param>
            public static PlatformImage Create(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage)
            {
                return operations.CreateAsync(location, publisher, offer, sku, version, newImage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a platform image.
            /// </summary>
            /// <remarks>
            /// Creates a new platform image with given publisher, offer, skus and version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='newImage'>
            /// New platform image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlatformImage> CreateAsync(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(location, publisher, offer, sku, version, newImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a platform image matching publisher, offer, skus and version
            /// </summary>
            /// <remarks>
            /// Delete a platform image
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            public static void Delete(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version)
            {
                operations.DeleteAsync(location, publisher, offer, sku, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a platform image matching publisher, offer, skus and version
            /// </summary>
            /// <remarks>
            /// Delete a platform image
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(location, publisher, offer, sku, version, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a platform image.
            /// </summary>
            /// <remarks>
            /// Creates a new platform image with given publisher, offer, skus and version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='newImage'>
            /// New platform image.
            /// </param>
            public static PlatformImage BeginCreate(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage)
            {
                return operations.BeginCreateAsync(location, publisher, offer, sku, version, newImage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a platform image.
            /// </summary>
            /// <remarks>
            /// Creates a new platform image with given publisher, offer, skus and version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='publisher'>
            /// Name of the publisher.
            /// </param>
            /// <param name='offer'>
            /// Name of the offer.
            /// </param>
            /// <param name='sku'>
            /// Name of the SKU.
            /// </param>
            /// <param name='version'>
            /// The version of the resource.
            /// </param>
            /// <param name='newImage'>
            /// New platform image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlatformImage> BeginCreateAsync(this IPlatformImagesOperations operations, string location, string publisher, string offer, string sku, string version, PlatformImageParameters newImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(location, publisher, offer, sku, version, newImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
