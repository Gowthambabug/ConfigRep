// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SensitivityLabelUpdateKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SensitivityLabelUpdateKind
    {
        [EnumMember(Value = "set")]
        Set,
        [EnumMember(Value = "remove")]
        Remove
    }
    internal static class SensitivityLabelUpdateKindEnumExtension
    {
        internal static string ToSerializedValue(this SensitivityLabelUpdateKind? value)
        {
            return value == null ? null : ((SensitivityLabelUpdateKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SensitivityLabelUpdateKind value)
        {
            switch( value )
            {
                case SensitivityLabelUpdateKind.Set:
                    return "set";
                case SensitivityLabelUpdateKind.Remove:
                    return "remove";
            }
            return null;
        }

        internal static SensitivityLabelUpdateKind? ParseSensitivityLabelUpdateKind(this string value)
        {
            switch( value )
            {
                case "set":
                    return SensitivityLabelUpdateKind.Set;
                case "remove":
                    return SensitivityLabelUpdateKind.Remove;
            }
            return null;
        }
    }
}