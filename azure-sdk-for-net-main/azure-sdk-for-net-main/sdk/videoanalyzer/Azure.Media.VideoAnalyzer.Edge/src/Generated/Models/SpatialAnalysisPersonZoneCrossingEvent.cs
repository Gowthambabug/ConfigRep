// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person crossing zone operation eventing configuration. </summary>
    public partial class SpatialAnalysisPersonZoneCrossingEvent : SpatialAnalysisOperationEventBase
    {
        /// <summary> Initializes a new instance of SpatialAnalysisPersonZoneCrossingEvent. </summary>
        public SpatialAnalysisPersonZoneCrossingEvent()
        {
        }

        /// <summary> Initializes a new instance of SpatialAnalysisPersonZoneCrossingEvent. </summary>
        /// <param name="threshold"> The event threshold. </param>
        /// <param name="focus"> The operation focus type. </param>
        /// <param name="eventType"> The event type. </param>
        internal SpatialAnalysisPersonZoneCrossingEvent(string threshold, SpatialAnalysisOperationFocus? focus, SpatialAnalysisPersonZoneCrossingEventType? eventType) : base(threshold, focus)
        {
            EventType = eventType;
        }

        /// <summary> The event type. </summary>
        public SpatialAnalysisPersonZoneCrossingEventType? EventType { get; set; }
    }
}