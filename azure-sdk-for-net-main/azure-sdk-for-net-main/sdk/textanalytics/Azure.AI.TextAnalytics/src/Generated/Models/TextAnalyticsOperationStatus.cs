// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The State. </summary>
    public readonly partial struct TextAnalyticsOperationStatus : IEquatable<TextAnalyticsOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TextAnalyticsOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string RejectedValue = "rejected";
        private const string CancelledValue = "cancelled";
        private const string CancellingValue = "cancelling";

        /// <summary> notStarted. </summary>
        public static TextAnalyticsOperationStatus NotStarted { get; } = new TextAnalyticsOperationStatus(NotStartedValue);
        /// <summary> running. </summary>
        public static TextAnalyticsOperationStatus Running { get; } = new TextAnalyticsOperationStatus(RunningValue);
        /// <summary> succeeded. </summary>
        public static TextAnalyticsOperationStatus Succeeded { get; } = new TextAnalyticsOperationStatus(SucceededValue);
        /// <summary> failed. </summary>
        public static TextAnalyticsOperationStatus Failed { get; } = new TextAnalyticsOperationStatus(FailedValue);
        /// <summary> rejected. </summary>
        public static TextAnalyticsOperationStatus Rejected { get; } = new TextAnalyticsOperationStatus(RejectedValue);
        /// <summary> cancelled. </summary>
        public static TextAnalyticsOperationStatus Cancelled { get; } = new TextAnalyticsOperationStatus(CancelledValue);
        /// <summary> cancelling. </summary>
        public static TextAnalyticsOperationStatus Cancelling { get; } = new TextAnalyticsOperationStatus(CancellingValue);
        /// <summary> Determines if two <see cref="TextAnalyticsOperationStatus"/> values are the same. </summary>
        public static bool operator ==(TextAnalyticsOperationStatus left, TextAnalyticsOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextAnalyticsOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(TextAnalyticsOperationStatus left, TextAnalyticsOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TextAnalyticsOperationStatus"/>. </summary>
        public static implicit operator TextAnalyticsOperationStatus(string value) => new TextAnalyticsOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextAnalyticsOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextAnalyticsOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}