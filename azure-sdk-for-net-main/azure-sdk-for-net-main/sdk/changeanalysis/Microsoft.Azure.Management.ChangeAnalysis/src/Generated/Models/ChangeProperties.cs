// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.ChangeAnalysis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a change.
    /// </summary>
    public partial class ChangeProperties
    {
        /// <summary>
        /// Initializes a new instance of the ChangeProperties class.
        /// </summary>
        public ChangeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangeProperties class.
        /// </summary>
        /// <param name="resourceId">The resource id that the change is
        /// attached to.</param>
        /// <param name="timeStamp">The time when the change is
        /// detected.</param>
        /// <param name="initiatedByList">The list of identities who might
        /// initiated the change.
        /// The identity could be user name (email address) or the object ID of
        /// the Service Principal.</param>
        /// <param name="changeType">Possible values include: 'Add', 'Remove',
        /// 'Update'</param>
        /// <param name="propertyChanges">The list of detailed changes at json
        /// property level.</param>
        public ChangeProperties(string resourceId = default(string), System.DateTime? timeStamp = default(System.DateTime?), IList<string> initiatedByList = default(IList<string>), string changeType = default(string), IList<PropertyChange> propertyChanges = default(IList<PropertyChange>))
        {
            ResourceId = resourceId;
            TimeStamp = timeStamp;
            InitiatedByList = initiatedByList;
            ChangeType = changeType;
            PropertyChanges = propertyChanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id that the change is attached to.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the time when the change is detected.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the list of identities who might initiated the change.
        /// The identity could be user name (email address) or the object ID of
        /// the Service Principal.
        /// </summary>
        [JsonProperty(PropertyName = "initiatedByList")]
        public IList<string> InitiatedByList { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Add', 'Remove', 'Update'
        /// </summary>
        [JsonProperty(PropertyName = "changeType")]
        public string ChangeType { get; set; }

        /// <summary>
        /// Gets or sets the list of detailed changes at json property level.
        /// </summary>
        [JsonProperty(PropertyName = "propertyChanges")]
        public IList<PropertyChange> PropertyChanges { get; set; }

    }
}