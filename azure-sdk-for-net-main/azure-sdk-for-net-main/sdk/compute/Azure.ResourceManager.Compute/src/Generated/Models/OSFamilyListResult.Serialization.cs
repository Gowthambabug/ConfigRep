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
    internal partial class OSFamilyListResult
    {
        internal static OSFamilyListResult DeserializeOSFamilyListResult(JsonElement element)
        {
            IReadOnlyList<OSFamilyData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OSFamilyData> array = new List<OSFamilyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OSFamilyData.DeserializeOSFamilyData(item));
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
            return new OSFamilyListResult(value, nextLink.Value);
        }
    }
}