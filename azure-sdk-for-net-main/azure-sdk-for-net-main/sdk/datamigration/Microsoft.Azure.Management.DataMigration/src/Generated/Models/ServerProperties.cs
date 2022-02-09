// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Server properties for MySQL type source
    /// </summary>
    public partial class ServerProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServerProperties class.
        /// </summary>
        public ServerProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerProperties class.
        /// </summary>
        /// <param name="serverPlatform">Name of the server platform</param>
        /// <param name="serverName">Name of the server</param>
        /// <param name="serverVersion">Version of the database server</param>
        /// <param name="serverEdition">Edition of the database server</param>
        /// <param name="serverOperatingSystemVersion">Version of the operating
        /// system</param>
        /// <param name="serverDatabaseCount">Number of databases in the
        /// server</param>
        public ServerProperties(string serverPlatform = default(string), string serverName = default(string), string serverVersion = default(string), string serverEdition = default(string), string serverOperatingSystemVersion = default(string), int? serverDatabaseCount = default(int?))
        {
            ServerPlatform = serverPlatform;
            ServerName = serverName;
            ServerVersion = serverVersion;
            ServerEdition = serverEdition;
            ServerOperatingSystemVersion = serverOperatingSystemVersion;
            ServerDatabaseCount = serverDatabaseCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the server platform
        /// </summary>
        [JsonProperty(PropertyName = "serverPlatform")]
        public string ServerPlatform { get; private set; }

        /// <summary>
        /// Gets name of the server
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; private set; }

        /// <summary>
        /// Gets version of the database server
        /// </summary>
        [JsonProperty(PropertyName = "serverVersion")]
        public string ServerVersion { get; private set; }

        /// <summary>
        /// Gets edition of the database server
        /// </summary>
        [JsonProperty(PropertyName = "serverEdition")]
        public string ServerEdition { get; private set; }

        /// <summary>
        /// Gets version of the operating system
        /// </summary>
        [JsonProperty(PropertyName = "serverOperatingSystemVersion")]
        public string ServerOperatingSystemVersion { get; private set; }

        /// <summary>
        /// Gets number of databases in the server
        /// </summary>
        [JsonProperty(PropertyName = "serverDatabaseCount")]
        public int? ServerDatabaseCount { get; private set; }

    }
}
