// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Qos Traffic Profiler IP Range properties. </summary>
    public partial class QosIpRange
    {
        /// <summary> Initializes a new instance of QosIpRange. </summary>
        public QosIpRange()
        {
        }

        /// <summary> Initializes a new instance of QosIpRange. </summary>
        /// <param name="startIP"> Start IP Address. </param>
        /// <param name="endIP"> End IP Address. </param>
        internal QosIpRange(string startIP, string endIP)
        {
            StartIP = startIP;
            EndIP = endIP;
        }

        /// <summary> Start IP Address. </summary>
        public string StartIP { get; set; }
        /// <summary> End IP Address. </summary>
        public string EndIP { get; set; }
    }
}
