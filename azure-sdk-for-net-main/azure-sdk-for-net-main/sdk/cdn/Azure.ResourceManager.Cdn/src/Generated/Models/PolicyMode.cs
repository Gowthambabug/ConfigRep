// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes if it is in detection mode or prevention mode at policy level. </summary>
    public readonly partial struct PolicyMode : IEquatable<PolicyMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreventionValue = "Prevention";
        private const string DetectionValue = "Detection";

        /// <summary> Prevention. </summary>
        public static PolicyMode Prevention { get; } = new PolicyMode(PreventionValue);
        /// <summary> Detection. </summary>
        public static PolicyMode Detection { get; } = new PolicyMode(DetectionValue);
        /// <summary> Determines if two <see cref="PolicyMode"/> values are the same. </summary>
        public static bool operator ==(PolicyMode left, PolicyMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyMode"/> values are not the same. </summary>
        public static bool operator !=(PolicyMode left, PolicyMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyMode"/>. </summary>
        public static implicit operator PolicyMode(string value) => new PolicyMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}