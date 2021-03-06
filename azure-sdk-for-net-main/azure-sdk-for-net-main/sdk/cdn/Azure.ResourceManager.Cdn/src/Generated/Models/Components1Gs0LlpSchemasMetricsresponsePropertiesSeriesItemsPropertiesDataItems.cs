// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
    public partial class Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        /// <summary> Initializes a new instance of Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
        internal Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems()
        {
        }

        /// <summary> Initializes a new instance of Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
        /// <param name="dateTime"></param>
        /// <param name="value"></param>
        internal Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(DateTimeOffset? dateTime, float? value)
        {
            DateTime = dateTime;
            Value = value;
        }

        /// <summary> Gets the date time. </summary>
        public DateTimeOffset? DateTime { get; }
        /// <summary> Gets the value. </summary>
        public float? Value { get; }
    }
}
