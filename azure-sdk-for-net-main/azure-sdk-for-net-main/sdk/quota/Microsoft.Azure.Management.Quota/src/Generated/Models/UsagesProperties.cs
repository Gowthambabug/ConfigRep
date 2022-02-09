// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage properties for the specified resource.
    /// </summary>
    public partial class UsagesProperties
    {
        /// <summary>
        /// Initializes a new instance of the UsagesProperties class.
        /// </summary>
        public UsagesProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsagesProperties class.
        /// </summary>
        /// <param name="usages">The quota limit properties for this
        /// resource.</param>
        /// <param name="unit"> The units for the quota usage, such as Count
        /// and Bytes. When requesting quota, use the **unit** value returned
        /// in the GET response in the request body of your PUT
        /// operation.</param>
        /// <param name="name">Resource name provided by the resource provider.
        /// Use this property name when requesting quota.</param>
        /// <param name="resourceType">The name of the resource type.</param>
        /// <param name="quotaPeriod">The time period for the summary of the
        /// quota usage values. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because it is not relevant for all
        /// resources such as compute.</param>
        /// <param name="isQuotaApplicable">States if quota can be requested
        /// for this resource.</param>
        /// <param name="properties">Additional properties for the specific
        /// resource provider.</param>
        public UsagesProperties(UsagesObject usages = default(UsagesObject), string unit = default(string), ResourceName name = default(ResourceName), string resourceType = default(string), string quotaPeriod = default(string), bool? isQuotaApplicable = default(bool?), object properties = default(object))
        {
            Usages = usages;
            Unit = unit;
            Name = name;
            ResourceType = resourceType;
            QuotaPeriod = quotaPeriod;
            IsQuotaApplicable = isQuotaApplicable;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the quota limit properties for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "usages")]
        public UsagesObject Usages { get; set; }

        /// <summary>
        /// Gets  The units for the quota usage, such as Count and Bytes. When
        /// requesting quota, use the **unit** value returned in the GET
        /// response in the request body of your PUT operation.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets or sets resource name provided by the resource provider. Use
        /// this property name when requesting quota.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public ResourceName Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets the time period for the summary of the quota usage values. For
        /// example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because it is not relevant for all
        /// resources such as compute.
        /// </summary>
        [JsonProperty(PropertyName = "quotaPeriod")]
        public string QuotaPeriod { get; private set; }

        /// <summary>
        /// Gets states if quota can be requested for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "isQuotaApplicable")]
        public bool? IsQuotaApplicable { get; private set; }

        /// <summary>
        /// Gets or sets additional properties for the specific resource
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Usages != null)
            {
                Usages.Validate();
            }
        }
    }
}