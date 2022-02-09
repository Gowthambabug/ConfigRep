// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> object used for creating workspace connection. </summary>
    public partial class WorkspaceConnectionDto
    {
        /// <summary> Initializes a new instance of WorkspaceConnectionDto. </summary>
        public WorkspaceConnectionDto()
        {
        }

        /// <summary> Friendly name of the workspace connection. </summary>
        public string Name { get; set; }
        /// <summary> Category of the workspace connection. </summary>
        public string Category { get; set; }
        /// <summary> Target of the workspace connection. </summary>
        public string Target { get; set; }
        /// <summary> Authorization type of the workspace connection. </summary>
        public string AuthType { get; set; }
        /// <summary> Value details of the workspace connection. </summary>
        public string Value { get; set; }
    }
}