// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FilesAndDirectoriesListSegment
    {
        internal static FilesAndDirectoriesListSegment DeserializeFilesAndDirectoriesListSegment(XElement element)
        {
            IReadOnlyList<DirectoryItem> directoryItems = default;
            IReadOnlyList<FileItem> fileItems = default;
            var array = new List<DirectoryItem>();
            foreach (var e in element.Elements("Directory"))
            {
                array.Add(DirectoryItem.DeserializeDirectoryItem(e));
            }
            directoryItems = array;
            var array0 = new List<FileItem>();
            foreach (var e in element.Elements("File"))
            {
                array0.Add(FileItem.DeserializeFileItem(e));
            }
            fileItems = array0;
            return new FilesAndDirectoriesListSegment(directoryItems, fileItems);
        }
    }
}
