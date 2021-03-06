// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the triggers and their properties. </summary>
    internal partial class SqlTriggerList
    {
        /// <summary> Initializes a new instance of SqlTriggerList. </summary>
        internal SqlTriggerList()
        {
            Value = new ChangeTrackingList<SqlTriggerData>();
        }

        /// <summary> Initializes a new instance of SqlTriggerList. </summary>
        /// <param name="value"> List of triggers and their properties. </param>
        internal SqlTriggerList(IReadOnlyList<SqlTriggerData> value)
        {
            Value = value;
        }

        /// <summary> List of triggers and their properties. </summary>
        public IReadOnlyList<SqlTriggerData> Value { get; }
    }
}
