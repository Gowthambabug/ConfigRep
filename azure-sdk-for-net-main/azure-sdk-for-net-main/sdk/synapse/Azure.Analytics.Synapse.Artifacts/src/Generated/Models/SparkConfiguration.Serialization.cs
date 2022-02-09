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
    [JsonConverter(typeof(SparkConfigurationConverter))]
    public partial class SparkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("configs");
            writer.WriteStartObject();
            foreach (var item in Configs)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(Created))
            {
                writer.WritePropertyName("created");
                writer.WriteStringValue(Created.Value, "O");
            }
            if (Optional.IsCollectionDefined(ConfigMergeRule))
            {
                writer.WritePropertyName("configMergeRule");
                writer.WriteStartObject();
                foreach (var item in ConfigMergeRule)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static SparkConfiguration DeserializeSparkConfiguration(JsonElement element)
        {
            Optional<string> description = default;
            IDictionary<string, string> configs = default;
            Optional<IList<string>> annotations = default;
            Optional<string> notes = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> created = default;
            Optional<IDictionary<string, string>> configMergeRule = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configs"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    configs = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
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
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("notes"))
                {
                    notes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("configMergeRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    configMergeRule = dictionary;
                    continue;
                }
            }
            return new SparkConfiguration(description.Value, configs, Optional.ToList(annotations), notes.Value, createdBy.Value, Optional.ToNullable(created), Optional.ToDictionary(configMergeRule));
        }

        internal partial class SparkConfigurationConverter : JsonConverter<SparkConfiguration>
        {
            public override void Write(Utf8JsonWriter writer, SparkConfiguration model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkConfiguration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkConfiguration(document.RootElement);
            }
        }
    }
}