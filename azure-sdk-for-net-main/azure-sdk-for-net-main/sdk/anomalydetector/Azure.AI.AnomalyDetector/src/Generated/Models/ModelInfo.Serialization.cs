// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class ModelInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SlidingWindow))
            {
                writer.WritePropertyName("slidingWindow");
                writer.WriteNumberValue(SlidingWindow.Value);
            }
            if (Optional.IsDefined(AlignPolicy))
            {
                writer.WritePropertyName("alignPolicy");
                writer.WriteObjectValue(AlignPolicy);
            }
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source);
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime");
            writer.WriteStringValue(EndTime, "O");
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static ModelInfo DeserializeModelInfo(JsonElement element)
        {
            Optional<int> slidingWindow = default;
            Optional<AlignPolicy> alignPolicy = default;
            string source = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            Optional<string> displayName = default;
            Optional<ModelStatus> status = default;
            Optional<IReadOnlyList<ErrorResponse>> errors = default;
            Optional<DiagnosticsInfo> diagnosticsInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slidingWindow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    slidingWindow = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("alignPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alignPolicy = AlignPolicy.DeserializeAlignPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToModelStatus();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorResponse.DeserializeErrorResponse(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("diagnosticsInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diagnosticsInfo = DiagnosticsInfo.DeserializeDiagnosticsInfo(property.Value);
                    continue;
                }
            }
            return new ModelInfo(Optional.ToNullable(slidingWindow), alignPolicy.Value, source, startTime, endTime, displayName.Value, Optional.ToNullable(status), Optional.ToList(errors), diagnosticsInfo.Value);
        }
    }
}