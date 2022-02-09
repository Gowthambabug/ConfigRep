// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceDetector and their operations over its parent. </summary>
    public partial class CertificateOrderDetectorCollection : ArmCollection, IEnumerable<CertificateOrderDetector>, IAsyncEnumerable<CertificateOrderDetector>
    {
        private readonly ClientDiagnostics _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics;
        private readonly CertificateOrdersDiagnosticsRestOperations _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorCollection"/> class for mocking. </summary>
        protected CertificateOrderDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateOrderDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CertificateOrderDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", CertificateOrderDetector.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(CertificateOrderDetector.ResourceType, out string certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
            _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient = new CertificateOrdersDiagnosticsRestOperations(_certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, certificateOrderDetectorCertificateOrdersDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceCertificateOrder.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceCertificateOrder.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<CertificateOrderDetector>> GetAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CertificateOrderDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<CertificateOrderDetector> Get(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken);
                if (response.Value == null)
                    throw _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_ListAppServiceCertificateOrderDetectorResponse
        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CertificateOrderDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CertificateOrderDetector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CertificateOrderDetector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.ListAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateOrderDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CertificateOrderDetector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.ListAppServiceCertificateOrderDetectorResponseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateOrderDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_ListAppServiceCertificateOrderDetectorResponse
        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CertificateOrderDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CertificateOrderDetector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CertificateOrderDetector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.ListAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateOrderDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CertificateOrderDetector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.ListAppServiceCertificateOrderDetectorResponseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateOrderDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(detectorName, startTime: startTime, endTime: endTime, timeGrain: timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(detectorName, startTime: startTime, endTime: endTime, timeGrain: timeGrain, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<CertificateOrderDetector>> GetIfExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CertificateOrderDetector>(null, response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: CertificateOrdersDiagnostics_GetAppServiceCertificateOrderDetectorResponse
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<CertificateOrderDetector> GetIfExists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _certificateOrderDetectorCertificateOrdersDiagnosticsClientDiagnostics.CreateScope("CertificateOrderDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _certificateOrderDetectorCertificateOrdersDiagnosticsRestClient.GetAppServiceCertificateOrderDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CertificateOrderDetector>(null, response.GetRawResponse());
                return Response.FromValue(new CertificateOrderDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CertificateOrderDetector> IEnumerable<CertificateOrderDetector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CertificateOrderDetector> IAsyncEnumerable<CertificateOrderDetector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}