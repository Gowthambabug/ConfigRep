// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class CommunicationIdentifierModel
    {
        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element)
        {
            Optional<string> rawId = default;
            Optional<CommunicationUserIdentifierModel> communicationUser = default;
            Optional<PhoneNumberIdentifierModel> phoneNumber = default;
            Optional<MicrosoftTeamsUserIdentifierModel> microsoftTeamsUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawId"))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    phoneNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    microsoftTeamsUser = MicrosoftTeamsUserIdentifierModel.DeserializeMicrosoftTeamsUserIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentifierModel(rawId.Value, communicationUser.Value, phoneNumber.Value, microsoftTeamsUser.Value);
        }
    }
}