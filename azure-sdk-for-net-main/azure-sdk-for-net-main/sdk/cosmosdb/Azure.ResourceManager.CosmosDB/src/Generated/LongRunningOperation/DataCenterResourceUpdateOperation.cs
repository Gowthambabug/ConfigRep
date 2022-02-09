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
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Update some of the properties of a managed Cassandra data center. </summary>
    public partial class DataCenterResourceUpdateOperation : Operation<DataCenterResource>, IOperationSource<DataCenterResource>
    {
        private readonly OperationInternals<DataCenterResource> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of DataCenterResourceUpdateOperation for mocking. </summary>
        protected DataCenterResourceUpdateOperation()
        {
        }

        internal DataCenterResourceUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DataCenterResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DataCenterResourceUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DataCenterResource Value => _operation.Value;

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
        public override ValueTask<Response<DataCenterResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DataCenterResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DataCenterResource IOperationSource<DataCenterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataCenterResourceData.DeserializeDataCenterResourceData(document.RootElement);
            return new DataCenterResource(_armClient, data);
        }

        async ValueTask<DataCenterResource> IOperationSource<DataCenterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataCenterResourceData.DeserializeDataCenterResourceData(document.RootElement);
            return new DataCenterResource(_armClient, data);
        }
    }
}