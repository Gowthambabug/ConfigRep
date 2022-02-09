// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Current state the recommended action is in. Some commonly used states are: Active      -&gt; recommended action is active and no action has been taken yet. Pending     -&gt; recommended action is approved for and is awaiting execution. Executing   -&gt; recommended action is being applied on the user database. Verifying   -&gt; recommended action was applied and is being verified of its usefulness by the system. Success     -&gt; recommended action was applied and improvement found during verification. Pending Revert  -&gt; verification found little or no improvement so recommended action is queued for revert or user has manually reverted. Reverting   -&gt; changes made while applying recommended action are being reverted on the user database. Reverted    -&gt; successfully reverted the changes made by recommended action on user database. Ignored     -&gt; user explicitly ignored/discarded the recommended action. </summary>
    public readonly partial struct RecommendedActionCurrentState : IEquatable<RecommendedActionCurrentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendedActionCurrentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendedActionCurrentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string PendingValue = "Pending";
        private const string ExecutingValue = "Executing";
        private const string VerifyingValue = "Verifying";
        private const string PendingRevertValue = "PendingRevert";
        private const string RevertCancelledValue = "RevertCancelled";
        private const string RevertingValue = "Reverting";
        private const string RevertedValue = "Reverted";
        private const string IgnoredValue = "Ignored";
        private const string ExpiredValue = "Expired";
        private const string MonitoringValue = "Monitoring";
        private const string ResolvedValue = "Resolved";
        private const string SuccessValue = "Success";
        private const string ErrorValue = "Error";

        /// <summary> Active. </summary>
        public static RecommendedActionCurrentState Active { get; } = new RecommendedActionCurrentState(ActiveValue);
        /// <summary> Pending. </summary>
        public static RecommendedActionCurrentState Pending { get; } = new RecommendedActionCurrentState(PendingValue);
        /// <summary> Executing. </summary>
        public static RecommendedActionCurrentState Executing { get; } = new RecommendedActionCurrentState(ExecutingValue);
        /// <summary> Verifying. </summary>
        public static RecommendedActionCurrentState Verifying { get; } = new RecommendedActionCurrentState(VerifyingValue);
        /// <summary> PendingRevert. </summary>
        public static RecommendedActionCurrentState PendingRevert { get; } = new RecommendedActionCurrentState(PendingRevertValue);
        /// <summary> RevertCancelled. </summary>
        public static RecommendedActionCurrentState RevertCancelled { get; } = new RecommendedActionCurrentState(RevertCancelledValue);
        /// <summary> Reverting. </summary>
        public static RecommendedActionCurrentState Reverting { get; } = new RecommendedActionCurrentState(RevertingValue);
        /// <summary> Reverted. </summary>
        public static RecommendedActionCurrentState Reverted { get; } = new RecommendedActionCurrentState(RevertedValue);
        /// <summary> Ignored. </summary>
        public static RecommendedActionCurrentState Ignored { get; } = new RecommendedActionCurrentState(IgnoredValue);
        /// <summary> Expired. </summary>
        public static RecommendedActionCurrentState Expired { get; } = new RecommendedActionCurrentState(ExpiredValue);
        /// <summary> Monitoring. </summary>
        public static RecommendedActionCurrentState Monitoring { get; } = new RecommendedActionCurrentState(MonitoringValue);
        /// <summary> Resolved. </summary>
        public static RecommendedActionCurrentState Resolved { get; } = new RecommendedActionCurrentState(ResolvedValue);
        /// <summary> Success. </summary>
        public static RecommendedActionCurrentState Success { get; } = new RecommendedActionCurrentState(SuccessValue);
        /// <summary> Error. </summary>
        public static RecommendedActionCurrentState Error { get; } = new RecommendedActionCurrentState(ErrorValue);
        /// <summary> Determines if two <see cref="RecommendedActionCurrentState"/> values are the same. </summary>
        public static bool operator ==(RecommendedActionCurrentState left, RecommendedActionCurrentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendedActionCurrentState"/> values are not the same. </summary>
        public static bool operator !=(RecommendedActionCurrentState left, RecommendedActionCurrentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecommendedActionCurrentState"/>. </summary>
        public static implicit operator RecommendedActionCurrentState(string value) => new RecommendedActionCurrentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendedActionCurrentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendedActionCurrentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}