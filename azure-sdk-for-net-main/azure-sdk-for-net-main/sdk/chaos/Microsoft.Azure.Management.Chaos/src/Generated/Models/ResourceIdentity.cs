// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The managed identity of a resource.
    /// </summary>
    public partial class ResourceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        public ResourceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        /// <param name="type">String of the resource identity type. Possible
        /// values include: 'None', 'SystemAssigned'</param>
        /// <param name="principalId">GUID that represents the principal ID of
        /// this resource identity.</param>
        /// <param name="tenantId">GUID that represents the tenant ID of this
        /// resource identity.</param>
        public ResourceIdentity(ResourceIdentityType type, string principalId = default(string), string tenantId = default(string))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string of the resource identity type. Possible values
        /// include: 'None', 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType Type { get; set; }

        /// <summary>
        /// Gets GUID that represents the principal ID of this resource
        /// identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets GUID that represents the tenant ID of this resource identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

    }
}