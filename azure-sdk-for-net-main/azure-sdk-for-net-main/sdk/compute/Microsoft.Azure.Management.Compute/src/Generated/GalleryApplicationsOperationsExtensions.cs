// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleryApplicationsOperations.
    /// </summary>
    public static partial class GalleryApplicationsOperationsExtensions
    {
            /// <summary>
            /// Create or update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be created.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be created or updated.
            /// The allowed characters are alphabets and numbers with dots, dashes, and
            /// periods allowed in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the create or update gallery Application operation.
            /// </param>
            public static GalleryApplication CreateOrUpdate(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be created.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be created or updated.
            /// The allowed characters are alphabets and numbers with dots, dashes, and
            /// periods allowed in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the create or update gallery Application operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplication> CreateOrUpdateAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be updated.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be updated. The allowed
            /// characters are alphabets and numbers with dots, dashes, and periods allowed
            /// in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the update gallery Application operation.
            /// </param>
            public static GalleryApplication Update(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication)
            {
                return operations.UpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be updated.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be updated. The allowed
            /// characters are alphabets and numbers with dots, dashes, and periods allowed
            /// in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the update gallery Application operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplication> UpdateAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery from which the Application
            /// Definitions are to be retrieved.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be retrieved.
            /// </param>
            public static GalleryApplication Get(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName)
            {
                return operations.GetAsync(resourceGroupName, galleryName, galleryApplicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery from which the Application
            /// Definitions are to be retrieved.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplication> GetAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be deleted.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be deleted.
            /// </param>
            public static void Delete(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName)
            {
                operations.DeleteAsync(resourceGroupName, galleryName, galleryApplicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery Application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be deleted.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Application Definitions in a gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery from which Application
            /// Definitions are to be listed.
            /// </param>
            public static IPage<GalleryApplication> ListByGallery(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName)
            {
                return operations.ListByGalleryAsync(resourceGroupName, galleryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery Application Definitions in a gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery from which Application
            /// Definitions are to be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryApplication>> ListByGalleryAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryWithHttpMessagesAsync(resourceGroupName, galleryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be created.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be created or updated.
            /// The allowed characters are alphabets and numbers with dots, dashes, and
            /// periods allowed in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the create or update gallery Application operation.
            /// </param>
            public static GalleryApplication BeginCreateOrUpdate(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be created.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be created or updated.
            /// The allowed characters are alphabets and numbers with dots, dashes, and
            /// periods allowed in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the create or update gallery Application operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplication> BeginCreateOrUpdateAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be updated.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be updated. The allowed
            /// characters are alphabets and numbers with dots, dashes, and periods allowed
            /// in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the update gallery Application operation.
            /// </param>
            public static GalleryApplication BeginUpdate(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication)
            {
                return operations.BeginUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be updated.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be updated. The allowed
            /// characters are alphabets and numbers with dots, dashes, and periods allowed
            /// in the middle. The maximum length is 80 characters.
            /// </param>
            /// <param name='galleryApplication'>
            /// Parameters supplied to the update gallery Application operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplication> BeginUpdateAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplication, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be deleted.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be deleted.
            /// </param>
            public static void BeginDelete(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, galleryName, galleryApplicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery Application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition is to be deleted.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGalleryApplicationsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Application Definitions in a gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GalleryApplication> ListByGalleryNext(this IGalleryApplicationsOperations operations, string nextPageLink)
            {
                return operations.ListByGalleryNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery Application Definitions in a gallery.
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
            public static async Task<IPage<GalleryApplication>> ListByGalleryNextAsync(this IGalleryApplicationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}