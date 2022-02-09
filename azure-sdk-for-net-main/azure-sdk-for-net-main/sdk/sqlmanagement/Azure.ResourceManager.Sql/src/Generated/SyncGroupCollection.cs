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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SyncGroup and their operations over its parent. </summary>
    public partial class SyncGroupCollection : ArmCollection, IEnumerable<SyncGroup>, IAsyncEnumerable<SyncGroup>
    {
        private readonly ClientDiagnostics _syncGroupClientDiagnostics;
        private readonly SyncGroupsRestOperations _syncGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncGroupCollection"/> class for mocking. </summary>
        protected SyncGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SyncGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SyncGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SyncGroup.ResourceType, out string syncGroupApiVersion);
            _syncGroupRestClient = new SyncGroupsRestOperations(_syncGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, syncGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_CreateOrUpdate
        /// <summary> Creates or updates a sync group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="parameters"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SyncGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string syncGroupName, SyncGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SyncGroupCreateOrUpdateOperation(Client, _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_CreateOrUpdate
        /// <summary> Creates or updates a sync group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="parameters"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SyncGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string syncGroupName, SyncGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, parameters, cancellationToken);
                var operation = new SyncGroupCreateOrUpdateOperation(Client, _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Gets a sync group. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public async virtual Task<Response<SyncGroup>> GetAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _syncGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Gets a sync group. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual Response<SyncGroup> Get(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken);
                if (response.Value == null)
                    throw _syncGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_ListByDatabase
        /// <summary> Lists sync groups under a hub database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SyncGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SyncGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncGroupRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_ListByDatabase
        /// <summary> Lists sync groups under a hub database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SyncGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SyncGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncGroupRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(syncGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(syncGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public async virtual Task<Response<SyncGroup>> GetIfExistsAsync(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SyncGroup>(null, response.GetRawResponse());
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: SyncGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncGroupName"> The name of the sync group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncGroupName"/> is null. </exception>
        public virtual Response<SyncGroup> GetIfExists(string syncGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncGroupName, nameof(syncGroupName));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SyncGroup>(null, response.GetRawResponse());
                return Response.FromValue(new SyncGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SyncGroup> IEnumerable<SyncGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncGroup> IAsyncEnumerable<SyncGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}