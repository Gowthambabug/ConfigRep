// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LabState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LabState
    {
        /// <summary>
        /// The lab is currently in draft (has not been published).
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,
        /// <summary>
        /// The lab is publishing.
        /// </summary>
        [EnumMember(Value = "Publishing")]
        Publishing,
        /// <summary>
        /// The lab is scaling.
        /// </summary>
        [EnumMember(Value = "Scaling")]
        Scaling,
        /// <summary>
        /// The lab is syncing users.
        /// </summary>
        [EnumMember(Value = "Syncing")]
        Syncing,
        /// <summary>
        /// The lab has been published.
        /// </summary>
        [EnumMember(Value = "Published")]
        Published
    }
    internal static class LabStateEnumExtension
    {
        internal static string ToSerializedValue(this LabState? value)
        {
            return value == null ? null : ((LabState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LabState value)
        {
            switch( value )
            {
                case LabState.Draft:
                    return "Draft";
                case LabState.Publishing:
                    return "Publishing";
                case LabState.Scaling:
                    return "Scaling";
                case LabState.Syncing:
                    return "Syncing";
                case LabState.Published:
                    return "Published";
            }
            return null;
        }

        internal static LabState? ParseLabState(this string value)
        {
            switch( value )
            {
                case "Draft":
                    return LabState.Draft;
                case "Publishing":
                    return LabState.Publishing;
                case "Scaling":
                    return LabState.Scaling;
                case "Syncing":
                    return LabState.Syncing;
                case "Published":
                    return LabState.Published;
            }
            return null;
        }
    }
}