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

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Perform a database extension operation, like polybase import. </summary>
    public partial class SqlDatabaseCreateOrUpdateDatabaseExtensionOperation : Operation<ImportExportExtensionsOperationResult>, IOperationSource<ImportExportExtensionsOperationResult>
    {
        private readonly OperationInternals<ImportExportExtensionsOperationResult> _operation;

        /// <summary> Initializes a new instance of SqlDatabaseCreateOrUpdateDatabaseExtensionOperation for mocking. </summary>
        protected SqlDatabaseCreateOrUpdateDatabaseExtensionOperation()
        {
        }

        internal SqlDatabaseCreateOrUpdateDatabaseExtensionOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ImportExportExtensionsOperationResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlDatabaseCreateOrUpdateDatabaseExtensionOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ImportExportExtensionsOperationResult Value => _operation.Value;

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
        public override ValueTask<Response<ImportExportExtensionsOperationResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ImportExportExtensionsOperationResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ImportExportExtensionsOperationResult IOperationSource<ImportExportExtensionsOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ImportExportExtensionsOperationResult.DeserializeImportExportExtensionsOperationResult(document.RootElement);
        }

        async ValueTask<ImportExportExtensionsOperationResult> IOperationSource<ImportExportExtensionsOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ImportExportExtensionsOperationResult.DeserializeImportExportExtensionsOperationResult(document.RootElement);
        }
    }
}