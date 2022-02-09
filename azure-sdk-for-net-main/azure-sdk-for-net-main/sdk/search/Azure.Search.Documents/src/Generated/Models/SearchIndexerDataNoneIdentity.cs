// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Clears the identity property of a datasource. </summary>
    public partial class SearchIndexerDataNoneIdentity : SearchIndexerDataIdentity
    {
        /// <summary> Initializes a new instance of SearchIndexerDataNoneIdentity. </summary>
        public SearchIndexerDataNoneIdentity()
        {
            ODataType = "#Microsoft.Azure.Search.SearchIndexerDataNoneIdentity";
        }

        /// <summary> Initializes a new instance of SearchIndexerDataNoneIdentity. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the identity. </param>
        internal SearchIndexerDataNoneIdentity(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.SearchIndexerDataNoneIdentity";
        }
    }
}