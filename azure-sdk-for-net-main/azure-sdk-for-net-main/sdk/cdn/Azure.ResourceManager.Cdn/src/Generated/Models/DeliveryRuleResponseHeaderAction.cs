// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the response header action for the delivery rule. </summary>
    public partial class DeliveryRuleResponseHeaderAction : DeliveryRuleActionAutoGenerated
    {
        /// <summary> Initializes a new instance of DeliveryRuleResponseHeaderAction. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleResponseHeaderAction(HeaderActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = DeliveryRuleAction.ModifyResponseHeader;
        }

        /// <summary> Initializes a new instance of DeliveryRuleResponseHeaderAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal DeliveryRuleResponseHeaderAction(DeliveryRuleAction name, HeaderActionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public HeaderActionParameters Parameters { get; set; }
    }
}