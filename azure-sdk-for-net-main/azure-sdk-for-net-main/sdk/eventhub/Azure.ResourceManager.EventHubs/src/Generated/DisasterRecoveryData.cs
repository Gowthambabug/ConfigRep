// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the DisasterRecovery data model. </summary>
    public partial class DisasterRecoveryData : ProxyResource
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
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values &apos;Accepted&apos; or &apos;Succeeded&apos; or &apos;Failed&apos;. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values &apos;Primary&apos; or &apos;PrimaryNotReplicating&apos; or &apos;Secondary&apos;. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        internal DisasterRecoveryData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, ProvisioningStateDR? provisioningState, string partnerNamespace, string alternateName, RoleDisasterRecovery? role, long? pendingReplicationOperationsCount) : base(id, name, type, systemData, location)
        {
            ProvisioningState = provisioningState;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
        }

        /// <summary> Provisioning state of the Alias(Disaster Recovery configuration) - possible values &apos;Accepted&apos; or &apos;Succeeded&apos; or &apos;Failed&apos;. </summary>
        public ProvisioningStateDR? ProvisioningState { get; }
        /// <summary> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string PartnerNamespace { get; set; }
        /// <summary> Alternate name specified when alias and namespace names are same. </summary>
        public string AlternateName { get; set; }
        /// <summary> role of namespace in GEO DR - possible values &apos;Primary&apos; or &apos;PrimaryNotReplicating&apos; or &apos;Secondary&apos;. </summary>
        public RoleDisasterRecovery? Role { get; }
        /// <summary> Number of entities pending to be replicated. </summary>
        public long? PendingReplicationOperationsCount { get; }
    }
}