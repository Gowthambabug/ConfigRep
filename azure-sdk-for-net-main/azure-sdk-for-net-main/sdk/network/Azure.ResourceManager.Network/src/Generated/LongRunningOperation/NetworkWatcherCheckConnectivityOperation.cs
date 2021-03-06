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
    /// <summary> Verifies the possibility of establishing a direct TCP connection from a virtual machine to a given endpoint including another VM or an arbitrary remote server. </summary>
    public partial class NetworkWatcherCheckConnectivityOperation : Operation<ConnectivityInformation>, IOperationSource<ConnectivityInformation>
    {
        private readonly OperationInternals<ConnectivityInformation> _operation;

        /// <summary> Initializes a new instance of NetworkWatcherCheckConnectivityOperation for mocking. </summary>
        protected NetworkWatcherCheckConnectivityOperation()
        {
        }

        internal NetworkWatcherCheckConnectivityOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ConnectivityInformation>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkWatcherCheckConnectivityOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConnectivityInformation Value => _operation.Value;

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
        public override ValueTask<Response<ConnectivityInformation>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectivityInformation>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ConnectivityInformation IOperationSource<ConnectivityInformation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectivityInformation.DeserializeConnectivityInformation(document.RootElement);
        }

        async ValueTask<ConnectivityInformation> IOperationSource<ConnectivityInformation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectivityInformation.DeserializeConnectivityInformation(document.RootElement);
        }
    }
}
