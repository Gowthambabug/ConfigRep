// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Communication
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region CommunicationService
        /// <summary> Gets an object representing a CommunicationService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunicationService" /> object. </returns>
        public static CommunicationService GetCommunicationService(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                CommunicationService.ValidateResourceId(id);
                return new CommunicationService(client, id);
            }
            );
        }
        #endregion
    }
}