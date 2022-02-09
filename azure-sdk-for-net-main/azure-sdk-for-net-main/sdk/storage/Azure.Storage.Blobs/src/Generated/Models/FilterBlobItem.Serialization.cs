// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class FilterBlobItem
    {
        internal static FilterBlobItem DeserializeFilterBlobItem(XElement element)
        {
            string name = default;
            string containerName = default;
            BlobTags tags = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("ContainerName") is XElement containerNameElement)
            {
                containerName = (string)containerNameElement;
            }
            if (element.Element("Tags") is XElement tagsElement)
            {
                tags = BlobTags.DeserializeBlobTags(tagsElement);
            }
            return new FilterBlobItem(name, containerName, tags);
        }
    }
}