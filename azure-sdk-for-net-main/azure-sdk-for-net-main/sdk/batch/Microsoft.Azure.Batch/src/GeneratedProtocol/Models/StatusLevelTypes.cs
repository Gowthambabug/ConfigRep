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
    /// Defines values for StatusLevelTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusLevelTypes
    {
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Info")]
        Info,
        [EnumMember(Value = "Warning")]
        Warning
    }
    internal static class StatusLevelTypesEnumExtension
    {
        internal static string ToSerializedValue(this StatusLevelTypes? value)
        {
            return value == null ? null : ((StatusLevelTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StatusLevelTypes value)
        {
            switch( value )
            {
                case StatusLevelTypes.Error:
                    return "Error";
                case StatusLevelTypes.Info:
                    return "Info";
                case StatusLevelTypes.Warning:
                    return "Warning";
            }
            return null;
        }

        internal static StatusLevelTypes? ParseStatusLevelTypes(this string value)
        {
            switch( value )
            {
                case "Error":
                    return StatusLevelTypes.Error;
                case "Info":
                    return StatusLevelTypes.Info;
                case "Warning":
                    return StatusLevelTypes.Warning;
            }
            return null;
        }
    }
}
