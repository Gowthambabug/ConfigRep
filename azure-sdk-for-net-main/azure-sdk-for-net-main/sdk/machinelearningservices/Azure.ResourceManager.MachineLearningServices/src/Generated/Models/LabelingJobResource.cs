// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Azure Resource Manager resource envelope. </summary>
    public partial class LabelingJobResource
    {
        /// <summary> Initializes a new instance of LabelingJobResource. </summary>
        /// <param name="properties"> Labeling job definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public LabelingJobResource(LabelingJob properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of LabelingJobResource. </summary>
        /// <param name="id"> The resource URL of the entity (not URL encoded). </param>
        /// <param name="name"> The name of the resource entity. </param>
        /// <param name="type"> The resource provider and type. </param>
        /// <param name="properties"> Labeling job definition. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal LabelingJobResource(string id, string name, string type, LabelingJob properties, SystemData systemData)
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> The resource URL of the entity (not URL encoded). </summary>
        public string Id { get; }
        /// <summary> The name of the resource entity. </summary>
        public string Name { get; }
        /// <summary> The resource provider and type. </summary>
        public string Type { get; }
        /// <summary> Labeling job definition. </summary>
        public LabelingJob Properties { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
    }
}
