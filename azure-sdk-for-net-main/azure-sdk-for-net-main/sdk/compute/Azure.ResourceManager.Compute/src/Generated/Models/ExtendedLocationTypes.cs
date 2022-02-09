// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The type of extendedLocation. </summary>
    public readonly partial struct ExtendedLocationTypes : IEquatable<ExtendedLocationTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExtendedLocationTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExtendedLocationTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EdgeZoneValue = "EdgeZone";

        /// <summary> EdgeZone. </summary>
        public static ExtendedLocationTypes EdgeZone { get; } = new ExtendedLocationTypes(EdgeZoneValue);
        /// <summary> Determines if two <see cref="ExtendedLocationTypes"/> values are the same. </summary>
        public static bool operator ==(ExtendedLocationTypes left, ExtendedLocationTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtendedLocationTypes"/> values are not the same. </summary>
        public static bool operator !=(ExtendedLocationTypes left, ExtendedLocationTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExtendedLocationTypes"/>. </summary>
        public static implicit operator ExtendedLocationTypes(string value) => new ExtendedLocationTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtendedLocationTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtendedLocationTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
