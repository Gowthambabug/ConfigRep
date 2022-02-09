// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The private link service connection state.
    /// </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        public PrivateLinkServiceConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        /// <param name="actionsRequired">The required actions.</param>
        /// <param name="description">The description.</param>
        /// <param name="status">The status. Possible values include:
        /// 'Unknown', 'Pending', 'Approved', 'Rejected',
        /// 'Disconnected'</param>
        public PrivateLinkServiceConnectionState(string actionsRequired = default(string), string description = default(string), string status = default(string))
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the required actions.
        /// </summary>
        [JsonProperty(PropertyName = "actionsRequired")]
        public string ActionsRequired { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the status. Possible values include: 'Unknown',
        /// 'Pending', 'Approved', 'Rejected', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
