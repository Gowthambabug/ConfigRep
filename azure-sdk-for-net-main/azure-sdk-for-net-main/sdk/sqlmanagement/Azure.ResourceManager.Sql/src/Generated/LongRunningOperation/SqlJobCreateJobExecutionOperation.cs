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
    /// <summary> Starts an elastic job execution. </summary>
    public partial class SqlJobCreateJobExecutionOperation : Operation<JobExecutionData>, IOperationSource<JobExecutionData>
    {
        private readonly OperationInternals<JobExecutionData> _operation;

        /// <summary> Initializes a new instance of SqlJobCreateJobExecutionOperation for mocking. </summary>
        protected SqlJobCreateJobExecutionOperation()
        {
        }

        internal SqlJobCreateJobExecutionOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<JobExecutionData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlJobCreateJobExecutionOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override JobExecutionData Value => _operation.Value;

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
        public override ValueTask<Response<JobExecutionData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<JobExecutionData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        JobExecutionData IOperationSource<JobExecutionData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return JobExecutionData.DeserializeJobExecutionData(document.RootElement);
        }

        async ValueTask<JobExecutionData> IOperationSource<JobExecutionData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return JobExecutionData.DeserializeJobExecutionData(document.RootElement);
        }
    }
}