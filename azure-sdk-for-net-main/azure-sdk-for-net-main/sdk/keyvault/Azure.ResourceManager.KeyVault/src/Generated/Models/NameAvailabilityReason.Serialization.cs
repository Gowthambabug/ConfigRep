// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class NameAvailabilityReasonExtensions
    {
        public static string ToSerialString(this NameAvailabilityReason value) => value switch
        {
            NameAvailabilityReason.AccountNameInvalid => "AccountNameInvalid",
            NameAvailabilityReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NameAvailabilityReason value.")
        };

        public static NameAvailabilityReason ToNameAvailabilityReason(this string value)
        {
            if (string.Equals(value, "AccountNameInvalid", StringComparison.InvariantCultureIgnoreCase)) return NameAvailabilityReason.AccountNameInvalid;
            if (string.Equals(value, "AlreadyExists", StringComparison.InvariantCultureIgnoreCase)) return NameAvailabilityReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NameAvailabilityReason value.");
        }
    }
}
