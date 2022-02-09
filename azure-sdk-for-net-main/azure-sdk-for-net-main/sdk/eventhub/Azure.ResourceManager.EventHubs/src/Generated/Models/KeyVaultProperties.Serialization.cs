// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName");
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri");
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion");
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            Optional<string> keyName = default;
            Optional<Uri> keyVaultUri = default;
            Optional<string> keyVersion = default;
            Optional<UserAssignedIdentityProperties> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVersion"))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = UserAssignedIdentityProperties.DeserializeUserAssignedIdentityProperties(property.Value);
                    continue;
                }
            }
            return new KeyVaultProperties(keyName.Value, keyVaultUri.Value, keyVersion.Value, identity.Value);
        }
    }
}