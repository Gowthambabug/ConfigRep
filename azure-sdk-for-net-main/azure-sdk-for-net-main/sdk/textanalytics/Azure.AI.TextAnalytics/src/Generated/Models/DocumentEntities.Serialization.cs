// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class DocumentEntities
    {
        internal static DocumentEntities DeserializeDocumentEntities(JsonElement element)
        {
            string id = default;
            IReadOnlyList<Entity> entities = default;
            IReadOnlyList<TextAnalyticsWarningInternal> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<Entity> array = new List<Entity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Entity.DeserializeEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarningInternal> array = new List<TextAnalyticsWarningInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarningInternal.DeserializeTextAnalyticsWarningInternal(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new DocumentEntities(id, entities, warnings, Optional.ToNullable(statistics));
        }
    }
}