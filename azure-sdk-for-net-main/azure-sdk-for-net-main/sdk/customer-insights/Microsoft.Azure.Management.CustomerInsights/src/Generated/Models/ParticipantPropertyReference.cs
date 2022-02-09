// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The participant property reference.
    /// </summary>
    public partial class ParticipantPropertyReference
    {
        /// <summary>
        /// Initializes a new instance of the ParticipantPropertyReference
        /// class.
        /// </summary>
        public ParticipantPropertyReference() { }

        /// <summary>
        /// Initializes a new instance of the ParticipantPropertyReference
        /// class.
        /// </summary>
        /// <param name="interactionPropertyName">The interaction property that
        /// maps to the profile property.</param>
        /// <param name="profilePropertyName">The profile property that maps to
        /// the interaction property.</param>
        public ParticipantPropertyReference(string interactionPropertyName, string profilePropertyName)
        {
            InteractionPropertyName = interactionPropertyName;
            ProfilePropertyName = profilePropertyName;
        }

        /// <summary>
        /// Gets or sets the interaction property that maps to the profile
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "interactionPropertyName")]
        public string InteractionPropertyName { get; set; }

        /// <summary>
        /// Gets or sets the profile property that maps to the interaction
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "profilePropertyName")]
        public string ProfilePropertyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InteractionPropertyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InteractionPropertyName");
            }
            if (ProfilePropertyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProfilePropertyName");
            }
        }
    }
}

