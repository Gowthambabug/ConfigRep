// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> IMDS attestation status of the cluster. </summary>
    public readonly partial struct ImdsAttestation : IEquatable<ImdsAttestation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImdsAttestation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImdsAttestation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ImdsAttestation Disabled { get; } = new ImdsAttestation(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ImdsAttestation Enabled { get; } = new ImdsAttestation(EnabledValue);
        /// <summary> Determines if two <see cref="ImdsAttestation"/> values are the same. </summary>
        public static bool operator ==(ImdsAttestation left, ImdsAttestation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImdsAttestation"/> values are not the same. </summary>
        public static bool operator !=(ImdsAttestation left, ImdsAttestation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImdsAttestation"/>. </summary>
        public static implicit operator ImdsAttestation(string value) => new ImdsAttestation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImdsAttestation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImdsAttestation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}