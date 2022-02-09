// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication. The default is &apos;Cassandra&apos;. </summary>
    public readonly partial struct AuthenticationMethod : IEquatable<AuthenticationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthenticationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthenticationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CassandraValue = "Cassandra";

        /// <summary> None. </summary>
        public static AuthenticationMethod None { get; } = new AuthenticationMethod(NoneValue);
        /// <summary> Cassandra. </summary>
        public static AuthenticationMethod Cassandra { get; } = new AuthenticationMethod(CassandraValue);
        /// <summary> Determines if two <see cref="AuthenticationMethod"/> values are the same. </summary>
        public static bool operator ==(AuthenticationMethod left, AuthenticationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationMethod"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationMethod left, AuthenticationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuthenticationMethod"/>. </summary>
        public static implicit operator AuthenticationMethod(string value) => new AuthenticationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}