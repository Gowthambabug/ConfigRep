// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GrantAccessData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("access");
            writer.WriteStringValue(Access.ToString());
            writer.WritePropertyName("durationInSeconds");
            writer.WriteNumberValue(DurationInSeconds);
            if (Optional.IsDefined(GetSecureVmGuestStateSAS))
            {
                writer.WritePropertyName("getSecureVMGuestStateSAS");
                writer.WriteBooleanValue(GetSecureVmGuestStateSAS.Value);
            }
            writer.WriteEndObject();
        }
    }
}