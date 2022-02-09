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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchemaTableColumn along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumn : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics;
        private readonly ManagedDatabaseColumnsRestOperations _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsRestClient;
        private readonly ClientDiagnostics _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient;
        private readonly DatabaseColumnData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumn()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumn(ArmClient client, DatabaseColumnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumn(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsApiVersion);
            _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsRestClient = new ManagedDatabaseColumnsRestOperations(_managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsApiVersion);
            _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel.ResourceType, out string managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsApiVersion);
            _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables/columns";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseColumnData Data
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

        /// <summary> Gets an object representing a ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel along with the instance operations that can be performed on it in the ManagedInstanceDatabaseSchemaTableColumn. </summary>
        /// <returns> Returns a <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel" /> object. </returns>
        public virtual ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel GetManagedInstanceDatabaseSchemaTableColumnSensitivityLabel()
        {
            return new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(Client, new ResourceIdentifier(Id.ToString() + "/sensitivityLabels/current"));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumn>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumn> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _managedInstanceDatabaseSchemaTableColumnManagedDatabaseColumnsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/disable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DisableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/disable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/enable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> EnableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/recommended/enable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsClientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseSchemaTableColumnSensitivityLabelManagedDatabaseSensitivityLabelsRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
