// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RankingsResponseTablesItem. </summary>
    public partial class RankingsResponseTablesItem
    {
        /// <summary> Initializes a new instance of RankingsResponseTablesItem. </summary>
        internal RankingsResponseTablesItem()
        {
            Data = new ChangeTrackingList<RankingsResponseTablesPropertiesItemsItem>();
        }

        /// <summary> Initializes a new instance of RankingsResponseTablesItem. </summary>
        /// <param name="ranking"></param>
        /// <param name="data"></param>
        internal RankingsResponseTablesItem(string ranking, IReadOnlyList<RankingsResponseTablesPropertiesItemsItem> data)
        {
            Ranking = ranking;
            Data = data;
        }

        /// <summary> Gets the ranking. </summary>
        public string Ranking { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<RankingsResponseTablesPropertiesItemsItem> Data { get; }
    }
}