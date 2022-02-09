// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of VirtualNetworks. </summary>
    internal partial class VirtualNetworksList
    {
        /// <summary> Initializes a new instance of VirtualNetworksList. </summary>
        /// <param name="value"> Array of VirtualNetworks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualNetworksList(IEnumerable<VirtualNetworkData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of VirtualNetworksList. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of VirtualNetworks. </param>
        /// <param name="value"> Array of VirtualNetworks. </param>
        internal VirtualNetworksList(string nextLink, IReadOnlyList<VirtualNetworkData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of VirtualNetworks. </summary>
        public string NextLink { get; }
        /// <summary> Array of VirtualNetworks. </summary>
        public IReadOnlyList<VirtualNetworkData> Value { get; }
    }
}
