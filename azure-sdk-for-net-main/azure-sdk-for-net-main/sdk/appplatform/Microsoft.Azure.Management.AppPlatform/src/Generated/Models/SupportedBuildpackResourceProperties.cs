// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Supported buildpack resource properties
    /// </summary>
    public partial class SupportedBuildpackResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SupportedBuildpackResourceProperties class.
        /// </summary>
        public SupportedBuildpackResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SupportedBuildpackResourceProperties class.
        /// </summary>
        /// <param name="buildpackId">The id of supported buildpack</param>
        public SupportedBuildpackResourceProperties(string buildpackId = default(string))
        {
            BuildpackId = buildpackId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of supported buildpack
        /// </summary>
        [JsonProperty(PropertyName = "buildpackId")]
        public string BuildpackId { get; set; }

    }
}