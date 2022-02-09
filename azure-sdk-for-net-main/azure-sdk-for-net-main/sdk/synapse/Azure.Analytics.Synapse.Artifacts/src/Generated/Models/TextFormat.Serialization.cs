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
    [JsonConverter(typeof(TextFormatConverter))]
    public partial class TextFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter");
                writer.WriteObjectValue(ColumnDelimiter);
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter");
                writer.WriteObjectValue(RowDelimiter);
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar");
                writer.WriteObjectValue(EscapeChar);
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar");
                writer.WriteObjectValue(QuoteChar);
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue");
                writer.WriteObjectValue(NullValue);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName");
                writer.WriteObjectValue(EncodingName);
            }
            if (Optional.IsDefined(TreatEmptyAsNull))
            {
                writer.WritePropertyName("treatEmptyAsNull");
                writer.WriteObjectValue(TreatEmptyAsNull);
            }
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount");
                writer.WriteObjectValue(SkipLineCount);
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader");
                writer.WriteObjectValue(FirstRowAsHeader);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer");
                writer.WriteObjectValue(Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer");
                writer.WriteObjectValue(Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TextFormat DeserializeTextFormat(JsonElement element)
        {
            Optional<object> columnDelimiter = default;
            Optional<object> rowDelimiter = default;
            Optional<object> escapeChar = default;
            Optional<object> quoteChar = default;
            Optional<object> nullValue = default;
            Optional<object> encodingName = default;
            Optional<object> treatEmptyAsNull = default;
            Optional<object> skipLineCount = default;
            Optional<object> firstRowAsHeader = default;
            string type = default;
            Optional<object> serializer = default;
            Optional<object> deserializer = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnDelimiter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    columnDelimiter = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rowDelimiter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowDelimiter = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("escapeChar"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    escapeChar = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("quoteChar"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    quoteChar = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("nullValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nullValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("encodingName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encodingName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("treatEmptyAsNull"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    treatEmptyAsNull = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("skipLineCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipLineCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("firstRowAsHeader"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    firstRowAsHeader = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serializer = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deserializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deserializer = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TextFormat(type, serializer.Value, deserializer.Value, additionalProperties, columnDelimiter.Value, rowDelimiter.Value, escapeChar.Value, quoteChar.Value, nullValue.Value, encodingName.Value, treatEmptyAsNull.Value, skipLineCount.Value, firstRowAsHeader.Value);
        }

        internal partial class TextFormatConverter : JsonConverter<TextFormat>
        {
            public override void Write(Utf8JsonWriter writer, TextFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TextFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTextFormat(document.RootElement);
            }
        }
    }
}