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
    public partial class HostingEnvironmentDetectorCollection : ArmCollection, IEnumerable<HostingEnvironmentDetector>, IAsyncEnumerable<HostingEnvironmentDetector>
    {
        private readonly ClientDiagnostics _hostingEnvironmentDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _hostingEnvironmentDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentDetectorCollection"/> class for mocking. </summary>
        protected HostingEnvironmentDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostingEnvironmentDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", HostingEnvironmentDetector.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(HostingEnvironmentDetector.ResourceType, out string hostingEnvironmentDetectorDiagnosticsApiVersion);
            _hostingEnvironmentDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(_hostingEnvironmentDetectorDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, hostingEnvironmentDetectorDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceEnvironment.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceEnvironment.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Description for Get Hosting Environment Detector Response. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentDetector>> GetAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentDetectorDiagnosticsRestClient.GetHostingEnvironmentDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Description for Get Hosting Environment Detector Response. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<HostingEnvironmentDetector> Get(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentDetectorDiagnosticsRestClient.GetHostingEnvironmentDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken);
                if (response.Value == null)
                    throw _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_ListHostingEnvironmentDetectorResponses
        /// <summary> Description for List Hosting Environment Detector Responses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostingEnvironmentDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostingEnvironmentDetector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostingEnvironmentDetector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentDetectorDiagnosticsRestClient.ListHostingEnvironmentDetectorResponsesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostingEnvironmentDetector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hostingEnvironmentDetectorDiagnosticsRestClient.ListHostingEnvironmentDetectorResponsesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_ListHostingEnvironmentDetectorResponses
        /// <summary> Description for List Hosting Environment Detector Responses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostingEnvironmentDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostingEnvironmentDetector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HostingEnvironmentDetector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentDetectorDiagnosticsRestClient.ListHostingEnvironmentDetectorResponses(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostingEnvironmentDetector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hostingEnvironmentDetectorDiagnosticsRestClient.ListHostingEnvironmentDetectorResponsesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostingEnvironmentDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.Exists");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.Exists");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<HostingEnvironmentDetector>> GetIfExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentDetectorDiagnosticsRestClient.GetHostingEnvironmentDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<HostingEnvironmentDetector>(null, response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// OperationId: Diagnostics_GetHostingEnvironmentDetectorResponse
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<HostingEnvironmentDetector> GetIfExists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _hostingEnvironmentDetectorDiagnosticsClientDiagnostics.CreateScope("HostingEnvironmentDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentDetectorDiagnosticsRestClient.GetHostingEnvironmentDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<HostingEnvironmentDetector>(null, response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostingEnvironmentDetector> IEnumerable<HostingEnvironmentDetector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostingEnvironmentDetector> IAsyncEnumerable<HostingEnvironmentDetector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}