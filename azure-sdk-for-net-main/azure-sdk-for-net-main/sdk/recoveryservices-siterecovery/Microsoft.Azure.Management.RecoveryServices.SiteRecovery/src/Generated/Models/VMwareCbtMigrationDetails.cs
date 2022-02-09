// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VMwareCbt provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtMigrationDetails : MigrationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtMigrationDetails class.
        /// </summary>
        public VMwareCbtMigrationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtMigrationDetails class.
        /// </summary>
        /// <param name="vmwareMachineId">The ARM Id of the VM discovered in
        /// VMware.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="firmwareType">The firmware type.</param>
        /// <param name="targetGeneration">The target generation.</param>
        /// <param name="licenseType">License Type of the VM to be
        /// used.</param>
        /// <param name="sqlServerLicenseType">The SQL Server license
        /// type.</param>
        /// <param name="dataMoverRunAsAccountId">The data mover run as account
        /// Id.</param>
        /// <param name="snapshotRunAsAccountId">The snapshot run as account
        /// Id.</param>
        /// <param name="targetVmName">Target VM name.</param>
        /// <param name="targetVmSize">The target VM size.</param>
        /// <param name="targetLocation">The target location.</param>
        /// <param name="targetResourceGroupId">The target resource group
        /// Id.</param>
        /// <param name="targetAvailabilitySetId">The target availability set
        /// Id.</param>
        /// <param name="targetAvailabilityZone">The target availability
        /// zone.</param>
        /// <param name="targetProximityPlacementGroupId">The target proximity
        /// placement group Id.</param>
        /// <param name="targetBootDiagnosticsStorageAccountId">The target boot
        /// diagnostics storage account ARM Id.</param>
        /// <param name="targetVmTags">The target VM tags.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="targetNetworkId">The target network Id.</param>
        /// <param name="vmNics">The network details.</param>
        /// <param name="targetNicTags">The tags for the target NICs.</param>
        /// <param name="migrationRecoveryPointId">The recovery point Id to
        /// which the VM was migrated.</param>
        /// <param name="lastRecoveryPointReceived">The last recovery point
        /// received time.</param>
        /// <param name="lastRecoveryPointId">The last recovery point
        /// Id.</param>
        /// <param name="initialSeedingProgressPercentage">The initial seeding
        /// progress percentage.</param>
        /// <param name="migrationProgressPercentage">The migration progress
        /// percentage.</param>
        /// <param name="resyncProgressPercentage">The resync progress
        /// percentage.</param>
        /// <param name="initialSeedingRetryCount">The initial seeding retry
        /// count.</param>
        /// <param name="resyncRetryCount">The resync retry count.</param>
        /// <param name="resyncRequired">A value indicating whether resync is
        /// required.</param>
        /// <param name="resyncState">The resync state. Possible values
        /// include: 'None', 'PreparedForResynchronization',
        /// 'StartedResynchronization'</param>
        /// <param name="performAutoResync">A value indicating whether auto
        /// resync is to be done.</param>
        /// <param name="seedDiskTags">The tags for the seed disks.</param>
        /// <param name="targetDiskTags">The tags for the target disks.</param>
        public VMwareCbtMigrationDetails(string vmwareMachineId = default(string), string osType = default(string), string firmwareType = default(string), string targetGeneration = default(string), string licenseType = default(string), string sqlServerLicenseType = default(string), string dataMoverRunAsAccountId = default(string), string snapshotRunAsAccountId = default(string), string targetVmName = default(string), string targetVmSize = default(string), string targetLocation = default(string), string targetResourceGroupId = default(string), string targetAvailabilitySetId = default(string), string targetAvailabilityZone = default(string), string targetProximityPlacementGroupId = default(string), string targetBootDiagnosticsStorageAccountId = default(string), IDictionary<string, string> targetVmTags = default(IDictionary<string, string>), IList<VMwareCbtProtectedDiskDetails> protectedDisks = default(IList<VMwareCbtProtectedDiskDetails>), string targetNetworkId = default(string), IList<VMwareCbtNicDetails> vmNics = default(IList<VMwareCbtNicDetails>), IDictionary<string, string> targetNicTags = default(IDictionary<string, string>), string migrationRecoveryPointId = default(string), System.DateTime? lastRecoveryPointReceived = default(System.DateTime?), string lastRecoveryPointId = default(string), int? initialSeedingProgressPercentage = default(int?), int? migrationProgressPercentage = default(int?), int? resyncProgressPercentage = default(int?), long? initialSeedingRetryCount = default(long?), long? resyncRetryCount = default(long?), string resyncRequired = default(string), string resyncState = default(string), string performAutoResync = default(string), IDictionary<string, string> seedDiskTags = default(IDictionary<string, string>), IDictionary<string, string> targetDiskTags = default(IDictionary<string, string>))
        {
            VmwareMachineId = vmwareMachineId;
            OsType = osType;
            FirmwareType = firmwareType;
            TargetGeneration = targetGeneration;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetLocation = targetLocation;
            TargetResourceGroupId = targetResourceGroupId;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            TargetVmTags = targetVmTags;
            ProtectedDisks = protectedDisks;
            TargetNetworkId = targetNetworkId;
            VmNics = vmNics;
            TargetNicTags = targetNicTags;
            MigrationRecoveryPointId = migrationRecoveryPointId;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            LastRecoveryPointId = lastRecoveryPointId;
            InitialSeedingProgressPercentage = initialSeedingProgressPercentage;
            MigrationProgressPercentage = migrationProgressPercentage;
            ResyncProgressPercentage = resyncProgressPercentage;
            InitialSeedingRetryCount = initialSeedingRetryCount;
            ResyncRetryCount = resyncRetryCount;
            ResyncRequired = resyncRequired;
            ResyncState = resyncState;
            PerformAutoResync = performAutoResync;
            SeedDiskTags = seedDiskTags;
            TargetDiskTags = targetDiskTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ARM Id of the VM discovered in VMware.
        /// </summary>
        [JsonProperty(PropertyName = "vmwareMachineId")]
        public string VmwareMachineId { get; private set; }

        /// <summary>
        /// Gets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets the firmware type.
        /// </summary>
        [JsonProperty(PropertyName = "firmwareType")]
        public string FirmwareType { get; private set; }

        /// <summary>
        /// Gets the target generation.
        /// </summary>
        [JsonProperty(PropertyName = "targetGeneration")]
        public string TargetGeneration { get; private set; }

        /// <summary>
        /// Gets or sets license Type of the VM to be used.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the SQL Server license type.
        /// </summary>
        [JsonProperty(PropertyName = "sqlServerLicenseType")]
        public string SqlServerLicenseType { get; set; }

        /// <summary>
        /// Gets the data mover run as account Id.
        /// </summary>
        [JsonProperty(PropertyName = "dataMoverRunAsAccountId")]
        public string DataMoverRunAsAccountId { get; private set; }

        /// <summary>
        /// Gets the snapshot run as account Id.
        /// </summary>
        [JsonProperty(PropertyName = "snapshotRunAsAccountId")]
        public string SnapshotRunAsAccountId { get; private set; }

        /// <summary>
        /// Gets or sets target VM name.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmName")]
        public string TargetVmName { get; set; }

        /// <summary>
        /// Gets or sets the target VM size.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmSize")]
        public string TargetVmSize { get; set; }

        /// <summary>
        /// Gets the target location.
        /// </summary>
        [JsonProperty(PropertyName = "targetLocation")]
        public string TargetLocation { get; private set; }

        /// <summary>
        /// Gets or sets the target resource group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupId")]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilitySetId")]
        public string TargetAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the target proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetProximityPlacementGroupId")]
        public string TargetProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target boot diagnostics storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetBootDiagnosticsStorageAccountId")]
        public string TargetBootDiagnosticsStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the target VM tags.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmTags")]
        public IDictionary<string, string> TargetVmTags { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<VMwareCbtProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the target network Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetNetworkId")]
        public string TargetNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMwareCbtNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target NICs.
        /// </summary>
        [JsonProperty(PropertyName = "targetNicTags")]
        public IDictionary<string, string> TargetNicTags { get; set; }

        /// <summary>
        /// Gets the recovery point Id to which the VM was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "migrationRecoveryPointId")]
        public string MigrationRecoveryPointId { get; private set; }

        /// <summary>
        /// Gets the last recovery point received time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointReceived")]
        public System.DateTime? LastRecoveryPointReceived { get; private set; }

        /// <summary>
        /// Gets the last recovery point Id.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointId")]
        public string LastRecoveryPointId { get; private set; }

        /// <summary>
        /// Gets the initial seeding progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "initialSeedingProgressPercentage")]
        public int? InitialSeedingProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the migration progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "migrationProgressPercentage")]
        public int? MigrationProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the initial seeding retry count.
        /// </summary>
        [JsonProperty(PropertyName = "initialSeedingRetryCount")]
        public long? InitialSeedingRetryCount { get; private set; }

        /// <summary>
        /// Gets the resync retry count.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRetryCount")]
        public long? ResyncRetryCount { get; private set; }

        /// <summary>
        /// Gets a value indicating whether resync is required.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public string ResyncRequired { get; private set; }

        /// <summary>
        /// Gets the resync state. Possible values include: 'None',
        /// 'PreparedForResynchronization', 'StartedResynchronization'
        /// </summary>
        [JsonProperty(PropertyName = "resyncState")]
        public string ResyncState { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto resync is to be done.
        /// </summary>
        [JsonProperty(PropertyName = "performAutoResync")]
        public string PerformAutoResync { get; set; }

        /// <summary>
        /// Gets or sets the tags for the seed disks.
        /// </summary>
        [JsonProperty(PropertyName = "seedDiskTags")]
        public IDictionary<string, string> SeedDiskTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target disks.
        /// </summary>
        [JsonProperty(PropertyName = "targetDiskTags")]
        public IDictionary<string, string> TargetDiskTags { get; set; }

    }
}