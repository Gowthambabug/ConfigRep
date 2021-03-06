// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// The payload for a Configure HTTP settings request.
    /// </summary>
    [System.Obsolete("This type is deprecated. Please use GatewaySettings instead.")]
    public partial class HttpConnectivitySettings
    {
        /// <summary>
        /// Gets or sets whether or not the HTTP based authorization is
        /// enabled. Possible values include: 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.isEnabled")]
        public string EnabledCredential { get; set; }

        /// <summary>
        /// Gets or sets the HTTP username.
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user password.
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.password")]
        public string Password { get; set; }
    }
}
