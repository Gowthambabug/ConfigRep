// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The endpoint type. </summary>
    public readonly partial struct EndpointType : IEquatable<EndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureVMValue = "AzureVM";
        private const string AzureVNetValue = "AzureVNet";
        private const string AzureSubnetValue = "AzureSubnet";
        private const string ExternalAddressValue = "ExternalAddress";
        private const string MMAWorkspaceMachineValue = "MMAWorkspaceMachine";
        private const string MMAWorkspaceNetworkValue = "MMAWorkspaceNetwork";

        /// <summary> AzureVM. </summary>
        public static EndpointType AzureVM { get; } = new EndpointType(AzureVMValue);
        /// <summary> AzureVNet. </summary>
        public static EndpointType AzureVNet { get; } = new EndpointType(AzureVNetValue);
        /// <summary> AzureSubnet. </summary>
        public static EndpointType AzureSubnet { get; } = new EndpointType(AzureSubnetValue);
        /// <summary> ExternalAddress. </summary>
        public static EndpointType ExternalAddress { get; } = new EndpointType(ExternalAddressValue);
        /// <summary> MMAWorkspaceMachine. </summary>
        public static EndpointType MMAWorkspaceMachine { get; } = new EndpointType(MMAWorkspaceMachineValue);
        /// <summary> MMAWorkspaceNetwork. </summary>
        public static EndpointType MMAWorkspaceNetwork { get; } = new EndpointType(MMAWorkspaceNetworkValue);
        /// <summary> Determines if two <see cref="EndpointType"/> values are the same. </summary>
        public static bool operator ==(EndpointType left, EndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointType"/> values are not the same. </summary>
        public static bool operator !=(EndpointType left, EndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointType"/>. </summary>
        public static implicit operator EndpointType(string value) => new EndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}