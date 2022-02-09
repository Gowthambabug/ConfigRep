// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class VirtualNetworkRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(IgnoreMissingVnetServiceEndpoint))
            {
                writer.WritePropertyName("ignoreMissingVnetServiceEndpoint");
                writer.WriteBooleanValue(IgnoreMissingVnetServiceEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworkRule DeserializeVirtualNetworkRule(JsonElement element)
        {
            string id = default;
            Optional<bool> ignoreMissingVnetServiceEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreMissingVnetServiceEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ignoreMissingVnetServiceEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new VirtualNetworkRule(id, Optional.ToNullable(ignoreMissingVnetServiceEndpoint));
        }
    }
}