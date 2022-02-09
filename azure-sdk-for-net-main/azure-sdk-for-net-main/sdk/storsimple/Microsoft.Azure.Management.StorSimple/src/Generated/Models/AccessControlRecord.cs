// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The access control record
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AccessControlRecord : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the AccessControlRecord class.
        /// </summary>
        public AccessControlRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessControlRecord class.
        /// </summary>
        /// <param name="initiatorName">The Iscsi initiator name (IQN)</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public AccessControlRecord(string initiatorName, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            InitiatorName = initiatorName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Iscsi initiator name (IQN)
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatorName")]
        public string InitiatorName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InitiatorName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InitiatorName");
            }
        }
    }
}
