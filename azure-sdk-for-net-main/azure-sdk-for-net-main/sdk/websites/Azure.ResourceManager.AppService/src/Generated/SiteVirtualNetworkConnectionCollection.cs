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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetInfoResource and their operations over its parent. </summary>
    public partial class SiteVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<SiteVirtualNetworkConnection>, IAsyncEnumerable<SiteVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _siteVirtualNetworkConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteVirtualNetworkConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteVirtualNetworkConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteVirtualNetworkConnection.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteVirtualNetworkConnection.ResourceType, out string siteVirtualNetworkConnectionWebAppsApiVersion);
            _siteVirtualNetworkConnectionWebAppsRestClient = new WebAppsRestOperations(_siteVirtualNetworkConnectionWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteVirtualNetworkConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateVnetConnection
        /// <summary> Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<SiteVirtualNetworkConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string vnetName, VnetInfoResourceData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteVirtualNetworkConnectionCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateVnetConnection
        /// <summary> Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual SiteVirtualNetworkConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string vnetName, VnetInfoResourceData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, connectionEnvelope, cancellationToken);
                var operation = new SiteVirtualNetworkConnectionCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Description for Gets a virtual network the app (or deployment slot) is connected to by name. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnection>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Description for Gets a virtual network the app (or deployment slot) is connected to by name. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnection> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListVnetConnections
        /// <summary> Description for Gets the virtual networks the app (or deployment slot) is connected to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteVirtualNetworkConnectionWebAppsRestClient.ListVnetConnectionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new SiteVirtualNetworkConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListVnetConnections
        /// <summary> Description for Gets the virtual networks the app (or deployment slot) is connected to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteVirtualNetworkConnectionWebAppsRestClient.ListVnetConnections(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new SiteVirtualNetworkConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnection> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteVirtualNetworkConnection> IEnumerable<SiteVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteVirtualNetworkConnection> IAsyncEnumerable<SiteVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}