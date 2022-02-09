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
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Creates a new custom domain within an endpoint. </summary>
    public partial class CdnCustomDomainCreateOrUpdateOperation : Operation<CdnCustomDomain>, IOperationSource<CdnCustomDomain>
    {
        private readonly OperationInternals<CdnCustomDomain> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of CdnCustomDomainCreateOrUpdateOperation for mocking. </summary>
        protected CdnCustomDomainCreateOrUpdateOperation()
        {
        }

        internal CdnCustomDomainCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CdnCustomDomain>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CdnCustomDomainCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CdnCustomDomain Value => _operation.Value;

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
        public override ValueTask<Response<CdnCustomDomain>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CdnCustomDomain>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CdnCustomDomain IOperationSource<CdnCustomDomain>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CdnCustomDomainData.DeserializeCdnCustomDomainData(document.RootElement);
            return new CdnCustomDomain(_armClient, data);
        }

        async ValueTask<CdnCustomDomain> IOperationSource<CdnCustomDomain>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CdnCustomDomainData.DeserializeCdnCustomDomainData(document.RootElement);
            return new CdnCustomDomain(_armClient, data);
        }
    }
}