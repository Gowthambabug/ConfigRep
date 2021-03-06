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
    /// The managed instance's service principal configuration for a resource.
    /// </summary>
    public partial class ServicePrincipal
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipal class.
        /// </summary>
        public ServicePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipal class.
        /// </summary>
        /// <param name="principalId">The Azure Active Directory application
        /// object id.</param>
        /// <param name="clientId">The Azure Active Directory application
        /// client id.</param>
        /// <param name="tenantId">The Azure Active Directory tenant
        /// id.</param>
        /// <param name="type">Service principal type. Possible values include:
        /// 'None', 'SystemAssigned'</param>
        public ServicePrincipal(string principalId = default(string), string clientId = default(string), string tenantId = default(string), string type = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Azure Active Directory application object id.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the Azure Active Directory application client id.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

        /// <summary>
        /// Gets the Azure Active Directory tenant id.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets service principal type. Possible values include:
        /// 'None', 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
