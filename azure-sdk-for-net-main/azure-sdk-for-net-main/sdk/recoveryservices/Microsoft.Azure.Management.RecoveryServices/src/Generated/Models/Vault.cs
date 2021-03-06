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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource information, as returned by the resource provider.
    /// </summary>
    public partial class Vault : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        public Vault()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="etag">Optional ETag.</param>
        /// <param name="tags">Resource tags.</param>
        public Vault(string location, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IdentityData identity = default(IdentityData), VaultProperties properties = default(VaultProperties), Sku sku = default(Sku), SystemData systemData = default(SystemData))
            : base(location, id, name, type, etag, tags)
        {
            Identity = identity;
            Properties = properties;
            Sku = sku;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityData Identity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VaultProperties Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Identity != null)
            {
                Identity.Validate();
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
