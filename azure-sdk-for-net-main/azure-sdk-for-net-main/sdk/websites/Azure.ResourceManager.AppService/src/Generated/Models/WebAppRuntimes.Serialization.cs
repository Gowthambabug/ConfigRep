// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppRuntimes
    {
        internal static WebAppRuntimes DeserializeWebAppRuntimes(JsonElement element)
        {
            Optional<WebAppRuntimeSettings> linuxRuntimeSettings = default;
            Optional<WebAppRuntimeSettings> windowsRuntimeSettings = default;
            Optional<LinuxJavaContainerSettings> linuxContainerSettings = default;
            Optional<WindowsJavaContainerSettings> windowsContainerSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linuxRuntimeSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxRuntimeSettings = WebAppRuntimeSettings.DeserializeWebAppRuntimeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsRuntimeSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsRuntimeSettings = WebAppRuntimeSettings.DeserializeWebAppRuntimeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxContainerSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxContainerSettings = LinuxJavaContainerSettings.DeserializeLinuxJavaContainerSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsContainerSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsContainerSettings = WindowsJavaContainerSettings.DeserializeWindowsJavaContainerSettings(property.Value);
                    continue;
                }
            }
            return new WebAppRuntimes(linuxRuntimeSettings.Value, windowsRuntimeSettings.Value, linuxContainerSettings.Value, windowsContainerSettings.Value);
        }
    }
}