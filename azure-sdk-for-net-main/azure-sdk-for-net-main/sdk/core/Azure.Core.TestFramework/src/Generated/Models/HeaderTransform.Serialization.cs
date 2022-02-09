// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    public partial class HeaderTransform : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key");
            writer.WriteStringValue(Key);
            writer.WritePropertyName("value");
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition");
                writer.WriteObjectValue(Condition);
            }
            writer.WriteEndObject();
        }
    }
}
