// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricAlertAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActionGroupId))
            {
                writer.WritePropertyName("actionGroupId");
                writer.WriteStringValue(ActionGroupId);
            }
            if (Optional.IsCollectionDefined(WebHookProperties))
            {
                writer.WritePropertyName("webHookProperties");
                writer.WriteStartObject();
                foreach (var item in WebHookProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static MetricAlertAction DeserializeMetricAlertAction(JsonElement element)
        {
            Optional<string> actionGroupId = default;
            Optional<IDictionary<string, string>> webHookProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroupId"))
                {
                    actionGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webHookProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    webHookProperties = dictionary;
                    continue;
                }
            }
            return new MetricAlertAction(actionGroupId.Value, Optional.ToDictionary(webHookProperties));
        }
    }
}