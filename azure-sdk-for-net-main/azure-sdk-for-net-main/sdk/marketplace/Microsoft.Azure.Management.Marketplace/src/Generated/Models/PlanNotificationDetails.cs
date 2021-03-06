// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Plan notification details
    /// </summary>
    public partial class PlanNotificationDetails
    {
        /// <summary>
        /// Initializes a new instance of the PlanNotificationDetails class.
        /// </summary>
        public PlanNotificationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlanNotificationDetails class.
        /// </summary>
        /// <param name="planId">Gets or sets the plan id</param>
        /// <param name="planDisplayName">Gets or sets the plan display
        /// name</param>
        public PlanNotificationDetails(string planId = default(string), string planDisplayName = default(string))
        {
            PlanId = planId;
            PlanDisplayName = planDisplayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan id
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets the plan display name
        /// </summary>
        [JsonProperty(PropertyName = "planDisplayName")]
        public string PlanDisplayName { get; set; }

    }
}
