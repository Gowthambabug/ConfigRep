// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure data lake store read settings. </summary>
    public partial class AmazonS3ReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of AmazonS3ReadSettings. </summary>
        public AmazonS3ReadSettings()
        {
            Type = "AmazonS3ReadSettings";
        }

        /// <summary> Initializes a new instance of AmazonS3ReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> AmazonS3 wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> AmazonS3 wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="prefix"> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="modifiedDatetimeStart"> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        internal AmazonS3ReadSettings(string type, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object recursive, object wildcardFolderPath, object wildcardFileName, object prefix, object fileListPath, bool? enablePartitionDiscovery, object partitionRootPath, object deleteFilesAfterCompletion, object modifiedDatetimeStart, object modifiedDatetimeEnd) : base(type, maxConcurrentConnections, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            Prefix = prefix;
            FileListPath = fileListPath;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Type = type ?? "AmazonS3ReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
        /// <summary> AmazonS3 wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public object WildcardFolderPath { get; set; }
        /// <summary> AmazonS3 wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public object WildcardFileName { get; set; }
        /// <summary> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </summary>
        public object Prefix { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public object FileListPath { get; set; }
        /// <summary> Indicates whether to enable partition discovery. </summary>
        public bool? EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public object PartitionRootPath { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object DeleteFilesAfterCompletion { get; set; }
        /// <summary> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
    }
}