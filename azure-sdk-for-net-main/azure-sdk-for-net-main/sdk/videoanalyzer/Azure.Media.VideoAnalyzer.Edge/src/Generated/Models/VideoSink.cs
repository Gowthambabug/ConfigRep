// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Video sink allows for video and audio to be recorded to the Video Analyzer service. The recorded video can be played from anywhere and further managed from the cloud. Due to security reasons, a given Video Analyzer edge module instance can only record content to new video entries, or existing video entries previously recorded by the same module. Any attempt to record content to an existing video which has not been created by the same module instance will result in failure to record. </summary>
    public partial class VideoSink : SinkNodeBase
    {
        /// <summary> Initializes a new instance of VideoSink. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="videoName"> Name of a new or existing Video Analyzer video resource used for the media recording. </param>
        /// <param name="localMediaCachePath"> Path to a local file system directory for caching of temporary media files. This will also be used to store content which cannot be immediately uploaded to Azure due to Internet connectivity issues. </param>
        /// <param name="localMediaCacheMaximumSizeMiB"> Maximum amount of disk space that can be used for caching of temporary media files. Once this limit is reached, the oldest segments of the media archive will be continuously deleted in order to make space for new media, thus leading to gaps in the cloud recorded content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, <paramref name="videoName"/>, <paramref name="localMediaCachePath"/>, or <paramref name="localMediaCacheMaximumSizeMiB"/> is null. </exception>
        public VideoSink(string name, IEnumerable<NodeInput> inputs, string videoName, string localMediaCachePath, string localMediaCacheMaximumSizeMiB) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (videoName == null)
            {
                throw new ArgumentNullException(nameof(videoName));
            }
            if (localMediaCachePath == null)
            {
                throw new ArgumentNullException(nameof(localMediaCachePath));
            }
            if (localMediaCacheMaximumSizeMiB == null)
            {
                throw new ArgumentNullException(nameof(localMediaCacheMaximumSizeMiB));
            }

            VideoName = videoName;
            LocalMediaCachePath = localMediaCachePath;
            LocalMediaCacheMaximumSizeMiB = localMediaCacheMaximumSizeMiB;
            Type = "#Microsoft.VideoAnalyzer.VideoSink";
        }

        /// <summary> Initializes a new instance of VideoSink. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="videoName"> Name of a new or existing Video Analyzer video resource used for the media recording. </param>
        /// <param name="videoCreationProperties"> Optional video properties to be used in case a new video resource needs to be created on the service. </param>
        /// <param name="videoPublishingOptions"> Optional video publishing options to be used for changing publishing behavior of the output video. </param>
        /// <param name="localMediaCachePath"> Path to a local file system directory for caching of temporary media files. This will also be used to store content which cannot be immediately uploaded to Azure due to Internet connectivity issues. </param>
        /// <param name="localMediaCacheMaximumSizeMiB"> Maximum amount of disk space that can be used for caching of temporary media files. Once this limit is reached, the oldest segments of the media archive will be continuously deleted in order to make space for new media, thus leading to gaps in the cloud recorded content. </param>
        internal VideoSink(string type, string name, IList<NodeInput> inputs, string videoName, VideoCreationProperties videoCreationProperties, VideoPublishingOptions videoPublishingOptions, string localMediaCachePath, string localMediaCacheMaximumSizeMiB) : base(type, name, inputs)
        {
            VideoName = videoName;
            VideoCreationProperties = videoCreationProperties;
            VideoPublishingOptions = videoPublishingOptions;
            LocalMediaCachePath = localMediaCachePath;
            LocalMediaCacheMaximumSizeMiB = localMediaCacheMaximumSizeMiB;
            Type = type ?? "#Microsoft.VideoAnalyzer.VideoSink";
        }

        /// <summary> Name of a new or existing Video Analyzer video resource used for the media recording. </summary>
        public string VideoName { get; set; }
        /// <summary> Optional video properties to be used in case a new video resource needs to be created on the service. </summary>
        public VideoCreationProperties VideoCreationProperties { get; set; }
        /// <summary> Optional video publishing options to be used for changing publishing behavior of the output video. </summary>
        public VideoPublishingOptions VideoPublishingOptions { get; set; }
        /// <summary> Path to a local file system directory for caching of temporary media files. This will also be used to store content which cannot be immediately uploaded to Azure due to Internet connectivity issues. </summary>
        public string LocalMediaCachePath { get; set; }
        /// <summary> Maximum amount of disk space that can be used for caching of temporary media files. Once this limit is reached, the oldest segments of the media archive will be continuously deleted in order to make space for new media, thus leading to gaps in the cloud recorded content. </summary>
        public string LocalMediaCacheMaximumSizeMiB { get; set; }
    }
}