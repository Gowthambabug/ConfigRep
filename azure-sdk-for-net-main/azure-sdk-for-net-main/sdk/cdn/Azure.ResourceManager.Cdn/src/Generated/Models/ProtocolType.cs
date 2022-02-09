// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the TLS extension protocol that is used for secure delivery. </summary>
    public readonly partial struct ProtocolType : IEquatable<ProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerNameIndicationValue = "ServerNameIndication";
        private const string IPBasedValue = "IPBased";

        /// <summary> ServerNameIndication. </summary>
        public static ProtocolType ServerNameIndication { get; } = new ProtocolType(ServerNameIndicationValue);
        /// <summary> IPBased. </summary>
        public static ProtocolType IPBased { get; } = new ProtocolType(IPBasedValue);
        /// <summary> Determines if two <see cref="ProtocolType"/> values are the same. </summary>
        public static bool operator ==(ProtocolType left, ProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProtocolType"/> values are not the same. </summary>
        public static bool operator !=(ProtocolType left, ProtocolType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProtocolType"/>. </summary>
        public static implicit operator ProtocolType(string value) => new ProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}