// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningStateDR.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningStateDR
    {
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class ProvisioningStateDREnumExtension
    {
        internal static string ToSerializedValue(this ProvisioningStateDR? value)
        {
            return value == null ? null : ((ProvisioningStateDR)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProvisioningStateDR value)
        {
            switch( value )
            {
                case ProvisioningStateDR.Accepted:
                    return "Accepted";
                case ProvisioningStateDR.Succeeded:
                    return "Succeeded";
                case ProvisioningStateDR.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static ProvisioningStateDR? ParseProvisioningStateDR(this string value)
        {
            switch( value )
            {
                case "Accepted":
                    return ProvisioningStateDR.Accepted;
                case "Succeeded":
                    return ProvisioningStateDR.Succeeded;
                case "Failed":
                    return ProvisioningStateDR.Failed;
            }
            return null;
        }
    }
}
