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
    /// Defines values for LoginMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoginMode
    {
        /// <summary>
        /// The LOGON32_LOGON_BATCH Win32 login mode. The batch login mode is
        /// recommended for long running parallel processes.
        /// </summary>
        [EnumMember(Value = "batch")]
        Batch,
        /// <summary>
        /// The LOGON32_LOGON_INTERACTIVE Win32 login mode. UAC is enabled on
        /// Windows VirtualMachineConfiguration Pools. If this option is used
        /// with an elevated user identity in a Windows
        /// VirtualMachineConfiguration Pool, the user session will not be
        /// elevated unless the application executed by the Task command line
        /// is configured to always require administrative privilege or to
        /// always require maximum privilege.
        /// </summary>
        [EnumMember(Value = "interactive")]
        Interactive
    }
    internal static class LoginModeEnumExtension
    {
        internal static string ToSerializedValue(this LoginMode? value)
        {
            return value == null ? null : ((LoginMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LoginMode value)
        {
            switch( value )
            {
                case LoginMode.Batch:
                    return "batch";
                case LoginMode.Interactive:
                    return "interactive";
            }
            return null;
        }

        internal static LoginMode? ParseLoginMode(this string value)
        {
            switch( value )
            {
                case "batch":
                    return LoginMode.Batch;
                case "interactive":
                    return LoginMode.Interactive;
            }
            return null;
        }
    }
}
