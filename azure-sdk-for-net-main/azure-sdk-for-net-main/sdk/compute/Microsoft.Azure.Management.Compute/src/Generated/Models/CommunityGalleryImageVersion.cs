// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery image version that you want to
    /// create or update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CommunityGalleryImageVersion : PirCommunityGalleryResource
    {
        /// <summary>
        /// Initializes a new instance of the CommunityGalleryImageVersion
        /// class.
        /// </summary>
        public CommunityGalleryImageVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommunityGalleryImageVersion
        /// class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="location">Resource location</param>
        /// <param name="type">Resource type</param>
        /// <param name="uniqueId">The unique id of this community
        /// gallery.</param>
        /// <param name="publishedDate">The published date of the gallery image
        /// version Definition. This property can be used for decommissioning
        /// purposes. This property is updatable.</param>
        /// <param name="endOfLifeDate">The end of life date of the gallery
        /// image version Definition. This property can be used for
        /// decommissioning purposes. This property is updatable.</param>
        public CommunityGalleryImageVersion(string name = default(string), string location = default(string), string type = default(string), string uniqueId = default(string), System.DateTime? publishedDate = default(System.DateTime?), System.DateTime? endOfLifeDate = default(System.DateTime?))
            : base(name, location, type, uniqueId)
        {
            PublishedDate = publishedDate;
            EndOfLifeDate = endOfLifeDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the published date of the gallery image version
        /// Definition. This property can be used for decommissioning purposes.
        /// This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishedDate")]
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the end of life date of the gallery image version
        /// Definition. This property can be used for decommissioning purposes.
        /// This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endOfLifeDate")]
        public System.DateTime? EndOfLifeDate { get; set; }

    }
}
