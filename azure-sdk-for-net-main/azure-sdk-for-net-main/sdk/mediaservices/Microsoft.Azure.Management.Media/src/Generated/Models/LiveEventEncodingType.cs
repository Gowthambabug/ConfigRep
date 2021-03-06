// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for LiveEventEncodingType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(LiveEventEncodingTypeConverter))]
    public struct LiveEventEncodingType : System.IEquatable<LiveEventEncodingType>
    {
        private LiveEventEncodingType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// This is the same as PassthroughStandard, please see description
        /// below. This enumeration value is being deprecated.
        /// </summary>
        public static readonly LiveEventEncodingType None = "None";

        /// <summary>
        /// A contribution live encoder sends a single bitrate stream to the
        /// live event and Media Services creates multiple bitrate streams. The
        /// output cannot exceed 720p in resolution.
        /// </summary>
        public static readonly LiveEventEncodingType Standard = "Standard";

        /// <summary>
        /// A contribution live encoder sends a single bitrate stream to the
        /// live event and Media Services creates multiple bitrate streams. The
        /// output cannot exceed 1080p in resolution.
        /// </summary>
        public static readonly LiveEventEncodingType Premium1080p = "Premium1080p";

        /// <summary>
        /// The ingested stream passes through the live event from the
        /// contribution encoder without any further processing. In the
        /// PassthroughBasic mode, ingestion is limited to up to 5Mbps and only
        /// 1 concurrent live output is allowed. Live transcription is not
        /// available.
        /// </summary>
        public static readonly LiveEventEncodingType PassthroughBasic = "PassthroughBasic";

        /// <summary>
        /// The ingested stream passes through the live event from the
        /// contribution encoder without any further processing. Live
        /// transcription is available. Ingestion bitrate limits are much
        /// higher and up to 3 concurrent live outputs are allowed.
        /// </summary>
        public static readonly LiveEventEncodingType PassthroughStandard = "PassthroughStandard";


        /// <summary>
        /// Underlying value of enum LiveEventEncodingType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for LiveEventEncodingType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type LiveEventEncodingType
        /// </summary>
        public bool Equals(LiveEventEncodingType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to LiveEventEncodingType
        /// </summary>
        public static implicit operator LiveEventEncodingType(string value)
        {
            return new LiveEventEncodingType(value);
        }

        /// <summary>
        /// Implicit operator to convert LiveEventEncodingType to string
        /// </summary>
        public static implicit operator string(LiveEventEncodingType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum LiveEventEncodingType
        /// </summary>
        public static bool operator == (LiveEventEncodingType e1, LiveEventEncodingType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum LiveEventEncodingType
        /// </summary>
        public static bool operator != (LiveEventEncodingType e1, LiveEventEncodingType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for LiveEventEncodingType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is LiveEventEncodingType && Equals((LiveEventEncodingType)obj);
        }

        /// <summary>
        /// Returns for hashCode LiveEventEncodingType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
