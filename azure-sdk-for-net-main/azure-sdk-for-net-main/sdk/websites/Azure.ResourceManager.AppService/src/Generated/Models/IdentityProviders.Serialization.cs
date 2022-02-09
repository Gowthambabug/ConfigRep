// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class IdentityProviders : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory");
                writer.WriteObjectValue(AzureActiveDirectory);
            }
            if (Optional.IsDefined(Facebook))
            {
                writer.WritePropertyName("facebook");
                writer.WriteObjectValue(Facebook);
            }
            if (Optional.IsDefined(GitHub))
            {
                writer.WritePropertyName("gitHub");
                writer.WriteObjectValue(GitHub);
            }
            if (Optional.IsDefined(Google))
            {
                writer.WritePropertyName("google");
                writer.WriteObjectValue(Google);
            }
            if (Optional.IsDefined(LegacyMicrosoftAccount))
            {
                writer.WritePropertyName("legacyMicrosoftAccount");
                writer.WriteObjectValue(LegacyMicrosoftAccount);
            }
            if (Optional.IsDefined(Twitter))
            {
                writer.WritePropertyName("twitter");
                writer.WriteObjectValue(Twitter);
            }
            if (Optional.IsDefined(Apple))
            {
                writer.WritePropertyName("apple");
                writer.WriteObjectValue(Apple);
            }
            if (Optional.IsDefined(AzureStaticWebApps))
            {
                writer.WritePropertyName("azureStaticWebApps");
                writer.WriteObjectValue(AzureStaticWebApps);
            }
            if (Optional.IsCollectionDefined(CustomOpenIdConnectProviders))
            {
                writer.WritePropertyName("customOpenIdConnectProviders");
                writer.WriteStartObject();
                foreach (var item in CustomOpenIdConnectProviders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static IdentityProviders DeserializeIdentityProviders(JsonElement element)
        {
            Optional<AzureActiveDirectory> azureActiveDirectory = default;
            Optional<Facebook> facebook = default;
            Optional<GitHub> gitHub = default;
            Optional<Google> google = default;
            Optional<LegacyMicrosoftAccount> legacyMicrosoftAccount = default;
            Optional<Twitter> twitter = default;
            Optional<Apple> apple = default;
            Optional<AzureStaticWebApps> azureStaticWebApps = default;
            Optional<IDictionary<string, CustomOpenIdConnectProvider>> customOpenIdConnectProviders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureActiveDirectory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureActiveDirectory = AzureActiveDirectory.DeserializeAzureActiveDirectory(property.Value);
                    continue;
                }
                if (property.NameEquals("facebook"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    facebook = Facebook.DeserializeFacebook(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHub"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gitHub = GitHub.DeserializeGitHub(property.Value);
                    continue;
                }
                if (property.NameEquals("google"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    google = Google.DeserializeGoogle(property.Value);
                    continue;
                }
                if (property.NameEquals("legacyMicrosoftAccount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    legacyMicrosoftAccount = LegacyMicrosoftAccount.DeserializeLegacyMicrosoftAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("twitter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    twitter = Twitter.DeserializeTwitter(property.Value);
                    continue;
                }
                if (property.NameEquals("apple"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    apple = Apple.DeserializeApple(property.Value);
                    continue;
                }
                if (property.NameEquals("azureStaticWebApps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureStaticWebApps = AzureStaticWebApps.DeserializeAzureStaticWebApps(property.Value);
                    continue;
                }
                if (property.NameEquals("customOpenIdConnectProviders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, CustomOpenIdConnectProvider> dictionary = new Dictionary<string, CustomOpenIdConnectProvider>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, CustomOpenIdConnectProvider.DeserializeCustomOpenIdConnectProvider(property0.Value));
                    }
                    customOpenIdConnectProviders = dictionary;
                    continue;
                }
            }
            return new IdentityProviders(azureActiveDirectory.Value, facebook.Value, gitHub.Value, google.Value, legacyMicrosoftAccount.Value, twitter.Value, apple.Value, azureStaticWebApps.Value, Optional.ToDictionary(customOpenIdConnectProviders));
        }
    }
}