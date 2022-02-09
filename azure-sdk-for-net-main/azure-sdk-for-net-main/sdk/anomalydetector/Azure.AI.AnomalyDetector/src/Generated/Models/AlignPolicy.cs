// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The AlignPolicy. </summary>
    public partial class AlignPolicy
    {
        /// <summary> Initializes a new instance of AlignPolicy. </summary>
        public AlignPolicy()
        {
        }

        /// <summary> Initializes a new instance of AlignPolicy. </summary>
        /// <param name="alignMode"> An optional field, indicating how we align different variables to the same time-range. Either Inner or Outer. </param>
        /// <param name="fillNAMethod"> An optional field, indicating how missing values will be filled. One of Previous, Subsequent, Linear, Zero, Fixed, and NotFill. Cannot be set to NotFill, when the alignMode is Outer. </param>
        /// <param name="paddingValue"> An optional field. Required when fillNAMethod is Fixed. </param>
        internal AlignPolicy(AlignMode? alignMode, FillNAMethod? fillNAMethod, float? paddingValue)
        {
            AlignMode = alignMode;
            FillNAMethod = fillNAMethod;
            PaddingValue = paddingValue;
        }

        /// <summary> An optional field, indicating how we align different variables to the same time-range. Either Inner or Outer. </summary>
        public AlignMode? AlignMode { get; set; }
        /// <summary> An optional field, indicating how missing values will be filled. One of Previous, Subsequent, Linear, Zero, Fixed, and NotFill. Cannot be set to NotFill, when the alignMode is Outer. </summary>
        public FillNAMethod? FillNAMethod { get; set; }
        /// <summary> An optional field. Required when fillNAMethod is Fixed. </summary>
        public float? PaddingValue { get; set; }
    }
}