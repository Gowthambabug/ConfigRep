// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A logical database transparent data encryption state.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogicalDatabaseTransparentDataEncryption : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LogicalDatabaseTransparentDataEncryption class.
        /// </summary>
        public LogicalDatabaseTransparentDataEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LogicalDatabaseTransparentDataEncryption class.
        /// </summary>
        /// <param name="state">Specifies the state of the transparent data
        /// encryption. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public LogicalDatabaseTransparentDataEncryption(TransparentDataEncryptionState state, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the state of the transparent data
        /// encryption. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public TransparentDataEncryptionState State { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
