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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Acquires server DNS alias from another server. </summary>
    public partial class ServerDnsAliasAcquireOperation : Operation<ServerDnsAliasData>, IOperationSource<ServerDnsAliasData>
    {
        private readonly OperationInternals<ServerDnsAliasData> _operation;

        /// <summary> Initializes a new instance of ServerDnsAliasAcquireOperation for mocking. </summary>
        protected ServerDnsAliasAcquireOperation()
        {
        }

        internal ServerDnsAliasAcquireOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServerDnsAliasData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServerDnsAliasAcquireOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerDnsAliasData Value => _operation.Value;

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
        public override ValueTask<Response<ServerDnsAliasData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerDnsAliasData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerDnsAliasData IOperationSource<ServerDnsAliasData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ServerDnsAliasData.DeserializeServerDnsAliasData(document.RootElement);
        }

        async ValueTask<ServerDnsAliasData> IOperationSource<ServerDnsAliasData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ServerDnsAliasData.DeserializeServerDnsAliasData(document.RootElement);
        }
    }
}