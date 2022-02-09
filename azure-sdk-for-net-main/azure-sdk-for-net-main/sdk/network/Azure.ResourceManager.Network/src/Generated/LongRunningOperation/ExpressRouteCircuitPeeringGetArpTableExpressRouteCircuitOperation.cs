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
    /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
    public partial class ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation : Operation<ExpressRouteCircuitsArpTableListResult>, IOperationSource<ExpressRouteCircuitsArpTableListResult>
    {
        private readonly OperationInternals<ExpressRouteCircuitsArpTableListResult> _operation;

        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation for mocking. </summary>
        protected ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation()
        {
        }

        internal ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ExpressRouteCircuitsArpTableListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCircuitsArpTableListResult Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCircuitsArpTableListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCircuitsArpTableListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ExpressRouteCircuitsArpTableListResult IOperationSource<ExpressRouteCircuitsArpTableListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ExpressRouteCircuitsArpTableListResult.DeserializeExpressRouteCircuitsArpTableListResult(document.RootElement);
        }

        async ValueTask<ExpressRouteCircuitsArpTableListResult> IOperationSource<ExpressRouteCircuitsArpTableListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ExpressRouteCircuitsArpTableListResult.DeserializeExpressRouteCircuitsArpTableListResult(document.RootElement);
        }
    }
}
