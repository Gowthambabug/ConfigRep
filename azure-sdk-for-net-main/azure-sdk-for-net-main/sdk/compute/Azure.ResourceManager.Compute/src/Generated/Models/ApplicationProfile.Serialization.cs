// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ApplicationProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(GalleryApplications))
            {
                writer.WritePropertyName("galleryApplications");
                writer.WriteStartArray();
                foreach (var item in GalleryApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationProfile DeserializeApplicationProfile(JsonElement element)
        {
            Optional<IList<VmGalleryApplication>> galleryApplications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("galleryApplications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VmGalleryApplication> array = new List<VmGalleryApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmGalleryApplication.DeserializeVmGalleryApplication(item));
                    }
                    galleryApplications = array;
                    continue;
                }
            }
            return new ApplicationProfile(Optional.ToList(galleryApplications));
        }
    }
}