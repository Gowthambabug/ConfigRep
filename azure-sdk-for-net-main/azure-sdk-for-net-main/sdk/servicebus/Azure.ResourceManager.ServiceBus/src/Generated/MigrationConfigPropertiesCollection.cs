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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of MigrationConfigProperties and their operations over its parent. </summary>
    public partial class MigrationConfigPropertiesCollection : ArmCollection, IEnumerable<MigrationConfigProperties>, IAsyncEnumerable<MigrationConfigProperties>
    {
        private readonly ClientDiagnostics _migrationConfigPropertiesMigrationConfigsClientDiagnostics;
        private readonly MigrationConfigsRestOperations _migrationConfigPropertiesMigrationConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigPropertiesCollection"/> class for mocking. </summary>
        protected MigrationConfigPropertiesCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigPropertiesCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationConfigPropertiesCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationConfigPropertiesMigrationConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", MigrationConfigProperties.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(MigrationConfigProperties.ResourceType, out string migrationConfigPropertiesMigrationConfigsApiVersion);
            _migrationConfigPropertiesMigrationConfigsRestClient = new MigrationConfigsRestOperations(_migrationConfigPropertiesMigrationConfigsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, migrationConfigPropertiesMigrationConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespace.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_CreateAndStartMigration
        /// <summary> Creates Migration configuration and starts migration of entities from Standard to Premium namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="parameters"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MigrationConfigPropertiesCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, MigrationConfigurationName configName, MigrationConfigPropertiesData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.CreateAndStartMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MigrationConfigPropertiesCreateOrUpdateOperation(Client, _migrationConfigPropertiesMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigPropertiesMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_CreateAndStartMigration
        /// <summary> Creates Migration configuration and starts migration of entities from Standard to Premium namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="parameters"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual MigrationConfigPropertiesCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, MigrationConfigurationName configName, MigrationConfigPropertiesData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.CreateAndStartMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, parameters, cancellationToken);
                var operation = new MigrationConfigPropertiesCreateOrUpdateOperation(Client, _migrationConfigPropertiesMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigPropertiesMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Retrieves Migration Config. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MigrationConfigProperties>> GetAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MigrationConfigProperties(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Retrieves Migration Config. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationConfigProperties> Get(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken);
                if (response.Value == null)
                    throw _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigProperties(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_List
        /// <summary> Gets all migrationConfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationConfigProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationConfigProperties> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MigrationConfigProperties>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _migrationConfigPropertiesMigrationConfigsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MigrationConfigProperties(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MigrationConfigProperties>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _migrationConfigPropertiesMigrationConfigsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MigrationConfigProperties(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_List
        /// <summary> Gets all migrationConfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationConfigProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationConfigProperties> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MigrationConfigProperties> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _migrationConfigPropertiesMigrationConfigsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MigrationConfigProperties(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MigrationConfigProperties> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _migrationConfigPropertiesMigrationConfigsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MigrationConfigProperties(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(configName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(configName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MigrationConfigProperties>> GetIfExistsAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MigrationConfigProperties>(null, response.GetRawResponse());
                return Response.FromValue(new MigrationConfigProperties(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: MigrationConfigs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="configName"> The configuration name. Should always be &quot;$default&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationConfigProperties> GetIfExists(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MigrationConfigProperties>(null, response.GetRawResponse());
                return Response.FromValue(new MigrationConfigProperties(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationConfigProperties> IEnumerable<MigrationConfigProperties>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationConfigProperties> IAsyncEnumerable<MigrationConfigProperties>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}