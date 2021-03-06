// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> List of iSCSI Targets. </summary>
    internal partial class IscsiTargetList
    {
        /// <summary> Initializes a new instance of IscsiTargetList. </summary>
        /// <param name="value"> An array of iSCSI Targets in a Disk Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IscsiTargetList(IEnumerable<IscsiTargetData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of IscsiTargetList. </summary>
        /// <param name="value"> An array of iSCSI Targets in a Disk Pool. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        internal IscsiTargetList(IReadOnlyList<IscsiTargetData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of iSCSI Targets in a Disk Pool. </summary>
        public IReadOnlyList<IscsiTargetData> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
