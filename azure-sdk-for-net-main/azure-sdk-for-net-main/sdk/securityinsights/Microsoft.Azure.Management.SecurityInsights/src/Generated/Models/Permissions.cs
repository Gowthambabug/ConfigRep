// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Permissions required for the connector
    /// </summary>
    public partial class Permissions
    {
        /// <summary>
        /// Initializes a new instance of the Permissions class.
        /// </summary>
        public Permissions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Permissions class.
        /// </summary>
        /// <param name="resourceProvider">Resource provider permissions
        /// required for the connector</param>
        /// <param name="customs">Customs permissions required for the
        /// connector</param>
        public Permissions(IList<PermissionsResourceProviderItem> resourceProvider = default(IList<PermissionsResourceProviderItem>), IList<PermissionsCustomsItem> customs = default(IList<PermissionsCustomsItem>))
        {
            ResourceProvider = resourceProvider;
            Customs = customs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource provider permissions required for the
        /// connector
        /// </summary>
        [JsonProperty(PropertyName = "resourceProvider")]
        public IList<PermissionsResourceProviderItem> ResourceProvider { get; set; }

        /// <summary>
        /// Gets or sets customs permissions required for the connector
        /// </summary>
        [JsonProperty(PropertyName = "customs")]
        public IList<PermissionsCustomsItem> Customs { get; set; }

    }
}
