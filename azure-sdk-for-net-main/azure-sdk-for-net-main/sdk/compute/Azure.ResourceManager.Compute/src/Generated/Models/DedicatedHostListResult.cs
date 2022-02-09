// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The list dedicated host operation response. </summary>
    internal partial class DedicatedHostListResult
    {
        /// <summary> Initializes a new instance of DedicatedHostListResult. </summary>
        /// <param name="value"> The list of dedicated hosts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DedicatedHostListResult(IEnumerable<DedicatedHostData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DedicatedHostListResult. </summary>
        /// <param name="value"> The list of dedicated hosts. </param>
        /// <param name="nextLink"> The URI to fetch the next page of dedicated hosts. Call ListNext() with this URI to fetch the next page of dedicated hosts. </param>
        internal DedicatedHostListResult(IReadOnlyList<DedicatedHostData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of dedicated hosts. </summary>
        public IReadOnlyList<DedicatedHostData> Value { get; }
        /// <summary> The URI to fetch the next page of dedicated hosts. Call ListNext() with this URI to fetch the next page of dedicated hosts. </summary>
        public string NextLink { get; }
    }
}