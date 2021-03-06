// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The AccessRights. </summary>
    public readonly partial struct AccessRights : IEquatable<AccessRights>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessRights"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessRights(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManageValue = "Manage";
        private const string SendValue = "Send";
        private const string ListenValue = "Listen";

        /// <summary> Manage. </summary>
        public static AccessRights Manage { get; } = new AccessRights(ManageValue);
        /// <summary> Send. </summary>
        public static AccessRights Send { get; } = new AccessRights(SendValue);
        /// <summary> Listen. </summary>
        public static AccessRights Listen { get; } = new AccessRights(ListenValue);
        /// <summary> Determines if two <see cref="AccessRights"/> values are the same. </summary>
        public static bool operator ==(AccessRights left, AccessRights right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessRights"/> values are not the same. </summary>
        public static bool operator !=(AccessRights left, AccessRights right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessRights"/>. </summary>
        public static implicit operator AccessRights(string value) => new AccessRights(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessRights other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessRights other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
