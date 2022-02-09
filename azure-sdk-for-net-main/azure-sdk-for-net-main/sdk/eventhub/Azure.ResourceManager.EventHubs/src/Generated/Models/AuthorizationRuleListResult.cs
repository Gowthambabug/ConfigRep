// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response from the List namespace operation. </summary>
    internal partial class AuthorizationRuleListResult
    {
        /// <summary> Initializes a new instance of AuthorizationRuleListResult. </summary>
        internal AuthorizationRuleListResult()
        {
            Value = new ChangeTrackingList<AuthorizationRuleData>();
        }

        /// <summary> Initializes a new instance of AuthorizationRuleListResult. </summary>
        /// <param name="value"> Result of the List Authorization Rules operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains an incomplete list of Authorization Rules. </param>
        internal AuthorizationRuleListResult(IReadOnlyList<AuthorizationRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Authorization Rules operation. </summary>
        public IReadOnlyList<AuthorizationRuleData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains an incomplete list of Authorization Rules. </summary>
        public string NextLink { get; }
    }
}