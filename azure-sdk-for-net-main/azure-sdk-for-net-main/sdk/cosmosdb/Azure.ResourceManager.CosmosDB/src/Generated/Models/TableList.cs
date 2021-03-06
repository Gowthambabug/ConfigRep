// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Table and their properties. </summary>
    internal partial class TableList
    {
        /// <summary> Initializes a new instance of TableList. </summary>
        internal TableList()
        {
            Value = new ChangeTrackingList<CosmosTableData>();
        }

        /// <summary> Initializes a new instance of TableList. </summary>
        /// <param name="value"> List of Table and their properties. </param>
        internal TableList(IReadOnlyList<CosmosTableData> value)
        {
            Value = value;
        }

        /// <summary> List of Table and their properties. </summary>
        public IReadOnlyList<CosmosTableData> Value { get; }
    }
}
