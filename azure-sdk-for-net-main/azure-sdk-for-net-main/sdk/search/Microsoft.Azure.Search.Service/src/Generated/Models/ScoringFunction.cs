// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Abstract base class for functions that can modify document scores
    /// during ranking.
    /// <see
    /// href="https://docs.microsoft.com/rest/api/searchservice/Add-scoring-profiles-to-a-search-index"
    /// />
    /// </summary>
    public partial class ScoringFunction
    {
        /// <summary>
        /// Initializes a new instance of the ScoringFunction class.
        /// </summary>
        public ScoringFunction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScoringFunction class.
        /// </summary>
        /// <param name="fieldName">The name of the field used as input to the
        /// scoring function.</param>
        /// <param name="boost">A multiplier for the raw score. Must be a
        /// positive number not equal to 1.0.</param>
        /// <param name="interpolation">A value indicating how boosting will be
        /// interpolated across document scores; defaults to "Linear". Possible
        /// values include: 'linear', 'constant', 'quadratic',
        /// 'logarithmic'</param>
        public ScoringFunction(string fieldName, double boost, ScoringFunctionInterpolation? interpolation = default(ScoringFunctionInterpolation?))
        {
            FieldName = fieldName;
            Boost = boost;
            Interpolation = interpolation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the field used as input to the scoring
        /// function.
        /// </summary>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets a multiplier for the raw score. Must be a positive
        /// number not equal to 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "boost")]
        public double Boost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating how boosting will be interpolated
        /// across document scores; defaults to "Linear". Possible values
        /// include: 'linear', 'constant', 'quadratic', 'logarithmic'
        /// </summary>
        [JsonProperty(PropertyName = "interpolation")]
        public ScoringFunctionInterpolation? Interpolation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FieldName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FieldName");
            }
        }
    }
}
