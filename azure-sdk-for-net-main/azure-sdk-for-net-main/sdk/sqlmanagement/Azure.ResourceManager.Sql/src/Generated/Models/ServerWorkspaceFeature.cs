// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Whether or not existing server has a workspace created and if it allows connection from workspace. </summary>
    public readonly partial struct ServerWorkspaceFeature : IEquatable<ServerWorkspaceFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerWorkspaceFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerWorkspaceFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Connected. </summary>
        public static ServerWorkspaceFeature Connected { get; } = new ServerWorkspaceFeature(ConnectedValue);
        /// <summary> Disconnected. </summary>
        public static ServerWorkspaceFeature Disconnected { get; } = new ServerWorkspaceFeature(DisconnectedValue);
        /// <summary> Determines if two <see cref="ServerWorkspaceFeature"/> values are the same. </summary>
        public static bool operator ==(ServerWorkspaceFeature left, ServerWorkspaceFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerWorkspaceFeature"/> values are not the same. </summary>
        public static bool operator !=(ServerWorkspaceFeature left, ServerWorkspaceFeature right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerWorkspaceFeature"/>. </summary>
        public static implicit operator ServerWorkspaceFeature(string value) => new ServerWorkspaceFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerWorkspaceFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerWorkspaceFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}