// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureApplicationInsightsDataFeedPatch. </summary>
    internal partial class AzureApplicationInsightsDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureApplicationInsightsDataFeedPatch. </summary>
        public AzureApplicationInsightsDataFeedPatch()
        {
            DataSourceType = DataFeedSourceKind.AzureApplicationInsights;
        }

        /// <summary> Gets or sets the data source parameter. </summary>
        public AzureApplicationInsightsParameterPatch DataSourceParameter { get; set; }
    }
}