// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SpendingLimit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpendingLimit
    {
        [EnumMember(Value = "On")]
        On,
        [EnumMember(Value = "Off")]
        Off,
        [EnumMember(Value = "CurrentPeriodOff")]
        CurrentPeriodOff
    }
    internal static class SpendingLimitEnumExtension
    {
        internal static string ToSerializedValue(this SpendingLimit? value)
        {
            return value == null ? null : ((SpendingLimit)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SpendingLimit value)
        {
            switch( value )
            {
                case SpendingLimit.On:
                    return "On";
                case SpendingLimit.Off:
                    return "Off";
                case SpendingLimit.CurrentPeriodOff:
                    return "CurrentPeriodOff";
            }
            return null;
        }

        internal static SpendingLimit? ParseSpendingLimit(this string value)
        {
            switch( value )
            {
                case "On":
                    return SpendingLimit.On;
                case "Off":
                    return SpendingLimit.Off;
                case "CurrentPeriodOff":
                    return SpendingLimit.CurrentPeriodOff;
            }
            return null;
        }
    }
}
