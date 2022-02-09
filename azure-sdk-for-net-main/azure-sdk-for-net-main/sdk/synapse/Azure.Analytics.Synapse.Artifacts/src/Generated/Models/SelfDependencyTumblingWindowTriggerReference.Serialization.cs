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
    [JsonConverter(typeof(SelfDependencyTumblingWindowTriggerReferenceConverter))]
    public partial class SelfDependencyTumblingWindowTriggerReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("offset");
            writer.WriteStringValue(Offset);
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size");
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SelfDependencyTumblingWindowTriggerReference DeserializeSelfDependencyTumblingWindowTriggerReference(JsonElement element)
        {
            string offset = default;
            Optional<string> size = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SelfDependencyTumblingWindowTriggerReference(type, offset, size.Value);
        }

        internal partial class SelfDependencyTumblingWindowTriggerReferenceConverter : JsonConverter<SelfDependencyTumblingWindowTriggerReference>
        {
            public override void Write(Utf8JsonWriter writer, SelfDependencyTumblingWindowTriggerReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SelfDependencyTumblingWindowTriggerReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSelfDependencyTumblingWindowTriggerReference(document.RootElement);
            }
        }
    }
}