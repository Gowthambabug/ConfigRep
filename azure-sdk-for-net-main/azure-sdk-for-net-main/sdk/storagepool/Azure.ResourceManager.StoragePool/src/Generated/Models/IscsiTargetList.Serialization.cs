// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    internal partial class IscsiTargetList
    {
        internal static IscsiTargetList DeserializeIscsiTargetList(JsonElement element)
        {
            IReadOnlyList<IscsiTargetData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<IscsiTargetData> array = new List<IscsiTargetData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IscsiTargetData.DeserializeIscsiTargetData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IscsiTargetList(value, nextLink.Value);
        }
    }
}