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
    /// The build result triggered by a build
    /// </summary>
    public partial class TriggeredBuildResult
    {
        /// <summary>
        /// Initializes a new instance of the TriggeredBuildResult class.
        /// </summary>
        public TriggeredBuildResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggeredBuildResult class.
        /// </summary>
        /// <param name="id">The unique build id of this build result</param>
        public TriggeredBuildResult(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique build id of this build result
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
