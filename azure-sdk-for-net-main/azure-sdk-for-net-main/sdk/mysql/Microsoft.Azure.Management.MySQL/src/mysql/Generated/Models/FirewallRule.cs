// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a server firewall rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FirewallRule : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        public FirewallRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        /// <param name="startIpAddress">The start IP address of the server
        /// firewall rule. Must be IPv4 format.</param>
        /// <param name="endIpAddress">The end IP address of the server
        /// firewall rule. Must be IPv4 format.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        public FirewallRule(string startIpAddress, string endIpAddress, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            StartIpAddress = startIpAddress;
            EndIpAddress = endIpAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start IP address of the server firewall rule. Must
        /// be IPv4 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startIpAddress")]
        public string StartIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the end IP address of the server firewall rule. Must
        /// be IPv4 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endIpAddress")]
        public string EndIpAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StartIpAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartIpAddress");
            }
            if (EndIpAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndIpAddress");
            }
            if (StartIpAddress != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(StartIpAddress, "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "StartIpAddress", "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
                }
            }
            if (EndIpAddress != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(EndIpAddress, "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "EndIpAddress", "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
                }
            }
        }
    }
}