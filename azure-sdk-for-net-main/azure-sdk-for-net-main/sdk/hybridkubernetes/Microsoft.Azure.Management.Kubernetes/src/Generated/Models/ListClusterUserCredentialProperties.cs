// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Kubernetes.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ListClusterUserCredentialProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ListClusterUserCredentialProperties class.
        /// </summary>
        public ListClusterUserCredentialProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ListClusterUserCredentialProperties class.
        /// </summary>
        /// <param name="authenticationMethod">The mode of client
        /// authentication. Possible values include: 'Token', 'AAD'</param>
        /// <param name="clientProxy">Boolean value to indicate whether the
        /// request is for client side proxy or not</param>
        public ListClusterUserCredentialProperties(string authenticationMethod, bool clientProxy)
        {
            AuthenticationMethod = authenticationMethod;
            ClientProxy = clientProxy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mode of client authentication. Possible values
        /// include: 'Token', 'AAD'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationMethod")]
        public string AuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or sets boolean value to indicate whether the request is for
        /// client side proxy or not
        /// </summary>
        [JsonProperty(PropertyName = "clientProxy")]
        public bool ClientProxy { get; set; }

    }
}
