// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStoreProjection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables");
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Objects))
            {
                writer.WritePropertyName("objects");
                writer.WriteStartArray();
                foreach (var item in Objects)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KnowledgeStoreProjection DeserializeKnowledgeStoreProjection(JsonElement element)
        {
            Optional<IList<KnowledgeStoreTableProjectionSelector>> tables = default;
            Optional<IList<KnowledgeStoreObjectProjectionSelector>> objects = default;
            Optional<IList<KnowledgeStoreFileProjectionSelector>> files = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgeStoreTableProjectionSelector> array = new List<KnowledgeStoreTableProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreTableProjectionSelector.DeserializeKnowledgeStoreTableProjectionSelector(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("objects"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgeStoreObjectProjectionSelector> array = new List<KnowledgeStoreObjectProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreObjectProjectionSelector.DeserializeKnowledgeStoreObjectProjectionSelector(item));
                    }
                    objects = array;
                    continue;
                }
                if (property.NameEquals("files"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgeStoreFileProjectionSelector> array = new List<KnowledgeStoreFileProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreFileProjectionSelector.DeserializeKnowledgeStoreFileProjectionSelector(item));
                    }
                    files = array;
                    continue;
                }
            }
            return new KnowledgeStoreProjection(Optional.ToList(tables), Optional.ToList(objects), Optional.ToList(files));
        }
    }
}