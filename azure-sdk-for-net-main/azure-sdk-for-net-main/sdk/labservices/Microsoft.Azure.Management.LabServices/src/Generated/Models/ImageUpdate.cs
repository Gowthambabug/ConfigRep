// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Lab services virtual machine image for updates.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImageUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ImageUpdate class.
        /// </summary>
        public ImageUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageUpdate class.
        /// </summary>
        /// <param name="enabledState">Is the image enabled. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        public ImageUpdate(EnableState? enabledState = default(EnableState?))
        {
            EnabledState = enabledState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is the image enabled. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public EnableState? EnabledState { get; set; }

    }
}