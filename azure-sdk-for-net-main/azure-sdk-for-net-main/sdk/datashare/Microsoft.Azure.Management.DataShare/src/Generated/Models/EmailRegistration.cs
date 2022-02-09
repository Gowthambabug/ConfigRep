// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dto for tenant domain registration
    /// </summary>
    public partial class EmailRegistration
    {
        /// <summary>
        /// Initializes a new instance of the EmailRegistration class.
        /// </summary>
        public EmailRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailRegistration class.
        /// </summary>
        /// <param name="activationCode">Activation code for the
        /// registration</param>
        /// <param name="activationExpirationDate">Date of the activation
        /// expiration</param>
        /// <param name="email">The email to register</param>
        /// <param name="registrationStatus">Registration status. Possible
        /// values include: 'ActivationPending', 'Activated',
        /// 'ActivationAttemptsExhausted'</param>
        /// <param name="tenantId">The tenant to register</param>
        public EmailRegistration(string activationCode = default(string), System.DateTime? activationExpirationDate = default(System.DateTime?), string email = default(string), string registrationStatus = default(string), string tenantId = default(string))
        {
            ActivationCode = activationCode;
            ActivationExpirationDate = activationExpirationDate;
            Email = email;
            RegistrationStatus = registrationStatus;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets activation code for the registration
        /// </summary>
        [JsonProperty(PropertyName = "activationCode")]
        public string ActivationCode { get; set; }

        /// <summary>
        /// Gets date of the activation expiration
        /// </summary>
        [JsonProperty(PropertyName = "activationExpirationDate")]
        public System.DateTime? ActivationExpirationDate { get; private set; }

        /// <summary>
        /// Gets the email to register
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; private set; }

        /// <summary>
        /// Gets registration status. Possible values include:
        /// 'ActivationPending', 'Activated', 'ActivationAttemptsExhausted'
        /// </summary>
        [JsonProperty(PropertyName = "registrationStatus")]
        public string RegistrationStatus { get; private set; }

        /// <summary>
        /// Gets the tenant to register
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

    }
}