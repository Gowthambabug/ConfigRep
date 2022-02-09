// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Symmetric key credential. </summary>
    public partial class SymmetricKeyCredentials : CredentialsBase
    {
        /// <summary> Initializes a new instance of SymmetricKeyCredentials. </summary>
        /// <param name="key"> Symmetric key credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public SymmetricKeyCredentials(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            Type = "#Microsoft.VideoAnalyzer.SymmetricKeyCredentials";
        }

        /// <summary> Initializes a new instance of SymmetricKeyCredentials. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="key"> Symmetric key credential. </param>
        internal SymmetricKeyCredentials(string type, string key) : base(type)
        {
            Key = key;
            Type = type ?? "#Microsoft.VideoAnalyzer.SymmetricKeyCredentials";
        }

        /// <summary> Symmetric key credential. </summary>
        public string Key { get; set; }
    }
}