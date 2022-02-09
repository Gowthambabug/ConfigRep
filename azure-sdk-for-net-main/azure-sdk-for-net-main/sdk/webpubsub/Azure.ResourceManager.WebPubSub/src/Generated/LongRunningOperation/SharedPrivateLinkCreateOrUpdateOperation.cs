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
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Create or update a shared private link resource. </summary>
    public partial class SharedPrivateLinkCreateOrUpdateOperation : Operation<SharedPrivateLink>, IOperationSource<SharedPrivateLink>
    {
        private readonly OperationInternals<SharedPrivateLink> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SharedPrivateLinkCreateOrUpdateOperation for mocking. </summary>
        protected SharedPrivateLinkCreateOrUpdateOperation()
        {
        }

        internal SharedPrivateLinkCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SharedPrivateLink>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SharedPrivateLinkCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SharedPrivateLink Value => _operation.Value;

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
        public override ValueTask<Response<SharedPrivateLink>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SharedPrivateLink>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SharedPrivateLink IOperationSource<SharedPrivateLink>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SharedPrivateLinkData.DeserializeSharedPrivateLinkData(document.RootElement);
            return new SharedPrivateLink(_armClient, data);
        }

        async ValueTask<SharedPrivateLink> IOperationSource<SharedPrivateLink>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SharedPrivateLinkData.DeserializeSharedPrivateLinkData(document.RootElement);
            return new SharedPrivateLink(_armClient, data);
        }
    }
}