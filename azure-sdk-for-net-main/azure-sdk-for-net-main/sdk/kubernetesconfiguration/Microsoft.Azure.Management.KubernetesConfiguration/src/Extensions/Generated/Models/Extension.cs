// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Extension object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Extension : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        public Extension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="extensionType">Type of the Extension, of which this
        /// resource is an instance of.  It must be one of the Extension Types
        /// registered with Microsoft.KubernetesConfiguration by the Extension
        /// publisher.</param>
        /// <param name="autoUpgradeMinorVersion">Flag to note if this
        /// extension participates in auto upgrade of minor version, or
        /// not.</param>
        /// <param name="releaseTrain">ReleaseTrain this extension participates
        /// in for auto-upgrade (e.g. Stable, Preview, etc.) - only if
        /// autoUpgradeMinorVersion is 'true'.</param>
        /// <param name="version">Version of the extension for this extension,
        /// if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.</param>
        /// <param name="scope">Scope at which the extension is
        /// installed.</param>
        /// <param name="configurationSettings">Configuration settings, as
        /// name-value pairs for configuring this extension.</param>
        /// <param name="configurationProtectedSettings">Configuration settings
        /// that are sensitive, as name-value pairs for configuring this
        /// extension.</param>
        /// <param name="provisioningState">Possible values include:
        /// 'Succeeded', 'Failed', 'Canceled', 'Creating', 'Updating',
        /// 'Deleting'</param>
        /// <param name="statuses">Status from this extension.</param>
        /// <param name="customLocationSettings">Custom Location settings
        /// properties.</param>
        /// <param name="packageUri">Uri of the Helm package</param>
        /// <param name="aksAssignedIdentity">Identity of the Extension
        /// resource in an AKS cluster</param>
        /// <param name="identity">Identity of the Extension resource</param>
        /// <param name="systemData">Top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources</param>
        public Extension(string id = default(string), string name = default(string), string type = default(string), string extensionType = default(string), bool? autoUpgradeMinorVersion = default(bool?), string releaseTrain = default(string), string version = default(string), Scope scope = default(Scope), IDictionary<string, string> configurationSettings = default(IDictionary<string, string>), IDictionary<string, string> configurationProtectedSettings = default(IDictionary<string, string>), string provisioningState = default(string), IList<ExtensionStatus> statuses = default(IList<ExtensionStatus>), ErrorDetail errorInfo = default(ErrorDetail), IDictionary<string, string> customLocationSettings = default(IDictionary<string, string>), string packageUri = default(string), ExtensionPropertiesAksAssignedIdentity aksAssignedIdentity = default(ExtensionPropertiesAksAssignedIdentity), Identity identity = default(Identity), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            ExtensionType = extensionType;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            ReleaseTrain = releaseTrain;
            Version = version;
            Scope = scope;
            ConfigurationSettings = configurationSettings;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            ProvisioningState = provisioningState;
            Statuses = statuses;
            ErrorInfo = errorInfo;
            CustomLocationSettings = customLocationSettings;
            PackageUri = packageUri;
            AksAssignedIdentity = aksAssignedIdentity;
            Identity = identity;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the Extension, of which this resource is an
        /// instance of.  It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.extensionType")]
        public string ExtensionType { get; set; }

        /// <summary>
        /// Gets or sets flag to note if this extension participates in auto
        /// upgrade of minor version, or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets releaseTrain this extension participates in for
        /// auto-upgrade (e.g. Stable, Preview, etc.) - only if
        /// autoUpgradeMinorVersion is 'true'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.releaseTrain")]
        public string ReleaseTrain { get; set; }

        /// <summary>
        /// Gets or sets version of the extension for this extension, if it is
        /// 'pinned' to a specific version. autoUpgradeMinorVersion must be
        /// 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets scope at which the extension is installed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public Scope Scope { get; set; }

        /// <summary>
        /// Gets or sets configuration settings, as name-value pairs for
        /// configuring this extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationSettings")]
        public IDictionary<string, string> ConfigurationSettings { get; set; }

        /// <summary>
        /// Gets or sets configuration settings that are sensitive, as
        /// name-value pairs for configuring this extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationProtectedSettings")]
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Succeeded', 'Failed',
        /// 'Canceled', 'Creating', 'Updating', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets status from this extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statuses")]
        public IList<ExtensionStatus> Statuses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorInfo")]
        public ErrorDetail ErrorInfo { get; set; }

        /// <summary>
        /// Gets custom Location settings properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customLocationSettings")]
        public IDictionary<string, string> CustomLocationSettings { get; private set; }

        /// <summary>
        /// Gets uri of the Helm package
        /// </summary>
        [JsonProperty(PropertyName = "properties.packageUri")]
        public string PackageUri { get; private set; }

        /// <summary>
        /// Gets or sets identity of the Extension resource in an AKS cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.aksAssignedIdentity")]
        public ExtensionPropertiesAksAssignedIdentity AksAssignedIdentity { get; set; }

        /// <summary>
        /// Gets or sets identity of the Extension resource
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}