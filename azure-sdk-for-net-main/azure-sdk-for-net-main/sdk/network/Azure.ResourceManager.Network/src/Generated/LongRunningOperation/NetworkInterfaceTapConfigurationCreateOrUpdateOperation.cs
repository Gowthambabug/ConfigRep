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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
    public partial class NetworkInterfaceTapConfigurationCreateOrUpdateOperation : Operation<NetworkInterfaceTapConfiguration>, IOperationSource<NetworkInterfaceTapConfiguration>
    {
        private readonly OperationInternals<NetworkInterfaceTapConfiguration> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of NetworkInterfaceTapConfigurationCreateOrUpdateOperation for mocking. </summary>
        protected NetworkInterfaceTapConfigurationCreateOrUpdateOperation()
        {
        }

        internal NetworkInterfaceTapConfigurationCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<NetworkInterfaceTapConfiguration>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "NetworkInterfaceTapConfigurationCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NetworkInterfaceTapConfiguration Value => _operation.Value;

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
        public override ValueTask<Response<NetworkInterfaceTapConfiguration>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkInterfaceTapConfiguration>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        NetworkInterfaceTapConfiguration IOperationSource<NetworkInterfaceTapConfiguration>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(document.RootElement);
            return new NetworkInterfaceTapConfiguration(_armClient, data);
        }

        async ValueTask<NetworkInterfaceTapConfiguration> IOperationSource<NetworkInterfaceTapConfiguration>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(document.RootElement);
            return new NetworkInterfaceTapConfiguration(_armClient, data);
        }
    }
}