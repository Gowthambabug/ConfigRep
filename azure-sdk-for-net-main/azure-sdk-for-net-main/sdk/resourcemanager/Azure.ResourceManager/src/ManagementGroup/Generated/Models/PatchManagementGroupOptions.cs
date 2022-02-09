// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Management group patch parameters. </summary>
    public partial class PatchManagementGroupOptions
    {
        /// <summary> Initializes a new instance of PatchManagementGroupOptions. </summary>
        public PatchManagementGroupOptions()
        {
        }

        /// <summary> The friendly name of the management group. </summary>
        public string DisplayName { get; set; }
        /// <summary> (Optional) The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string ParentGroupId { get; set; }
    }
}
