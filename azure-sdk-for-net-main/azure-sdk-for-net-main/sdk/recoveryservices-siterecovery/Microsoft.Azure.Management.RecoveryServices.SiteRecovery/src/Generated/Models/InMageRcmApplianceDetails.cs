// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMageRcm appliance details.
    /// </summary>
    public partial class InMageRcmApplianceDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmApplianceDetails class.
        /// </summary>
        public InMageRcmApplianceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmApplianceDetails class.
        /// </summary>
        /// <param name="id">The appliance Id.</param>
        /// <param name="name">The appliance name.</param>
        /// <param name="fabricArmId">The fabric ARM Id.</param>
        /// <param name="processServer">The process server.</param>
        /// <param name="rcmProxy">The of RCM proxy.</param>
        /// <param name="pushInstaller">The push installer.</param>
        /// <param name="replicationAgent">The replication agent.</param>
        /// <param name="reprotectAgent">The reprotect agent.</param>
        /// <param name="marsAgent">The Mars agent.</param>
        /// <param name="dra">The DRA.</param>
        /// <param name="switchProviderBlockingErrorDetails">The switch
        /// provider blocking error information.</param>
        public InMageRcmApplianceDetails(string id = default(string), string name = default(string), string fabricArmId = default(string), ProcessServerDetails processServer = default(ProcessServerDetails), RcmProxyDetails rcmProxy = default(RcmProxyDetails), PushInstallerDetails pushInstaller = default(PushInstallerDetails), ReplicationAgentDetails replicationAgent = default(ReplicationAgentDetails), ReprotectAgentDetails reprotectAgent = default(ReprotectAgentDetails), MarsAgentDetails marsAgent = default(MarsAgentDetails), DraDetails dra = default(DraDetails), IList<InMageRcmFabricSwitchProviderBlockingErrorDetails> switchProviderBlockingErrorDetails = default(IList<InMageRcmFabricSwitchProviderBlockingErrorDetails>))
        {
            Id = id;
            Name = name;
            FabricArmId = fabricArmId;
            ProcessServer = processServer;
            RcmProxy = rcmProxy;
            PushInstaller = pushInstaller;
            ReplicationAgent = replicationAgent;
            ReprotectAgent = reprotectAgent;
            MarsAgent = marsAgent;
            Dra = dra;
            SwitchProviderBlockingErrorDetails = switchProviderBlockingErrorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the appliance Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the appliance name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the fabric ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "fabricArmId")]
        public string FabricArmId { get; private set; }

        /// <summary>
        /// Gets the process server.
        /// </summary>
        [JsonProperty(PropertyName = "processServer")]
        public ProcessServerDetails ProcessServer { get; private set; }

        /// <summary>
        /// Gets the of RCM proxy.
        /// </summary>
        [JsonProperty(PropertyName = "rcmProxy")]
        public RcmProxyDetails RcmProxy { get; private set; }

        /// <summary>
        /// Gets the push installer.
        /// </summary>
        [JsonProperty(PropertyName = "pushInstaller")]
        public PushInstallerDetails PushInstaller { get; private set; }

        /// <summary>
        /// Gets the replication agent.
        /// </summary>
        [JsonProperty(PropertyName = "replicationAgent")]
        public ReplicationAgentDetails ReplicationAgent { get; private set; }

        /// <summary>
        /// Gets the reprotect agent.
        /// </summary>
        [JsonProperty(PropertyName = "reprotectAgent")]
        public ReprotectAgentDetails ReprotectAgent { get; private set; }

        /// <summary>
        /// Gets the Mars agent.
        /// </summary>
        [JsonProperty(PropertyName = "marsAgent")]
        public MarsAgentDetails MarsAgent { get; private set; }

        /// <summary>
        /// Gets the DRA.
        /// </summary>
        [JsonProperty(PropertyName = "dra")]
        public DraDetails Dra { get; private set; }

        /// <summary>
        /// Gets the switch provider blocking error information.
        /// </summary>
        [JsonProperty(PropertyName = "switchProviderBlockingErrorDetails")]
        public IList<InMageRcmFabricSwitchProviderBlockingErrorDetails> SwitchProviderBlockingErrorDetails { get; private set; }

    }
}