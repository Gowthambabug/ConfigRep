// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class V1Manifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture");
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag");
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsCollectionDefined(FsLayers))
            {
                writer.WritePropertyName("fsLayers");
                writer.WriteStartArray();
                foreach (var item in FsLayers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(History))
            {
                writer.WritePropertyName("history");
                writer.WriteStartArray();
                foreach (var item in History)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Signatures))
            {
                writer.WritePropertyName("signatures");
                writer.WriteStartArray();
                foreach (var item in Signatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static V1Manifest DeserializeV1Manifest(JsonElement element)
        {
            Optional<string> architecture = default;
            Optional<string> name = default;
            Optional<string> tag = default;
            Optional<IList<FsLayer>> fsLayers = default;
            Optional<IList<History>> history = default;
            Optional<IList<ImageSignature>> signatures = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FsLayer> array = new List<FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FsLayer.DeserializeFsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<History> array = new List<History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistry.History.DeserializeHistory(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ImageSignature> array = new List<ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageSignature.DeserializeImageSignature(item));
                    }
                    signatures = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new V1Manifest(Optional.ToNullable(schemaVersion), architecture.Value, name.Value, tag.Value, Optional.ToList(fsLayers), Optional.ToList(history), Optional.ToList(signatures));
        }
    }
}