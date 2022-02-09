// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes what transforms were applied before matching. </summary>
    public readonly partial struct TransformType : IEquatable<TransformType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TransformType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TransformType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowercaseValue = "Lowercase";
        private const string UppercaseValue = "Uppercase";
        private const string TrimValue = "Trim";
        private const string UrlDecodeValue = "UrlDecode";
        private const string UrlEncodeValue = "UrlEncode";
        private const string RemoveNullsValue = "RemoveNulls";

        /// <summary> Lowercase. </summary>
        public static TransformType Lowercase { get; } = new TransformType(LowercaseValue);
        /// <summary> Uppercase. </summary>
        public static TransformType Uppercase { get; } = new TransformType(UppercaseValue);
        /// <summary> Trim. </summary>
        public static TransformType Trim { get; } = new TransformType(TrimValue);
        /// <summary> UrlDecode. </summary>
        public static TransformType UrlDecode { get; } = new TransformType(UrlDecodeValue);
        /// <summary> UrlEncode. </summary>
        public static TransformType UrlEncode { get; } = new TransformType(UrlEncodeValue);
        /// <summary> RemoveNulls. </summary>
        public static TransformType RemoveNulls { get; } = new TransformType(RemoveNullsValue);
        /// <summary> Determines if two <see cref="TransformType"/> values are the same. </summary>
        public static bool operator ==(TransformType left, TransformType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransformType"/> values are not the same. </summary>
        public static bool operator !=(TransformType left, TransformType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransformType"/>. </summary>
        public static implicit operator TransformType(string value) => new TransformType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TransformType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TransformType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}