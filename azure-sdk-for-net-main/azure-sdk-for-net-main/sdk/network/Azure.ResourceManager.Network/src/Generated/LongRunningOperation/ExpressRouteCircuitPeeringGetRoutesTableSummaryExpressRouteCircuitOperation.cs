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
    /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
    public partial class ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation : Operation<ExpressRouteCircuitsRoutesTableSummaryListResult>, IOperationSource<ExpressRouteCircuitsRoutesTableSummaryListResult>
    {
        private readonly OperationInternals<ExpressRouteCircuitsRoutesTableSummaryListResult> _operation;

        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation for mocking. </summary>
        protected ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation()
        {
        }

        internal ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ExpressRouteCircuitsRoutesTableSummaryListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCircuitsRoutesTableSummaryListResult Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCircuitsRoutesTableSummaryListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCircuitsRoutesTableSummaryListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ExpressRouteCircuitsRoutesTableSummaryListResult IOperationSource<ExpressRouteCircuitsRoutesTableSummaryListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ExpressRouteCircuitsRoutesTableSummaryListResult.DeserializeExpressRouteCircuitsRoutesTableSummaryListResult(document.RootElement);
        }

        async ValueTask<ExpressRouteCircuitsRoutesTableSummaryListResult> IOperationSource<ExpressRouteCircuitsRoutesTableSummaryListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ExpressRouteCircuitsRoutesTableSummaryListResult.DeserializeExpressRouteCircuitsRoutesTableSummaryListResult(document.RootElement);
        }
    }
}