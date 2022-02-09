// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for PrivateEndpointConnectionProvisioningState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PrivateEndpointConnectionProvisioningStateConverter))]
    public struct PrivateEndpointConnectionProvisioningState : System.IEquatable<PrivateEndpointConnectionProvisioningState>
    {
        private PrivateEndpointConnectionProvisioningState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly PrivateEndpointConnectionProvisioningState Succeeded = "Succeeded";

        public static readonly PrivateEndpointConnectionProvisioningState Creating = "Creating";

        public static readonly PrivateEndpointConnectionProvisioningState Deleting = "Deleting";

        public static readonly PrivateEndpointConnectionProvisioningState Failed = "Failed";


        /// <summary>
        /// Underlying value of enum PrivateEndpointConnectionProvisioningState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for
        /// PrivateEndpointConnectionProvisioningState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PrivateEndpointConnectionProvisioningState
        /// </summary>
        public bool Equals(PrivateEndpointConnectionProvisioningState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// PrivateEndpointConnectionProvisioningState
        /// </summary>
        public static implicit operator PrivateEndpointConnectionProvisioningState(string value)
        {
            return new PrivateEndpointConnectionProvisioningState(value);
        }

        /// <summary>
        /// Implicit operator to convert
        /// PrivateEndpointConnectionProvisioningState to string
        /// </summary>
        public static implicit operator string(PrivateEndpointConnectionProvisioningState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum
        /// PrivateEndpointConnectionProvisioningState
        /// </summary>
        public static bool operator == (PrivateEndpointConnectionProvisioningState e1, PrivateEndpointConnectionProvisioningState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum
        /// PrivateEndpointConnectionProvisioningState
        /// </summary>
        public static bool operator != (PrivateEndpointConnectionProvisioningState e1, PrivateEndpointConnectionProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for
        /// PrivateEndpointConnectionProvisioningState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PrivateEndpointConnectionProvisioningState && Equals((PrivateEndpointConnectionProvisioningState)obj);
        }

        /// <summary>
        /// Returns for hashCode PrivateEndpointConnectionProvisioningState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
