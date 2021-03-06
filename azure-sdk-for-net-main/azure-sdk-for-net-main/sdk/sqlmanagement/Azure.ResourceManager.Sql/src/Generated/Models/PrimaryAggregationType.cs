// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The primary aggregation type defining how metric values are displayed. </summary>
    public readonly partial struct PrimaryAggregationType : IEquatable<PrimaryAggregationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrimaryAggregationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrimaryAggregationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AverageValue = "Average";
        private const string CountValue = "Count";
        private const string MinimumValue = "Minimum";
        private const string MaximumValue = "Maximum";
        private const string TotalValue = "Total";

        /// <summary> None. </summary>
        public static PrimaryAggregationType None { get; } = new PrimaryAggregationType(NoneValue);
        /// <summary> Average. </summary>
        public static PrimaryAggregationType Average { get; } = new PrimaryAggregationType(AverageValue);
        /// <summary> Count. </summary>
        public static PrimaryAggregationType Count { get; } = new PrimaryAggregationType(CountValue);
        /// <summary> Minimum. </summary>
        public static PrimaryAggregationType Minimum { get; } = new PrimaryAggregationType(MinimumValue);
        /// <summary> Maximum. </summary>
        public static PrimaryAggregationType Maximum { get; } = new PrimaryAggregationType(MaximumValue);
        /// <summary> Total. </summary>
        public static PrimaryAggregationType Total { get; } = new PrimaryAggregationType(TotalValue);
        /// <summary> Determines if two <see cref="PrimaryAggregationType"/> values are the same. </summary>
        public static bool operator ==(PrimaryAggregationType left, PrimaryAggregationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrimaryAggregationType"/> values are not the same. </summary>
        public static bool operator !=(PrimaryAggregationType left, PrimaryAggregationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrimaryAggregationType"/>. </summary>
        public static implicit operator PrimaryAggregationType(string value) => new PrimaryAggregationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrimaryAggregationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrimaryAggregationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
