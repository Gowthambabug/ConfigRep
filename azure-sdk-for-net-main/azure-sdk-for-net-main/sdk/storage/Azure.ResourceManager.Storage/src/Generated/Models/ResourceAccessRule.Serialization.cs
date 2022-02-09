// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ResourceAccessRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            writer.WriteEndObject();
        }

        internal static ResourceAccessRule DeserializeResourceAccessRule(JsonElement element)
        {
            Optional<string> tenantId = default;
            Optional<string> resourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceAccessRule(tenantId.Value, resourceId.Value);
        }
    }
}