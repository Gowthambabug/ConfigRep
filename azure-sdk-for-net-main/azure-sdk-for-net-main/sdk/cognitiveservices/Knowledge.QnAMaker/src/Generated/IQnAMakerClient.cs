// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// An API for QnAMaker Service
    /// </summary>
    public partial interface IQnAMakerClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Cognitive Services endpoint (e.g., https://&lt;
        /// qnamaker-resource-name &gt;.api.cognitiveservices.azure.com).
        /// </summary>
        string Endpoint { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IEndpointSettings.
        /// </summary>
        IEndpointSettings EndpointSettings { get; }

        /// <summary>
        /// Gets the IEndpointKeys.
        /// </summary>
        IEndpointKeys EndpointKeys { get; }

        /// <summary>
        /// Gets the IAlterations.
        /// </summary>
        IAlterations Alterations { get; }

        /// <summary>
        /// Gets the IKnowledgebase.
        /// </summary>
        IKnowledgebase Knowledgebase { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

    }
}