// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the Shared Image Gallery that you want to update. </summary>
    public partial class GalleryUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryUpdate. </summary>
        public GalleryUpdate()
        {
        }

        /// <summary> The description of this Shared Image Gallery resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> Describes the gallery unique name. </summary>
        public GalleryIdentifier Identifier { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
        public SharingProfile SharingProfile { get; set; }
        /// <summary> Contains information about the soft deletion policy of the gallery. </summary>
        public SoftDeletePolicy SoftDeletePolicy { get; set; }
    }
}