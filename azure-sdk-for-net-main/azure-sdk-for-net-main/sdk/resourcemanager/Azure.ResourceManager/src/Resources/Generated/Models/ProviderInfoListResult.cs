// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of resource providers. </summary>
    internal partial class ProviderInfoListResult
    {
        /// <summary> Initializes a new instance of ProviderInfoListResult. </summary>
        internal ProviderInfoListResult()
        {
            Value = new ChangeTrackingList<ProviderInfo>();
        }

        /// <summary> Initializes a new instance of ProviderInfoListResult. </summary>
        /// <param name="value"> An array of resource providers. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ProviderInfoListResult(IReadOnlyList<ProviderInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of resource providers. </summary>
        public IReadOnlyList<ProviderInfo> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}