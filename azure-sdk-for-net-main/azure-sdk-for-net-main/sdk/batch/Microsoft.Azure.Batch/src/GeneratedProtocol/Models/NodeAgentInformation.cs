// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the Compute Node agent.
    /// </summary>
    /// <remarks>
    /// The Batch Compute Node agent is a program that runs on each Compute
    /// Node in the Pool and provides Batch capability on the Compute Node.
    /// </remarks>
    public partial class NodeAgentInformation
    {
        /// <summary>
        /// Initializes a new instance of the NodeAgentInformation class.
        /// </summary>
        public NodeAgentInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeAgentInformation class.
        /// </summary>
        /// <param name="version">The version of the Batch Compute Node agent
        /// running on the Compute Node.</param>
        /// <param name="lastUpdateTime">The time when the Compute Node agent
        /// was updated on the Compute Node.</param>
        public NodeAgentInformation(string version, System.DateTime lastUpdateTime)
        {
            Version = version;
            LastUpdateTime = lastUpdateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the Batch Compute Node agent running on
        /// the Compute Node.
        /// </summary>
        /// <remarks>
        /// This version number can be checked against the Compute Node agent
        /// release notes located at
        /// https://github.com/Azure/Batch/blob/master/changelogs/nodeagent/CHANGELOG.md.
        /// </remarks>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the time when the Compute Node agent was updated on
        /// the Compute Node.
        /// </summary>
        /// <remarks>
        /// This is the most recent time that the Compute Node agent was
        /// updated to a new version.
        /// </remarks>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

    }
}
