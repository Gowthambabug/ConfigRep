// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of page BLOB acquisitions.
    /// </summary>
    public partial class AcquisitionList
    {
        /// <summary>
        /// Initializes a new instance of the AcquisitionList class.
        /// </summary>
        public AcquisitionList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AcquisitionList class.
        /// </summary>
        /// <param name="value">List of acquisitions.</param>
        public AcquisitionList(IList<Acquisition> value = default(IList<Acquisition>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of acquisitions.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Acquisition> Value { get; private set; }

    }
}
