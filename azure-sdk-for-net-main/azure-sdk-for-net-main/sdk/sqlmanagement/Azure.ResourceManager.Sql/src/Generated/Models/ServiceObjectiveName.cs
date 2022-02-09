// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The serviceLevelObjective for SLO usage metric. </summary>
    internal readonly partial struct ServiceObjectiveName : IEquatable<ServiceObjectiveName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceObjectiveName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemValue = "System";
        private const string System0Value = "System0";
        private const string System1Value = "System1";
        private const string System2Value = "System2";
        private const string System3Value = "System3";
        private const string System4Value = "System4";
        private const string System2LValue = "System2L";
        private const string System3LValue = "System3L";
        private const string System4LValue = "System4L";
        private const string FreeValue = "Free";
        private const string BasicValue = "Basic";
        private const string S0Value = "S0";
        private const string S1Value = "S1";
        private const string S2Value = "S2";
        private const string S3Value = "S3";
        private const string S4Value = "S4";
        private const string S6Value = "S6";
        private const string S7Value = "S7";
        private const string S9Value = "S9";
        private const string S12Value = "S12";
        private const string P1Value = "P1";
        private const string P2Value = "P2";
        private const string P3Value = "P3";
        private const string P4Value = "P4";
        private const string P6Value = "P6";
        private const string P11Value = "P11";
        private const string P15Value = "P15";
        private const string PRS1Value = "PRS1";
        private const string PRS2Value = "PRS2";
        private const string PRS4Value = "PRS4";
        private const string PRS6Value = "PRS6";
        private const string DW100Value = "DW100";
        private const string DW200Value = "DW200";
        private const string DW300Value = "DW300";
        private const string DW400Value = "DW400";
        private const string DW500Value = "DW500";
        private const string DW600Value = "DW600";
        private const string DW1000Value = "DW1000";
        private const string DW1200Value = "DW1200";
        private const string DW1000CValue = "DW1000c";
        private const string DW1500Value = "DW1500";
        private const string DW1500CValue = "DW1500c";
        private const string DW2000Value = "DW2000";
        private const string DW2000CValue = "DW2000c";
        private const string DW3000Value = "DW3000";
        private const string DW2500CValue = "DW2500c";
        private const string DW3000CValue = "DW3000c";
        private const string DW6000Value = "DW6000";
        private const string DW5000CValue = "DW5000c";
        private const string DW6000CValue = "DW6000c";
        private const string DW7500CValue = "DW7500c";
        private const string DW10000CValue = "DW10000c";
        private const string DW15000CValue = "DW15000c";
        private const string DW30000CValue = "DW30000c";
        private const string DS100Value = "DS100";
        private const string DS200Value = "DS200";
        private const string DS300Value = "DS300";
        private const string DS400Value = "DS400";
        private const string DS500Value = "DS500";
        private const string DS600Value = "DS600";
        private const string DS1000Value = "DS1000";
        private const string DS1200Value = "DS1200";
        private const string DS1500Value = "DS1500";
        private const string DS2000Value = "DS2000";
        private const string ElasticPoolValue = "ElasticPool";

        /// <summary> System. </summary>
        public static ServiceObjectiveName System { get; } = new ServiceObjectiveName(SystemValue);
        /// <summary> System0. </summary>
        public static ServiceObjectiveName System0 { get; } = new ServiceObjectiveName(System0Value);
        /// <summary> System1. </summary>
        public static ServiceObjectiveName System1 { get; } = new ServiceObjectiveName(System1Value);
        /// <summary> System2. </summary>
        public static ServiceObjectiveName System2 { get; } = new ServiceObjectiveName(System2Value);
        /// <summary> System3. </summary>
        public static ServiceObjectiveName System3 { get; } = new ServiceObjectiveName(System3Value);
        /// <summary> System4. </summary>
        public static ServiceObjectiveName System4 { get; } = new ServiceObjectiveName(System4Value);
        /// <summary> System2L. </summary>
        public static ServiceObjectiveName System2L { get; } = new ServiceObjectiveName(System2LValue);
        /// <summary> System3L. </summary>
        public static ServiceObjectiveName System3L { get; } = new ServiceObjectiveName(System3LValue);
        /// <summary> System4L. </summary>
        public static ServiceObjectiveName System4L { get; } = new ServiceObjectiveName(System4LValue);
        /// <summary> Free. </summary>
        public static ServiceObjectiveName Free { get; } = new ServiceObjectiveName(FreeValue);
        /// <summary> Basic. </summary>
        public static ServiceObjectiveName Basic { get; } = new ServiceObjectiveName(BasicValue);
        /// <summary> S0. </summary>
        public static ServiceObjectiveName S0 { get; } = new ServiceObjectiveName(S0Value);
        /// <summary> S1. </summary>
        public static ServiceObjectiveName S1 { get; } = new ServiceObjectiveName(S1Value);
        /// <summary> S2. </summary>
        public static ServiceObjectiveName S2 { get; } = new ServiceObjectiveName(S2Value);
        /// <summary> S3. </summary>
        public static ServiceObjectiveName S3 { get; } = new ServiceObjectiveName(S3Value);
        /// <summary> S4. </summary>
        public static ServiceObjectiveName S4 { get; } = new ServiceObjectiveName(S4Value);
        /// <summary> S6. </summary>
        public static ServiceObjectiveName S6 { get; } = new ServiceObjectiveName(S6Value);
        /// <summary> S7. </summary>
        public static ServiceObjectiveName S7 { get; } = new ServiceObjectiveName(S7Value);
        /// <summary> S9. </summary>
        public static ServiceObjectiveName S9 { get; } = new ServiceObjectiveName(S9Value);
        /// <summary> S12. </summary>
        public static ServiceObjectiveName S12 { get; } = new ServiceObjectiveName(S12Value);
        /// <summary> P1. </summary>
        public static ServiceObjectiveName P1 { get; } = new ServiceObjectiveName(P1Value);
        /// <summary> P2. </summary>
        public static ServiceObjectiveName P2 { get; } = new ServiceObjectiveName(P2Value);
        /// <summary> P3. </summary>
        public static ServiceObjectiveName P3 { get; } = new ServiceObjectiveName(P3Value);
        /// <summary> P4. </summary>
        public static ServiceObjectiveName P4 { get; } = new ServiceObjectiveName(P4Value);
        /// <summary> P6. </summary>
        public static ServiceObjectiveName P6 { get; } = new ServiceObjectiveName(P6Value);
        /// <summary> P11. </summary>
        public static ServiceObjectiveName P11 { get; } = new ServiceObjectiveName(P11Value);
        /// <summary> P15. </summary>
        public static ServiceObjectiveName P15 { get; } = new ServiceObjectiveName(P15Value);
        /// <summary> PRS1. </summary>
        public static ServiceObjectiveName PRS1 { get; } = new ServiceObjectiveName(PRS1Value);
        /// <summary> PRS2. </summary>
        public static ServiceObjectiveName PRS2 { get; } = new ServiceObjectiveName(PRS2Value);
        /// <summary> PRS4. </summary>
        public static ServiceObjectiveName PRS4 { get; } = new ServiceObjectiveName(PRS4Value);
        /// <summary> PRS6. </summary>
        public static ServiceObjectiveName PRS6 { get; } = new ServiceObjectiveName(PRS6Value);
        /// <summary> DW100. </summary>
        public static ServiceObjectiveName DW100 { get; } = new ServiceObjectiveName(DW100Value);
        /// <summary> DW200. </summary>
        public static ServiceObjectiveName DW200 { get; } = new ServiceObjectiveName(DW200Value);
        /// <summary> DW300. </summary>
        public static ServiceObjectiveName DW300 { get; } = new ServiceObjectiveName(DW300Value);
        /// <summary> DW400. </summary>
        public static ServiceObjectiveName DW400 { get; } = new ServiceObjectiveName(DW400Value);
        /// <summary> DW500. </summary>
        public static ServiceObjectiveName DW500 { get; } = new ServiceObjectiveName(DW500Value);
        /// <summary> DW600. </summary>
        public static ServiceObjectiveName DW600 { get; } = new ServiceObjectiveName(DW600Value);
        /// <summary> DW1000. </summary>
        public static ServiceObjectiveName DW1000 { get; } = new ServiceObjectiveName(DW1000Value);
        /// <summary> DW1200. </summary>
        public static ServiceObjectiveName DW1200 { get; } = new ServiceObjectiveName(DW1200Value);
        /// <summary> DW1000c. </summary>
        public static ServiceObjectiveName DW1000C { get; } = new ServiceObjectiveName(DW1000CValue);
        /// <summary> DW1500. </summary>
        public static ServiceObjectiveName DW1500 { get; } = new ServiceObjectiveName(DW1500Value);
        /// <summary> DW1500c. </summary>
        public static ServiceObjectiveName DW1500C { get; } = new ServiceObjectiveName(DW1500CValue);
        /// <summary> DW2000. </summary>
        public static ServiceObjectiveName DW2000 { get; } = new ServiceObjectiveName(DW2000Value);
        /// <summary> DW2000c. </summary>
        public static ServiceObjectiveName DW2000C { get; } = new ServiceObjectiveName(DW2000CValue);
        /// <summary> DW3000. </summary>
        public static ServiceObjectiveName DW3000 { get; } = new ServiceObjectiveName(DW3000Value);
        /// <summary> DW2500c. </summary>
        public static ServiceObjectiveName DW2500C { get; } = new ServiceObjectiveName(DW2500CValue);
        /// <summary> DW3000c. </summary>
        public static ServiceObjectiveName DW3000C { get; } = new ServiceObjectiveName(DW3000CValue);
        /// <summary> DW6000. </summary>
        public static ServiceObjectiveName DW6000 { get; } = new ServiceObjectiveName(DW6000Value);
        /// <summary> DW5000c. </summary>
        public static ServiceObjectiveName DW5000C { get; } = new ServiceObjectiveName(DW5000CValue);
        /// <summary> DW6000c. </summary>
        public static ServiceObjectiveName DW6000C { get; } = new ServiceObjectiveName(DW6000CValue);
        /// <summary> DW7500c. </summary>
        public static ServiceObjectiveName DW7500C { get; } = new ServiceObjectiveName(DW7500CValue);
        /// <summary> DW10000c. </summary>
        public static ServiceObjectiveName DW10000C { get; } = new ServiceObjectiveName(DW10000CValue);
        /// <summary> DW15000c. </summary>
        public static ServiceObjectiveName DW15000C { get; } = new ServiceObjectiveName(DW15000CValue);
        /// <summary> DW30000c. </summary>
        public static ServiceObjectiveName DW30000C { get; } = new ServiceObjectiveName(DW30000CValue);
        /// <summary> DS100. </summary>
        public static ServiceObjectiveName DS100 { get; } = new ServiceObjectiveName(DS100Value);
        /// <summary> DS200. </summary>
        public static ServiceObjectiveName DS200 { get; } = new ServiceObjectiveName(DS200Value);
        /// <summary> DS300. </summary>
        public static ServiceObjectiveName DS300 { get; } = new ServiceObjectiveName(DS300Value);
        /// <summary> DS400. </summary>
        public static ServiceObjectiveName DS400 { get; } = new ServiceObjectiveName(DS400Value);
        /// <summary> DS500. </summary>
        public static ServiceObjectiveName DS500 { get; } = new ServiceObjectiveName(DS500Value);
        /// <summary> DS600. </summary>
        public static ServiceObjectiveName DS600 { get; } = new ServiceObjectiveName(DS600Value);
        /// <summary> DS1000. </summary>
        public static ServiceObjectiveName DS1000 { get; } = new ServiceObjectiveName(DS1000Value);
        /// <summary> DS1200. </summary>
        public static ServiceObjectiveName DS1200 { get; } = new ServiceObjectiveName(DS1200Value);
        /// <summary> DS1500. </summary>
        public static ServiceObjectiveName DS1500 { get; } = new ServiceObjectiveName(DS1500Value);
        /// <summary> DS2000. </summary>
        public static ServiceObjectiveName DS2000 { get; } = new ServiceObjectiveName(DS2000Value);
        /// <summary> ElasticPool. </summary>
        public static ServiceObjectiveName ElasticPool { get; } = new ServiceObjectiveName(ElasticPoolValue);
        /// <summary> Determines if two <see cref="ServiceObjectiveName"/> values are the same. </summary>
        public static bool operator ==(ServiceObjectiveName left, ServiceObjectiveName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceObjectiveName"/> values are not the same. </summary>
        public static bool operator !=(ServiceObjectiveName left, ServiceObjectiveName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceObjectiveName"/>. </summary>
        public static implicit operator ServiceObjectiveName(string value) => new ServiceObjectiveName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceObjectiveName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceObjectiveName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}