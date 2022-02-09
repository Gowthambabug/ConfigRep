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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the vault
    /// </summary>
    public partial class VaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        public VaultProperties()
        {
            Sku = new Sku();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="sku">SKU details</param>
        /// <param name="accessPolicies">An array of 0 to 1024 identities that
        /// have access to the key vault. All identities in the array must use
        /// the same tenant ID as the key vault's tenant ID. When `createMode`
        /// is set to `recover`, access policies are not required. Otherwise,
        /// access policies are required.</param>
        /// <param name="vaultUri">The URI of the vault for performing
        /// operations on keys and secrets.</param>
        /// <param name="hsmPoolResourceId">The resource id of HSM
        /// Pool.</param>
        /// <param name="enabledForDeployment">Property to specify whether
        /// Azure Virtual Machines are permitted to retrieve certificates
        /// stored as secrets from the key vault.</param>
        /// <param name="enabledForDiskEncryption">Property to specify whether
        /// Azure Disk Encryption is permitted to retrieve secrets from the
        /// vault and unwrap keys.</param>
        /// <param name="enabledForTemplateDeployment">Property to specify
        /// whether Azure Resource Manager is permitted to retrieve secrets
        /// from the key vault.</param>
        /// <param name="enableSoftDelete">Property to specify whether the
        /// 'soft delete' functionality is enabled for this key vault. If it's
        /// not set to any value(true or false) when creating new key vault, it
        /// will be set to true by default. Once set to true, it cannot be
        /// reverted to false.</param>
        /// <param name="softDeleteRetentionInDays">softDelete data retention
        /// days. It accepts &gt;=7 and &lt;=90.</param>
        /// <param name="enableRbacAuthorization">Property that controls how
        /// data actions are authorized. When true, the key vault will use Role
        /// Based Access Control (RBAC) for authorization of data actions, and
        /// the access policies specified in vault properties will be  ignored
        /// (warning: this is a preview feature). When false, the key vault
        /// will use the access policies specified in vault properties, and any
        /// policy stored on Azure Resource Manager will be ignored. If null or
        /// not specified, the vault is created with the default value of
        /// false. Note that management actions are always authorized with
        /// RBAC.</param>
        /// <param name="createMode">The vault's create mode to indicate
        /// whether the vault need to be recovered or not. Possible values
        /// include: 'recover', 'default'</param>
        /// <param name="enablePurgeProtection">Property specifying whether
        /// protection against purge is enabled for this vault. Setting this
        /// property to true activates protection against purge for this vault
        /// and its content - only the Key Vault service may initiate a hard,
        /// irrecoverable deletion. The setting is effective only if soft
        /// delete is also enabled. Enabling this functionality is irreversible
        /// - that is, the property does not accept false as its value.</param>
        /// <param name="networkAcls">Rules governing the accessibility of the
        /// key vault from specific network locations.</param>
        /// <param name="provisioningState">Provisioning state of the vault.
        /// Possible values include: 'Succeeded', 'RegisteringDns'</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections associated with the key vault.</param>
        /// <param name="publicNetworkAccess">Property to specify whether the
        /// vault will accept traffic from public internet. If set to
        /// 'disabled' all traffic except private endpoint traffic and that
        /// that originates from trusted services will be blocked. This will
        /// override the set firewall rules, meaning that even if the firewall
        /// rules are present we will not honor the rules.</param>
        public VaultProperties(System.Guid tenantId, Sku sku, IList<AccessPolicyEntry> accessPolicies = default(IList<AccessPolicyEntry>), string vaultUri = default(string), string hsmPoolResourceId = default(string), bool? enabledForDeployment = default(bool?), bool? enabledForDiskEncryption = default(bool?), bool? enabledForTemplateDeployment = default(bool?), bool? enableSoftDelete = default(bool?), int? softDeleteRetentionInDays = default(int?), bool? enableRbacAuthorization = default(bool?), CreateMode? createMode = default(CreateMode?), bool? enablePurgeProtection = default(bool?), NetworkRuleSet networkAcls = default(NetworkRuleSet), string provisioningState = default(string), IList<PrivateEndpointConnectionItem> privateEndpointConnections = default(IList<PrivateEndpointConnectionItem>), string publicNetworkAccess = default(string))
        {
            TenantId = tenantId;
            Sku = sku;
            AccessPolicies = accessPolicies;
            VaultUri = vaultUri;
            HsmPoolResourceId = hsmPoolResourceId;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            EnableSoftDelete = enableSoftDelete;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnableRbacAuthorization = enableRbacAuthorization;
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets SKU details
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets an array of 0 to 1024 identities that have access to
        /// the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID. When `createMode` is set to
        /// `recover`, access policies are not required. Otherwise, access
        /// policies are required.
        /// </summary>
        [JsonProperty(PropertyName = "accessPolicies")]
        public IList<AccessPolicyEntry> AccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets the URI of the vault for performing operations on keys
        /// and secrets.
        /// </summary>
        [JsonProperty(PropertyName = "vaultUri")]
        public string VaultUri { get; set; }

        /// <summary>
        /// Gets the resource id of HSM Pool.
        /// </summary>
        [JsonProperty(PropertyName = "hsmPoolResourceId")]
        public string HsmPoolResourceId { get; private set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Virtual Machines are
        /// permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDeployment")]
        public bool? EnabledForDeployment { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Disk Encryption is
        /// permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDiskEncryption")]
        public bool? EnabledForDiskEncryption { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Resource Manager is
        /// permitted to retrieve secrets from the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForTemplateDeployment")]
        public bool? EnabledForTemplateDeployment { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether the 'soft delete'
        /// functionality is enabled for this key vault. If it's not set to any
        /// value(true or false) when creating new key vault, it will be set to
        /// true by default. Once set to true, it cannot be reverted to false.
        /// </summary>
        [JsonProperty(PropertyName = "enableSoftDelete")]
        public bool? EnableSoftDelete { get; set; }

        /// <summary>
        /// Gets or sets softDelete data retention days. It accepts &amp;gt;=7
        /// and &amp;lt;=90.
        /// </summary>
        [JsonProperty(PropertyName = "softDeleteRetentionInDays")]
        public int? SoftDeleteRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets property that controls how data actions are
        /// authorized. When true, the key vault will use Role Based Access
        /// Control (RBAC) for authorization of data actions, and the access
        /// policies specified in vault properties will be  ignored (warning:
        /// this is a preview feature). When false, the key vault will use the
        /// access policies specified in vault properties, and any policy
        /// stored on Azure Resource Manager will be ignored. If null or not
        /// specified, the vault is created with the default value of false.
        /// Note that management actions are always authorized with RBAC.
        /// </summary>
        [JsonProperty(PropertyName = "enableRbacAuthorization")]
        public bool? EnableRbacAuthorization { get; set; }

        /// <summary>
        /// Gets or sets the vault's create mode to indicate whether the vault
        /// need to be recovered or not. Possible values include: 'recover',
        /// 'default'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public CreateMode? CreateMode { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether protection against purge
        /// is enabled for this vault. Setting this property to true activates
        /// protection against purge for this vault and its content - only the
        /// Key Vault service may initiate a hard, irrecoverable deletion. The
        /// setting is effective only if soft delete is also enabled. Enabling
        /// this functionality is irreversible - that is, the property does not
        /// accept false as its value.
        /// </summary>
        [JsonProperty(PropertyName = "enablePurgeProtection")]
        public bool? EnablePurgeProtection { get; set; }

        /// <summary>
        /// Gets or sets rules governing the accessibility of the key vault
        /// from specific network locations.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public NetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the vault. Possible values
        /// include: 'Succeeded', 'RegisteringDns'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpointConnections")]
        public IList<PrivateEndpointConnectionItem> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets property to specify whether the vault will accept
        /// traffic from public internet. If set to 'disabled' all traffic
        /// except private endpoint traffic and that that originates from
        /// trusted services will be blocked. This will override the set
        /// firewall rules, meaning that even if the firewall rules are present
        /// we will not honor the rules.
        /// </summary>
        [JsonProperty(PropertyName = "publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (AccessPolicies != null)
            {
                foreach (var element in AccessPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}