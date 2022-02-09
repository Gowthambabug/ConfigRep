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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of RouteTable and their operations over its parent. </summary>
    public partial class RouteTableCollection : ArmCollection, IEnumerable<RouteTable>, IAsyncEnumerable<RouteTable>
    {
        private readonly ClientDiagnostics _routeTableClientDiagnostics;
        private readonly RouteTablesRestOperations _routeTableRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteTableCollection"/> class for mocking. </summary>
        protected RouteTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RouteTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routeTableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RouteTable.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(RouteTable.ResourceType, out string routeTableApiVersion);
            _routeTableRestClient = new RouteTablesRestOperations(_routeTableClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, routeTableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RouteTableCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string routeTableName, RouteTableData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeTableRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteTableCreateOrUpdateOperation(Client, _routeTableClientDiagnostics, Pipeline, _routeTableRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters).Request, response);
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

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RouteTableCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string routeTableName, RouteTableData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeTableRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters, cancellationToken);
                var operation = new RouteTableCreateOrUpdateOperation(Client, _routeTableClientDiagnostics, Pipeline, _routeTableRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters).Request, response);
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

        /// <summary> Gets the specified route table. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<RouteTable>> GetAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _routeTableClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RouteTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route table. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<RouteTable> Get(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = _routeTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken);
                if (response.Value == null)
                    throw _routeTableClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeTableRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeTableRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RouteTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeTableRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeTableRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeTableName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeTableName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<RouteTable>> GetIfExistsAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routeTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RouteTable>(null, response.GetRawResponse());
                return Response.FromValue(new RouteTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<RouteTable> GetIfExists(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _routeTableClientDiagnostics.CreateScope("RouteTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RouteTable>(null, response.GetRawResponse());
                return Response.FromValue(new RouteTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteTable> IEnumerable<RouteTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteTable> IAsyncEnumerable<RouteTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}