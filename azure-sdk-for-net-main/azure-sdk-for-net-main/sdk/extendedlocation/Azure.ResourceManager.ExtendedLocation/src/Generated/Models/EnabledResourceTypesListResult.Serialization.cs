// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocation.Models
{
    internal partial class EnabledResourceTypesListResult
    {
        internal static EnabledResourceTypesListResult DeserializeEnabledResourceTypesListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<EnabledResourceType>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EnabledResourceType> array = new List<EnabledResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnabledResourceType.DeserializeEnabledResourceType(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EnabledResourceTypesListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}