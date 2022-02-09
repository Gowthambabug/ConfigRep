// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Current TCP connectivity information from the App Service Environment
    /// to a single endpoint.
    /// </summary>
    public partial class EndpointDetail
    {
        /// <summary>
        /// Initializes a new instance of the EndpointDetail class.
        /// </summary>
        public EndpointDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointDetail class.
        /// </summary>
        /// <param name="ipAddress">An IP Address that Domain Name currently
        /// resolves to.</param>
        /// <param name="port">The port an endpoint is connected to.</param>
        /// <param name="latency">The time in milliseconds it takes for a TCP
        /// connection to be created from the App Service Environment to this
        /// IpAddress at this Port.</param>
        /// <param name="isAccessible">Whether it is possible to create a TCP
        /// connection from the App Service Environment to this IpAddress at
        /// this Port.</param>
        public EndpointDetail(string ipAddress = default(string), int? port = default(int?), double? latency = default(double?), bool? isAccessible = default(bool?))
        {
            IpAddress = ipAddress;
            Port = port;
            Latency = latency;
            IsAccessible = isAccessible;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an IP Address that Domain Name currently resolves to.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the port an endpoint is connected to.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the time in milliseconds it takes for a TCP connection
        /// to be created from the App Service Environment to this IpAddress at
        /// this Port.
        /// </summary>
        [JsonProperty(PropertyName = "latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Gets or sets whether it is possible to create a TCP connection from
        /// the App Service Environment to this IpAddress at this Port.
        /// </summary>
        [JsonProperty(PropertyName = "isAccessible")]
        public bool? IsAccessible { get; set; }

    }
}