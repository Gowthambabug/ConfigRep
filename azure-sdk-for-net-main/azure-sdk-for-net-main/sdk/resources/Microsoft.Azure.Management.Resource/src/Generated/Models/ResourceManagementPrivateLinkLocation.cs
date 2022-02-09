// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceManagementPrivateLinkLocation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementPrivateLinkLocation class.
        /// </summary>
        public ResourceManagementPrivateLinkLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementPrivateLinkLocation class.
        /// </summary>
        /// <param name="location">the region to create private link
        /// association.</param>
        public ResourceManagementPrivateLinkLocation(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region to create private link association.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}