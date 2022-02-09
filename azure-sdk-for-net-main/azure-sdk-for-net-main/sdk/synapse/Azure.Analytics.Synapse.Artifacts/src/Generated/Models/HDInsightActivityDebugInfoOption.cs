// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The HDInsightActivityDebugInfoOption settings to use. </summary>
    public readonly partial struct HDInsightActivityDebugInfoOption : IEquatable<HDInsightActivityDebugInfoOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightActivityDebugInfoOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightActivityDebugInfoOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AlwaysValue = "Always";
        private const string FailureValue = "Failure";

        /// <summary> None. </summary>
        public static HDInsightActivityDebugInfoOption None { get; } = new HDInsightActivityDebugInfoOption(NoneValue);
        /// <summary> Always. </summary>
        public static HDInsightActivityDebugInfoOption Always { get; } = new HDInsightActivityDebugInfoOption(AlwaysValue);
        /// <summary> Failure. </summary>
        public static HDInsightActivityDebugInfoOption Failure { get; } = new HDInsightActivityDebugInfoOption(FailureValue);
        /// <summary> Determines if two <see cref="HDInsightActivityDebugInfoOption"/> values are the same. </summary>
        public static bool operator ==(HDInsightActivityDebugInfoOption left, HDInsightActivityDebugInfoOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightActivityDebugInfoOption"/> values are not the same. </summary>
        public static bool operator !=(HDInsightActivityDebugInfoOption left, HDInsightActivityDebugInfoOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightActivityDebugInfoOption"/>. </summary>
        public static implicit operator HDInsightActivityDebugInfoOption(string value) => new HDInsightActivityDebugInfoOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightActivityDebugInfoOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightActivityDebugInfoOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}