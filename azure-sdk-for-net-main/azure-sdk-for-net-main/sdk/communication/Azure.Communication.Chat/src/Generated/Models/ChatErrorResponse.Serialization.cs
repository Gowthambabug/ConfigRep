// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatErrorResponse
    {
        internal static ChatErrorResponse DeserializeChatErrorResponse(JsonElement element)
        {
            ChatError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = ChatError.DeserializeChatError(property.Value);
                    continue;
                }
            }
            return new ChatErrorResponse(error);
        }
    }
}
