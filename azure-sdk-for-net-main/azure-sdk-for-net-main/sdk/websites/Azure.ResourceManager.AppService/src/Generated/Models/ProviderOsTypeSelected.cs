// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ProviderOsTypeSelected. </summary>
    public readonly partial struct ProviderOsTypeSelected : IEquatable<ProviderOsTypeSelected>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderOsTypeSelected"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderOsTypeSelected(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string WindowsFunctionsValue = "WindowsFunctions";
        private const string LinuxFunctionsValue = "LinuxFunctions";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static ProviderOsTypeSelected Windows { get; } = new ProviderOsTypeSelected(WindowsValue);
        /// <summary> Linux. </summary>
        public static ProviderOsTypeSelected Linux { get; } = new ProviderOsTypeSelected(LinuxValue);
        /// <summary> WindowsFunctions. </summary>
        public static ProviderOsTypeSelected WindowsFunctions { get; } = new ProviderOsTypeSelected(WindowsFunctionsValue);
        /// <summary> LinuxFunctions. </summary>
        public static ProviderOsTypeSelected LinuxFunctions { get; } = new ProviderOsTypeSelected(LinuxFunctionsValue);
        /// <summary> All. </summary>
        public static ProviderOsTypeSelected All { get; } = new ProviderOsTypeSelected(AllValue);
        /// <summary> Determines if two <see cref="ProviderOsTypeSelected"/> values are the same. </summary>
        public static bool operator ==(ProviderOsTypeSelected left, ProviderOsTypeSelected right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderOsTypeSelected"/> values are not the same. </summary>
        public static bool operator !=(ProviderOsTypeSelected left, ProviderOsTypeSelected right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderOsTypeSelected"/>. </summary>
        public static implicit operator ProviderOsTypeSelected(string value) => new ProviderOsTypeSelected(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderOsTypeSelected other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderOsTypeSelected other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}