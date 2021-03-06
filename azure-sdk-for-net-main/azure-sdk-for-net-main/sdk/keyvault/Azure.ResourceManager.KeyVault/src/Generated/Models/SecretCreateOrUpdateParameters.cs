// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Parameters for creating or updating a secret. </summary>
    public partial class SecretCreateOrUpdateParameters
    {
        /// <summary> Initializes a new instance of SecretCreateOrUpdateParameters. </summary>
        /// <param name="properties"> Properties of the secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SecretCreateOrUpdateParameters(SecretProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> The tags that will be assigned to the secret. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the secret. </summary>
        public SecretProperties Properties { get; }
    }
}
