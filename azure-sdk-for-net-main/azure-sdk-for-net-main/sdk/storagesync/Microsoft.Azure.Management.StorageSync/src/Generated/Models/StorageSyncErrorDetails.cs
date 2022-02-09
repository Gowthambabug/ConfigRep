// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error Details object.
    /// </summary>
    public partial class StorageSyncErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the StorageSyncErrorDetails class.
        /// </summary>
        public StorageSyncErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageSyncErrorDetails class.
        /// </summary>
        /// <param name="code">Error code of the given entry.</param>
        /// <param name="message">Error message of the given entry.</param>
        /// <param name="target">Target of the given entry.</param>
        /// <param name="requestUri">Request URI of the given entry.</param>
        /// <param name="exceptionType">Exception type of the given
        /// entry.</param>
        /// <param name="httpMethod">HTTP method of the given entry.</param>
        /// <param name="hashedMessage">Hashed message of the given
        /// entry.</param>
        /// <param name="httpErrorCode">HTTP error code of the given
        /// entry.</param>
        public StorageSyncErrorDetails(string code = default(string), string message = default(string), string target = default(string), string requestUri = default(string), string exceptionType = default(string), string httpMethod = default(string), string hashedMessage = default(string), string httpErrorCode = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            RequestUri = requestUri;
            ExceptionType = exceptionType;
            HttpMethod = httpMethod;
            HashedMessage = hashedMessage;
            HttpErrorCode = httpErrorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets target of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets request URI of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "requestUri")]
        public string RequestUri { get; set; }

        /// <summary>
        /// Gets or sets exception type of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "exceptionType")]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or sets HTTP method of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "httpMethod")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// Gets or sets hashed message of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "hashedMessage")]
        public string HashedMessage { get; set; }

        /// <summary>
        /// Gets or sets HTTP error code of the given entry.
        /// </summary>
        [JsonProperty(PropertyName = "httpErrorCode")]
        public string HttpErrorCode { get; set; }

    }
}