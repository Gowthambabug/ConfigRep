// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the rule collection. </summary>
    public partial class FirewallPolicyRuleCollection
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleCollection. </summary>
        public FirewallPolicyRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollection. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        internal FirewallPolicyRuleCollection(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority)
        {
            RuleCollectionType = ruleCollectionType;
            Name = name;
            Priority = priority;
        }

        /// <summary> The type of the rule collection. </summary>
        internal FirewallPolicyRuleCollectionType RuleCollectionType { get; set; }
        /// <summary> The name of the rule collection. </summary>
        public string Name { get; set; }
        /// <summary> Priority of the Firewall Policy Rule Collection resource. </summary>
        public int? Priority { get; set; }
    }
}