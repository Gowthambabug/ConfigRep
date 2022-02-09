// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CosmosTablePropertiesOptions. </summary>
    public partial class CosmosTablePropertiesOptions : OptionsResource
    {
        /// <summary> Initializes a new instance of CosmosTablePropertiesOptions. </summary>
        public CosmosTablePropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of CosmosTablePropertiesOptions. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal CosmosTablePropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}