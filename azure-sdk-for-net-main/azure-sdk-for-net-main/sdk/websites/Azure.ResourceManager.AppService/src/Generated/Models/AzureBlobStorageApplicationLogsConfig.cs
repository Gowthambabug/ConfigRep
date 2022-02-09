// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs azure blob storage configuration. </summary>
    public partial class AzureBlobStorageApplicationLogsConfig
    {
        /// <summary> Initializes a new instance of AzureBlobStorageApplicationLogsConfig. </summary>
        public AzureBlobStorageApplicationLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of AzureBlobStorageApplicationLogsConfig. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUrl"> SAS url to a azure blob container with read/write/list/delete permissions. </param>
        /// <param name="retentionInDays">
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </param>
        internal AzureBlobStorageApplicationLogsConfig(LogLevel? level, string sasUrl, int? retentionInDays)
        {
            Level = level;
            SasUrl = sasUrl;
            RetentionInDays = retentionInDays;
        }

        /// <summary> Log level. </summary>
        public LogLevel? Level { get; set; }
        /// <summary> SAS url to a azure blob container with read/write/list/delete permissions. </summary>
        public string SasUrl { get; set; }
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        public int? RetentionInDays { get; set; }
    }
}