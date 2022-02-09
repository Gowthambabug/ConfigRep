// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Start capturing network packets for the site. </summary>
    public partial class SiteSlotStartNetworkTraceSlotOperation : Operation<IReadOnlyList<NetworkTrace>>, IOperationSource<IReadOnlyList<NetworkTrace>>
    {
        private readonly OperationInternals<IReadOnlyList<NetworkTrace>> _operation;

        /// <summary> Initializes a new instance of SiteSlotStartNetworkTraceSlotOperation for mocking. </summary>
        protected SiteSlotStartNetworkTraceSlotOperation()
        {
        }

        internal SiteSlotStartNetworkTraceSlotOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<IReadOnlyList<NetworkTrace>>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteSlotStartNetworkTraceSlotOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override IReadOnlyList<NetworkTrace> Value => _operation.Value;

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
        public override ValueTask<Response<IReadOnlyList<NetworkTrace>>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<IReadOnlyList<NetworkTrace>>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        IReadOnlyList<NetworkTrace> IOperationSource<IReadOnlyList<NetworkTrace>>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            List<NetworkTrace> array = new List<NetworkTrace>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(NetworkTrace.DeserializeNetworkTrace(item));
            }
            return array;
        }

        async ValueTask<IReadOnlyList<NetworkTrace>> IOperationSource<IReadOnlyList<NetworkTrace>>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            List<NetworkTrace> array = new List<NetworkTrace>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(NetworkTrace.DeserializeNetworkTrace(item));
            }
            return array;
        }
    }
}
