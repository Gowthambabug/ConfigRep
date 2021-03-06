// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The VirtualNetworkGatewayConnectionResetSharedKey operation resets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
    public partial class VirtualNetworkGatewayConnectionResetSharedKeyOperation : Operation<ConnectionResetSharedKey>, IOperationSource<ConnectionResetSharedKey>
    {
        private readonly OperationInternals<ConnectionResetSharedKey> _operation;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnectionResetSharedKeyOperation for mocking. </summary>
        protected VirtualNetworkGatewayConnectionResetSharedKeyOperation()
        {
        }

        internal VirtualNetworkGatewayConnectionResetSharedKeyOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ConnectionResetSharedKey>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualNetworkGatewayConnectionResetSharedKeyOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConnectionResetSharedKey Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionResetSharedKey>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionResetSharedKey>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ConnectionResetSharedKey IOperationSource<ConnectionResetSharedKey>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectionResetSharedKey.DeserializeConnectionResetSharedKey(document.RootElement);
        }

        async ValueTask<ConnectionResetSharedKey> IOperationSource<ConnectionResetSharedKey>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectionResetSharedKey.DeserializeConnectionResetSharedKey(document.RootElement);
        }
    }
}
