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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a new static site in an existing resource group, or updates an existing static site. </summary>
    public partial class StaticSiteARMResourceCreateOrUpdateOperation : Operation<StaticSiteARMResource>, IOperationSource<StaticSiteARMResource>
    {
        private readonly OperationInternals<StaticSiteARMResource> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of StaticSiteARMResourceCreateOrUpdateOperation for mocking. </summary>
        protected StaticSiteARMResourceCreateOrUpdateOperation()
        {
        }

        internal StaticSiteARMResourceCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StaticSiteARMResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StaticSiteARMResourceCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StaticSiteARMResource Value => _operation.Value;

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
        public override ValueTask<Response<StaticSiteARMResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StaticSiteARMResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StaticSiteARMResource IOperationSource<StaticSiteARMResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StaticSiteARMResourceData.DeserializeStaticSiteARMResourceData(document.RootElement);
            return new StaticSiteARMResource(_armClient, data);
        }

        async ValueTask<StaticSiteARMResource> IOperationSource<StaticSiteARMResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StaticSiteARMResourceData.DeserializeStaticSiteARMResourceData(document.RootElement);
            return new StaticSiteARMResource(_armClient, data);
        }
    }
}