// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SampleUtterance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text");
                writer.WriteStringValue(Text);
            }
            if (Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links");
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Qid))
            {
                writer.WritePropertyName("qid");
                writer.WriteStringValue(Qid);
            }
            writer.WriteEndObject();
        }

        internal static SampleUtterance DeserializeSampleUtterance(JsonElement element)
        {
            Optional<string> text = default;
            Optional<IList<string>> links = default;
            Optional<string> qid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("qid"))
                {
                    qid = property.Value.GetString();
                    continue;
                }
            }
            return new SampleUtterance(text.Value, Optional.ToList(links), qid.Value);
        }
    }
}
