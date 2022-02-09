// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.MachineLearningServices.ModelDeployed event. </summary>
    public partial class MachineLearningServicesModelDeployedEventData
    {
        /// <summary> Initializes a new instance of MachineLearningServicesModelDeployedEventData. </summary>
        internal MachineLearningServicesModelDeployedEventData()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningServicesModelDeployedEventData. </summary>
        /// <param name="serviceName"> The name of the deployed service. </param>
        /// <param name="serviceComputeType"> The compute type (e.g. ACI, AKS) of the deployed service. </param>
        /// <param name="modelIds"> A common separated list of model IDs. The IDs of the models deployed in the service. </param>
        /// <param name="serviceTags"> The tags of the deployed service. </param>
        /// <param name="serviceProperties"> The properties of the deployed service. </param>
        internal MachineLearningServicesModelDeployedEventData(string serviceName, string serviceComputeType, string modelIds, object serviceTags, object serviceProperties)
        {
            ServiceName = serviceName;
            ServiceComputeType = serviceComputeType;
            ModelIds = modelIds;
            ServiceTags = serviceTags;
            ServiceProperties = serviceProperties;
        }

        /// <summary> The name of the deployed service. </summary>
        public string ServiceName { get; }
        /// <summary> The compute type (e.g. ACI, AKS) of the deployed service. </summary>
        public string ServiceComputeType { get; }
        /// <summary> A common separated list of model IDs. The IDs of the models deployed in the service. </summary>
        public string ModelIds { get; }
        /// <summary> The tags of the deployed service. </summary>
        public object ServiceTags { get; }
        /// <summary> The properties of the deployed service. </summary>
        public object ServiceProperties { get; }
    }
}