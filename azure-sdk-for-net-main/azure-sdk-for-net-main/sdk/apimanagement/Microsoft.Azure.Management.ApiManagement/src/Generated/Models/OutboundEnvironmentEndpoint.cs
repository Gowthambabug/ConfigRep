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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Endpoints accessed for a common purpose that the Api Management Service
    /// requires outbound network access to.
    /// </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the OutboundEnvironmentEndpoint
        /// class.
        /// </summary>
        public OutboundEnvironmentEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutboundEnvironmentEndpoint
        /// class.
        /// </summary>
        /// <param name="category">The type of service accessed by the Api
        /// Management Service, e.g., Azure Storage, Azure SQL Database, and
        /// Azure Active Directory.</param>
        /// <param name="endpoints">The endpoints that the Api Management
        /// Service reaches the service at.</param>
        public OutboundEnvironmentEndpoint(string category = default(string), IList<EndpointDependency> endpoints = default(IList<EndpointDependency>))
        {
            Category = category;
            Endpoints = endpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of service accessed by the Api Management
        /// Service, e.g., Azure Storage, Azure SQL Database, and Azure Active
        /// Directory.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the endpoints that the Api Management Service reaches
        /// the service at.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<EndpointDependency> Endpoints { get; set; }

    }
}