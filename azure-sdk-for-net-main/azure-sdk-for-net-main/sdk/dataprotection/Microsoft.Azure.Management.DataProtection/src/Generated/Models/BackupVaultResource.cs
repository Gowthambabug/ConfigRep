// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// BackupVault Resource
    /// </summary>
    /// <remarks>
    /// Backup Vault Resource
    /// </remarks>
    public partial class BackupVaultResource : DppTrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the BackupVaultResource class.
        /// </summary>
        public BackupVaultResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupVaultResource class.
        /// </summary>
        /// <param name="properties">BackupVaultResource properties</param>
        /// <param name="eTag">Optional ETag.</param>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="identity">Input Managed Identity Details</param>
        /// <param name="location">Resource location.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        public BackupVaultResource(BackupVault properties, string eTag = default(string), string id = default(string), DppIdentityDetails identity = default(DppIdentityDetails), string location = default(string), string name = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string type = default(string), SystemData systemData = default(SystemData))
            : base(eTag, id, identity, location, name, tags, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backupVaultResource properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BackupVault Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
