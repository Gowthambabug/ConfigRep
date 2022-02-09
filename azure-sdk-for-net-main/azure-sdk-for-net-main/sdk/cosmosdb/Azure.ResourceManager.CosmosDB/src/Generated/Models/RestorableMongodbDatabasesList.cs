// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the MongoDB database events and their properties. </summary>
    internal partial class RestorableMongodbDatabasesList
    {
        /// <summary> Initializes a new instance of RestorableMongodbDatabasesList. </summary>
        internal RestorableMongodbDatabasesList()
        {
            Value = new ChangeTrackingList<RestorableMongodbDatabase>();
        }

        /// <summary> Initializes a new instance of RestorableMongodbDatabasesList. </summary>
        /// <param name="value"> List of MongoDB database events and their properties. </param>
        internal RestorableMongodbDatabasesList(IReadOnlyList<RestorableMongodbDatabase> value)
        {
            Value = value;
        }

        /// <summary> List of MongoDB database events and their properties. </summary>
        public IReadOnlyList<RestorableMongodbDatabase> Value { get; }
    }
}