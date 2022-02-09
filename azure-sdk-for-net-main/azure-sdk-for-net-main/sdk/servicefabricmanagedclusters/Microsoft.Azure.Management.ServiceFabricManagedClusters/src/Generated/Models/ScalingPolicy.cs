// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies a metric to load balance a service during runtime.
    /// </summary>
    public partial class ScalingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ScalingPolicy class.
        /// </summary>
        public ScalingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScalingPolicy class.
        /// </summary>
        /// <param name="scalingMechanism">Specifies the mechanism associated
        /// with this scaling policy</param>
        /// <param name="scalingTrigger">Specifies the trigger associated with
        /// this scaling policy.</param>
        public ScalingPolicy(ScalingMechanism scalingMechanism, ScalingTrigger scalingTrigger)
        {
            ScalingMechanism = scalingMechanism;
            ScalingTrigger = scalingTrigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the mechanism associated with this scaling
        /// policy
        /// </summary>
        [JsonProperty(PropertyName = "scalingMechanism")]
        public ScalingMechanism ScalingMechanism { get; set; }

        /// <summary>
        /// Gets or sets specifies the trigger associated with this scaling
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "scalingTrigger")]
        public ScalingTrigger ScalingTrigger { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScalingMechanism == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScalingMechanism");
            }
            if (ScalingTrigger == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScalingTrigger");
            }
        }
    }
}