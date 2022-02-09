// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StackHCI.Models;

namespace Azure.ResourceManager.StackHCI
{
    public partial class ArcSettingData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WritePropertyName("systemData");
            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(CreatedByType))
            {
                writer.WritePropertyName("createdByType");
                writer.WriteStringValue(CreatedByType.Value.ToString());
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt");
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy");
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Optional.IsDefined(LastModifiedByType))
            {
                writer.WritePropertyName("lastModifiedByType");
                writer.WriteStringValue(LastModifiedByType.Value.ToString());
            }
            if (Optional.IsDefined(LastModifiedAt))
            {
                writer.WritePropertyName("lastModifiedAt");
                writer.WriteStringValue(LastModifiedAt.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArcSettingData DeserializeArcSettingData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> arcInstanceResourceGroup = default;
            Optional<ArcSettingAggregateState> aggregateState = default;
            Optional<IReadOnlyList<PerNodeState>> perNodeDetails = default;
            Optional<string> createdBy = default;
            Optional<Models.CreatedByType> createdByType = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<string> lastModifiedBy = default;
            Optional<Models.CreatedByType> lastModifiedByType = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("arcInstanceResourceGroup"))
                        {
                            arcInstanceResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aggregateState = new ArcSettingAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PerNodeState> array = new List<PerNodeState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeState.DeserializePerNodeState(item));
                            }
                            perNodeDetails = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createdBy"))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdByType = new Models.CreatedByType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedByType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedByType = new Models.CreatedByType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArcSettingData(id, name, type, systemData, Optional.ToNullable(provisioningState), arcInstanceResourceGroup.Value, Optional.ToNullable(aggregateState), Optional.ToList(perNodeDetails), createdBy.Value, Optional.ToNullable(createdByType), Optional.ToNullable(createdAt), lastModifiedBy.Value, Optional.ToNullable(lastModifiedByType), Optional.ToNullable(lastModifiedAt));
        }
    }
}