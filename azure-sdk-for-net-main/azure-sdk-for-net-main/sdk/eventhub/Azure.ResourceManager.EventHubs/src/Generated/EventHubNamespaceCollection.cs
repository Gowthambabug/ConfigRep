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
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of EventHubNamespace and their operations over its parent. </summary>
    public partial class EventHubNamespaceCollection : ArmCollection, IEnumerable<EventHubNamespace>, IAsyncEnumerable<EventHubNamespace>
    {
        private readonly ClientDiagnostics _eventHubNamespaceClientDiagnostics;
        private readonly EventHubNamespacesRestOperations _eventHubNamespaceRestClient;
        private readonly ClientDiagnostics _eventHubNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _eventHubNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubNamespaceCollection"/> class for mocking. </summary>
        protected EventHubNamespaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubNamespaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubNamespaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubNamespaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubNamespace.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(EventHubNamespace.ResourceType, out string eventHubNamespaceApiVersion);
            _eventHubNamespaceRestClient = new EventHubNamespacesRestOperations(_eventHubNamespaceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubNamespaceApiVersion);
            _eventHubNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubNamespace.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(EventHubNamespace.ResourceType, out string eventHubNamespaceNamespacesApiVersion);
            _eventHubNamespaceNamespacesRestClient = new NamespacesRestOperations(_eventHubNamespaceNamespacesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubNamespaceNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="parameters"> Parameters for creating a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<EventHubNamespaceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string namespaceName, EventHubNamespaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _eventHubNamespaceClientDiagnostics.CreateScope("EventHubNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubNamespaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubNamespaceCreateOrUpdateOperation(Client, _eventHubNamespaceClientDiagnostics, Pipeline, _eventHubNamespaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters).Request, response);
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

        /// <summary> Creates or updates a namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="parameters"> Parameters for creating a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual EventHubNamespaceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string namespaceName, EventHubNamespaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _eventHubNamespaceClientDiagnostics.CreateScope("EventHubNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubNamespaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters, cancellationToken);
                var operation = new EventHubNamespaceCreateOrUpdateOperation(Client, _eventHubNamespaceClientDiagnostics, Pipeline, _eventHubNamespaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters).Request, response);
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

        /// <summary> Gets the description of the specified namespace. </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<EventHubNamespace>> GetAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _eventHubNamespaceNamespacesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EventHubNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the description of the specified namespace. </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<EventHubNamespace> Get(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken);
                if (response.Value == null)
                    throw _eventHubNamespaceNamespacesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the available Namespaces within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubNamespace> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHubNamespace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubNamespaceNamespacesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHubNamespace>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubNamespaceNamespacesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the available Namespaces within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubNamespace> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EventHubNamespace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubNamespaceNamespacesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHubNamespace> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubNamespaceNamespacesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(namespaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<EventHubNamespace>> GetIfExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EventHubNamespace>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<EventHubNamespace> GetIfExists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _eventHubNamespaceNamespacesClientDiagnostics.CreateScope("EventHubNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EventHubNamespace>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubNamespace> IEnumerable<EventHubNamespace>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubNamespace> IAsyncEnumerable<EventHubNamespace>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}