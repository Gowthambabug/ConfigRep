// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entry associating a tag to an image.
    /// </summary>
    public partial class ImageTagCreateEntry
    {
        /// <summary>
        /// Initializes a new instance of the ImageTagCreateEntry class.
        /// </summary>
        public ImageTagCreateEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTagCreateEntry class.
        /// </summary>
        /// <param name="imageId">Id of the image.</param>
        /// <param name="tagId">Id of the tag.</param>
        public ImageTagCreateEntry(System.Guid imageId = default(System.Guid), System.Guid tagId = default(System.Guid))
        {
            ImageId = imageId;
            TagId = tagId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the image.
        /// </summary>
        [JsonProperty(PropertyName = "imageId")]
        public System.Guid ImageId { get; set; }

        /// <summary>
        /// Gets or sets id of the tag.
        /// </summary>
        [JsonProperty(PropertyName = "tagId")]
        public System.Guid TagId { get; set; }

    }
}
