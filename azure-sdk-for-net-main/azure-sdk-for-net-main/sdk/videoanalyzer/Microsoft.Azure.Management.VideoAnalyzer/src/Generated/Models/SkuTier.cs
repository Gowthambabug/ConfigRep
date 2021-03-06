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
    /// Defines values for SkuTier.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(SkuTierConverter))]
    public struct SkuTier : System.IEquatable<SkuTier>
    {
        private SkuTier(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Standard tier.
        /// </summary>
        public static readonly SkuTier Standard = "Standard";


        /// <summary>
        /// Underlying value of enum SkuTier
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for SkuTier
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type SkuTier
        /// </summary>
        public bool Equals(SkuTier e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to SkuTier
        /// </summary>
        public static implicit operator SkuTier(string value)
        {
            return new SkuTier(value);
        }

        /// <summary>
        /// Implicit operator to convert SkuTier to string
        /// </summary>
        public static implicit operator string(SkuTier e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum SkuTier
        /// </summary>
        public static bool operator == (SkuTier e1, SkuTier e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum SkuTier
        /// </summary>
        public static bool operator != (SkuTier e1, SkuTier e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for SkuTier
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is SkuTier && Equals((SkuTier)obj);
        }

        /// <summary>
        /// Returns for hashCode SkuTier
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
