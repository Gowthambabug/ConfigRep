// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class BuiltInAuthenticationProviderExtensions
    {
        public static string ToSerialString(this BuiltInAuthenticationProvider value) => value switch
        {
            BuiltInAuthenticationProvider.AzureActiveDirectory => "AzureActiveDirectory",
            BuiltInAuthenticationProvider.Facebook => "Facebook",
            BuiltInAuthenticationProvider.Google => "Google",
            BuiltInAuthenticationProvider.MicrosoftAccount => "MicrosoftAccount",
            BuiltInAuthenticationProvider.Twitter => "Twitter",
            BuiltInAuthenticationProvider.Github => "Github",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BuiltInAuthenticationProvider value.")
        };

        public static BuiltInAuthenticationProvider ToBuiltInAuthenticationProvider(this string value)
        {
            if (string.Equals(value, "AzureActiveDirectory", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.AzureActiveDirectory;
            if (string.Equals(value, "Facebook", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.Facebook;
            if (string.Equals(value, "Google", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.Google;
            if (string.Equals(value, "MicrosoftAccount", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.MicrosoftAccount;
            if (string.Equals(value, "Twitter", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.Twitter;
            if (string.Equals(value, "Github", StringComparison.InvariantCultureIgnoreCase)) return BuiltInAuthenticationProvider.Github;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BuiltInAuthenticationProvider value.");
        }
    }
}