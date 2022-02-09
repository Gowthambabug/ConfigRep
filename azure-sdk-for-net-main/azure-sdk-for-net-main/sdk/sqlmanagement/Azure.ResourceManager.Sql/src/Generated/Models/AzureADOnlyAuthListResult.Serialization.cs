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
    internal partial class AzureADOnlyAuthListResult
    {
        internal static AzureADOnlyAuthListResult DeserializeAzureADOnlyAuthListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ServerAzureADOnlyAuthenticationData>> value = default;
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
                    List<ServerAzureADOnlyAuthenticationData> array = new List<ServerAzureADOnlyAuthenticationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerAzureADOnlyAuthenticationData.DeserializeServerAzureADOnlyAuthenticationData(item));
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
            return new AzureADOnlyAuthListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
