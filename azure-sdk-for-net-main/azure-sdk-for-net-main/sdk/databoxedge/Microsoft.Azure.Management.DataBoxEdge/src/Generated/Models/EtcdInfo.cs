// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Etcd configuration
    /// </summary>
    public partial class EtcdInfo
    {
        /// <summary>
        /// Initializes a new instance of the EtcdInfo class.
        /// </summary>
        public EtcdInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EtcdInfo class.
        /// </summary>
        /// <param name="type">Etcd type</param>
        /// <param name="version">Etcd version</param>
        public EtcdInfo(string type = default(string), string version = default(string))
        {
            Type = type;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets etcd type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets etcd version
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

    }
}