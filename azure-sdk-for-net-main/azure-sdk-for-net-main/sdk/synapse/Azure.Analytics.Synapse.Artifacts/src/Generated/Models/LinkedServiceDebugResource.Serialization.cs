// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedServiceDebugResourceConverter))]
    public partial class LinkedServiceDebugResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(Properties);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static LinkedServiceDebugResource DeserializeLinkedServiceDebugResource(JsonElement element)
        {
            LinkedService properties = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    properties = LinkedService.DeserializeLinkedService(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedServiceDebugResource(name.Value, properties);
        }

        internal partial class LinkedServiceDebugResourceConverter : JsonConverter<LinkedServiceDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, LinkedServiceDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkedServiceDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedServiceDebugResource(document.RootElement);
            }
        }
    }
}