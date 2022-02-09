// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Tier of an Azure Firewall. </summary>
    public readonly partial struct AzureFirewallSkuTier : IEquatable<AzureFirewallSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureFirewallSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Standard. </summary>
        public static AzureFirewallSkuTier Standard { get; } = new AzureFirewallSkuTier(StandardValue);
        /// <summary> Premium. </summary>
        public static AzureFirewallSkuTier Premium { get; } = new AzureFirewallSkuTier(PremiumValue);
        /// <summary> Determines if two <see cref="AzureFirewallSkuTier"/> values are the same. </summary>
        public static bool operator ==(AzureFirewallSkuTier left, AzureFirewallSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureFirewallSkuTier"/> values are not the same. </summary>
        public static bool operator !=(AzureFirewallSkuTier left, AzureFirewallSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureFirewallSkuTier"/>. </summary>
        public static implicit operator AzureFirewallSkuTier(string value) => new AzureFirewallSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureFirewallSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureFirewallSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
