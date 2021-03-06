// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the Spring Cloud Gateway Operator.
    /// </summary>
    public partial class GatewayOperatorProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayOperatorProperties class.
        /// </summary>
        public GatewayOperatorProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayOperatorProperties class.
        /// </summary>
        /// <param name="resourceRequests">The requested resource quantity for
        /// required CPU and Memory.</param>
        /// <param name="instances">Collection of instances belong to Spring
        /// Cloud Gateway operator.</param>
        public GatewayOperatorProperties(GatewayOperatorResourceRequests resourceRequests = default(GatewayOperatorResourceRequests), IList<GatewayInstance> instances = default(IList<GatewayInstance>))
        {
            ResourceRequests = resourceRequests;
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the requested resource quantity for required CPU and
        /// Memory.
        /// </summary>
        [JsonProperty(PropertyName = "resourceRequests")]
        public GatewayOperatorResourceRequests ResourceRequests { get; set; }

        /// <summary>
        /// Gets collection of instances belong to Spring Cloud Gateway
        /// operator.
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<GatewayInstance> Instances { get; private set; }

    }
}
