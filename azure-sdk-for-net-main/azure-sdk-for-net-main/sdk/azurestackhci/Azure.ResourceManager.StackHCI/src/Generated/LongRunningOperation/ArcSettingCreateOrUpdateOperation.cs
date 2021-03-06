// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.StackHCI;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> Create ArcSetting for HCI cluster. </summary>
    public partial class ArcSettingCreateOrUpdateOperation : Operation<ArcSetting>
    {
        private readonly OperationOrResponseInternals<ArcSetting> _operation;

        /// <summary> Initializes a new instance of ArcSettingCreateOrUpdateOperation for mocking. </summary>
        protected ArcSettingCreateOrUpdateOperation()
        {
        }

        internal ArcSettingCreateOrUpdateOperation(ArmClient armClient, Response<ArcSettingData> response)
        {
            _operation = new OperationOrResponseInternals<ArcSetting>(Response.FromValue(new ArcSetting(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ArcSetting Value => _operation.Value;

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
        public override ValueTask<Response<ArcSetting>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ArcSetting>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
