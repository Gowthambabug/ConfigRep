// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdRuleSet data model. </summary>
    public partial class AfdRuleSetData : Resource
    {
        /// <summary> Initializes a new instance of AfdRuleSetData. </summary>
        public AfdRuleSetData()
        {
        }

        /// <summary> Initializes a new instance of AfdRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        internal AfdRuleSetData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, AfdProvisioningState? provisioningState, DeploymentStatus? deploymentStatus) : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}