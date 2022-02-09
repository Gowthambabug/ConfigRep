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
    using System.Linq;

    /// <summary>
    /// InMageAzureV2 provider specific input for unplanned failover.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2UnplannedFailoverInput : UnplannedFailoverProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2UnplannedFailoverInput class.
        /// </summary>
        public InMageAzureV2UnplannedFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2UnplannedFailoverInput class.
        /// </summary>
        /// <param name="recoveryPointId">The recovery point id to be passed to
        /// failover to a particular recovery point. In case of latest recovery
        /// point, null should be passed.</param>
        public InMageAzureV2UnplannedFailoverInput(string recoveryPointId = default(string))
        {
            RecoveryPointId = recoveryPointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point id to be passed to failover to a
        /// particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

    }
}