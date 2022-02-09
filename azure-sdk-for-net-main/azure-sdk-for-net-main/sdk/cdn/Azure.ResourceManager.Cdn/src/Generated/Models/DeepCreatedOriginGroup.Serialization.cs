// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeepCreatedOriginGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbeSettings))
            {
                if (HealthProbeSettings != null)
                {
                    writer.WritePropertyName("healthProbeSettings");
                    writer.WriteObjectValue(HealthProbeSettings);
                }
                else
                {
                    writer.WriteNull("healthProbeSettings");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins");
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes))
            {
                if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                    writer.WriteNumberValue(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(ResponseBasedOriginErrorDetectionSettings))
            {
                if (ResponseBasedOriginErrorDetectionSettings != null)
                {
                    writer.WritePropertyName("responseBasedOriginErrorDetectionSettings");
                    writer.WriteObjectValue(ResponseBasedOriginErrorDetectionSettings);
                }
                else
                {
                    writer.WriteNull("responseBasedOriginErrorDetectionSettings");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeepCreatedOriginGroup DeserializeDeepCreatedOriginGroup(JsonElement element)
        {
            string name = default;
            Optional<HealthProbeParameters> healthProbeSettings = default;
            Optional<IList<WritableSubResource>> origins = default;
            Optional<int?> trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            Optional<ResponseBasedOriginErrorDetectionParameters> responseBasedOriginErrorDetectionSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("healthProbeSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthProbeSettings = null;
                                continue;
                            }
                            healthProbeSettings = HealthProbeParameters.DeserializeHealthProbeParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("origins"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("responseBasedOriginErrorDetectionSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                responseBasedOriginErrorDetectionSettings = null;
                                continue;
                            }
                            responseBasedOriginErrorDetectionSettings = ResponseBasedOriginErrorDetectionParameters.DeserializeResponseBasedOriginErrorDetectionParameters(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeepCreatedOriginGroup(name, healthProbeSettings.Value, Optional.ToList(origins), Optional.ToNullable(trafficRestorationTimeToHealedOrNewEndpointsInMinutes), responseBasedOriginErrorDetectionSettings.Value);
        }
    }
}