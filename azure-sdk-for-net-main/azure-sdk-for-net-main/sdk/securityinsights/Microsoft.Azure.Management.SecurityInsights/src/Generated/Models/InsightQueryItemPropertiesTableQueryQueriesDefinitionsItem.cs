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

    public partial class InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem class.
        /// </summary>
        public InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem class.
        /// </summary>
        /// <param name="filter">Insight column header.</param>
        /// <param name="summarize">Insight column header.</param>
        /// <param name="project">Insight column header.</param>
        /// <param name="linkColumnsDefinitions">Insight column header.</param>
        public InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem(string filter = default(string), string summarize = default(string), string project = default(string), IList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItemLinkColumnsDefinitionsItem> linkColumnsDefinitions = default(IList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItemLinkColumnsDefinitionsItem>))
        {
            Filter = filter;
            Summarize = summarize;
            Project = project;
            LinkColumnsDefinitions = linkColumnsDefinitions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets insight column header.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets insight column header.
        /// </summary>
        [JsonProperty(PropertyName = "summarize")]
        public string Summarize { get; set; }

        /// <summary>
        /// Gets or sets insight column header.
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public string Project { get; set; }

        /// <summary>
        /// Gets or sets insight column header.
        /// </summary>
        [JsonProperty(PropertyName = "linkColumnsDefinitions")]
        public IList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsItemLinkColumnsDefinitionsItem> LinkColumnsDefinitions { get; set; }

    }
}