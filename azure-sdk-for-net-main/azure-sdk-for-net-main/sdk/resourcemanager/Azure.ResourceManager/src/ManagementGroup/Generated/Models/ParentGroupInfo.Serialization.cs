// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    public partial class ParentGroupInfo
    {
        internal static ParentGroupInfo DeserializeParentGroupInfo(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new ParentGroupInfo(id.Value, name.Value, displayName.Value);
        }
    }
}