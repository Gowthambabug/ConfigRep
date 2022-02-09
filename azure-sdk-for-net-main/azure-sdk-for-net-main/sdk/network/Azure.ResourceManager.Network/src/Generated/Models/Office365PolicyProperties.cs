// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance Sku Properties. </summary>
    public partial class Office365PolicyProperties
    {
        /// <summary> Initializes a new instance of Office365PolicyProperties. </summary>
        public Office365PolicyProperties()
        {
        }

        /// <summary> Initializes a new instance of Office365PolicyProperties. </summary>
        /// <param name="breakOutCategories"> Office 365 breakout categories. </param>
        internal Office365PolicyProperties(BreakOutCategoryPolicies breakOutCategories)
        {
            BreakOutCategories = breakOutCategories;
        }

        /// <summary> Office 365 breakout categories. </summary>
        public BreakOutCategoryPolicies BreakOutCategories { get; set; }
    }
}