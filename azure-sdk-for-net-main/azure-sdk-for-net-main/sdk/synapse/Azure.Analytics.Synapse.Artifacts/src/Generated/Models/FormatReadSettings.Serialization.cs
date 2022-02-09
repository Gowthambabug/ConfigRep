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
    [JsonConverter(typeof(FormatReadSettingsConverter))]
    public partial class FormatReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static FormatReadSettings DeserializeFormatReadSettings(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BinaryReadSettings": return BinaryReadSettings.DeserializeBinaryReadSettings(element);
                    case "JsonReadSettings": return JsonReadSettings.DeserializeJsonReadSettings(element);
                    case "XmlReadSettings": return XmlReadSettings.DeserializeXmlReadSettings(element);
                    case "DelimitedTextReadSettings": return DelimitedTextReadSettings.DeserializeDelimitedTextReadSettings(element);
                }
            }
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FormatReadSettings(type, additionalProperties);
        }

        internal partial class FormatReadSettingsConverter : JsonConverter<FormatReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, FormatReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override FormatReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFormatReadSettings(document.RootElement);
            }
        }
    }
}