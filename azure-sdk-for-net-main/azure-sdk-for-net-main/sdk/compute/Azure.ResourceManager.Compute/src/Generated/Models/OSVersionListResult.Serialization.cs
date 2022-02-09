// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class OSVersionListResult
    {
        internal static OSVersionListResult DeserializeOSVersionListResult(JsonElement element)
        {
            IReadOnlyList<OSVersionData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OSVersionData> array = new List<OSVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OSVersionData.DeserializeOSVersionData(item));
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
            return new OSVersionListResult(value, nextLink.Value);
        }
    }
}