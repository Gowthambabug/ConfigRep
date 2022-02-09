// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CollectionsList
    {
        /// <summary>
        /// Initializes a new instance of the CollectionsList class.
        /// </summary>
        public CollectionsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CollectionsList class.
        /// </summary>
        /// <param name="nextLink">URL to get the next set of offer list
        /// results if there are any.</param>
        public CollectionsList(IList<Collection> value = default(IList<Collection>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Collection> Value { get; set; }

        /// <summary>
        /// Gets or sets URL to get the next set of offer list results if there
        /// are any.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
