// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversion
    {
        internal static AssetConversion DeserializeAssetConversion(JsonElement element)
        {
            string id = default;
            AssetConversionOptions settings = default;
            Optional<AssetConversionOutput> output = default;
            RemoteRenderingServiceError error = default;
            AssetConversionStatus status = default;
            DateTimeOffset creationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settings"))
                {
                    settings = AssetConversionOptions.DeserializeAssetConversionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    output = AssetConversionOutput.DeserializeAssetConversionOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = RemoteRenderingServiceError.DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new AssetConversionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AssetConversion(id, settings, output.Value, error, status, creationTime);
        }
    }
}