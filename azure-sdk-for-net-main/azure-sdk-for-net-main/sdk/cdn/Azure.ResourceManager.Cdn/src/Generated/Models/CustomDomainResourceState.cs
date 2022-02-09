// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Resource status of the custom domain. </summary>
    public readonly partial struct CustomDomainResourceState : IEquatable<CustomDomainResourceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomDomainResourceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomDomainResourceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string ActiveValue = "Active";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static CustomDomainResourceState Creating { get; } = new CustomDomainResourceState(CreatingValue);
        /// <summary> Active. </summary>
        public static CustomDomainResourceState Active { get; } = new CustomDomainResourceState(ActiveValue);
        /// <summary> Deleting. </summary>
        public static CustomDomainResourceState Deleting { get; } = new CustomDomainResourceState(DeletingValue);
        /// <summary> Determines if two <see cref="CustomDomainResourceState"/> values are the same. </summary>
        public static bool operator ==(CustomDomainResourceState left, CustomDomainResourceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomDomainResourceState"/> values are not the same. </summary>
        public static bool operator !=(CustomDomainResourceState left, CustomDomainResourceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CustomDomainResourceState"/>. </summary>
        public static implicit operator CustomDomainResourceState(string value) => new CustomDomainResourceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomDomainResourceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomDomainResourceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}