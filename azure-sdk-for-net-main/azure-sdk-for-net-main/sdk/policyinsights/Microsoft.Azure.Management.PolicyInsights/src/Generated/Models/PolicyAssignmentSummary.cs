// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Policy assignment summary.
    /// </summary>
    public partial class PolicyAssignmentSummary
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignmentSummary class.
        /// </summary>
        public PolicyAssignmentSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignmentSummary class.
        /// </summary>
        /// <param name="policyAssignmentId">Policy assignment ID.</param>
        /// <param name="policySetDefinitionId">Policy set definition ID, if
        /// the policy assignment is for a policy set.</param>
        /// <param name="results">Compliance summary for the policy
        /// assignment.</param>
        /// <param name="policyDefinitions">Policy definitions summary.</param>
        /// <param name="policyGroups">Policy definition group summary.</param>
        public PolicyAssignmentSummary(string policyAssignmentId = default(string), string policySetDefinitionId = default(string), SummaryResults results = default(SummaryResults), IList<PolicyDefinitionSummary> policyDefinitions = default(IList<PolicyDefinitionSummary>), IList<PolicyGroupSummary> policyGroups = default(IList<PolicyGroupSummary>))
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicySetDefinitionId = policySetDefinitionId;
            Results = results;
            PolicyDefinitions = policyDefinitions;
            PolicyGroups = policyGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy assignment ID.
        /// </summary>
        [JsonProperty(PropertyName = "policyAssignmentId")]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets policy set definition ID, if the policy assignment is
        /// for a policy set.
        /// </summary>
        [JsonProperty(PropertyName = "policySetDefinitionId")]
        public string PolicySetDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets compliance summary for the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public SummaryResults Results { get; set; }

        /// <summary>
        /// Gets or sets policy definitions summary.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitions")]
        public IList<PolicyDefinitionSummary> PolicyDefinitions { get; set; }

        /// <summary>
        /// Gets or sets policy definition group summary.
        /// </summary>
        [JsonProperty(PropertyName = "policyGroups")]
        public IList<PolicyGroupSummary> PolicyGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Results != null)
            {
                Results.Validate();
            }
            if (PolicyDefinitions != null)
            {
                foreach (var element in PolicyDefinitions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (PolicyGroups != null)
            {
                foreach (var element1 in PolicyGroups)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
