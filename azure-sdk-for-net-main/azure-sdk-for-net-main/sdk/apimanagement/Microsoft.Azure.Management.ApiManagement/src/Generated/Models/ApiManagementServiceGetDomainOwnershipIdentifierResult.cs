// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response of the GetDomainOwnershipIdentifier operation.
    /// </summary>
    public partial class ApiManagementServiceGetDomainOwnershipIdentifierResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceGetDomainOwnershipIdentifierResult class.
        /// </summary>
        public ApiManagementServiceGetDomainOwnershipIdentifierResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceGetDomainOwnershipIdentifierResult class.
        /// </summary>
        /// <param name="domainOwnershipIdentifier">The domain ownership
        /// identifier value.</param>
        public ApiManagementServiceGetDomainOwnershipIdentifierResult(string domainOwnershipIdentifier = default(string))
        {
            DomainOwnershipIdentifier = domainOwnershipIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the domain ownership identifier value.
        /// </summary>
        [JsonProperty(PropertyName = "domainOwnershipIdentifier")]
        public string DomainOwnershipIdentifier { get; private set; }

    }
}