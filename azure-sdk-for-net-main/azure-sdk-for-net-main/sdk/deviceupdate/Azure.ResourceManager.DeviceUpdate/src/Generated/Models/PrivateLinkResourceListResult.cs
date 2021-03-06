// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The available private link resources for an Account. </summary>
    internal partial class PrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        internal PrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<PrivateLinkData>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        /// <param name="value"> The list of available private link resources for an Account. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of private link resources. </param>
        internal PrivateLinkResourceListResult(IReadOnlyList<PrivateLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of available private link resources for an Account. </summary>
        public IReadOnlyList<PrivateLinkData> Value { get; }
        /// <summary> The URI that can be used to request the next list of private link resources. </summary>
        public string NextLink { get; }
    }
}
