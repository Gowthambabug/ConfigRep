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
    /// <summary> A Class representing a InstanceFailoverGroup along with the instance operations that can be performed on it. </summary>
    public partial class InstanceFailoverGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="InstanceFailoverGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string locationName, string failoverGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _instanceFailoverGroupClientDiagnostics;
        private readonly InstanceFailoverGroupsRestOperations _instanceFailoverGroupRestClient;
        private readonly InstanceFailoverGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroup"/> class for mocking. </summary>
        protected InstanceFailoverGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "InstanceFailoverGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal InstanceFailoverGroup(ArmClient client, InstanceFailoverGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal InstanceFailoverGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _instanceFailoverGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string instanceFailoverGroupApiVersion);
            _instanceFailoverGroupRestClient = new InstanceFailoverGroupsRestOperations(_instanceFailoverGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, instanceFailoverGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/instanceFailoverGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual InstanceFailoverGroupData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<InstanceFailoverGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Get");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _instanceFailoverGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<InstanceFailoverGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Get");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _instanceFailoverGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Delete
        /// <summary> Deletes a failover group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<InstanceFailoverGroupDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Delete");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new InstanceFailoverGroupDeleteOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Delete
        /// <summary> Deletes a failover group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual InstanceFailoverGroupDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Delete");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new InstanceFailoverGroupDeleteOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}/failover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Failover
        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<InstanceFailoverGroupFailoverOperation> FailoverAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Failover");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.FailoverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new InstanceFailoverGroupFailoverOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateFailoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}/failover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_Failover
        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual InstanceFailoverGroupFailoverOperation Failover(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.Failover");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Failover(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new InstanceFailoverGroupFailoverOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateFailoverRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}/forceFailoverAllowDataLoss
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_ForceFailoverAllowDataLoss
        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<InstanceFailoverGroupForceFailoverAllowDataLossOperation> ForceFailoverAllowDataLossAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.ForceFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.ForceFailoverAllowDataLossAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new InstanceFailoverGroupForceFailoverAllowDataLossOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateForceFailoverAllowDataLossRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}/forceFailoverAllowDataLoss
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}
        /// OperationId: InstanceFailoverGroups_ForceFailoverAllowDataLoss
        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual InstanceFailoverGroupForceFailoverAllowDataLossOperation ForceFailoverAllowDataLoss(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroup.ForceFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.ForceFailoverAllowDataLoss(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new InstanceFailoverGroupForceFailoverAllowDataLossOperation(_instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateForceFailoverAllowDataLossRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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
    }
}