// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The storage redundancy type of the copied backup. </summary>
    public readonly partial struct TargetBackupStorageRedundancy : IEquatable<TargetBackupStorageRedundancy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetBackupStorageRedundancy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetBackupStorageRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeoValue = "Geo";
        private const string LocalValue = "Local";
        private const string ZoneValue = "Zone";

        /// <summary> Geo. </summary>
        public static TargetBackupStorageRedundancy Geo { get; } = new TargetBackupStorageRedundancy(GeoValue);
        /// <summary> Local. </summary>
        public static TargetBackupStorageRedundancy Local { get; } = new TargetBackupStorageRedundancy(LocalValue);
        /// <summary> Zone. </summary>
        public static TargetBackupStorageRedundancy Zone { get; } = new TargetBackupStorageRedundancy(ZoneValue);
        /// <summary> Determines if two <see cref="TargetBackupStorageRedundancy"/> values are the same. </summary>
        public static bool operator ==(TargetBackupStorageRedundancy left, TargetBackupStorageRedundancy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetBackupStorageRedundancy"/> values are not the same. </summary>
        public static bool operator !=(TargetBackupStorageRedundancy left, TargetBackupStorageRedundancy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetBackupStorageRedundancy"/>. </summary>
        public static implicit operator TargetBackupStorageRedundancy(string value) => new TargetBackupStorageRedundancy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetBackupStorageRedundancy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetBackupStorageRedundancy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}