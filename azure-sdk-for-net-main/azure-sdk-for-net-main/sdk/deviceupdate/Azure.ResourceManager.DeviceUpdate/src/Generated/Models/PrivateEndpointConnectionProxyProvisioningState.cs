// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct PrivateEndpointConnectionProxyProvisioningState : IEquatable<PrivateEndpointConnectionProxyProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionProxyProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateEndpointConnectionProxyProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static PrivateEndpointConnectionProxyProvisioningState Succeeded { get; } = new PrivateEndpointConnectionProxyProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static PrivateEndpointConnectionProxyProvisioningState Creating { get; } = new PrivateEndpointConnectionProxyProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static PrivateEndpointConnectionProxyProvisioningState Deleting { get; } = new PrivateEndpointConnectionProxyProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static PrivateEndpointConnectionProxyProvisioningState Failed { get; } = new PrivateEndpointConnectionProxyProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionProxyProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PrivateEndpointConnectionProxyProvisioningState left, PrivateEndpointConnectionProxyProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionProxyProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PrivateEndpointConnectionProxyProvisioningState left, PrivateEndpointConnectionProxyProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateEndpointConnectionProxyProvisioningState"/>. </summary>
        public static implicit operator PrivateEndpointConnectionProxyProvisioningState(string value) => new PrivateEndpointConnectionProxyProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateEndpointConnectionProxyProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateEndpointConnectionProxyProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
