// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StackMajorVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayVersion))
            {
                writer.WritePropertyName("displayVersion");
                writer.WriteStringValue(DisplayVersion);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion");
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault");
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsCollectionDefined(MinorVersions))
            {
                writer.WritePropertyName("minorVersions");
                writer.WriteStartArray();
                foreach (var item in MinorVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights");
                writer.WriteBooleanValue(ApplicationInsights.Value);
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview");
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated");
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden");
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (Optional.IsCollectionDefined(AppSettingsDictionary))
            {
                writer.WritePropertyName("appSettingsDictionary");
                writer.WriteStartObject();
                foreach (var item in AppSettingsDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SiteConfigPropertiesDictionary))
            {
                writer.WritePropertyName("siteConfigPropertiesDictionary");
                writer.WriteStartObject();
                foreach (var item in SiteConfigPropertiesDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static StackMajorVersion DeserializeStackMajorVersion(JsonElement element)
        {
            Optional<string> displayVersion = default;
            Optional<string> runtimeVersion = default;
            Optional<bool> isDefault = default;
            Optional<IList<StackMinorVersion>> minorVersions = default;
            Optional<bool> applicationInsights = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<IDictionary<string, object>> appSettingsDictionary = default;
            Optional<IDictionary<string, object>> siteConfigPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayVersion"))
                {
                    displayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minorVersions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StackMinorVersion> array = new List<StackMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StackMinorVersion.DeserializeStackMinorVersion(item));
                    }
                    minorVersions = array;
                    continue;
                }
                if (property.NameEquals("applicationInsights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationInsights = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPreview"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    siteConfigPropertiesDictionary = dictionary;
                    continue;
                }
            }
            return new StackMajorVersion(displayVersion.Value, runtimeVersion.Value, Optional.ToNullable(isDefault), Optional.ToList(minorVersions), Optional.ToNullable(applicationInsights), Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToDictionary(appSettingsDictionary), Optional.ToDictionary(siteConfigPropertiesDictionary));
        }
    }
}
