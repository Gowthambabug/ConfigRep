// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SupportedOptimizationTypesListResult
    {
        internal static SupportedOptimizationTypesListResult DeserializeSupportedOptimizationTypesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<OptimizationType>> supportedOptimizationTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedOptimizationTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OptimizationType> array = new List<OptimizationType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new OptimizationType(item.GetString()));
                    }
                    supportedOptimizationTypes = array;
                    continue;
                }
            }
            return new SupportedOptimizationTypesListResult(Optional.ToList(supportedOptimizationTypes));
        }
    }
}