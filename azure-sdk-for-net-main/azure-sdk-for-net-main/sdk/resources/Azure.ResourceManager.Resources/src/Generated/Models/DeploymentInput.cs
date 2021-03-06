// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation parameters. </summary>
    public partial class DeploymentInput
    {
        /// <summary> Initializes a new instance of DeploymentInput. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeploymentInput(DeploymentProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The location to store the deployment data. </summary>
        public string Location { get; set; }
        /// <summary> The deployment properties. </summary>
        public DeploymentProperties Properties { get; }
        /// <summary> Deployment tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
