// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of top resource consuming queries on managed instance. </summary>
    internal partial class TopQueriesListResult
    {
        /// <summary> Initializes a new instance of TopQueriesListResult. </summary>
        internal TopQueriesListResult()
        {
            Value = new ChangeTrackingList<TopQueries>();
        }

        /// <summary> Initializes a new instance of TopQueriesListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal TopQueriesListResult(IReadOnlyList<TopQueries> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<TopQueries> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}