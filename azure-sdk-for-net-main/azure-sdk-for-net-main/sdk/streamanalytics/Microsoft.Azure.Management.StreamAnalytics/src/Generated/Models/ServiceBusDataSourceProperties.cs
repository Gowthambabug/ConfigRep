// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The common properties that are associated with Service Bus data sources
    /// (Queues, Topics, Event Hubs, etc.).
    /// </summary>
    public partial class ServiceBusDataSourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServiceBusDataSourceProperties
        /// class.
        /// </summary>
        public ServiceBusDataSourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusDataSourceProperties
        /// class.
        /// </summary>
        /// <param name="serviceBusNamespace">The namespace that is associated
        /// with the desired Event Hub, Service Bus Queue, Service Bus Topic,
        /// etc. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyName">The shared access policy name
        /// for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyKey">The shared access policy key
        /// for the specified shared access policy. Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="authenticationMode">Authentication Mode. Possible
        /// values include: 'Msi', 'UserToken', 'ConnectionString'</param>
        public ServiceBusDataSourceProperties(string serviceBusNamespace = default(string), string sharedAccessPolicyName = default(string), string sharedAccessPolicyKey = default(string), string authenticationMode = default(string))
        {
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyName = sharedAccessPolicyName;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            AuthenticationMode = authenticationMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the namespace that is associated with the desired
        /// Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on
        /// PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy name for the Event Hub,
        /// Service Bus Queue, Service Bus Topic, etc. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "sharedAccessPolicyName")]
        public string SharedAccessPolicyName { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy key for the specified shared
        /// access policy. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "sharedAccessPolicyKey")]
        public string SharedAccessPolicyKey { get; set; }

        /// <summary>
        /// Gets or sets authentication Mode. Possible values include: 'Msi',
        /// 'UserToken', 'ConnectionString'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationMode")]
        public string AuthenticationMode { get; set; }

    }
}