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
    [JsonConverter(typeof(RedirectIncompatibleRowSettingsConverter))]
    public partial class RedirectIncompatibleRowSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteObjectValue(Path);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RedirectIncompatibleRowSettings DeserializeRedirectIncompatibleRowSettings(JsonElement element)
        {
            object linkedServiceName = default;
            Optional<object> path = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    path = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RedirectIncompatibleRowSettings(linkedServiceName, path.Value, additionalProperties);
        }

        internal partial class RedirectIncompatibleRowSettingsConverter : JsonConverter<RedirectIncompatibleRowSettings>
        {
            public override void Write(Utf8JsonWriter writer, RedirectIncompatibleRowSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RedirectIncompatibleRowSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRedirectIncompatibleRowSettings(document.RootElement);
            }
        }
    }
}