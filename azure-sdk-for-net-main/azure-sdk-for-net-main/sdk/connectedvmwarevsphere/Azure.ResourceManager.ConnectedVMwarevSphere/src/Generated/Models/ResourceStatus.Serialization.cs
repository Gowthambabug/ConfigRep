// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class ResourceStatus
    {
        internal static ResourceStatus DeserializeResourceStatus(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> status = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            Optional<string> severity = default;
            Optional<DateTimeOffset> lastUpdatedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdatedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ResourceStatus(type.Value, status.Value, reason.Value, message.Value, severity.Value, Optional.ToNullable(lastUpdatedAt));
        }
    }
}