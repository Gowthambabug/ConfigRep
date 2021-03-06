// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query results for table insights query.
    /// </summary>
    public partial class InsightsTableResult
    {
        /// <summary>
        /// Initializes a new instance of the InsightsTableResult class.
        /// </summary>
        public InsightsTableResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InsightsTableResult class.
        /// </summary>
        /// <param name="columns">Columns Metadata of the table</param>
        /// <param name="rows">Rows data of the table</param>
        public InsightsTableResult(IList<InsightsTableResultColumnsItem> columns = default(IList<InsightsTableResultColumnsItem>), IList<IList<string>> rows = default(IList<IList<string>>))
        {
            Columns = columns;
            Rows = rows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets columns Metadata of the table
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<InsightsTableResultColumnsItem> Columns { get; set; }

        /// <summary>
        /// Gets or sets rows data of the table
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<IList<string>> Rows { get; set; }

    }
}
