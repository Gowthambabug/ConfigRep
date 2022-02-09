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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Quota request properties.
    /// </summary>
    public partial class QuotaRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the QuotaRequestProperties class.
        /// </summary>
        public QuotaRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaRequestProperties class.
        /// </summary>
        /// <param name="provisioningState">The quota request status. Possible
        /// values include: 'Accepted', 'Invalid', 'Succeeded', 'Failed',
        /// 'InProgress'</param>
        /// <param name="message">User-friendly status message.</param>
        /// <param name="error">Error details of the quota request.</param>
        /// <param name="requestSubmitTime">The quota request submission time.
        /// The date conforms to the following format specified by the ISO 8601
        /// standard: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="value">Quota request details.</param>
        public QuotaRequestProperties(string provisioningState = default(string), string message = default(string), ServiceErrorDetail error = default(ServiceErrorDetail), System.DateTime? requestSubmitTime = default(System.DateTime?), IList<SubRequest> value = default(IList<SubRequest>))
        {
            ProvisioningState = provisioningState;
            Message = message;
            Error = error;
            RequestSubmitTime = requestSubmitTime;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the quota request status. Possible values include:
        /// 'Accepted', 'Invalid', 'Succeeded', 'Failed', 'InProgress'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets user-friendly status message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets error details of the quota request.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ServiceErrorDetail Error { get; set; }

        /// <summary>
        /// Gets the quota request submission time. The date conforms to the
        /// following format specified by the ISO 8601 standard:
        /// yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "requestSubmitTime")]
        public System.DateTime? RequestSubmitTime { get; private set; }

        /// <summary>
        /// Gets or sets quota request details.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SubRequest> Value { get; set; }

    }
}