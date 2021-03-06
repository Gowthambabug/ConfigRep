// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> the list of pages. </summary>
    internal partial class PageList
    {
        /// <summary> Initializes a new instance of PageList. </summary>
        internal PageList()
        {
            PageRange = new ChangeTrackingList<PageRange>();
            ClearRange = new ChangeTrackingList<ClearRange>();
        }

        /// <summary> Initializes a new instance of PageList. </summary>
        /// <param name="pageRange"></param>
        /// <param name="clearRange"></param>
        internal PageList(IReadOnlyList<PageRange> pageRange, IReadOnlyList<ClearRange> clearRange)
        {
            PageRange = pageRange;
            ClearRange = clearRange;
        }

        /// <summary> Gets the page range. </summary>
        public IReadOnlyList<PageRange> PageRange { get; }
        /// <summary> Gets the clear range. </summary>
        public IReadOnlyList<ClearRange> ClearRange { get; }
    }
}
