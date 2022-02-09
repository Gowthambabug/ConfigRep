// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealthDetailListResult
    {
        internal static VpnClientConnectionHealthDetailListResult DeserializeVpnClientConnectionHealthDetailListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnClientConnectionHealthDetail>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VpnClientConnectionHealthDetail> array = new List<VpnClientConnectionHealthDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientConnectionHealthDetail.DeserializeVpnClientConnectionHealthDetail(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new VpnClientConnectionHealthDetailListResult(Optional.ToList(value));
        }
    }
}