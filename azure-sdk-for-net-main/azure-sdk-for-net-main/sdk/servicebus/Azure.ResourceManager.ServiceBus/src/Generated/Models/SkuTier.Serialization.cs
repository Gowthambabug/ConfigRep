// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal static partial class SkuTierExtensions
    {
        public static string ToSerialString(this SkuTier value) => value switch
        {
            SkuTier.Basic => "Basic",
            SkuTier.Standard => "Standard",
            SkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuTier value.")
        };

        public static SkuTier ToSkuTier(this string value)
        {
            if (string.Equals(value, "Basic", StringComparison.InvariantCultureIgnoreCase)) return SkuTier.Basic;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return SkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return SkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuTier value.");
        }
    }
}
