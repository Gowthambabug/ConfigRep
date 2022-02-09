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
    /// <summary> Creates a new security policy within the specified profile. </summary>
    public partial class AfdSecurityPolicyCreateOrUpdateOperation : Operation<AfdSecurityPolicy>, IOperationSource<AfdSecurityPolicy>
    {
        private readonly OperationInternals<AfdSecurityPolicy> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of AfdSecurityPolicyCreateOrUpdateOperation for mocking. </summary>
        protected AfdSecurityPolicyCreateOrUpdateOperation()
        {
        }

        internal AfdSecurityPolicyCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AfdSecurityPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "AfdSecurityPolicyCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AfdSecurityPolicy Value => _operation.Value;

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
        public override ValueTask<Response<AfdSecurityPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AfdSecurityPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AfdSecurityPolicy IOperationSource<AfdSecurityPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AfdSecurityPolicyData.DeserializeAfdSecurityPolicyData(document.RootElement);
            return new AfdSecurityPolicy(_armClient, data);
        }

        async ValueTask<AfdSecurityPolicy> IOperationSource<AfdSecurityPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AfdSecurityPolicyData.DeserializeAfdSecurityPolicyData(document.RootElement);
            return new AfdSecurityPolicy(_armClient, data);
        }
    }
}
