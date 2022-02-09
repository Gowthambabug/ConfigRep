// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Usage of the quota resource. </summary>
    public partial class CsmUsageQuota
    {
        /// <summary> Initializes a new instance of CsmUsageQuota. </summary>
        internal CsmUsageQuota()
        {
        }

        /// <summary> Initializes a new instance of CsmUsageQuota. </summary>
        /// <param name="unit"> Units of measurement for the quota resource. </param>
        /// <param name="nextResetTime"> Next reset time for the resource counter. </param>
        /// <param name="currentValue"> The current value of the resource counter. </param>
        /// <param name="limit"> The resource limit. </param>
        /// <param name="name"> Quota name. </param>
        internal CsmUsageQuota(string unit, DateTimeOffset? nextResetTime, long? currentValue, long? limit, LocalizableString name)
        {
            Unit = unit;
            NextResetTime = nextResetTime;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Units of measurement for the quota resource. </summary>
        public string Unit { get; }
        /// <summary> Next reset time for the resource counter. </summary>
        public DateTimeOffset? NextResetTime { get; }
        /// <summary> The current value of the resource counter. </summary>
        public long? CurrentValue { get; }
        /// <summary> The resource limit. </summary>
        public long? Limit { get; }
        /// <summary> Quota name. </summary>
        public LocalizableString Name { get; }
    }
}