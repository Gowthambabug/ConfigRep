// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerRunsQueryResponseConverter))]
    public partial class TriggerRunsQueryResponse
    {
        internal static TriggerRunsQueryResponse DeserializeTriggerRunsQueryResponse(JsonElement element)
        {
            IReadOnlyList<TriggerRun> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TriggerRun> array = new List<TriggerRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerRun.DeserializeTriggerRun(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerRunsQueryResponse(value, continuationToken.Value);
        }

        internal partial class TriggerRunsQueryResponseConverter : JsonConverter<TriggerRunsQueryResponse>
        {
            public override void Write(Utf8JsonWriter writer, TriggerRunsQueryResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override TriggerRunsQueryResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerRunsQueryResponse(document.RootElement);
            }
        }
    }
}