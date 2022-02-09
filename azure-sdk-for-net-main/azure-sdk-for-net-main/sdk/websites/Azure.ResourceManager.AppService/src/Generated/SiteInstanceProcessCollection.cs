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
    /// <summary> A class representing collection of ProcessInfo and their operations over its parent. </summary>
    public partial class SiteInstanceProcessCollection : ArmCollection, IEnumerable<SiteInstanceProcess>, IAsyncEnumerable<SiteInstanceProcess>
    {
        private readonly ClientDiagnostics _siteInstanceProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessCollection"/> class for mocking. </summary>
        protected SiteInstanceProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteInstanceProcessCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteInstanceProcess.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteInstanceProcess.ResourceType, out string siteInstanceProcessWebAppsApiVersion);
            _siteInstanceProcessWebAppsRestClient = new WebAppsRestOperations(_siteInstanceProcessWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteInstanceProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteInstance.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteInstanceProcess>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.GetInstanceProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteInstanceProcessWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteInstanceProcess> Get(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.GetInstanceProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw _siteInstanceProcessWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_ListInstanceProcesses
        /// <summary> Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteInstanceProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteInstanceProcess> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteInstanceProcess>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceProcessWebAppsRestClient.ListInstanceProcessesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteInstanceProcess>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceProcessWebAppsRestClient.ListInstanceProcessesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_ListInstanceProcesses
        /// <summary> Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteInstanceProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteInstanceProcess> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteInstanceProcess> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceProcessWebAppsRestClient.ListInstanceProcesses(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteInstanceProcess> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceProcessWebAppsRestClient.ListInstanceProcessesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(processId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteInstanceProcess>> GetIfExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessWebAppsRestClient.GetInstanceProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteInstanceProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// OperationId: WebApps_GetInstanceProcess
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteInstanceProcess> GetIfExists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessWebAppsRestClient.GetInstanceProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteInstanceProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteInstanceProcess> IEnumerable<SiteInstanceProcess>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteInstanceProcess> IAsyncEnumerable<SiteInstanceProcess>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}