// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User info for an event result
    /// </summary>
    public partial class EventsUserInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventsUserInfo class.
        /// </summary>
        public EventsUserInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsUserInfo class.
        /// </summary>
        /// <param name="id">ID of the user</param>
        /// <param name="accountId">Account ID of the user</param>
        /// <param name="authenticatedId">Authenticated ID of the user</param>
        public EventsUserInfo(string id = default(string), string accountId = default(string), string authenticatedId = default(string))
        {
            Id = id;
            AccountId = accountId;
            AuthenticatedId = authenticatedId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the user
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets account ID of the user
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets authenticated ID of the user
        /// </summary>
        [JsonProperty(PropertyName = "authenticatedId")]
        public string AuthenticatedId { get; set; }

    }
}
