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
    /// <summary> A class representing collection of VirtualHubRouteTableV2 and their operations over its parent. </summary>
    public partial class VirtualHubRouteTableV2Collection : ArmCollection, IEnumerable<VirtualHubRouteTableV2>, IAsyncEnumerable<VirtualHubRouteTableV2>
    {
        private readonly ClientDiagnostics _virtualHubRouteTableV2ClientDiagnostics;
        private readonly VirtualHubRouteTableV2SRestOperations _virtualHubRouteTableV2RestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualHubRouteTableV2Collection"/> class for mocking. </summary>
        protected VirtualHubRouteTableV2Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubRouteTableV2Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualHubRouteTableV2Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualHubRouteTableV2ClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualHubRouteTableV2.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VirtualHubRouteTableV2.ResourceType, out string virtualHubRouteTableV2ApiVersion);
            _virtualHubRouteTableV2RestClient = new VirtualHubRouteTableV2SRestOperations(_virtualHubRouteTableV2ClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualHubRouteTableV2ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHub.ResourceType), nameof(id));
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public async virtual Task<VirtualHubRouteTableV2CreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualHubRouteTableV2RestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualHubRouteTableV2CreateOrUpdateOperation(Client, _virtualHubRouteTableV2ClientDiagnostics, Pipeline, _virtualHubRouteTableV2RestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters).Request, response);
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

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public virtual VirtualHubRouteTableV2CreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualHubRouteTableV2RestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken);
                var operation = new VirtualHubRouteTableV2CreateOrUpdateOperation(Client, _virtualHubRouteTableV2ClientDiagnostics, Pipeline, _virtualHubRouteTableV2RestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters).Request, response);
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

        /// <summary> Retrieves the details of a VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<VirtualHubRouteTableV2>> GetAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubRouteTableV2RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualHubRouteTableV2ClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<VirtualHubRouteTableV2> Get(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.Get");
            scope.Start();
            try
            {
                var response = _virtualHubRouteTableV2RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken);
                if (response.Value == null)
                    throw _virtualHubRouteTableV2ClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualHubRouteTableV2" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualHubRouteTableV2> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualHubRouteTableV2>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualHubRouteTableV2RestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualHubRouteTableV2>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualHubRouteTableV2RestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualHubRouteTableV2" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualHubRouteTableV2> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualHubRouteTableV2> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualHubRouteTableV2RestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualHubRouteTableV2> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualHubRouteTableV2RestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeTableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public async virtual Task<Response<VirtualHubRouteTableV2>> GetIfExistsAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualHubRouteTableV2RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualHubRouteTableV2>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<VirtualHubRouteTableV2> GetIfExists(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualHubRouteTableV2RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualHubRouteTableV2>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualHubRouteTableV2> IEnumerable<VirtualHubRouteTableV2>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualHubRouteTableV2> IAsyncEnumerable<VirtualHubRouteTableV2>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}