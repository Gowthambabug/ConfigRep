// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The incident related entities response.
    /// </summary>
    public partial class IncidentEntitiesResponse
    {
        /// <summary>
        /// Initializes a new instance of the IncidentEntitiesResponse class.
        /// </summary>
        public IncidentEntitiesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncidentEntitiesResponse class.
        /// </summary>
        /// <param name="entities">Array of the incident related
        /// entities.</param>
        /// <param name="metaData">The metadata from the incident related
        /// entities results.</param>
        public IncidentEntitiesResponse(IList<Entity> entities = default(IList<Entity>), IList<IncidentEntitiesResultsMetadata> metaData = default(IList<IncidentEntitiesResultsMetadata>))
        {
            Entities = entities;
            MetaData = metaData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of the incident related entities.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets the metadata from the incident related entities
        /// results.
        /// </summary>
        [JsonProperty(PropertyName = "metaData")]
        public IList<IncidentEntitiesResultsMetadata> MetaData { get; set; }

    }
}