// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class BulkRegistryOperationResponse
    {
        internal static BulkRegistryOperationResponse DeserializeBulkRegistryOperationResponse(JsonElement element)
        {
            Optional<bool> isSuccessful = default;
            Optional<IReadOnlyList<DeviceRegistryOperationError>> errors = default;
            Optional<IReadOnlyList<DeviceRegistryOperationWarning>> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSuccessful"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isSuccessful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeviceRegistryOperationError> array = new List<DeviceRegistryOperationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationError.DeserializeDeviceRegistryOperationError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeviceRegistryOperationWarning> array = new List<DeviceRegistryOperationWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationWarning.DeserializeDeviceRegistryOperationWarning(item));
                    }
                    warnings = array;
                    continue;
                }
            }
            return new BulkRegistryOperationResponse(Optional.ToNullable(isSuccessful), Optional.ToList(errors), Optional.ToList(warnings));
        }
    }
}
