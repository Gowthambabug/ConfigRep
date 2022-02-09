// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the UrlFileExtension condition for the delivery rule. </summary>
    public partial class DeliveryRuleUrlFileExtensionCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleUrlFileExtensionCondition. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleUrlFileExtensionCondition(UrlFileExtensionMatchConditionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = MatchVariable.UrlFileExtension;
        }

        /// <summary> Initializes a new instance of DeliveryRuleUrlFileExtensionCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRuleUrlFileExtensionCondition(MatchVariable name, UrlFileExtensionMatchConditionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public UrlFileExtensionMatchConditionParameters Parameters { get; set; }
    }
}