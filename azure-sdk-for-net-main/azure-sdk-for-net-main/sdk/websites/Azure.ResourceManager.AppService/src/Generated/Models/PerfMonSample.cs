// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Performance monitor sample in a set. </summary>
    public partial class PerfMonSample
    {
        /// <summary> Initializes a new instance of PerfMonSample. </summary>
        internal PerfMonSample()
        {
        }

        /// <summary> Initializes a new instance of PerfMonSample. </summary>
        /// <param name="time"> Point in time for which counter was measured. </param>
        /// <param name="instanceName"> Name of the server on which the measurement is made. </param>
        /// <param name="value"> Value of counter at a certain time. </param>
        internal PerfMonSample(DateTimeOffset? time, string instanceName, double? value)
        {
            Time = time;
            InstanceName = instanceName;
            Value = value;
        }

        /// <summary> Point in time for which counter was measured. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> Name of the server on which the measurement is made. </summary>
        public string InstanceName { get; }
        /// <summary> Value of counter at a certain time. </summary>
        public double? Value { get; }
    }
}