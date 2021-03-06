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
    /// <summary> Description for Install site extension on a web site, or a deployment slot. </summary>
    public partial class SiteSiteextensionCreateOrUpdateOperation : Operation<SiteSiteextension>, IOperationSource<SiteSiteextension>
    {
        private readonly OperationInternals<SiteSiteextension> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SiteSiteextensionCreateOrUpdateOperation for mocking. </summary>
        protected SiteSiteextensionCreateOrUpdateOperation()
        {
        }

        internal SiteSiteextensionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteSiteextension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteSiteextensionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSiteextension Value => _operation.Value;

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
        public override ValueTask<Response<SiteSiteextension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSiteextension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteSiteextension IOperationSource<SiteSiteextension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSiteextension(_armClient, data);
        }

        async ValueTask<SiteSiteextension> IOperationSource<SiteSiteextension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSiteextension(_armClient, data);
        }
    }
}
