// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Restrictions where the SKU cannot be used
    /// </summary>
    public partial class ResourceSkuRestrictions
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuRestrictions class.
        /// </summary>
        public ResourceSkuRestrictions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuRestrictions class.
        /// </summary>
        /// <param name="type">Gets the type of restrictions. Possible values
        /// include: 'Location', 'Zone'</param>
        /// <param name="values">Gets the value of restrictions. If the
        /// restriction type is set to
        /// location. This would be different locations where the SKU is
        /// restricted.</param>
        /// <param name="restrictionInfo">Gets the information about the
        /// restriction where the SKU cannot be used.</param>
        /// <param name="reasonCode">Gets the reason for restriction. Possible
        /// values include: 'QuotaId', 'NotAvailableForSubscription'</param>
        public ResourceSkuRestrictions(string type = default(string), IList<string> values = default(IList<string>), ResourceSkuRestrictionInfo restrictionInfo = default(ResourceSkuRestrictionInfo), string reasonCode = default(string))
        {
            Type = type;
            Values = values;
            RestrictionInfo = restrictionInfo;
            ReasonCode = reasonCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of restrictions. Possible values include: 'Location',
        /// 'Zone'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is
        /// restricted.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Gets the information about the restriction where the SKU cannot be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "restrictionInfo")]
        public ResourceSkuRestrictionInfo RestrictionInfo { get; set; }

        /// <summary>
        /// Gets the reason for restriction. Possible values include:
        /// 'QuotaId', 'NotAvailableForSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public string ReasonCode { get; set; }

    }
}
