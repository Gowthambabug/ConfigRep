// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Backup information of a resource. </summary>
    public partial class BackupInformation
    {
        /// <summary> Initializes a new instance of BackupInformation. </summary>
        internal BackupInformation()
        {
        }

        /// <summary> Initializes a new instance of BackupInformation. </summary>
        /// <param name="continuousBackupInformation"> Information about the status of continuous backups. </param>
        internal BackupInformation(ContinuousBackupInformation continuousBackupInformation)
        {
            ContinuousBackupInformation = continuousBackupInformation;
        }

        /// <summary> Information about the status of continuous backups. </summary>
        public ContinuousBackupInformation ContinuousBackupInformation { get; }
    }
}
