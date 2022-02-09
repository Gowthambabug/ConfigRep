// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Authorization Profile
    /// </summary>
    public partial class AuthorizationProfile
    {
        /// <summary>
        /// Initializes a new instance of the AuthorizationProfile class.
        /// </summary>
        public AuthorizationProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationProfile class.
        /// </summary>
        /// <param name="requestedTime">The requested time</param>
        /// <param name="requester">The requester</param>
        /// <param name="requesterObjectId">The requester object id</param>
        /// <param name="approvedTime">The approved time</param>
        /// <param name="approver">The approver</param>
        public AuthorizationProfile(System.DateTime? requestedTime = default(System.DateTime?), string requester = default(string), string requesterObjectId = default(string), System.DateTime? approvedTime = default(System.DateTime?), string approver = default(string))
        {
            RequestedTime = requestedTime;
            Requester = requester;
            RequesterObjectId = requesterObjectId;
            ApprovedTime = approvedTime;
            Approver = approver;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the requested time
        /// </summary>
        [JsonProperty(PropertyName = "requestedTime")]
        public System.DateTime? RequestedTime { get; private set; }

        /// <summary>
        /// Gets the requester
        /// </summary>
        [JsonProperty(PropertyName = "requester")]
        public string Requester { get; private set; }

        /// <summary>
        /// Gets the requester object id
        /// </summary>
        [JsonProperty(PropertyName = "requesterObjectId")]
        public string RequesterObjectId { get; private set; }

        /// <summary>
        /// Gets the approved time
        /// </summary>
        [JsonProperty(PropertyName = "approvedTime")]
        public System.DateTime? ApprovedTime { get; private set; }

        /// <summary>
        /// Gets the approver
        /// </summary>
        [JsonProperty(PropertyName = "approver")]
        public string Approver { get; private set; }

    }
}