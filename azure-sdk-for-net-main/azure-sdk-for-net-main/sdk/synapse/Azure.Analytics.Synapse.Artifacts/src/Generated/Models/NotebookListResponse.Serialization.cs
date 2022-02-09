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
    [JsonConverter(typeof(NotebookListResponseConverter))]
    internal partial class NotebookListResponse
    {
        internal static NotebookListResponse DeserializeNotebookListResponse(JsonElement element)
        {
            IReadOnlyList<NotebookResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<NotebookResource> array = new List<NotebookResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotebookResource.DeserializeNotebookResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NotebookListResponse(value, nextLink.Value);
        }

        internal partial class NotebookListResponseConverter : JsonConverter<NotebookListResponse>
        {
            public override void Write(Utf8JsonWriter writer, NotebookListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override NotebookListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookListResponse(document.RootElement);
            }
        }
    }
}