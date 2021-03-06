// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configuration for HTTP or HTTPS requests.
    /// </summary>
    public partial class ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration
        /// class.
        /// </summary>
        public ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration
        /// class.
        /// </summary>
        /// <param name="method">The HTTP method to be used. Possible values
        /// include: 'GET', 'POST'</param>
        /// <param name="validStatusCodes">List of HTTP status codes considered
        /// valid for the request response.</param>
        /// <param name="headers">List of headers to be included in the
        /// request.</param>
        public ConnectivityCheckRequestProtocolConfigurationHTTPConfiguration(string method = default(string), IList<long?> validStatusCodes = default(IList<long?>), IList<HTTPHeader> headers = default(IList<HTTPHeader>))
        {
            Method = method;
            ValidStatusCodes = validStatusCodes;
            Headers = headers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the HTTP method to be used. Possible values include:
        /// 'GET', 'POST'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets list of HTTP status codes considered valid for the
        /// request response.
        /// </summary>
        [JsonProperty(PropertyName = "validStatusCodes")]
        public IList<long?> ValidStatusCodes { get; set; }

        /// <summary>
        /// Gets or sets list of headers to be included in the request.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<HTTPHeader> Headers { get; set; }

    }
}
