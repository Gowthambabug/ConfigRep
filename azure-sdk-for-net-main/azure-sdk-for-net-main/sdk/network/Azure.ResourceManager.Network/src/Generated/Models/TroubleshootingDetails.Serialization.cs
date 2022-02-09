// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TroubleshootingDetails
    {
        internal static TroubleshootingDetails DeserializeTroubleshootingDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> reasonType = default;
            Optional<string> summary = default;
            Optional<string> detail = default;
            Optional<IReadOnlyList<TroubleshootingRecommendedActions>> recommendedActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reasonType"))
                {
                    reasonType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TroubleshootingRecommendedActions> array = new List<TroubleshootingRecommendedActions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TroubleshootingRecommendedActions.DeserializeTroubleshootingRecommendedActions(item));
                    }
                    recommendedActions = array;
                    continue;
                }
            }
            return new TroubleshootingDetails(id.Value, reasonType.Value, summary.Value, detail.Value, Optional.ToList(recommendedActions));
        }
    }
}