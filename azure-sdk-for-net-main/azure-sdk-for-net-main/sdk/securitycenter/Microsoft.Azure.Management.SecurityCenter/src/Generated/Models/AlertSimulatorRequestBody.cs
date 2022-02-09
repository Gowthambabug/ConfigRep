// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Alert Simulator request body.
    /// </summary>
    public partial class AlertSimulatorRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the AlertSimulatorRequestBody class.
        /// </summary>
        public AlertSimulatorRequestBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertSimulatorRequestBody class.
        /// </summary>
        /// <param name="properties">Alert Simulator request body data.</param>
        public AlertSimulatorRequestBody(AlertSimulatorRequestProperties properties = default(AlertSimulatorRequestProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets alert Simulator request body data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AlertSimulatorRequestProperties Properties { get; set; }

    }
}