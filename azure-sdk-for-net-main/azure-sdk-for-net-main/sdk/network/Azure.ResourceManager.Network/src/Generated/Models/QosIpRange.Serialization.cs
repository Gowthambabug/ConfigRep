// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class QosIpRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartIP))
            {
                writer.WritePropertyName("startIP");
                writer.WriteStringValue(StartIP);
            }
            if (Optional.IsDefined(EndIP))
            {
                writer.WritePropertyName("endIP");
                writer.WriteStringValue(EndIP);
            }
            writer.WriteEndObject();
        }

        internal static QosIpRange DeserializeQosIpRange(JsonElement element)
        {
            Optional<string> startIP = default;
            Optional<string> endIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startIP"))
                {
                    startIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endIP"))
                {
                    endIP = property.Value.GetString();
                    continue;
                }
            }
            return new QosIpRange(startIP.Value, endIP.Value);
        }
    }
}