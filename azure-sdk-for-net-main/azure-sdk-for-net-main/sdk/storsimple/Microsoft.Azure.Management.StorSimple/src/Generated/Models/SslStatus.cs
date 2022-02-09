// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SslStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SslStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class SslStatusEnumExtension
    {
        internal static string ToSerializedValue(this SslStatus? value)
        {
            return value == null ? null : ((SslStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SslStatus value)
        {
            switch( value )
            {
                case SslStatus.Enabled:
                    return "Enabled";
                case SslStatus.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static SslStatus? ParseSslStatus(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return SslStatus.Enabled;
                case "Disabled":
                    return SslStatus.Disabled;
            }
            return null;
        }
    }
}
