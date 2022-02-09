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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VirtualHub along with the instance operations that can be performed on it. </summary>
    public partial class VirtualHub : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualHub"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualHubName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualHubClientDiagnostics;
        private readonly VirtualHubsRestOperations _virtualHubRestClient;
        private readonly VirtualHubData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualHub"/> class for mocking. </summary>
        protected VirtualHub()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualHub"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualHub(ArmClient client, VirtualHubData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHub"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualHub(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string virtualHubApiVersion);
            _virtualHubRestClient = new VirtualHubsRestOperations(_virtualHubClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualHubData Data
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

        /// <summary> Gets a collection of HubVirtualNetworkConnections in the HubVirtualNetworkConnection. </summary>
        /// <returns> An object representing collection of HubVirtualNetworkConnections and their operations over a HubVirtualNetworkConnection. </returns>
        public virtual HubVirtualNetworkConnectionCollection GetHubVirtualNetworkConnections()
        {
            return new HubVirtualNetworkConnectionCollection(Client, Id);
        }

        /// <summary> Gets a collection of VirtualHubRouteTableV2s in the VirtualHubRouteTableV2. </summary>
        /// <returns> An object representing collection of VirtualHubRouteTableV2s and their operations over a VirtualHubRouteTableV2. </returns>
        public virtual VirtualHubRouteTableV2Collection GetVirtualHubRouteTableV2s()
        {
            return new VirtualHubRouteTableV2Collection(Client, Id);
        }

        /// <summary> Gets a collection of BgpConnections in the BgpConnection. </summary>
        /// <returns> An object representing collection of BgpConnections and their operations over a BgpConnection. </returns>
        public virtual BgpConnectionCollection GetBgpConnections()
        {
            return new BgpConnectionCollection(Client, Id);
        }

        /// <summary> Gets a collection of HubIpConfigurations in the HubIpConfiguration. </summary>
        /// <returns> An object representing collection of HubIpConfigurations and their operations over a HubIpConfiguration. </returns>
        public virtual HubIpConfigurationCollection GetHubIpConfigurations()
        {
            return new HubIpConfigurationCollection(Client, Id);
        }

        /// <summary> Gets a collection of HubRouteTables in the HubRouteTable. </summary>
        /// <returns> An object representing collection of HubRouteTables and their operations over a HubRouteTable. </returns>
        public virtual HubRouteTableCollection GetHubRouteTables()
        {
            return new HubRouteTableCollection(Client, Id);
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualHub>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualHubClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHub> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Get");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _virtualHubClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualHubDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Delete");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualHubDeleteOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Delete");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VirtualHubDeleteOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="virtualHubParameters"> Parameters supplied to update VirtualHub tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubParameters"/> is null. </exception>
        public async virtual Task<Response<VirtualHub>> UpdateAsync(TagsObject virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Update");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualHubParameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="virtualHubParameters"> Parameters supplied to update VirtualHub tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubParameters"/> is null. </exception>
        public virtual Response<VirtualHub> Update(TagsObject virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.Update");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualHubParameters, cancellationToken);
                return Response.FromValue(new VirtualHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="effectiveRoutesParameters"> Parameters supplied to get the effective routes for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualHubGetEffectiveVirtualHubRoutesOperation> GetEffectiveVirtualHubRoutesAsync(bool waitForCompletion, EffectiveRoutesParameters effectiveRoutesParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetEffectiveVirtualHubRoutesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualHubGetEffectiveVirtualHubRoutesOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters).Request, response);
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

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="effectiveRoutesParameters"> Parameters supplied to get the effective routes for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubGetEffectiveVirtualHubRoutesOperation GetEffectiveVirtualHubRoutes(bool waitForCompletion, EffectiveRoutesParameters effectiveRoutesParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHub.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.GetEffectiveVirtualHubRoutes(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters, cancellationToken);
                var operation = new VirtualHubGetEffectiveVirtualHubRoutesOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters).Request, response);
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
