// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AmazonS3DatasetConverter))]
    public partial class AmazonS3Dataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure");
                writer.WriteObjectValue(Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
                writer.WriteObjectValue(Schema);
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("bucketName");
            writer.WriteObjectValue(BucketName);
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteObjectValue(Key);
            }
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix");
                writer.WriteObjectValue(Prefix);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteObjectValue(Version);
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart");
                writer.WriteObjectValue(ModifiedDatetimeStart);
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd");
                writer.WriteObjectValue(ModifiedDatetimeEnd);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression");
                writer.WriteObjectValue(Compression);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AmazonS3Dataset DeserializeAmazonS3Dataset(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<object> structure = default;
            Optional<object> schema = default;
            LinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            Optional<DatasetFolder> folder = default;
            object bucketName = default;
            Optional<object> key = default;
            Optional<object> prefix = default;
            Optional<object> version = default;
            Optional<object> modifiedDatetimeStart = default;
            Optional<object> modifiedDatetimeEnd = default;
            Optional<DatasetStorageFormat> format = default;
            Optional<DatasetCompression> compression = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    structure = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("bucketName"))
                        {
                            bucketName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("key"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            key = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("prefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            prefix = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeStart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedDatetimeStart = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeEnd"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedDatetimeEnd = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("format"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            format = DatasetStorageFormat.DeserializeDatasetStorageFormat(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("compression"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compression = DatasetCompression.DeserializeDatasetCompression(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonS3Dataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, bucketName, key.Value, prefix.Value, version.Value, modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value, format.Value, compression.Value);
        }

        internal partial class AmazonS3DatasetConverter : JsonConverter<AmazonS3Dataset>
        {
            public override void Write(Utf8JsonWriter writer, AmazonS3Dataset model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AmazonS3Dataset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAmazonS3Dataset(document.RootElement);
            }
        }
    }
}