// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </summary>
    public readonly partial struct HttpsRedirect : IEquatable<HttpsRedirect>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HttpsRedirect"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpsRedirect(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static HttpsRedirect Enabled { get; } = new HttpsRedirect(EnabledValue);
        /// <summary> Disabled. </summary>
        public static HttpsRedirect Disabled { get; } = new HttpsRedirect(DisabledValue);
        /// <summary> Determines if two <see cref="HttpsRedirect"/> values are the same. </summary>
        public static bool operator ==(HttpsRedirect left, HttpsRedirect right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpsRedirect"/> values are not the same. </summary>
        public static bool operator !=(HttpsRedirect left, HttpsRedirect right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpsRedirect"/>. </summary>
        public static implicit operator HttpsRedirect(string value) => new HttpsRedirect(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpsRedirect other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpsRedirect other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}