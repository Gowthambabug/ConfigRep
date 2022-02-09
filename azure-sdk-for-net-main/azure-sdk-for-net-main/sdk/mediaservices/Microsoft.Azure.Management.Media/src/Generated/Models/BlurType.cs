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
    /// Defines values for BlurType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(BlurTypeConverter))]
    public struct BlurType : System.IEquatable<BlurType>
    {
        private BlurType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Box: debug filter, bounding box only
        /// </summary>
        public static readonly BlurType Box = "Box";

        /// <summary>
        /// Low: box-car blur filter
        /// </summary>
        public static readonly BlurType Low = "Low";

        /// <summary>
        /// Med: Gaussian blur filter
        /// </summary>
        public static readonly BlurType Med = "Med";

        /// <summary>
        /// High: Confuse blur filter
        /// </summary>
        public static readonly BlurType High = "High";

        /// <summary>
        /// Black: Black out filter
        /// </summary>
        public static readonly BlurType Black = "Black";


        /// <summary>
        /// Underlying value of enum BlurType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for BlurType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type BlurType
        /// </summary>
        public bool Equals(BlurType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to BlurType
        /// </summary>
        public static implicit operator BlurType(string value)
        {
            return new BlurType(value);
        }

        /// <summary>
        /// Implicit operator to convert BlurType to string
        /// </summary>
        public static implicit operator string(BlurType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum BlurType
        /// </summary>
        public static bool operator == (BlurType e1, BlurType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum BlurType
        /// </summary>
        public static bool operator != (BlurType e1, BlurType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for BlurType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is BlurType && Equals((BlurType)obj);
        }

        /// <summary>
        /// Returns for hashCode BlurType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}