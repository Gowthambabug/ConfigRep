// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error message received in an Azure Batch error response.
    /// </summary>
    public partial class ErrorMessage : IPropertyMetadata
    {
        #region Constructors

        internal ErrorMessage(Models.ErrorMessage protocolObject)
        {
            this.Language = protocolObject.Lang;
            this.Value = protocolObject.Value;
        }

        #endregion Constructors

        #region ErrorMessage

        /// <summary>
        /// Gets the language code of the error message.
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Gets the text of the message.
        /// </summary>
        public string Value { get; }

        #endregion // ErrorMessage

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}