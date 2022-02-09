// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload specific restore details for restores using managed
    /// identity
    /// </summary>
    public partial class IdentityBasedRestoreDetails
    {
        /// <summary>
        /// Initializes a new instance of the IdentityBasedRestoreDetails
        /// class.
        /// </summary>
        public IdentityBasedRestoreDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityBasedRestoreDetails
        /// class.
        /// </summary>
        /// <param name="objectType">Gets the class type.</param>
        /// <param name="targetStorageAccountId">Fully qualified ARM ID of the
        /// target storage account.</param>
        public IdentityBasedRestoreDetails(string objectType = default(string), string targetStorageAccountId = default(string))
        {
            ObjectType = objectType;
            TargetStorageAccountId = targetStorageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the class type.
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the target storage account.
        /// </summary>
        [JsonProperty(PropertyName = "targetStorageAccountId")]
        public string TargetStorageAccountId { get; set; }

    }
}