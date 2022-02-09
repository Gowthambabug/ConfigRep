// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListFrontendIPConfiguration API service call. </summary>
    internal partial class LoadBalancerFrontendIPConfigurationListResult
    {
        /// <summary> Initializes a new instance of LoadBalancerFrontendIPConfigurationListResult. </summary>
        internal LoadBalancerFrontendIPConfigurationListResult()
        {
            Value = new ChangeTrackingList<FrontendIPConfigurationData>();
        }

        /// <summary> Initializes a new instance of LoadBalancerFrontendIPConfigurationListResult. </summary>
        /// <param name="value"> A list of frontend IP configurations in a load balancer. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LoadBalancerFrontendIPConfigurationListResult(IReadOnlyList<FrontendIPConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of frontend IP configurations in a load balancer. </summary>
        public IReadOnlyList<FrontendIPConfigurationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}