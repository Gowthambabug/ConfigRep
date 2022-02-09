// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Credential reference type.
    /// </summary>
    public partial class CredentialReference
    {
        /// <summary>
        /// Initializes a new instance of the CredentialReference class.
        /// </summary>
        public CredentialReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialReference class.
        /// </summary>
        /// <param name="referenceName">Reference credential name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public CredentialReference(string referenceName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
        {
            AdditionalProperties = additionalProperties;
            ReferenceName = referenceName;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CredentialReference class.
        /// </summary>
        static CredentialReference()
        {
            Type = "CredentialReference";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets reference credential name.
        /// </summary>
        [JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Credential reference type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReferenceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReferenceName");
            }
        }
    }
}