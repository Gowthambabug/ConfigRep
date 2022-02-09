// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the Secret to create. </summary>
    public partial class SecretProperties : AfdStateProperties
    {
        /// <summary> Initializes a new instance of SecretProperties. </summary>
        public SecretProperties()
        {
        }

        /// <summary> object which contains secret parameters. </summary>
        public SecretParameters Parameters { get; set; }
    }
}