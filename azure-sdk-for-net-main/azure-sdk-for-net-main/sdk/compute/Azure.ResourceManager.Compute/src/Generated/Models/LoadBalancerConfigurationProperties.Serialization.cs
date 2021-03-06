// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class LoadBalancerConfigurationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frontendIPConfigurations");
            writer.WriteStartArray();
            foreach (var item in FrontendIPConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static LoadBalancerConfigurationProperties DeserializeLoadBalancerConfigurationProperties(JsonElement element)
        {
            IList<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontendIPConfigurations"))
                {
                    List<LoadBalancerFrontendIPConfiguration> array = new List<LoadBalancerFrontendIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerFrontendIPConfiguration.DeserializeLoadBalancerFrontendIPConfiguration(item));
                    }
                    frontendIPConfigurations = array;
                    continue;
                }
            }
            return new LoadBalancerConfigurationProperties(frontendIPConfigurations);
        }
    }
}
