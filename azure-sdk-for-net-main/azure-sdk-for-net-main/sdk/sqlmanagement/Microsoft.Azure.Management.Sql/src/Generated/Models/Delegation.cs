// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Delegated Resource Properties - Internal Use Only
    /// </summary>
    public partial class Delegation
    {
        /// <summary>
        /// Initializes a new instance of the Delegation class.
        /// </summary>
        public Delegation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Delegation class.
        /// </summary>
        /// <param name="resourceId">The resource id of the source resource -
        /// Internal Use Only</param>
        /// <param name="tenantId">AAD tenant guid of the source resource
        /// identity - Internal Use Only.</param>
        public Delegation(string resourceId = default(string), System.Guid? tenantId = default(System.Guid?))
        {
            ResourceId = resourceId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the source resource - Internal Use
        /// Only
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets AAD tenant guid of the source resource identity - Internal Use
        /// Only.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

    }
}
