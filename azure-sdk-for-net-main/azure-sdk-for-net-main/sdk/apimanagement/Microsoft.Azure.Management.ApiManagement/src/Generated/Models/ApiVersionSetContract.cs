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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// API Version Set Contract details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiVersionSetContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContract class.
        /// </summary>
        public ApiVersionSetContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContract class.
        /// </summary>
        /// <param name="displayName">Name of API Version Set</param>
        /// <param name="versioningScheme">An value that determines where the
        /// API Version identifier will be located in a HTTP request. Possible
        /// values include: 'Segment', 'Query', 'Header'</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="description">Description of API Version Set.</param>
        /// <param name="versionQueryName">Name of query parameter that
        /// indicates the API Version if versioningScheme is set to
        /// `query`.</param>
        /// <param name="versionHeaderName">Name of HTTP header parameter that
        /// indicates the API Version if versioningScheme is set to
        /// `header`.</param>
        public ApiVersionSetContract(string displayName, string versioningScheme, string id = default(string), string name = default(string), string type = default(string), string description = default(string), string versionQueryName = default(string), string versionHeaderName = default(string))
            : base(id, name, type)
        {
            Description = description;
            VersionQueryName = versionQueryName;
            VersionHeaderName = versionHeaderName;
            DisplayName = displayName;
            VersioningScheme = versioningScheme;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of API Version Set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of query parameter that indicates the API Version
        /// if versioningScheme is set to `query`.
        /// </summary>
        [JsonProperty(PropertyName = "properties.versionQueryName")]
        public string VersionQueryName { get; set; }

        /// <summary>
        /// Gets or sets name of HTTP header parameter that indicates the API
        /// Version if versioningScheme is set to `header`.
        /// </summary>
        [JsonProperty(PropertyName = "properties.versionHeaderName")]
        public string VersionHeaderName { get; set; }

        /// <summary>
        /// Gets or sets name of API Version Set
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets an value that determines where the API Version
        /// identifier will be located in a HTTP request. Possible values
        /// include: 'Segment', 'Query', 'Header'
        /// </summary>
        [JsonProperty(PropertyName = "properties.versioningScheme")]
        public string VersioningScheme { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (VersioningScheme == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VersioningScheme");
            }
            if (VersionQueryName != null)
            {
                if (VersionQueryName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "VersionQueryName", 100);
                }
                if (VersionQueryName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "VersionQueryName", 1);
                }
            }
            if (VersionHeaderName != null)
            {
                if (VersionHeaderName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "VersionHeaderName", 100);
                }
                if (VersionHeaderName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "VersionHeaderName", 1);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 100);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
        }
    }
}
