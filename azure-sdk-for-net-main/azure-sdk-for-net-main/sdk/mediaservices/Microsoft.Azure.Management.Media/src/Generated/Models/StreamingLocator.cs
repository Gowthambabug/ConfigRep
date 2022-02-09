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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Streaming Locator resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StreamingLocator : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the StreamingLocator class.
        /// </summary>
        public StreamingLocator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingLocator class.
        /// </summary>
        /// <param name="assetName">Asset Name</param>
        /// <param name="streamingPolicyName">Name of the Streaming Policy used
        /// by this Streaming Locator. Either specify the name of Streaming
        /// Policy you created or use one of the predefined Streaming Policies.
        /// The predefined Streaming Policies available are:
        /// 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly',
        /// 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey',
        /// 'Predefined_MultiDrmCencStreaming' and
        /// 'Predefined_MultiDrmStreaming'</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="created">The creation time of the Streaming
        /// Locator.</param>
        /// <param name="startTime">The start time of the Streaming
        /// Locator.</param>
        /// <param name="endTime">The end time of the Streaming
        /// Locator.</param>
        /// <param name="streamingLocatorId">The StreamingLocatorId of the
        /// Streaming Locator.</param>
        /// <param name="defaultContentKeyPolicyName">Name of the default
        /// ContentKeyPolicy used by this Streaming Locator.</param>
        /// <param name="contentKeys">The ContentKeys used by this Streaming
        /// Locator.</param>
        /// <param name="alternativeMediaId">Alternative Media ID of this
        /// Streaming Locator</param>
        /// <param name="filters">A list of asset or account filters which
        /// apply to this streaming locator</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        public StreamingLocator(string assetName, string streamingPolicyName, string id = default(string), string name = default(string), string type = default(string), System.DateTime created = default(System.DateTime), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), System.Guid? streamingLocatorId = default(System.Guid?), string defaultContentKeyPolicyName = default(string), IList<StreamingLocatorContentKey> contentKeys = default(IList<StreamingLocatorContentKey>), string alternativeMediaId = default(string), IList<string> filters = default(IList<string>), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            AssetName = assetName;
            Created = created;
            StartTime = startTime;
            EndTime = endTime;
            StreamingLocatorId = streamingLocatorId;
            StreamingPolicyName = streamingPolicyName;
            DefaultContentKeyPolicyName = defaultContentKeyPolicyName;
            ContentKeys = contentKeys;
            AlternativeMediaId = alternativeMediaId;
            Filters = filters;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets asset Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.assetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Gets the creation time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets or sets the start time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the StreamingLocatorId of the Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamingLocatorId")]
        public System.Guid? StreamingLocatorId { get; set; }

        /// <summary>
        /// Gets or sets name of the Streaming Policy used by this Streaming
        /// Locator. Either specify the name of Streaming Policy you created or
        /// use one of the predefined Streaming Policies. The predefined
        /// Streaming Policies available are: 'Predefined_DownloadOnly',
        /// 'Predefined_ClearStreamingOnly',
        /// 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey',
        /// 'Predefined_MultiDrmCencStreaming' and
        /// 'Predefined_MultiDrmStreaming'
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamingPolicyName")]
        public string StreamingPolicyName { get; set; }

        /// <summary>
        /// Gets or sets name of the default ContentKeyPolicy used by this
        /// Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultContentKeyPolicyName")]
        public string DefaultContentKeyPolicyName { get; set; }

        /// <summary>
        /// Gets or sets the ContentKeys used by this Streaming Locator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentKeys")]
        public IList<StreamingLocatorContentKey> ContentKeys { get; set; }

        /// <summary>
        /// Gets or sets alternative Media ID of this Streaming Locator
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternativeMediaId")]
        public string AlternativeMediaId { get; set; }

        /// <summary>
        /// Gets or sets a list of asset or account filters which apply to this
        /// streaming locator
        /// </summary>
        [JsonProperty(PropertyName = "properties.filters")]
        public IList<string> Filters { get; set; }

        /// <summary>
        /// Gets the system metadata relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssetName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetName");
            }
            if (StreamingPolicyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StreamingPolicyName");
            }
            if (ContentKeys != null)
            {
                foreach (var element in ContentKeys)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}