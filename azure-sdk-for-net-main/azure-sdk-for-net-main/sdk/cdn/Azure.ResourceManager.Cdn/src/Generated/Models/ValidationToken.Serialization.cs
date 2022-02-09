// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ValidationToken
    {
        internal static ValidationToken DeserializeValidationToken(JsonElement element)
        {
            Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"))
                {
                    token = property.Value.GetString();
                    continue;
                }
            }
            return new ValidationToken(token.Value);
        }
    }
}