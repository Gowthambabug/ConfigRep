// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The object attributes managed by the Azure Key Vault service.
    /// </summary>
    public partial class KeyAttributes
    {
        /// <summary>
        /// Initializes a new instance of the KeyAttributes class.
        /// </summary>
        public KeyAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyAttributes class.
        /// </summary>
        /// <param name="enabled">Determines whether or not the object is
        /// enabled.</param>
        /// <param name="notBefore">Not before date in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="expires">Expiry date in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="created">Creation time in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="updated">Last updated time in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="recoveryLevel">The deletion recovery level currently
        /// in effect for the object. If it contains 'Purgeable', then the
        /// object can be permanently deleted by a privileged user; otherwise,
        /// only the system can purge the object at the end of the retention
        /// interval. Possible values include: 'Purgeable',
        /// 'Recoverable+Purgeable', 'Recoverable',
        /// 'Recoverable+ProtectedSubscription'</param>
        /// <param name="exportable">Indicates if the private key can be
        /// exported.</param>
        public KeyAttributes(bool? enabled = default(bool?), long? notBefore = default(long?), long? expires = default(long?), long? created = default(long?), long? updated = default(long?), string recoveryLevel = default(string), bool? exportable = default(bool?))
        {
            Enabled = enabled;
            NotBefore = notBefore;
            Expires = expires;
            Created = created;
            Updated = updated;
            RecoveryLevel = recoveryLevel;
            Exportable = exportable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets determines whether or not the object is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets not before date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "nbf")]
        public long? NotBefore { get; set; }

        /// <summary>
        /// Gets or sets expiry date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "exp")]
        public long? Expires { get; set; }

        /// <summary>
        /// Gets creation time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public long? Created { get; private set; }

        /// <summary>
        /// Gets last updated time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public long? Updated { get; private set; }

        /// <summary>
        /// Gets the deletion recovery level currently in effect for the
        /// object. If it contains 'Purgeable', then the object can be
        /// permanently deleted by a privileged user; otherwise, only the
        /// system can purge the object at the end of the retention interval.
        /// Possible values include: 'Purgeable', 'Recoverable+Purgeable',
        /// 'Recoverable', 'Recoverable+ProtectedSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryLevel")]
        public string RecoveryLevel { get; private set; }

        /// <summary>
        /// Gets or sets indicates if the private key can be exported.
        /// </summary>
        [JsonProperty(PropertyName = "exportable")]
        public bool? Exportable { get; set; }

    }
}