// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SeriesResultList. </summary>
    internal partial class SeriesResultList
    {
        /// <summary> Initializes a new instance of SeriesResultList. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SeriesResultList(IEnumerable<MetricEnrichedSeriesData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SeriesResultList. </summary>
        /// <param name="value"></param>
        internal SeriesResultList(IReadOnlyList<MetricEnrichedSeriesData> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<MetricEnrichedSeriesData> Value { get; }
    }
}