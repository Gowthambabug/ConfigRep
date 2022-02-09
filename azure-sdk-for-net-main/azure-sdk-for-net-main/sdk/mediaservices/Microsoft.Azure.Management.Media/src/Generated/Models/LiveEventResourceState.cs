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
    /// Defines values for LiveEventResourceState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(LiveEventResourceStateConverter))]
    public struct LiveEventResourceState : System.IEquatable<LiveEventResourceState>
    {
        private LiveEventResourceState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// This is the initial state of the live event after creation (unless
        /// autostart was set to true.) No billing occurs in this state. In
        /// this state, the live event properties can be updated but streaming
        /// is not allowed.
        /// </summary>
        public static readonly LiveEventResourceState Stopped = "Stopped";

        /// <summary>
        /// Allocate action was called on the live event and resources are
        /// being provisioned for this live event. Once allocation completes
        /// successfully, the live event will transition to StandBy state.
        /// </summary>
        public static readonly LiveEventResourceState Allocating = "Allocating";

        /// <summary>
        /// Live event resources have been provisioned and is ready to start.
        /// Billing occurs in this state. Most properties can still be updated,
        /// however ingest or streaming is not allowed during this state.
        /// </summary>
        public static readonly LiveEventResourceState StandBy = "StandBy";

        /// <summary>
        /// The live event is being started and resources are being allocated.
        /// No billing occurs in this state. Updates or streaming are not
        /// allowed during this state. If an error occurs, the live event
        /// returns to the Stopped state.
        /// </summary>
        public static readonly LiveEventResourceState Starting = "Starting";

        /// <summary>
        /// The live event resources have been allocated, ingest and preview
        /// URLs have been generated, and it is capable of receiving live
        /// streams. At this point, billing is active. You must explicitly call
        /// Stop on the live event resource to halt further billing.
        /// </summary>
        public static readonly LiveEventResourceState Running = "Running";

        /// <summary>
        /// The live event is being stopped and resources are being
        /// de-provisioned. No billing occurs in this transient state. Updates
        /// or streaming are not allowed during this state.
        /// </summary>
        public static readonly LiveEventResourceState Stopping = "Stopping";

        /// <summary>
        /// The live event is being deleted. No billing occurs in this
        /// transient state. Updates or streaming are not allowed during this
        /// state.
        /// </summary>
        public static readonly LiveEventResourceState Deleting = "Deleting";


        /// <summary>
        /// Underlying value of enum LiveEventResourceState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for LiveEventResourceState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type LiveEventResourceState
        /// </summary>
        public bool Equals(LiveEventResourceState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to LiveEventResourceState
        /// </summary>
        public static implicit operator LiveEventResourceState(string value)
        {
            return new LiveEventResourceState(value);
        }

        /// <summary>
        /// Implicit operator to convert LiveEventResourceState to string
        /// </summary>
        public static implicit operator string(LiveEventResourceState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum LiveEventResourceState
        /// </summary>
        public static bool operator == (LiveEventResourceState e1, LiveEventResourceState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum LiveEventResourceState
        /// </summary>
        public static bool operator != (LiveEventResourceState e1, LiveEventResourceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for LiveEventResourceState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is LiveEventResourceState && Equals((LiveEventResourceState)obj);
        }

        /// <summary>
        /// Returns for hashCode LiveEventResourceState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}