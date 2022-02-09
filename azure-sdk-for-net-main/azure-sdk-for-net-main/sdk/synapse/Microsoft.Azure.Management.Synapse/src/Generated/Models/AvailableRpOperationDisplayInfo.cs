// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of an available operation
    /// </summary>
    public partial class AvailableRpOperationDisplayInfo
    {
        /// <summary>
        /// Initializes a new instance of the AvailableRpOperationDisplayInfo
        /// class.
        /// </summary>
        public AvailableRpOperationDisplayInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableRpOperationDisplayInfo
        /// class.
        /// </summary>
        /// <param name="description">Operation description</param>
        /// <param name="resource">Resource type</param>
        /// <param name="provider">Resource provider name</param>
        /// <param name="operation">Operation name</param>
        public AvailableRpOperationDisplayInfo(string description = default(string), string resource = default(string), string provider = default(string), string operation = default(string))
        {
            Description = description;
            Resource = resource;
            Provider = provider;
            Operation = operation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets resource type
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets resource provider name
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets operation name
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

    }
}
