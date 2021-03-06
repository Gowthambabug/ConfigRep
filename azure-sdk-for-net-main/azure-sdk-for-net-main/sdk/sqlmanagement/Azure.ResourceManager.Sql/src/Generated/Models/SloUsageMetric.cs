// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A Slo Usage Metric. </summary>
    internal partial class SloUsageMetric
    {
        /// <summary> Initializes a new instance of SloUsageMetric. </summary>
        internal SloUsageMetric()
        {
        }

        /// <summary> The serviceLevelObjective for SLO usage metric. </summary>
        public ServiceObjectiveName? ServiceLevelObjective { get; }
        /// <summary> The serviceLevelObjectiveId for SLO usage metric. </summary>
        public Guid? ServiceLevelObjectiveId { get; }
        /// <summary> Gets or sets inRangeTimeRatio for SLO usage metric. </summary>
        public double? InRangeTimeRatio { get; }
    }
}
