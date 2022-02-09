// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(SubscriptionValidationResponseConverter))]
    public partial class SubscriptionValidationResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidationResponse))
            {
                writer.WritePropertyName("validationResponse");
                writer.WriteStringValue(ValidationResponse);
            }
            writer.WriteEndObject();
        }

        internal static SubscriptionValidationResponse DeserializeSubscriptionValidationResponse(JsonElement element)
        {
            Optional<string> validationResponse = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationResponse"))
                {
                    validationResponse = property.Value.GetString();
                    continue;
                }
            }
            return new SubscriptionValidationResponse(validationResponse.Value);
        }

        internal partial class SubscriptionValidationResponseConverter : JsonConverter<SubscriptionValidationResponse>
        {
            public override void Write(Utf8JsonWriter writer, SubscriptionValidationResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SubscriptionValidationResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSubscriptionValidationResponse(document.RootElement);
            }
        }
    }
}