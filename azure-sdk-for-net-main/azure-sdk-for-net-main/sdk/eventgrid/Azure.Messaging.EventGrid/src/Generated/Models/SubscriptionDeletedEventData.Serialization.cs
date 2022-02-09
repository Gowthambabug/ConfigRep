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
    [JsonConverter(typeof(SubscriptionDeletedEventDataConverter))]
    public partial class SubscriptionDeletedEventData
    {
        internal static SubscriptionDeletedEventData DeserializeSubscriptionDeletedEventData(JsonElement element)
        {
            Optional<string> eventSubscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSubscriptionId"))
                {
                    eventSubscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new SubscriptionDeletedEventData(eventSubscriptionId.Value);
        }

        internal partial class SubscriptionDeletedEventDataConverter : JsonConverter<SubscriptionDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, SubscriptionDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SubscriptionDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSubscriptionDeletedEventData(document.RootElement);
            }
        }
    }
}