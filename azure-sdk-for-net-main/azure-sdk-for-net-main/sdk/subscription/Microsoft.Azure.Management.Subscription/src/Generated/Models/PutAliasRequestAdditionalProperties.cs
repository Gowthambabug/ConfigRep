// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Put subscription additional properties.
    /// </summary>
    public partial class PutAliasRequestAdditionalProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PutAliasRequestAdditionalProperties class.
        /// </summary>
        public PutAliasRequestAdditionalProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PutAliasRequestAdditionalProperties class.
        /// </summary>
        /// <param name="managementGroupId">Management group Id for the
        /// subscription.</param>
        /// <param name="subscriptionTenantId">Tenant Id of the
        /// subscription</param>
        /// <param name="subscriptionOwnerId">Owner Id of the
        /// subscription</param>
        /// <param name="tags">Tags for the subscription</param>
        public PutAliasRequestAdditionalProperties(string managementGroupId = default(string), string subscriptionTenantId = default(string), string subscriptionOwnerId = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            ManagementGroupId = managementGroupId;
            SubscriptionTenantId = subscriptionTenantId;
            SubscriptionOwnerId = subscriptionOwnerId;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets management group Id for the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "managementGroupId")]
        public string ManagementGroupId { get; set; }

        /// <summary>
        /// Gets or sets tenant Id of the subscription
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionTenantId")]
        public string SubscriptionTenantId { get; set; }

        /// <summary>
        /// Gets or sets owner Id of the subscription
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionOwnerId")]
        public string SubscriptionOwnerId { get; set; }

        /// <summary>
        /// Gets or sets tags for the subscription
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
