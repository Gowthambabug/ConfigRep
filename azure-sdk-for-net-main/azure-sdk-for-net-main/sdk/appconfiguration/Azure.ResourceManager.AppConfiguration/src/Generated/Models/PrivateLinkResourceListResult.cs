// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class PrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        internal PrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<PrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceListResult. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        internal PrivateLinkResourceListResult(IReadOnlyList<PrivateLinkResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<PrivateLinkResourceData> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}