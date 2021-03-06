// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The context info
    /// </summary>
    public partial class Context
    {
        /// <summary>
        /// Initializes a new instance of the Context class.
        /// </summary>
        public Context()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Context class.
        /// </summary>
        /// <param name="notificationSource">The source of the notification
        /// request</param>
        /// <param name="contextType">The context id type</param>
        public Context(string notificationSource = default(string), string contextType = default(string))
        {
            NotificationSource = notificationSource;
            ContextType = contextType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source of the notification request
        /// </summary>
        [JsonProperty(PropertyName = "NotificationSource")]
        public string NotificationSource { get; set; }

        /// <summary>
        /// Gets or sets the context id type
        /// </summary>
        [JsonProperty(PropertyName = "ContextType")]
        public string ContextType { get; set; }

    }
}
