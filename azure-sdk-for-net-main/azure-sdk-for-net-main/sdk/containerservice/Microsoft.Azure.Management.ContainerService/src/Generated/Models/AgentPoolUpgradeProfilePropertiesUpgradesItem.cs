// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AgentPoolUpgradeProfilePropertiesUpgradesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AgentPoolUpgradeProfilePropertiesUpgradesItem class.
        /// </summary>
        public AgentPoolUpgradeProfilePropertiesUpgradesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AgentPoolUpgradeProfilePropertiesUpgradesItem class.
        /// </summary>
        /// <param name="kubernetesVersion">The Kubernetes version
        /// (major.minor.patch).</param>
        /// <param name="isPreview">Whether the Kubernetes version is currently
        /// in preview.</param>
        public AgentPoolUpgradeProfilePropertiesUpgradesItem(string kubernetesVersion = default(string), bool? isPreview = default(bool?))
        {
            KubernetesVersion = kubernetesVersion;
            IsPreview = isPreview;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Kubernetes version (major.minor.patch).
        /// </summary>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets or sets whether the Kubernetes version is currently in
        /// preview.
        /// </summary>
        [JsonProperty(PropertyName = "isPreview")]
        public bool? IsPreview { get; set; }

    }
}