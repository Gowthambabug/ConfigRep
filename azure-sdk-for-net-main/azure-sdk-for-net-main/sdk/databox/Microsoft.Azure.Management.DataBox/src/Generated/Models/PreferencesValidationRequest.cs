// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to validate preference of transport and data center.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidatePreferences")]
    public partial class PreferencesValidationRequest : ValidationInputRequest
    {
        /// <summary>
        /// Initializes a new instance of the PreferencesValidationRequest
        /// class.
        /// </summary>
        public PreferencesValidationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PreferencesValidationRequest
        /// class.
        /// </summary>
        /// <param name="deviceType">Device type to be used for the job.
        /// Possible values include: 'DataBox', 'DataBoxDisk', 'DataBoxHeavy',
        /// 'DataBoxCustomerDisk'</param>
        /// <param name="preference">Preference of transport and data
        /// center.</param>
        public PreferencesValidationRequest(SkuName deviceType, Preferences preference = default(Preferences))
        {
            Preference = preference;
            DeviceType = deviceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets preference of transport and data center.
        /// </summary>
        [JsonProperty(PropertyName = "preference")]
        public Preferences Preference { get; set; }

        /// <summary>
        /// Gets or sets device type to be used for the job. Possible values
        /// include: 'DataBox', 'DataBoxDisk', 'DataBoxHeavy',
        /// 'DataBoxCustomerDisk'
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public SkuName DeviceType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Preference != null)
            {
                Preference.Validate();
            }
        }
    }
}
