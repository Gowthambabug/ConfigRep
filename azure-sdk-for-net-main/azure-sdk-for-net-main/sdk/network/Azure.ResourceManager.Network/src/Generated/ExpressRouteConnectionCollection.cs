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
    /// <summary> A class representing collection of ExpressRouteConnection and their operations over its parent. </summary>
    public partial class ExpressRouteConnectionCollection : ArmCollection, IEnumerable<ExpressRouteConnection>, IAsyncEnumerable<ExpressRouteConnection>
    {
        private readonly ClientDiagnostics _expressRouteConnectionClientDiagnostics;
        private readonly ExpressRouteConnectionsRestOperations _expressRouteConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteConnection.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ExpressRouteConnection.ResourceType, out string expressRouteConnectionApiVersion);
            _expressRouteConnectionRestClient = new ExpressRouteConnectionsRestOperations(_expressRouteConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteGateway.ResourceType), nameof(id));
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteConnectionCreateOrUpdateOperation(Client, _expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
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

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual ExpressRouteConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken);
                var operation = new ExpressRouteConnectionCreateOrUpdateOperation(Client, _expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
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

        /// <summary> Gets the specified ExpressRouteConnection. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified ExpressRouteConnection. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Exists");
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
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Exists");
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
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteConnection> IEnumerable<ExpressRouteConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteConnection> IAsyncEnumerable<ExpressRouteConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
