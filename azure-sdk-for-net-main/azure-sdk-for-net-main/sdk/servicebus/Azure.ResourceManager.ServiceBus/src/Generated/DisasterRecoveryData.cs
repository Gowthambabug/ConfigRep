// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the DisasterRecovery data model. </summary>
    public partial class DisasterRecoveryData : Resource
    {
        /// <summary> Initializes a new instance of DisasterRecoveryData. </summary>
        public DisasterRecoveryData()
        {
        }

        /// <summary> Initializes a new instance of DisasterRecoveryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values &apos;Accepted&apos; or &apos;Succeeded&apos; or &apos;Failed&apos;. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values &apos;Primary&apos; or &apos;PrimaryNotReplicating&apos; or &apos;Secondary&apos;. </param>
        internal DisasterRecoveryData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, ProvisioningStateDisasterRecovery? provisioningState, long? pendingReplicationOperationsCount, string partnerNamespace, string alternateName, RoleDisasterRecovery? role) : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
        }

        /// <summary> Provisioning state of the Alias(Disaster Recovery configuration) - possible values &apos;Accepted&apos; or &apos;Succeeded&apos; or &apos;Failed&apos;. </summary>
        public ProvisioningStateDisasterRecovery? ProvisioningState { get; }
        /// <summary> Number of entities pending to be replicated. </summary>
        public long? PendingReplicationOperationsCount { get; }
        /// <summary> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string PartnerNamespace { get; set; }
        /// <summary> Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string AlternateName { get; set; }
        /// <summary> role of namespace in GEO DR - possible values &apos;Primary&apos; or &apos;PrimaryNotReplicating&apos; or &apos;Secondary&apos;. </summary>
        public RoleDisasterRecovery? Role { get; }
    }
}