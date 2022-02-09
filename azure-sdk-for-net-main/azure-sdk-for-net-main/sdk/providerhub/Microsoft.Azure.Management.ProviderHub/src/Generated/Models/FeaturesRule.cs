// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FeaturesRule
    {
        /// <summary>
        /// Initializes a new instance of the FeaturesRule class.
        /// </summary>
        public FeaturesRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeaturesRule class.
        /// </summary>
        /// <param name="requiredFeaturesPolicy">Possible values include:
        /// 'Any', 'All'</param>
        public FeaturesRule(string requiredFeaturesPolicy)
        {
            RequiredFeaturesPolicy = requiredFeaturesPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Any', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "requiredFeaturesPolicy")]
        public string RequiredFeaturesPolicy { get; set; }

    }
}