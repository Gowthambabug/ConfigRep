// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Scope of the extension. It can be either Cluster or Namespace; but not
    /// both.
    /// </summary>
    public partial class Scope
    {
        /// <summary>
        /// Initializes a new instance of the Scope class.
        /// </summary>
        public Scope()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Scope class.
        /// </summary>
        public Scope(ScopeCluster cluster = default(ScopeCluster), ScopeNamespace namespaceProperty = default(ScopeNamespace))
        {
            Cluster = cluster;
            NamespaceProperty = namespaceProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public ScopeCluster Cluster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public ScopeNamespace NamespaceProperty { get; set; }

    }
}
