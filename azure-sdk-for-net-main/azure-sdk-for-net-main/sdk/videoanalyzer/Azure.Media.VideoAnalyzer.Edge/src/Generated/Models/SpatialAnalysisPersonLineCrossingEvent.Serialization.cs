// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonLineCrossingEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold");
                writer.WriteStringValue(Threshold);
            }
            if (Optional.IsDefined(Focus))
            {
                writer.WritePropertyName("focus");
                writer.WriteStringValue(Focus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonLineCrossingEvent DeserializeSpatialAnalysisPersonLineCrossingEvent(JsonElement element)
        {
            Optional<string> threshold = default;
            Optional<SpatialAnalysisOperationFocus> focus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("focus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    focus = new SpatialAnalysisOperationFocus(property.Value.GetString());
                    continue;
                }
            }
            return new SpatialAnalysisPersonLineCrossingEvent(threshold.Value, Optional.ToNullable(focus));
        }
    }
}