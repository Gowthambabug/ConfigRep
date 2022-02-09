// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Standard error object.
    /// </summary>
    public partial class ErrorResponseError : Error
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseError class.
        /// </summary>
        public ErrorResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseError class.
        /// </summary>
        /// <param name="code">Server-defined set of error codes.</param>
        /// <param name="message">Human-readable representation of the
        /// error.</param>
        /// <param name="target">Target of the error.</param>
        /// <param name="details">Array of details about specific errors that
        /// led to this reported error.</param>
        /// <param name="innerError">Object containing more specific
        /// information than  the current object about the error.</param>
        public ErrorResponseError(string code = default(string), string message = default(string), string target = default(string), IList<Error> details = default(IList<Error>), ErrorInnerError innerError = default(ErrorInnerError))
            : base(code, message, target, details, innerError)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}