// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model that represents a continuous action.
    /// </summary>
    [Newtonsoft.Json.JsonObject("continuous")]
    public partial class ContinuousAction : Action
    {
        /// <summary>
        /// Initializes a new instance of the ContinuousAction class.
        /// </summary>
        public ContinuousAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContinuousAction class.
        /// </summary>
        /// <param name="name">String that represents a Capability URN.</param>
        /// <param name="duration">ISO8601 formatted string that represents a
        /// duration.</param>
        /// <param name="parameters">List of key value pairs.</param>
        /// <param name="selectorId">String that represents a selector.</param>
        public ContinuousAction(string name, string duration, IList<KeyValuePair> parameters, string selectorId)
            : base(name)
        {
            Duration = duration;
            Parameters = parameters;
            SelectorId = selectorId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ISO8601 formatted string that represents a duration.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets list of key value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<KeyValuePair> Parameters { get; set; }

        /// <summary>
        /// Gets or sets string that represents a selector.
        /// </summary>
        [JsonProperty(PropertyName = "selectorId")]
        public string SelectorId { get; set; }

    }
}