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
    /// <summary> A class representing collection of JobCredential and their operations over its parent. </summary>
    public partial class JobCredentialCollection : ArmCollection, IEnumerable<JobCredential>, IAsyncEnumerable<JobCredential>
    {
        private readonly ClientDiagnostics _jobCredentialClientDiagnostics;
        private readonly JobCredentialsRestOperations _jobCredentialRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobCredentialCollection"/> class for mocking. </summary>
        protected JobCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobCredentialClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", JobCredential.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(JobCredential.ResourceType, out string jobCredentialApiVersion);
            _jobCredentialRestClient = new JobCredentialsRestOperations(_jobCredentialClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, jobCredentialApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobAgent.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobAgent.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_CreateOrUpdate
        /// <summary> Creates or updates a job credential. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="parameters"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<JobCredentialCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string credentialName, JobCredentialData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new JobCredentialCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_CreateOrUpdate
        /// <summary> Creates or updates a job credential. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="parameters"> The requested job credential state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual JobCredentialCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string credentialName, JobCredentialData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, parameters, cancellationToken);
                var operation = new JobCredentialCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Gets a jobs credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<JobCredential>> GetAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _jobCredentialClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobCredential(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Gets a jobs credential. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredential> Get(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken);
                if (response.Value == null)
                    throw _jobCredentialClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobCredential(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_ListByAgent
        /// <summary> Gets a list of jobs credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobCredential" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobCredential> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobCredential>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobCredential>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobCredentialRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_ListByAgent
        /// <summary> Gets a list of jobs credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobCredential" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobCredential> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobCredential> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobCredential> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobCredentialRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobCredential(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(credentialName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public async virtual Task<Response<JobCredential>> GetIfExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobCredential>(null, response.GetRawResponse());
                return Response.FromValue(new JobCredential(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/credentials/{credentialName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// OperationId: JobCredentials_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="credentialName"> The name of the credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<JobCredential> GetIfExists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _jobCredentialClientDiagnostics.CreateScope("JobCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, credentialName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobCredential>(null, response.GetRawResponse());
                return Response.FromValue(new JobCredential(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobCredential> IEnumerable<JobCredential>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobCredential> IAsyncEnumerable<JobCredential>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
