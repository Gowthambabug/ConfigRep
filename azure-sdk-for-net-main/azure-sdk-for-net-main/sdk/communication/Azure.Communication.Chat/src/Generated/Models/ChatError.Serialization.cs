// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class ChatError
    {
        internal static ChatError DeserializeChatError(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<ChatError>> details = default;
            Optional<ChatError> innererror = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ChatError> array = new List<ChatError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeChatError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innererror = DeserializeChatError(property.Value);
                    continue;
                }
            }
            return new ChatError(code, message, target.Value, Optional.ToList(details), innererror.Value);
        }
    }
}