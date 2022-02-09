// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL instance pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InstancePool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the InstancePool class.
        /// </summary>
        public InstancePool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstancePool class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="subnetId">Resource ID of the subnet to place this
        /// instance pool in.</param>
        /// <param name="vCores">Count of vCores belonging to this instance
        /// pool.</param>
        /// <param name="licenseType">The license type. Possible values are
        /// 'LicenseIncluded' (price for SQL license is included) and
        /// 'BasePrice' (without SQL license price). Possible values include:
        /// 'LicenseIncluded', 'BasePrice'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The name and tier of the SKU.</param>
        public InstancePool(string location, string subnetId, int vCores, string licenseType, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            SubnetId = subnetId;
            VCores = vCores;
            LicenseType = licenseType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name and tier of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets resource ID of the subnet to place this instance pool
        /// in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets count of vCores belonging to this instance pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vCores")]
        public int VCores { get; set; }

        /// <summary>
        /// Gets or sets the license type. Possible values are
        /// 'LicenseIncluded' (price for SQL license is included) and
        /// 'BasePrice' (without SQL license price). Possible values include:
        /// 'LicenseIncluded', 'BasePrice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (SubnetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubnetId");
            }
            if (LicenseType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LicenseType");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
