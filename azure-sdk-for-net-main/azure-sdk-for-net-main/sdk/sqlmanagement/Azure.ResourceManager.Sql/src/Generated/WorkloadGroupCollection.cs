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
    /// <summary> A class representing collection of WorkloadGroup and their operations over its parent. </summary>
    public partial class WorkloadGroupCollection : ArmCollection, IEnumerable<WorkloadGroup>, IAsyncEnumerable<WorkloadGroup>
    {
        private readonly ClientDiagnostics _workloadGroupClientDiagnostics;
        private readonly WorkloadGroupsRestOperations _workloadGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupCollection"/> class for mocking. </summary>
        protected WorkloadGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", WorkloadGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(WorkloadGroup.ResourceType, out string workloadGroupApiVersion);
            _workloadGroupRestClient = new WorkloadGroupsRestOperations(_workloadGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, workloadGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_CreateOrUpdate
        /// <summary> Creates or updates a workload group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="parameters"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WorkloadGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string workloadGroupName, WorkloadGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadGroupCreateOrUpdateOperation(Client, _workloadGroupClientDiagnostics, Pipeline, _workloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_CreateOrUpdate
        /// <summary> Creates or updates a workload group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="parameters"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WorkloadGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string workloadGroupName, WorkloadGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters, cancellationToken);
                var operation = new WorkloadGroupCreateOrUpdateOperation(Client, _workloadGroupClientDiagnostics, Pipeline, _workloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Gets a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<WorkloadGroup>> GetAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _workloadGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WorkloadGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Gets a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<WorkloadGroup> Get(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken);
                if (response.Value == null)
                    throw _workloadGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_ListByDatabase
        /// <summary> Gets the list of workload groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkloadGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadGroupRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkloadGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadGroupRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_ListByDatabase
        /// <summary> Gets the list of workload groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WorkloadGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadGroupRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkloadGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadGroupRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(workloadGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<WorkloadGroup>> GetIfExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WorkloadGroup>(null, response.GetRawResponse());
                return Response.FromValue(new WorkloadGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<WorkloadGroup> GetIfExists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _workloadGroupClientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WorkloadGroup>(null, response.GetRawResponse());
                return Response.FromValue(new WorkloadGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadGroup> IEnumerable<WorkloadGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadGroup> IAsyncEnumerable<WorkloadGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
