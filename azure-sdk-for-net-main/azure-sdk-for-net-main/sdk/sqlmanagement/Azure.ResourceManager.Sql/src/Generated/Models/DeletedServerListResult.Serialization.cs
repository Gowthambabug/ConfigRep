// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class DeletedServerListResult
    {
        internal static DeletedServerListResult DeserializeDeletedServerListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeletedServerData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeletedServerData> array = new List<DeletedServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedServerData.DeserializeDeletedServerData(item));
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
            return new DeletedServerListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}