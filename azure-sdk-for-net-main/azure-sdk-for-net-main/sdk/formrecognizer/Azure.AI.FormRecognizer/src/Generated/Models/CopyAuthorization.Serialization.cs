// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class CopyAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetResourceRegion");
            writer.WriteStringValue(TargetResourceRegion);
            writer.WritePropertyName("targetModelId");
            writer.WriteStringValue(TargetModelId);
            writer.WritePropertyName("targetModelLocation");
            writer.WriteStringValue(TargetModelLocation);
            writer.WritePropertyName("accessToken");
            writer.WriteStringValue(AccessToken);
            writer.WritePropertyName("expirationDateTime");
            writer.WriteStringValue(ExpirationDateTime, "O");
            writer.WriteEndObject();
        }

        internal static CopyAuthorization DeserializeCopyAuthorization(JsonElement element)
        {
            string targetResourceId = default;
            string targetResourceRegion = default;
            string targetModelId = default;
            string targetModelLocation = default;
            string accessToken = default;
            DateTimeOffset expirationDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceRegion"))
                {
                    targetResourceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelId"))
                {
                    targetModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelLocation"))
                {
                    targetModelLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTime"))
                {
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new CopyAuthorization(targetResourceId, targetResourceRegion, targetModelId, targetModelLocation, accessToken, expirationDateTime);
        }
    }
}