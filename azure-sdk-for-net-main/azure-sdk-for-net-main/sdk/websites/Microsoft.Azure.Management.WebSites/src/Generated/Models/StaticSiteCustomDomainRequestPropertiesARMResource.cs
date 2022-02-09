// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Static Site Custom Domain Request Properties ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteCustomDomainRequestPropertiesARMResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteCustomDomainRequestPropertiesARMResource class.
        /// </summary>
        public StaticSiteCustomDomainRequestPropertiesARMResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteCustomDomainRequestPropertiesARMResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="validationMethod">Validation method for adding a
        /// custom domain</param>
        public StaticSiteCustomDomainRequestPropertiesARMResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string validationMethod = default(string))
            : base(id, name, kind, type)
        {
            ValidationMethod = validationMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets validation method for adding a custom domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationMethod")]
        public string ValidationMethod { get; set; }

    }
}