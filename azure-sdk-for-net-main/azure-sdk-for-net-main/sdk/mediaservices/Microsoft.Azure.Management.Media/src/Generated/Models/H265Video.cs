// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes all the properties for encoding a video with the H.265 codec.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.H265Video")]
    public partial class H265Video : Video
    {
        /// <summary>
        /// Initializes a new instance of the H265Video class.
        /// </summary>
        public H265Video()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the H265Video class.
        /// </summary>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="keyFrameInterval">The distance between two key frames.
        /// The value should be non-zero in the range [0.5, 20] seconds,
        /// specified in ISO 8601 format. The default is 2 seconds(PT2S). Note
        /// that this setting is ignored if VideoSyncMode.Passthrough is set,
        /// where the KeyFrameInterval value will follow the input source
        /// setting.</param>
        /// <param name="stretchMode">The resizing mode - how the input video
        /// will be resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize',
        /// 'AutoFit'</param>
        /// <param name="syncMode">The Video Sync Mode. Possible values
        /// include: 'Auto', 'Passthrough', 'Cfr', 'Vfr'</param>
        /// <param name="sceneChangeDetection">Specifies whether or not the
        /// encoder should insert key frames at scene changes. If not
        /// specified, the default is false. This flag should be set to true
        /// only when the encoder is being configured to produce a single
        /// output video.</param>
        /// <param name="complexity">Tells the encoder how to choose its
        /// encoding settings.  Quality will provide for a higher compression
        /// ratio but at a higher cost and longer compute time.  Speed will
        /// produce a relatively larger file but is faster and more economical.
        /// The default value is Balanced. Possible values include: 'Speed',
        /// 'Balanced', 'Quality'</param>
        /// <param name="layers">The collection of output H.265 layers to be
        /// produced by the encoder.</param>
        public H265Video(string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), VideoSyncMode? syncMode = default(VideoSyncMode?), bool? sceneChangeDetection = default(bool?), H265Complexity? complexity = default(H265Complexity?), IList<H265Layer> layers = default(IList<H265Layer>))
            : base(label, keyFrameInterval, stretchMode, syncMode)
        {
            SceneChangeDetection = sceneChangeDetection;
            Complexity = complexity;
            Layers = layers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether or not the encoder should insert key
        /// frames at scene changes. If not specified, the default is false.
        /// This flag should be set to true only when the encoder is being
        /// configured to produce a single output video.
        /// </summary>
        [JsonProperty(PropertyName = "sceneChangeDetection")]
        public bool? SceneChangeDetection { get; set; }

        /// <summary>
        /// Gets or sets tells the encoder how to choose its encoding settings.
        /// Quality will provide for a higher compression ratio but at a higher
        /// cost and longer compute time.  Speed will produce a relatively
        /// larger file but is faster and more economical. The default value is
        /// Balanced. Possible values include: 'Speed', 'Balanced', 'Quality'
        /// </summary>
        [JsonProperty(PropertyName = "complexity")]
        public H265Complexity? Complexity { get; set; }

        /// <summary>
        /// Gets or sets the collection of output H.265 layers to be produced
        /// by the encoder.
        /// </summary>
        [JsonProperty(PropertyName = "layers")]
        public IList<H265Layer> Layers { get; set; }

    }
}