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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Transfer offers properties
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TransferOffersProperties
    {
        /// <summary>
        /// Initializes a new instance of the TransferOffersProperties class.
        /// </summary>
        public TransferOffersProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferOffersProperties class.
        /// </summary>
        /// <param name="targetCollections">Target collections ids</param>
        /// <param name="operation">Operation to perform (For example: Copy or
        /// Move)</param>
        /// <param name="offerIdsList">Offers ids list to transfer from source
        /// collection to target collection(s)</param>
        public TransferOffersProperties(IList<string> targetCollections = default(IList<string>), string operation = default(string), IList<string> offerIdsList = default(IList<string>))
        {
            TargetCollections = targetCollections;
            Operation = operation;
            OfferIdsList = offerIdsList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target collections ids
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetCollections")]
        public IList<string> TargetCollections { get; set; }

        /// <summary>
        /// Gets or sets operation to perform (For example: Copy or Move)
        /// </summary>
        [JsonProperty(PropertyName = "properties.operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets offers ids list to transfer from source collection to
        /// target collection(s)
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerIdsList")]
        public IList<string> OfferIdsList { get; set; }

    }
}