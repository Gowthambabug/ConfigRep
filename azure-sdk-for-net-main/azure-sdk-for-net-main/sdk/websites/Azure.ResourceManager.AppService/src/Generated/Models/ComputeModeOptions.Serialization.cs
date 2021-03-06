// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class ComputeModeOptionsExtensions
    {
        public static string ToSerialString(this ComputeModeOptions value) => value switch
        {
            ComputeModeOptions.Shared => "Shared",
            ComputeModeOptions.Dedicated => "Dedicated",
            ComputeModeOptions.Dynamic => "Dynamic",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeModeOptions value.")
        };

        public static ComputeModeOptions ToComputeModeOptions(this string value)
        {
            if (string.Equals(value, "Shared", StringComparison.InvariantCultureIgnoreCase)) return ComputeModeOptions.Shared;
            if (string.Equals(value, "Dedicated", StringComparison.InvariantCultureIgnoreCase)) return ComputeModeOptions.Dedicated;
            if (string.Equals(value, "Dynamic", StringComparison.InvariantCultureIgnoreCase)) return ComputeModeOptions.Dynamic;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeModeOptions value.");
        }
    }
}
