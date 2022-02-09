// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the certificate to be uploaded to the vault.
    /// </summary>
    public partial class CertificateRequest
    {
        /// <summary>
        /// Initializes a new instance of the CertificateRequest class.
        /// </summary>
        public CertificateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateRequest class.
        /// </summary>
        public CertificateRequest(RawCertificateData properties = default(RawCertificateData))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RawCertificateData Properties { get; set; }

    }
}