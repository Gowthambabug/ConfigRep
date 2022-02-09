// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Name of the pricing tier. </summary>
    public readonly partial struct SkuName : IEquatable<SkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardVerizonValue = "Standard_Verizon";
        private const string PremiumVerizonValue = "Premium_Verizon";
        private const string CustomVerizonValue = "Custom_Verizon";
        private const string StandardAkamaiValue = "Standard_Akamai";
        private const string StandardChinaCdnValue = "Standard_ChinaCdn";
        private const string StandardMicrosoftValue = "Standard_Microsoft";
        private const string PremiumChinaCdnValue = "Premium_ChinaCdn";
        private const string StandardAzureFrontDoorValue = "Standard_AzureFrontDoor";
        private const string PremiumAzureFrontDoorValue = "Premium_AzureFrontDoor";
        private const string Standard955BandWidthChinaCdnValue = "Standard_955BandWidth_ChinaCdn";
        private const string StandardAvgBandWidthChinaCdnValue = "Standard_AvgBandWidth_ChinaCdn";
        private const string StandardPlusChinaCdnValue = "StandardPlus_ChinaCdn";
        private const string StandardPlus955BandWidthChinaCdnValue = "StandardPlus_955BandWidth_ChinaCdn";
        private const string StandardPlusAvgBandWidthChinaCdnValue = "StandardPlus_AvgBandWidth_ChinaCdn";

        /// <summary> Standard_Verizon. </summary>
        public static SkuName StandardVerizon { get; } = new SkuName(StandardVerizonValue);
        /// <summary> Premium_Verizon. </summary>
        public static SkuName PremiumVerizon { get; } = new SkuName(PremiumVerizonValue);
        /// <summary> Custom_Verizon. </summary>
        public static SkuName CustomVerizon { get; } = new SkuName(CustomVerizonValue);
        /// <summary> Standard_Akamai. </summary>
        public static SkuName StandardAkamai { get; } = new SkuName(StandardAkamaiValue);
        /// <summary> Standard_ChinaCdn. </summary>
        public static SkuName StandardChinaCdn { get; } = new SkuName(StandardChinaCdnValue);
        /// <summary> Standard_Microsoft. </summary>
        public static SkuName StandardMicrosoft { get; } = new SkuName(StandardMicrosoftValue);
        /// <summary> Premium_ChinaCdn. </summary>
        public static SkuName PremiumChinaCdn { get; } = new SkuName(PremiumChinaCdnValue);
        /// <summary> Standard_AzureFrontDoor. </summary>
        public static SkuName StandardAzureFrontDoor { get; } = new SkuName(StandardAzureFrontDoorValue);
        /// <summary> Premium_AzureFrontDoor. </summary>
        public static SkuName PremiumAzureFrontDoor { get; } = new SkuName(PremiumAzureFrontDoorValue);
        /// <summary> Standard_955BandWidth_ChinaCdn. </summary>
        public static SkuName Standard955BandWidthChinaCdn { get; } = new SkuName(Standard955BandWidthChinaCdnValue);
        /// <summary> Standard_AvgBandWidth_ChinaCdn. </summary>
        public static SkuName StandardAvgBandWidthChinaCdn { get; } = new SkuName(StandardAvgBandWidthChinaCdnValue);
        /// <summary> StandardPlus_ChinaCdn. </summary>
        public static SkuName StandardPlusChinaCdn { get; } = new SkuName(StandardPlusChinaCdnValue);
        /// <summary> StandardPlus_955BandWidth_ChinaCdn. </summary>
        public static SkuName StandardPlus955BandWidthChinaCdn { get; } = new SkuName(StandardPlus955BandWidthChinaCdnValue);
        /// <summary> StandardPlus_AvgBandWidth_ChinaCdn. </summary>
        public static SkuName StandardPlusAvgBandWidthChinaCdn { get; } = new SkuName(StandardPlusAvgBandWidthChinaCdnValue);
        /// <summary> Determines if two <see cref="SkuName"/> values are the same. </summary>
        public static bool operator ==(SkuName left, SkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuName"/> values are not the same. </summary>
        public static bool operator !=(SkuName left, SkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuName"/>. </summary>
        public static implicit operator SkuName(string value) => new SkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}