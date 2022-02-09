// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatMessageReadReceiptsCollection
    {
        internal static ChatMessageReadReceiptsCollection DeserializeChatMessageReadReceiptsCollection(JsonElement element)
        {
            IReadOnlyList<ChatMessageReadReceiptInternal> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ChatMessageReadReceiptInternal> array = new List<ChatMessageReadReceiptInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatMessageReadReceiptInternal.DeserializeChatMessageReadReceiptInternal(item));
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
            return new ChatMessageReadReceiptsCollection(value, nextLink.Value);
        }
    }
}