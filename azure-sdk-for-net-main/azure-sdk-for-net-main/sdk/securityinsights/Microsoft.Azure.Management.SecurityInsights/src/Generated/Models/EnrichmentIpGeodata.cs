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
    /// Geodata information for a given IP address
    /// </summary>
    public partial class EnrichmentIpGeodata
    {
        /// <summary>
        /// Initializes a new instance of the EnrichmentIpGeodata class.
        /// </summary>
        public EnrichmentIpGeodata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnrichmentIpGeodata class.
        /// </summary>
        /// <param name="asn">The autonomous system number associated with this
        /// IP address</param>
        /// <param name="carrier">The name of the carrier for this IP
        /// address</param>
        /// <param name="city">The city this IP address is located in</param>
        /// <param name="cityCf">A numeric rating of confidence that the value
        /// in the 'city' field is correct, on a scale of 0-100</param>
        /// <param name="continent">The continent this IP address is located
        /// on</param>
        /// <param name="country">The county this IP address is located
        /// in</param>
        /// <param name="countryCf">A numeric rating of confidence that the
        /// value in the 'country' field is correct on a scale of 0-100</param>
        /// <param name="ipAddr">The dotted-decimal or colon-separated string
        /// representation of the IP address</param>
        /// <param name="ipRoutingType">A description of the connection type of
        /// this IP address</param>
        /// <param name="latitude">The latitude of this IP address</param>
        /// <param name="longitude">The longitude of this IP address</param>
        /// <param name="organization">The name of the organization for this IP
        /// address</param>
        /// <param name="organizationType">The type of the organization for
        /// this IP address</param>
        /// <param name="region">The geographic region this IP address is
        /// located in</param>
        /// <param name="state">The state this IP address is located in</param>
        /// <param name="stateCf">A numeric rating of confidence that the value
        /// in the 'state' field is correct on a scale of 0-100</param>
        /// <param name="stateCode">The abbreviated name for the state this IP
        /// address is located in</param>
        public EnrichmentIpGeodata(string asn = default(string), string carrier = default(string), string city = default(string), int? cityCf = default(int?), string continent = default(string), string country = default(string), int? countryCf = default(int?), string ipAddr = default(string), string ipRoutingType = default(string), string latitude = default(string), string longitude = default(string), string organization = default(string), string organizationType = default(string), string region = default(string), string state = default(string), int? stateCf = default(int?), string stateCode = default(string))
        {
            Asn = asn;
            Carrier = carrier;
            City = city;
            CityCf = cityCf;
            Continent = continent;
            Country = country;
            CountryCf = countryCf;
            IpAddr = ipAddr;
            IpRoutingType = ipRoutingType;
            Latitude = latitude;
            Longitude = longitude;
            Organization = organization;
            OrganizationType = organizationType;
            Region = region;
            State = state;
            StateCf = stateCf;
            StateCode = stateCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the autonomous system number associated with this IP
        /// address
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public string Asn { get; set; }

        /// <summary>
        /// Gets or sets the name of the carrier for this IP address
        /// </summary>
        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets the city this IP address is located in
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets a numeric rating of confidence that the value in the
        /// 'city' field is correct, on a scale of 0-100
        /// </summary>
        [JsonProperty(PropertyName = "cityCf")]
        public int? CityCf { get; set; }

        /// <summary>
        /// Gets or sets the continent this IP address is located on
        /// </summary>
        [JsonProperty(PropertyName = "continent")]
        public string Continent { get; set; }

        /// <summary>
        /// Gets or sets the county this IP address is located in
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets a numeric rating of confidence that the value in the
        /// 'country' field is correct on a scale of 0-100
        /// </summary>
        [JsonProperty(PropertyName = "countryCf")]
        public int? CountryCf { get; set; }

        /// <summary>
        /// Gets or sets the dotted-decimal or colon-separated string
        /// representation of the IP address
        /// </summary>
        [JsonProperty(PropertyName = "ipAddr")]
        public string IpAddr { get; set; }

        /// <summary>
        /// Gets or sets a description of the connection type of this IP
        /// address
        /// </summary>
        [JsonProperty(PropertyName = "ipRoutingType")]
        public string IpRoutingType { get; set; }

        /// <summary>
        /// Gets or sets the latitude of this IP address
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of this IP address
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the name of the organization for this IP address
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or sets the type of the organization for this IP address
        /// </summary>
        [JsonProperty(PropertyName = "organizationType")]
        public string OrganizationType { get; set; }

        /// <summary>
        /// Gets or sets the geographic region this IP address is located in
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the state this IP address is located in
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets a numeric rating of confidence that the value in the
        /// 'state' field is correct on a scale of 0-100
        /// </summary>
        [JsonProperty(PropertyName = "stateCf")]
        public int? StateCf { get; set; }

        /// <summary>
        /// Gets or sets the abbreviated name for the state this IP address is
        /// located in
        /// </summary>
        [JsonProperty(PropertyName = "stateCode")]
        public string StateCode { get; set; }

    }
}