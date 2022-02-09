// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> data used to implement value filter. </summary>
    public readonly partial struct BoundaryMeasureType : IEquatable<BoundaryMeasureType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BoundaryMeasureType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BoundaryMeasureType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValueValue = "Value";
        private const string MeanValue = "Mean";
        /// <summary> Determines if two <see cref="BoundaryMeasureType"/> values are the same. </summary>
        public static bool operator ==(BoundaryMeasureType left, BoundaryMeasureType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BoundaryMeasureType"/> values are not the same. </summary>
        public static bool operator !=(BoundaryMeasureType left, BoundaryMeasureType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BoundaryMeasureType"/>. </summary>
        public static implicit operator BoundaryMeasureType(string value) => new BoundaryMeasureType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BoundaryMeasureType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BoundaryMeasureType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}