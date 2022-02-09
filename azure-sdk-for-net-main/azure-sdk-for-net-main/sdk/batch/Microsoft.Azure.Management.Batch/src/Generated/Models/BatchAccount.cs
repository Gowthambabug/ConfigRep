// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about an Azure Batch account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BatchAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>
        public BatchAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="accountEndpoint">The account endpoint used to interact
        /// with the Batch service.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Invalid', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Cancelled'</param>
        /// <param name="poolAllocationMode">The allocation mode to use for
        /// creating pools in the Batch account.</param>
        /// <param name="keyVaultReference">A reference to the Azure key vault
        /// associated with the Batch account.</param>
        /// <param name="publicNetworkAccess">The network interface type for
        /// accessing Azure Batch service and Batch account operations.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections associated with the Batch account</param>
        /// <param name="autoStorage">The properties and status of any
        /// auto-storage account associated with the Batch account.</param>
        /// <param name="encryption">The encryption configuration for the Batch
        /// account.</param>
        /// <param name="dedicatedCoreQuota">The dedicated core quota for the
        /// Batch account.</param>
        /// <param name="lowPriorityCoreQuota">The low-priority core quota for
        /// the Batch account.</param>
        /// <param name="dedicatedCoreQuotaPerVMFamily">A list of the dedicated
        /// core quota per Virtual Machine family for the Batch account. For
        /// accounts with PoolAllocationMode set to UserSubscription, quota is
        /// managed on the subscription so this value is not returned.</param>
        /// <param name="dedicatedCoreQuotaPerVMFamilyEnforced">A value
        /// indicating whether core quotas per Virtual Machine family are
        /// enforced for this account</param>
        /// <param name="poolQuota">The pool quota for the Batch
        /// account.</param>
        /// <param name="activeJobAndJobScheduleQuota">The active job and job
        /// schedule quota for the Batch account.</param>
        /// <param name="allowedAuthenticationModes">List of allowed
        /// authentication modes for the Batch account that can be used to
        /// authenticate with the data plane. This does not affect
        /// authentication with the control plane.</param>
        /// <param name="identity">The identity of the Batch account.</param>
        public BatchAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string accountEndpoint = default(string), ProvisioningState provisioningState = default(ProvisioningState), PoolAllocationMode? poolAllocationMode = default(PoolAllocationMode?), KeyVaultReference keyVaultReference = default(KeyVaultReference), PublicNetworkAccessType? publicNetworkAccess = default(PublicNetworkAccessType?), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), AutoStorageProperties autoStorage = default(AutoStorageProperties), EncryptionProperties encryption = default(EncryptionProperties), int? dedicatedCoreQuota = default(int?), int? lowPriorityCoreQuota = default(int?), IList<VirtualMachineFamilyCoreQuota> dedicatedCoreQuotaPerVMFamily = default(IList<VirtualMachineFamilyCoreQuota>), bool dedicatedCoreQuotaPerVMFamilyEnforced = default(bool), int poolQuota = default(int), int activeJobAndJobScheduleQuota = default(int), IList<AuthenticationMode?> allowedAuthenticationModes = default(IList<AuthenticationMode?>), BatchAccountIdentity identity = default(BatchAccountIdentity))
            : base(id, name, type, location, tags)
        {
            AccountEndpoint = accountEndpoint;
            ProvisioningState = provisioningState;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            AutoStorage = autoStorage;
            Encryption = encryption;
            DedicatedCoreQuota = dedicatedCoreQuota;
            LowPriorityCoreQuota = lowPriorityCoreQuota;
            DedicatedCoreQuotaPerVMFamily = dedicatedCoreQuotaPerVMFamily;
            DedicatedCoreQuotaPerVMFamilyEnforced = dedicatedCoreQuotaPerVMFamilyEnforced;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            AllowedAuthenticationModes = allowedAuthenticationModes;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the account endpoint used to interact with the Batch service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountEndpoint")]
        public string AccountEndpoint { get; private set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Invalid', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the allocation mode to use for creating pools in the Batch
        /// account.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'BatchService', 'UserSubscription'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.poolAllocationMode")]
        public PoolAllocationMode? PoolAllocationMode { get; private set; }

        /// <summary>
        /// Gets a reference to the Azure key vault associated with the Batch
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultReference")]
        public KeyVaultReference KeyVaultReference { get; private set; }

        /// <summary>
        /// Gets the network interface type for accessing Azure Batch service
        /// and Batch account operations.
        /// </summary>
        /// <remarks>
        /// If not specified, the default value is 'enabled'. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public PublicNetworkAccessType? PublicNetworkAccess { get; private set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the Batch
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the properties and status of any auto-storage account
        /// associated with the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageProperties AutoStorage { get; private set; }

        /// <summary>
        /// Gets the encryption configuration for the Batch account.
        /// </summary>
        /// <remarks>
        /// Configures how customer data is encrypted inside the Batch account.
        /// By default, accounts are encrypted using a Microsoft managed key.
        /// For additional control, a customer-managed key can be used instead.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperties Encryption { get; private set; }

        /// <summary>
        /// Gets the dedicated core quota for the Batch account.
        /// </summary>
        /// <remarks>
        /// For accounts with PoolAllocationMode set to UserSubscription, quota
        /// is managed on the subscription so this value is not returned.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dedicatedCoreQuota")]
        public int? DedicatedCoreQuota { get; private set; }

        /// <summary>
        /// Gets the low-priority core quota for the Batch account.
        /// </summary>
        /// <remarks>
        /// For accounts with PoolAllocationMode set to UserSubscription, quota
        /// is managed on the subscription so this value is not returned.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.lowPriorityCoreQuota")]
        public int? LowPriorityCoreQuota { get; private set; }

        /// <summary>
        /// Gets a list of the dedicated core quota per Virtual Machine family
        /// for the Batch account. For accounts with PoolAllocationMode set to
        /// UserSubscription, quota is managed on the subscription so this
        /// value is not returned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dedicatedCoreQuotaPerVMFamily")]
        public IList<VirtualMachineFamilyCoreQuota> DedicatedCoreQuotaPerVMFamily { get; private set; }

        /// <summary>
        /// Gets a value indicating whether core quotas per Virtual Machine
        /// family are enforced for this account
        /// </summary>
        /// <remarks>
        /// Batch is transitioning its core quota system for dedicated cores to
        /// be enforced per Virtual Machine family. During this transitional
        /// phase, the dedicated core quota per Virtual Machine family may not
        /// yet be enforced. If this flag is false, dedicated core quota is
        /// enforced via the old dedicatedCoreQuota property on the account and
        /// does not consider Virtual Machine family. If this flag is true,
        /// dedicated core quota is enforced via the
        /// dedicatedCoreQuotaPerVMFamily property on the account, and the old
        /// dedicatedCoreQuota does not apply.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dedicatedCoreQuotaPerVMFamilyEnforced")]
        public bool DedicatedCoreQuotaPerVMFamilyEnforced { get; private set; }

        /// <summary>
        /// Gets the pool quota for the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.poolQuota")]
        public int PoolQuota { get; private set; }

        /// <summary>
        /// Gets the active job and job schedule quota for the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeJobAndJobScheduleQuota")]
        public int ActiveJobAndJobScheduleQuota { get; private set; }

        /// <summary>
        /// Gets list of allowed authentication modes for the Batch account
        /// that can be used to authenticate with the data plane. This does not
        /// affect authentication with the control plane.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedAuthenticationModes")]
        public IList<AuthenticationMode?> AllowedAuthenticationModes { get; private set; }

        /// <summary>
        /// Gets or sets the identity of the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public BatchAccountIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyVaultReference != null)
            {
                KeyVaultReference.Validate();
            }
            if (PrivateEndpointConnections != null)
            {
                foreach (var element in PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (AutoStorage != null)
            {
                AutoStorage.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}