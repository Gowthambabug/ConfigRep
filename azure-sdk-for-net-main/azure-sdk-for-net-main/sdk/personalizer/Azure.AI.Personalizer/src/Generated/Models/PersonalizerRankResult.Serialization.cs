// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    public partial class PersonalizerRankResult
    {
        internal static PersonalizerRankResult DeserializePersonalizerRankResult(JsonElement element)
        {
            Optional<IReadOnlyList<PersonalizerRankedAction>> ranking = default;
            Optional<string> eventId = default;
            Optional<string> rewardActionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ranking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PersonalizerRankedAction> array = new List<PersonalizerRankedAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PersonalizerRankedAction.DeserializePersonalizerRankedAction(item));
                    }
                    ranking = array;
                    continue;
                }
                if (property.NameEquals("eventId"))
                {
                    eventId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rewardActionId"))
                {
                    rewardActionId = property.Value.GetString();
                    continue;
                }
            }
            return new PersonalizerRankResult(Optional.ToList(ranking), eventId.Value, rewardActionId.Value);
        }
    }
}