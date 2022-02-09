// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response body for evaluating a policy set.
    /// </summary>
    public partial class EvaluatePoliciesResponse
    {
        /// <summary>
        /// Initializes a new instance of the EvaluatePoliciesResponse class.
        /// </summary>
        public EvaluatePoliciesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EvaluatePoliciesResponse class.
        /// </summary>
        /// <param name="results">Results of evaluating a policy set.</param>
        public EvaluatePoliciesResponse(IList<PolicySetResult> results = default(IList<PolicySetResult>))
        {
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets results of evaluating a policy set.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<PolicySetResult> Results { get; set; }

    }
}
