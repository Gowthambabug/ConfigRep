// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Personalizer
{
    /// <summary> Evaluation type (manual or through Automatic Optimization). </summary>
    public readonly partial struct PersonalizerEvaluationType : IEquatable<PersonalizerEvaluationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PersonalizerEvaluationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PersonalizerEvaluationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManualValue = "Manual";
        private const string AutoValue = "Auto";

        /// <summary> Manual. </summary>
        public static PersonalizerEvaluationType Manual { get; } = new PersonalizerEvaluationType(ManualValue);
        /// <summary> Auto. </summary>
        public static PersonalizerEvaluationType Auto { get; } = new PersonalizerEvaluationType(AutoValue);
        /// <summary> Determines if two <see cref="PersonalizerEvaluationType"/> values are the same. </summary>
        public static bool operator ==(PersonalizerEvaluationType left, PersonalizerEvaluationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PersonalizerEvaluationType"/> values are not the same. </summary>
        public static bool operator !=(PersonalizerEvaluationType left, PersonalizerEvaluationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PersonalizerEvaluationType"/>. </summary>
        public static implicit operator PersonalizerEvaluationType(string value) => new PersonalizerEvaluationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PersonalizerEvaluationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PersonalizerEvaluationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}