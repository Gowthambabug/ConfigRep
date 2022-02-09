// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesInsightsEventProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(PropertyValueType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(PropertyValueType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesInsightsEventProperty DeserializeTimeSeriesInsightsEventProperty(JsonElement element)
        {
            Optional<string> name = default;
            Optional<TimeSeriesPropertyType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new TimeSeriesPropertyType(property.Value.GetString());
                    continue;
                }
            }
            return new TimeSeriesInsightsEventProperty(name.Value, Optional.ToNullable(type));
        }
    }
}