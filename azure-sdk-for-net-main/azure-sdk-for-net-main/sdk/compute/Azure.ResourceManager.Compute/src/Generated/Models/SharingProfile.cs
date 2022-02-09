// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
    public partial class SharingProfile
    {
        /// <summary> Initializes a new instance of SharingProfile. </summary>
        public SharingProfile()
        {
            Groups = new ChangeTrackingList<SharingProfileGroup>();
        }

        /// <summary> Initializes a new instance of SharingProfile. </summary>
        /// <param name="permissions"> This property allows you to specify the permission of sharing gallery. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Private** &lt;br&gt;&lt;br&gt; **Groups**. </param>
        /// <param name="groups"> A list of sharing profile groups. </param>
        internal SharingProfile(GallerySharingPermissionTypes? permissions, IReadOnlyList<SharingProfileGroup> groups)
        {
            Permissions = permissions;
            Groups = groups;
        }

        /// <summary> This property allows you to specify the permission of sharing gallery. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Private** &lt;br&gt;&lt;br&gt; **Groups**. </summary>
        public GallerySharingPermissionTypes? Permissions { get; set; }
        /// <summary> A list of sharing profile groups. </summary>
        public IReadOnlyList<SharingProfileGroup> Groups { get; }
    }
}