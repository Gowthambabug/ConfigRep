// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnNatRuleMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace");
                writer.WriteStringValue(AddressSpace);
            }
            writer.WriteEndObject();
        }

        internal static VpnNatRuleMapping DeserializeVpnNatRuleMapping(JsonElement element)
        {
            Optional<string> addressSpace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressSpace"))
                {
                    addressSpace = property.Value.GetString();
                    continue;
                }
            }
            return new VpnNatRuleMapping(addressSpace.Value);
        }
    }
}