// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class for CheckServiceProviderAvailabilityInput
    /// </summary>
    public partial class CheckServiceProviderAvailabilityInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckServiceProviderAvailabilityInput class.
        /// </summary>
        public CheckServiceProviderAvailabilityInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckServiceProviderAvailabilityInput class.
        /// </summary>
        /// <param name="peeringServiceLocation">Gets or sets the peering
        /// service location.</param>
        /// <param name="peeringServiceProvider">Gets or sets the peering
        /// service provider.</param>
        public CheckServiceProviderAvailabilityInput(string peeringServiceLocation = default(string), string peeringServiceProvider = default(string))
        {
            PeeringServiceLocation = peeringServiceLocation;
            PeeringServiceProvider = peeringServiceProvider;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the peering service location.
        /// </summary>
        [JsonProperty(PropertyName = "peeringServiceLocation")]
        public string PeeringServiceLocation { get; set; }

        /// <summary>
        /// Gets or sets the peering service provider.
        /// </summary>
        [JsonProperty(PropertyName = "peeringServiceProvider")]
        public string PeeringServiceProvider { get; set; }

    }
}