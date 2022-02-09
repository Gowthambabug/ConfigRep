// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Day of maintenance window. </summary>
    public readonly partial struct SqlDayOfWeek : IEquatable<SqlDayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlDayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlDayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "Sunday";
        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";

        /// <summary> Sunday. </summary>
        public static SqlDayOfWeek Sunday { get; } = new SqlDayOfWeek(SundayValue);
        /// <summary> Monday. </summary>
        public static SqlDayOfWeek Monday { get; } = new SqlDayOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static SqlDayOfWeek Tuesday { get; } = new SqlDayOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static SqlDayOfWeek Wednesday { get; } = new SqlDayOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static SqlDayOfWeek Thursday { get; } = new SqlDayOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static SqlDayOfWeek Friday { get; } = new SqlDayOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static SqlDayOfWeek Saturday { get; } = new SqlDayOfWeek(SaturdayValue);
        /// <summary> Determines if two <see cref="SqlDayOfWeek"/> values are the same. </summary>
        public static bool operator ==(SqlDayOfWeek left, SqlDayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlDayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(SqlDayOfWeek left, SqlDayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlDayOfWeek"/>. </summary>
        public static implicit operator SqlDayOfWeek(string value) => new SqlDayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlDayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlDayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}