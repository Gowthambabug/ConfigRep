// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Optional flags used to change how video is published. These are only
    /// allowed for topologies where "kind" is set to "live".
    /// </summary>
    public partial class VideoPublishingOptions
    {
        /// <summary>
        /// Initializes a new instance of the VideoPublishingOptions class.
        /// </summary>
        public VideoPublishingOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoPublishingOptions class.
        /// </summary>
        /// <param name="disableArchive">When set to 'true' content will not be
        /// archived or recorded. This is used, for example, when the topology
        /// is used only for low latency video streaming. Default is 'false'.
        /// If set to 'true', then "disableRtspPublishing" must be set to
        /// 'false'.</param>
        /// <param name="disableRtspPublishing">When set to 'true' the RTSP
        /// playback URL will not be published, disabling low latency
        /// streaming. This is used, for example, when the topology is used
        /// only for archiving content. Default is 'false'.  If set to 'true',
        /// then "disableArchive" must be set to 'false'.</param>
        public VideoPublishingOptions(string disableArchive = default(string), string disableRtspPublishing = default(string))
        {
            DisableArchive = disableArchive;
            DisableRtspPublishing = disableRtspPublishing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets when set to 'true' content will not be archived or
        /// recorded. This is used, for example, when the topology is used only
        /// for low latency video streaming. Default is 'false'.  If set to
        /// 'true', then "disableRtspPublishing" must be set to 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "disableArchive")]
        public string DisableArchive { get; set; }

        /// <summary>
        /// Gets or sets when set to 'true' the RTSP playback URL will not be
        /// published, disabling low latency streaming. This is used, for
        /// example, when the topology is used only for archiving content.
        /// Default is 'false'.  If set to 'true', then "disableArchive" must
        /// be set to 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "disableRtspPublishing")]
        public string DisableRtspPublishing { get; set; }

    }
}
