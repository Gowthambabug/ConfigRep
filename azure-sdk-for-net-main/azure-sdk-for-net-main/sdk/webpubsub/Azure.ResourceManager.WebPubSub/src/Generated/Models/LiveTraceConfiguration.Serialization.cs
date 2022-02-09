// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class LiveTraceConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteStringValue(Enabled);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories");
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LiveTraceConfiguration DeserializeLiveTraceConfiguration(JsonElement element)
        {
            Optional<string> enabled = default;
            Optional<IList<LiveTraceCategory>> categories = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categories"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LiveTraceCategory> array = new List<LiveTraceCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LiveTraceCategory.DeserializeLiveTraceCategory(item));
                    }
                    categories = array;
                    continue;
                }
            }
            return new LiveTraceConfiguration(enabled.Value, Optional.ToList(categories));
        }
    }
}