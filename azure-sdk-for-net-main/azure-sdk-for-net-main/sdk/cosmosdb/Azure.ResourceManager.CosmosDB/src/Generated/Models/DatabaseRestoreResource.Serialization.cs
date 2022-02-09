// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DatabaseRestoreResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName");
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsCollectionDefined(CollectionNames))
            {
                writer.WritePropertyName("collectionNames");
                writer.WriteStartArray();
                foreach (var item in CollectionNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DatabaseRestoreResource DeserializeDatabaseRestoreResource(JsonElement element)
        {
            Optional<string> databaseName = default;
            Optional<IList<string>> collectionNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    collectionNames = array;
                    continue;
                }
            }
            return new DatabaseRestoreResource(databaseName.Value, Optional.ToList(collectionNames));
        }
    }
}