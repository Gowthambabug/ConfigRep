// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class UpstreamAuthSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                writer.WritePropertyName("managedIdentity");
                writer.WriteObjectValue(ManagedIdentity);
            }
            writer.WriteEndObject();
        }

        internal static UpstreamAuthSettings DeserializeUpstreamAuthSettings(JsonElement element)
        {
            Optional<UpstreamAuthType> type = default;
            Optional<ManagedIdentitySettings> managedIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new UpstreamAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedIdentity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedIdentity = ManagedIdentitySettings.DeserializeManagedIdentitySettings(property.Value);
                    continue;
                }
            }
            return new UpstreamAuthSettings(Optional.ToNullable(type), managedIdentity.Value);
        }
    }
}