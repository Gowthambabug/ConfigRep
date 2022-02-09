// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnGatewayData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections");
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BgpSettings))
            {
                writer.WritePropertyName("bgpSettings");
                writer.WriteObjectValue(BgpSettings);
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit");
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (Optional.IsDefined(IsRoutingPreferenceInternet))
            {
                writer.WritePropertyName("isRoutingPreferenceInternet");
                writer.WriteBooleanValue(IsRoutingPreferenceInternet.Value);
            }
            if (Optional.IsCollectionDefined(NatRules))
            {
                writer.WritePropertyName("natRules");
                writer.WriteStartArray();
                foreach (var item in NatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnGatewayData DeserializeVpnGatewayData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualHub = default;
            Optional<IList<VpnConnectionData>> connections = default;
            Optional<BgpSettings> bgpSettings = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            Optional<IReadOnlyList<VpnGatewayIpConfiguration>> ipConfigurations = default;
            Optional<bool> isRoutingPreferenceInternet = default;
            Optional<IList<VpnGatewayNatRuleData>> natRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("virtualHub"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("connections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnConnectionData> array = new List<VpnConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnConnectionData.DeserializeVpnConnectionData(item));
                            }
                            connections = array;
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnGatewayIpConfiguration> array = new List<VpnGatewayIpConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnGatewayIpConfiguration.DeserializeVpnGatewayIpConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("isRoutingPreferenceInternet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRoutingPreferenceInternet = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("natRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnGatewayNatRuleData> array = new List<VpnGatewayNatRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnGatewayNatRuleData.DeserializeVpnGatewayNatRuleData(item));
                            }
                            natRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnGatewayData(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualHub, Optional.ToList(connections), bgpSettings.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(vpnGatewayScaleUnit), Optional.ToList(ipConfigurations), Optional.ToNullable(isRoutingPreferenceInternet), Optional.ToList(natRules));
        }
    }
}