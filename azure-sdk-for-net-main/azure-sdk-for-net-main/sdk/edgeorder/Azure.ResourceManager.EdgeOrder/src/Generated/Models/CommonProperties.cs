// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents common properties across product hierarchy. </summary>
    internal partial class CommonProperties : BasicInformation
    {
        /// <summary> Initializes a new instance of CommonProperties. </summary>
        internal CommonProperties()
        {
            FilterableProperties = new ChangeTrackingList<FilterableProperty>();
        }

        /// <summary> list of filters supported for a product. </summary>
        public IReadOnlyList<FilterableProperty> FilterableProperties { get; }
    }
}