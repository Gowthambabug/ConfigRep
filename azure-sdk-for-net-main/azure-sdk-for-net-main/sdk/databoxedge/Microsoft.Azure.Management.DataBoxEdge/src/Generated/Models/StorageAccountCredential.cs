// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account credential.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountCredential : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCredential class.
        /// </summary>
        public StorageAccountCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCredential class.
        /// </summary>
        /// <param name="alias">Alias for the storage account.</param>
        /// <param name="sslStatus">Signifies whether SSL needs to be enabled
        /// or not. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="accountType">Type of storage accessed on the storage
        /// account. Possible values include: 'GeneralPurposeStorage',
        /// 'BlobStorage'</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">StorageAccountCredential object</param>
        /// <param name="userName">Username for the storage account.</param>
        /// <param name="accountKey">Encrypted storage key.</param>
        /// <param name="connectionString">Connection string for the storage
        /// account. Use this string if username and account key are not
        /// specified.</param>
        /// <param name="blobDomainName">Blob end point for private
        /// clouds.</param>
        /// <param name="storageAccountId">Id of the storage account.</param>
        public StorageAccountCredential(string alias, string sslStatus, string accountType, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string userName = default(string), AsymmetricEncryptedSecret accountKey = default(AsymmetricEncryptedSecret), string connectionString = default(string), string blobDomainName = default(string), string storageAccountId = default(string))
            : base(id, name, type)
        {
            SystemData = systemData;
            Alias = alias;
            UserName = userName;
            AccountKey = accountKey;
            ConnectionString = connectionString;
            SslStatus = sslStatus;
            BlobDomainName = blobDomainName;
            AccountType = accountType;
            StorageAccountId = storageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storageAccountCredential object
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets alias for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or sets username for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets encrypted storage key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountKey")]
        public AsymmetricEncryptedSecret AccountKey { get; set; }

        /// <summary>
        /// Gets or sets connection string for the storage account. Use this
        /// string if username and account key are not specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets signifies whether SSL needs to be enabled or not.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslStatus")]
        public string SslStatus { get; set; }

        /// <summary>
        /// Gets or sets blob end point for private clouds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobDomainName")]
        public string BlobDomainName { get; set; }

        /// <summary>
        /// Gets or sets type of storage accessed on the storage account.
        /// Possible values include: 'GeneralPurposeStorage', 'BlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or sets id of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Alias == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Alias");
            }
            if (SslStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SslStatus");
            }
            if (AccountType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountType");
            }
            if (AccountKey != null)
            {
                AccountKey.Validate();
            }
        }
    }
}