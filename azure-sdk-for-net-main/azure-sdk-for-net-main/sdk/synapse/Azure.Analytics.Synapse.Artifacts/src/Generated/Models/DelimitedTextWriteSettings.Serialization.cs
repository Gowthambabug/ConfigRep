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
    [JsonConverter(typeof(DelimitedTextWriteSettingsConverter))]
    public partial class DelimitedTextWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QuoteAllText))
            {
                writer.WritePropertyName("quoteAllText");
                writer.WriteObjectValue(QuoteAllText);
            }
            writer.WritePropertyName("fileExtension");
            writer.WriteObjectValue(FileExtension);
            if (Optional.IsDefined(MaxRowsPerFile))
            {
                writer.WritePropertyName("maxRowsPerFile");
                writer.WriteObjectValue(MaxRowsPerFile);
            }
            if (Optional.IsDefined(FileNamePrefix))
            {
                writer.WritePropertyName("fileNamePrefix");
                writer.WriteObjectValue(FileNamePrefix);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextWriteSettings DeserializeDelimitedTextWriteSettings(JsonElement element)
        {
            Optional<object> quoteAllText = default;
            object fileExtension = default;
            Optional<object> maxRowsPerFile = default;
            Optional<object> fileNamePrefix = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quoteAllText"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    quoteAllText = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileExtension"))
                {
                    fileExtension = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxRowsPerFile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxRowsPerFile = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileNamePrefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileNamePrefix = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextWriteSettings(type, additionalProperties, quoteAllText.Value, fileExtension, maxRowsPerFile.Value, fileNamePrefix.Value);
        }

        internal partial class DelimitedTextWriteSettingsConverter : JsonConverter<DelimitedTextWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, DelimitedTextWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DelimitedTextWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDelimitedTextWriteSettings(document.RootElement);
            }
        }
    }
}