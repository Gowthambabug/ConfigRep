// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list metric definitions request. </summary>
    internal partial class MetricDefinitionList
    {
        /// <summary> Initializes a new instance of MetricDefinitionList. </summary>
        internal MetricDefinitionList()
        {
            Value = new ChangeTrackingList<MetricDefinition>();
        }

        /// <summary> Initializes a new instance of MetricDefinitionList. </summary>
        /// <param name="value"> The list of metric definitions for the account. </param>
        internal MetricDefinitionList(IReadOnlyList<MetricDefinition> value)
        {
            Value = value;
        }

        /// <summary> The list of metric definitions for the account. </summary>
        public IReadOnlyList<MetricDefinition> Value { get; }
    }
}
