// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A recoverable server resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecoverableServerResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RecoverableServerResource class.
        /// </summary>
        public RecoverableServerResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoverableServerResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="lastAvailableBackupDateTime">The last available backup
        /// date time.</param>
        /// <param name="serviceLevelObjective">The service level
        /// objective</param>
        /// <param name="edition">Edition of the performance tier.</param>
        /// <param name="vCore">vCore associated with the service level
        /// objective</param>
        /// <param name="hardwareGeneration">Hardware generation associated
        /// with the service level objective</param>
        /// <param name="version">The MySQL version</param>
        public RecoverableServerResource(string id = default(string), string name = default(string), string type = default(string), string lastAvailableBackupDateTime = default(string), string serviceLevelObjective = default(string), string edition = default(string), int? vCore = default(int?), string hardwareGeneration = default(string), string version = default(string))
            : base(id, name, type)
        {
            LastAvailableBackupDateTime = lastAvailableBackupDateTime;
            ServiceLevelObjective = serviceLevelObjective;
            Edition = edition;
            VCore = vCore;
            HardwareGeneration = hardwareGeneration;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the last available backup date time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastAvailableBackupDateTime")]
        public string LastAvailableBackupDateTime { get; private set; }

        /// <summary>
        /// Gets the service level objective
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets edition of the performance tier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; private set; }

        /// <summary>
        /// Gets vCore associated with the service level objective
        /// </summary>
        [JsonProperty(PropertyName = "properties.vCore")]
        public int? VCore { get; private set; }

        /// <summary>
        /// Gets hardware generation associated with the service level
        /// objective
        /// </summary>
        [JsonProperty(PropertyName = "properties.hardwareGeneration")]
        public string HardwareGeneration { get; private set; }

        /// <summary>
        /// Gets the MySQL version
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

    }
}