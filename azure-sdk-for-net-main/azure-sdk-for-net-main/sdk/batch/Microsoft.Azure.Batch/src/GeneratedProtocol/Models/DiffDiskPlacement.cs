// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiffDiskPlacement.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiffDiskPlacement
    {
        /// <summary>
        /// The Ephemeral OS Disk is stored on the VM cache.
        /// </summary>
        [EnumMember(Value = "CacheDisk")]
        CacheDisk
    }
    internal static class DiffDiskPlacementEnumExtension
    {
        internal static string ToSerializedValue(this DiffDiskPlacement? value)
        {
            return value == null ? null : ((DiffDiskPlacement)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DiffDiskPlacement value)
        {
            switch( value )
            {
                case DiffDiskPlacement.CacheDisk:
                    return "CacheDisk";
            }
            return null;
        }

        internal static DiffDiskPlacement? ParseDiffDiskPlacement(this string value)
        {
            switch( value )
            {
                case "CacheDisk":
                    return DiffDiskPlacement.CacheDisk;
            }
            return null;
        }
    }
}