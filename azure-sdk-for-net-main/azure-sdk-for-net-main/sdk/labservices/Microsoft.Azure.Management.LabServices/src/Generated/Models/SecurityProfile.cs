// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The lab security profile.
    /// </summary>
    public partial class SecurityProfile
    {
        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        public SecurityProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        /// <param name="registrationCode">The registration code for the
        /// lab.</param>
        /// <param name="openAccess">Whether any user or only specified users
        /// can register to a lab. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public SecurityProfile(string registrationCode = default(string), EnableState? openAccess = default(EnableState?))
        {
            RegistrationCode = registrationCode;
            OpenAccess = openAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the registration code for the lab.
        /// </summary>
        [JsonProperty(PropertyName = "registrationCode")]
        public string RegistrationCode { get; private set; }

        /// <summary>
        /// Gets or sets whether any user or only specified users can register
        /// to a lab. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "openAccess")]
        public EnableState? OpenAccess { get; set; }

    }
}