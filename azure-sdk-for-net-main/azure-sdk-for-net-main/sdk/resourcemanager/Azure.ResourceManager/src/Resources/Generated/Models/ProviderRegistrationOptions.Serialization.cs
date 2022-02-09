// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ProviderRegistrationOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ThirdPartyProviderConsent))
            {
                writer.WritePropertyName("thirdPartyProviderConsent");
                writer.WriteObjectValue(ThirdPartyProviderConsent);
            }
            writer.WriteEndObject();
        }
    }
}
