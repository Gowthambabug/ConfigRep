// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The metric counter set
    /// </summary>
    public partial class MetricCounterSet
    {
        /// <summary>
        /// Initializes a new instance of the MetricCounterSet class.
        /// </summary>
        public MetricCounterSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricCounterSet class.
        /// </summary>
        /// <param name="counters">The counters that should be collected in
        /// this set.</param>
        public MetricCounterSet(IList<MetricCounter> counters)
        {
            Counters = counters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the counters that should be collected in this set.
        /// </summary>
        [JsonProperty(PropertyName = "counters")]
        public IList<MetricCounter> Counters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Counters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Counters");
            }
            if (Counters != null)
            {
                foreach (var element in Counters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
