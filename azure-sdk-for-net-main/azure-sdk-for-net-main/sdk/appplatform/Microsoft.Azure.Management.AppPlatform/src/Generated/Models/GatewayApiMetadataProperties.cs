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
    using System.Linq;

    /// <summary>
    /// API metadata property for Spring Cloud Gateway
    /// </summary>
    public partial class GatewayApiMetadataProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayApiMetadataProperties
        /// class.
        /// </summary>
        public GatewayApiMetadataProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayApiMetadataProperties
        /// class.
        /// </summary>
        /// <param name="title">Title describing the context of the APIs
        /// available on the Gateway instance (default: `Spring Cloud Gateway
        /// for K8S`)</param>
        /// <param name="description">Detailed description of the APIs
        /// available on the Gateway instance (default: `Generated OpenAPI 3
        /// document that describes the API routes configured.`)</param>
        /// <param name="documentation">Location of additional documentation
        /// for the APIs available on the Gateway instance</param>
        /// <param name="version">Version of APIs available on this Gateway
        /// instance (default: `unspecified`).</param>
        /// <param name="serverUrl">Base URL that API consumers will use to
        /// access APIs on the Gateway instance.</param>
        public GatewayApiMetadataProperties(string title = default(string), string description = default(string), string documentation = default(string), string version = default(string), string serverUrl = default(string))
        {
            Title = title;
            Description = description;
            Documentation = documentation;
            Version = version;
            ServerUrl = serverUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets title describing the context of the APIs available on
        /// the Gateway instance (default: `Spring Cloud Gateway for K8S`)
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets detailed description of the APIs available on the
        /// Gateway instance (default: `Generated OpenAPI 3 document that
        /// describes the API routes configured.`)
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets location of additional documentation for the APIs
        /// available on the Gateway instance
        /// </summary>
        [JsonProperty(PropertyName = "documentation")]
        public string Documentation { get; set; }

        /// <summary>
        /// Gets or sets version of APIs available on this Gateway instance
        /// (default: `unspecified`).
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets base URL that API consumers will use to access APIs on
        /// the Gateway instance.
        /// </summary>
        [JsonProperty(PropertyName = "serverUrl")]
        public string ServerUrl { get; set; }

    }
}