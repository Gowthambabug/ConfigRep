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
    /// Properties of site details provided during the time of site creation.
    /// </summary>
    public partial class FabricCreationInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the FabricCreationInputProperties
        /// class.
        /// </summary>
        public FabricCreationInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FabricCreationInputProperties
        /// class.
        /// </summary>
        /// <param name="customDetails">Fabric provider specific creation
        /// input.</param>
        public FabricCreationInputProperties(FabricSpecificCreationInput customDetails = default(FabricSpecificCreationInput))
        {
            CustomDetails = customDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fabric provider specific creation input.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public FabricSpecificCreationInput CustomDetails { get; set; }

    }
}