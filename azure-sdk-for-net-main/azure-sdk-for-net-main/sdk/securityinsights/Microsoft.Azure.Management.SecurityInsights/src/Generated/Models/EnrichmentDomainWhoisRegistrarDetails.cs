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
    using System.Linq;

    /// <summary>
    /// The registrar associated with this domain
    /// </summary>
    public partial class EnrichmentDomainWhoisRegistrarDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EnrichmentDomainWhoisRegistrarDetails class.
        /// </summary>
        public EnrichmentDomainWhoisRegistrarDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EnrichmentDomainWhoisRegistrarDetails class.
        /// </summary>
        /// <param name="name">The name of this registrar</param>
        /// <param name="abuseContactEmail">This registrar's abuse contact
        /// email</param>
        /// <param name="abuseContactPhone">This registrar's abuse contact
        /// phone number</param>
        /// <param name="ianaId">This registrar's Internet Assigned Numbers
        /// Authority id</param>
        /// <param name="url">This registrar's URL</param>
        /// <param name="whoisServer">The hostname of this registrar's whois
        /// server</param>
        public EnrichmentDomainWhoisRegistrarDetails(string name = default(string), string abuseContactEmail = default(string), string abuseContactPhone = default(string), string ianaId = default(string), string url = default(string), string whoisServer = default(string))
        {
            Name = name;
            AbuseContactEmail = abuseContactEmail;
            AbuseContactPhone = abuseContactPhone;
            IanaId = ianaId;
            Url = url;
            WhoisServer = whoisServer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of this registrar
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets this registrar's abuse contact email
        /// </summary>
        [JsonProperty(PropertyName = "abuseContactEmail")]
        public string AbuseContactEmail { get; set; }

        /// <summary>
        /// Gets or sets this registrar's abuse contact phone number
        /// </summary>
        [JsonProperty(PropertyName = "abuseContactPhone")]
        public string AbuseContactPhone { get; set; }

        /// <summary>
        /// Gets or sets this registrar's Internet Assigned Numbers Authority
        /// id
        /// </summary>
        [JsonProperty(PropertyName = "ianaId")]
        public string IanaId { get; set; }

        /// <summary>
        /// Gets or sets this registrar's URL
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the hostname of this registrar's whois server
        /// </summary>
        [JsonProperty(PropertyName = "whoisServer")]
        public string WhoisServer { get; set; }

    }
}
