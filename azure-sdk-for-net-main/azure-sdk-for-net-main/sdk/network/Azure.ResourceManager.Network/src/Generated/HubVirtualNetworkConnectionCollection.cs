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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of HubVirtualNetworkConnection and their operations over its parent. </summary>
    public partial class HubVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<HubVirtualNetworkConnection>, IAsyncEnumerable<HubVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _hubVirtualNetworkConnectionClientDiagnostics;
        private readonly HubVirtualNetworkConnectionsRestOperations _hubVirtualNetworkConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected HubVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HubVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubVirtualNetworkConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", HubVirtualNetworkConnection.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(HubVirtualNetworkConnection.ResourceType, out string hubVirtualNetworkConnectionApiVersion);
            _hubVirtualNetworkConnectionRestClient = new HubVirtualNetworkConnectionsRestOperations(_hubVirtualNetworkConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, hubVirtualNetworkConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHub.ResourceType), nameof(id));
        }

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public async virtual Task<HubVirtualNetworkConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new HubVirtualNetworkConnectionCreateOrUpdateOperation(Client, _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, _hubVirtualNetworkConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
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

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public virtual HubVirtualNetworkConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken);
                var operation = new HubVirtualNetworkConnectionCreateOrUpdateOperation(Client, _hubVirtualNetworkConnectionClientDiagnostics, Pipeline, _hubVirtualNetworkConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
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

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _hubVirtualNetworkConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HubVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _hubVirtualNetworkConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubVirtualNetworkConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubVirtualNetworkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubVirtualNetworkConnectionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HubVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubVirtualNetworkConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubVirtualNetworkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubVirtualNetworkConnectionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _hubVirtualNetworkConnectionClientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HubVirtualNetworkConnection> IEnumerable<HubVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubVirtualNetworkConnection> IAsyncEnumerable<HubVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}