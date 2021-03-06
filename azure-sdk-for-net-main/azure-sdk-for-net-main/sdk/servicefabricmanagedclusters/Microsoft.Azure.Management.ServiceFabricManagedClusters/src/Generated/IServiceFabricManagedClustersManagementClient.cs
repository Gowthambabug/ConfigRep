// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Service Fabric Managed Clusters Management Client
    /// </summary>
    public partial interface IServiceFabricManagedClustersManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The version of the Service Fabric resource provider API. This is a
        /// required parameter and it's value must be "2021-05-01" for this
        /// specification.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The customer subscription identifier.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IApplicationTypesOperations.
        /// </summary>
        IApplicationTypesOperations ApplicationTypes { get; }

        /// <summary>
        /// Gets the IApplicationTypeVersionsOperations.
        /// </summary>
        IApplicationTypeVersionsOperations ApplicationTypeVersions { get; }

        /// <summary>
        /// Gets the IApplicationsOperations.
        /// </summary>
        IApplicationsOperations Applications { get; }

        /// <summary>
        /// Gets the IServicesOperations.
        /// </summary>
        IServicesOperations Services { get; }

        /// <summary>
        /// Gets the IManagedClustersOperations.
        /// </summary>
        IManagedClustersOperations ManagedClusters { get; }

        /// <summary>
        /// Gets the IManagedClusterVersionOperations.
        /// </summary>
        IManagedClusterVersionOperations ManagedClusterVersion { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the INodeTypesOperations.
        /// </summary>
        INodeTypesOperations NodeTypes { get; }

    }
}
