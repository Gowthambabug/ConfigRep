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
    /// Credential of the image registry
    /// </summary>
    public partial class ImageRegistryCredential
    {
        /// <summary>
        /// Initializes a new instance of the ImageRegistryCredential class.
        /// </summary>
        public ImageRegistryCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageRegistryCredential class.
        /// </summary>
        /// <param name="username">The username of the image registry
        /// credential</param>
        /// <param name="password">The password of the image registry
        /// credential</param>
        public ImageRegistryCredential(string username = default(string), string password = default(string))
        {
            Username = username;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username of the image registry credential
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the image registry credential
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
