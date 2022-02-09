// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The SchemaCompatibility. </summary>
    public readonly partial struct SchemaCompatibility : IEquatable<SchemaCompatibility>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SchemaCompatibility"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SchemaCompatibility(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string BackwardValue = "Backward";
        private const string ForwardValue = "Forward";

        /// <summary> None. </summary>
        public static SchemaCompatibility None { get; } = new SchemaCompatibility(NoneValue);
        /// <summary> Backward. </summary>
        public static SchemaCompatibility Backward { get; } = new SchemaCompatibility(BackwardValue);
        /// <summary> Forward. </summary>
        public static SchemaCompatibility Forward { get; } = new SchemaCompatibility(ForwardValue);
        /// <summary> Determines if two <see cref="SchemaCompatibility"/> values are the same. </summary>
        public static bool operator ==(SchemaCompatibility left, SchemaCompatibility right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SchemaCompatibility"/> values are not the same. </summary>
        public static bool operator !=(SchemaCompatibility left, SchemaCompatibility right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SchemaCompatibility"/>. </summary>
        public static implicit operator SchemaCompatibility(string value) => new SchemaCompatibility(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SchemaCompatibility other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SchemaCompatibility other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}