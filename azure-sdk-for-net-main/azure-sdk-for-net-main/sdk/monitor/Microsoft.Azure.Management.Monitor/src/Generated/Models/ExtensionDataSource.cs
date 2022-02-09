// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of which data will be collected from a separate VM extension
    /// that integrates with the Azure Monitor Agent.
    /// Collected from either Windows and Linux machines, depending on which
    /// extension is defined.
    /// </summary>
    public partial class ExtensionDataSource
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionDataSource class.
        /// </summary>
        public ExtensionDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionDataSource class.
        /// </summary>
        /// <param name="extensionName">The name of the VM extension.</param>
        /// <param name="streams">List of streams that this data source will be
        /// sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent
        /// to.</param>
        /// <param name="extensionSettings">The extension settings. The format
        /// is specific for particular extension.</param>
        /// <param name="inputDataSources">The list of data sources this
        /// extension needs data from.</param>
        /// <param name="name">A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
        /// type) within the data collection rule.</param>
        public ExtensionDataSource(string extensionName, IList<string> streams = default(IList<string>), object extensionSettings = default(object), IList<string> inputDataSources = default(IList<string>), string name = default(string))
        {
            Streams = streams;
            ExtensionName = extensionName;
            ExtensionSettings = extensionSettings;
            InputDataSources = inputDataSources;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public IList<string> Streams { get; set; }

        /// <summary>
        /// Gets or sets the name of the VM extension.
        /// </summary>
        [JsonProperty(PropertyName = "extensionName")]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets the extension settings. The format is specific for
        /// particular extension.
        /// </summary>
        [JsonProperty(PropertyName = "extensionSettings")]
        public object ExtensionSettings { get; set; }

        /// <summary>
        /// Gets or sets the list of data sources this extension needs data
        /// from.
        /// </summary>
        [JsonProperty(PropertyName = "inputDataSources")]
        public IList<string> InputDataSources { get; set; }

        /// <summary>
        /// Gets or sets a friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
        /// type) within the data collection rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExtensionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExtensionName");
            }
        }
    }
}