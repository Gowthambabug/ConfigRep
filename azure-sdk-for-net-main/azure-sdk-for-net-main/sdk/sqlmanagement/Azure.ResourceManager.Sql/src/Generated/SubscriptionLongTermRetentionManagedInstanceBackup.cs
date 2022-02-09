// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
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
    /// <summary> A Class representing a SubscriptionLongTermRetentionManagedInstanceBackup along with the instance operations that can be performed on it. </summary>
    public partial class SubscriptionLongTermRetentionManagedInstanceBackup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionLongTermRetentionManagedInstanceBackup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string managedInstanceName, string databaseName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient;
        private readonly ManagedInstanceLongTermRetentionBackupData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackup"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionManagedInstanceBackup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionLongTermRetentionManagedInstanceBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionLongTermRetentionManagedInstanceBackup(ArmClient client, ManagedInstanceLongTermRetentionBackupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionManagedInstanceBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionLongTermRetentionManagedInstanceBackup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
            _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(_subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/longTermRetentionManagedInstances/longTermRetentionDatabases/longTermRetentionManagedInstanceBackups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceLongTermRetentionBackupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Get
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SubscriptionLongTermRetentionManagedInstanceBackup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackup.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Get
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionLongTermRetentionManagedInstanceBackup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackup.Get");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Delete
        /// <summary> Deletes a long term retention backup. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubscriptionLongTermRetentionManagedInstanceBackupDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackup.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.DeleteAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionLongTermRetentionManagedInstanceBackupDeleteOperation(_subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_Delete
        /// <summary> Deletes a long term retention backup. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubscriptionLongTermRetentionManagedInstanceBackupDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionManagedInstanceBackup.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.Delete(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SubscriptionLongTermRetentionManagedInstanceBackupDeleteOperation(_subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, _subscriptionLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
