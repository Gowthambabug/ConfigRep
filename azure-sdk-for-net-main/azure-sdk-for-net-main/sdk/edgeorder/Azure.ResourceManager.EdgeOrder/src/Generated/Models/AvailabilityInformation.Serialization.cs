// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class AvailabilityInformation
    {
        internal static AvailabilityInformation DeserializeAvailabilityInformation(JsonElement element)
        {
            Optional<AvailabilityStage> availabilityStage = default;
            Optional<DisabledReason> disabledReason = default;
            Optional<string> disabledReasonMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityStage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availabilityStage = new AvailabilityStage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disabledReason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disabledReason = new DisabledReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disabledReasonMessage"))
                {
                    disabledReasonMessage = property.Value.GetString();
                    continue;
                }
            }
            return new AvailabilityInformation(Optional.ToNullable(availabilityStage), Optional.ToNullable(disabledReason), disabledReasonMessage.Value);
        }
    }
}