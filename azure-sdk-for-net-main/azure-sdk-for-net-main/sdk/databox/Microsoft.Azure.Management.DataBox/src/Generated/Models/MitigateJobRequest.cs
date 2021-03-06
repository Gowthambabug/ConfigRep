// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Mitigate Job captured from request body for Mitigate API
    /// </summary>
    public partial class MitigateJobRequest
    {
        /// <summary>
        /// Initializes a new instance of the MitigateJobRequest class.
        /// </summary>
        public MitigateJobRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MitigateJobRequest class.
        /// </summary>
        /// <param name="customerResolutionCode">Resolution code for the job.
        /// Possible values include: 'None', 'MoveToCleanUpDevice',
        /// 'Resume'</param>
        public MitigateJobRequest(CustomerResolutionCode customerResolutionCode)
        {
            CustomerResolutionCode = customerResolutionCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resolution code for the job. Possible values include:
        /// 'None', 'MoveToCleanUpDevice', 'Resume'
        /// </summary>
        [JsonProperty(PropertyName = "customerResolutionCode")]
        public CustomerResolutionCode CustomerResolutionCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
