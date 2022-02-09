// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents Microsoft Threat Intelligence requirements check request.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MicrosoftThreatIntelligence")]
    [Rest.Serialization.JsonTransformation]
    public partial class MSTICheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary>
        /// Initializes a new instance of the MSTICheckRequirements class.
        /// </summary>
        public MSTICheckRequirements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MSTICheckRequirements class.
        /// </summary>
        /// <param name="tenantId">The tenant id to connect to, and get the
        /// data from.</param>
        public MSTICheckRequirements(string tenantId)
        {
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenant id to connect to, and get the data from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TenantId");
            }
        }
    }
}