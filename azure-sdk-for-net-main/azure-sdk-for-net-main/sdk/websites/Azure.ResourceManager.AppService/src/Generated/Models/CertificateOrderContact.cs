// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The CertificateOrderContact. </summary>
    public partial class CertificateOrderContact
    {
        /// <summary> Initializes a new instance of CertificateOrderContact. </summary>
        internal CertificateOrderContact()
        {
        }

        /// <summary> Initializes a new instance of CertificateOrderContact. </summary>
        /// <param name="email"></param>
        /// <param name="nameFirst"></param>
        /// <param name="nameLast"></param>
        /// <param name="phone"></param>
        internal CertificateOrderContact(string email, string nameFirst, string nameLast, string phone)
        {
            Email = email;
            NameFirst = nameFirst;
            NameLast = nameLast;
            Phone = phone;
        }

        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Gets the name first. </summary>
        public string NameFirst { get; }
        /// <summary> Gets the name last. </summary>
        public string NameLast { get; }
        /// <summary> Gets the phone. </summary>
        public string Phone { get; }
    }
}
