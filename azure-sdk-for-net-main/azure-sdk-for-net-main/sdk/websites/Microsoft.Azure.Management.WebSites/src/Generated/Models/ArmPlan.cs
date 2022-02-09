// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The plan object in Azure Resource Manager, represents a marketplace
    /// plan.
    /// </summary>
    public partial class ArmPlan
    {
        /// <summary>
        /// Initializes a new instance of the ArmPlan class.
        /// </summary>
        public ArmPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmPlan class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="publisher">The publisher.</param>
        /// <param name="product">The product.</param>
        /// <param name="promotionCode">The promotion code.</param>
        /// <param name="version">Version of product.</param>
        public ArmPlan(string name = default(string), string publisher = default(string), string product = default(string), string promotionCode = default(string), string version = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the promotion code.
        /// </summary>
        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Gets or sets version of product.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}