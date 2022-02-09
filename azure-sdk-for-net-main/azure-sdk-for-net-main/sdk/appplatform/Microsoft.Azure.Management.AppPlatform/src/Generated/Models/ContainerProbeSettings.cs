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
    /// Container liveness and readiness probe settings
    /// </summary>
    public partial class ContainerProbeSettings
    {
        /// <summary>
        /// Initializes a new instance of the ContainerProbeSettings class.
        /// </summary>
        public ContainerProbeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerProbeSettings class.
        /// </summary>
        /// <param name="disableProbe">Indicates whether disable the liveness
        /// and readiness probe</param>
        public ContainerProbeSettings(bool? disableProbe = default(bool?))
        {
            DisableProbe = disableProbe;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether disable the liveness and readiness
        /// probe
        /// </summary>
        [JsonProperty(PropertyName = "disableProbe")]
        public bool? DisableProbe { get; set; }

    }
}