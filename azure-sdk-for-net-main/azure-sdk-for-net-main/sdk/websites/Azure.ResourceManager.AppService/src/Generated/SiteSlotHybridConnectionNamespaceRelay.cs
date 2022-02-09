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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteSlotHybridConnectionNamespaceRelay along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotHybridConnectionNamespaceRelay : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotHybridConnectionNamespaceRelay"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string namespaceName, string relayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient;
        private readonly HybridConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelay"/> class for mocking. </summary>
        protected SiteSlotHybridConnectionNamespaceRelay()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotHybridConnectionNamespaceRelay"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotHybridConnectionNamespaceRelay(ArmClient client, HybridConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelay"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotHybridConnectionNamespaceRelay(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
            _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient = new WebAppsRestOperations(_siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridConnectionData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Get");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_DeleteHybridConnectionSlot
        /// <summary> Description for Removes a Hybrid Connection from this site. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SiteSlotHybridConnectionNamespaceRelayDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.DeleteHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotHybridConnectionNamespaceRelayDeleteOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_DeleteHybridConnectionSlot
        /// <summary> Description for Removes a Hybrid Connection from this site. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SiteSlotHybridConnectionNamespaceRelayDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.DeleteHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SiteSlotHybridConnectionNamespaceRelayDeleteOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_UpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> UpdateAsync(HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.UpdateHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// OperationId: WebApps_UpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> Update(HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelay.Update");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.UpdateHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, connectionEnvelope, cancellationToken);
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
