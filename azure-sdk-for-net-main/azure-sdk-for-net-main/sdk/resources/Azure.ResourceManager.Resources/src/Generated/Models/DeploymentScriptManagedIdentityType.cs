// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Type of the managed identity. </summary>
    public readonly partial struct DeploymentScriptManagedIdentityType : IEquatable<DeploymentScriptManagedIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentScriptManagedIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentScriptManagedIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserAssignedValue = "UserAssigned";

        /// <summary> UserAssigned. </summary>
        public static DeploymentScriptManagedIdentityType UserAssigned { get; } = new DeploymentScriptManagedIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="DeploymentScriptManagedIdentityType"/> values are the same. </summary>
        public static bool operator ==(DeploymentScriptManagedIdentityType left, DeploymentScriptManagedIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentScriptManagedIdentityType"/> values are not the same. </summary>
        public static bool operator !=(DeploymentScriptManagedIdentityType left, DeploymentScriptManagedIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentScriptManagedIdentityType"/>. </summary>
        public static implicit operator DeploymentScriptManagedIdentityType(string value) => new DeploymentScriptManagedIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentScriptManagedIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentScriptManagedIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}