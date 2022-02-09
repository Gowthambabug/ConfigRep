// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Cognitive Services Management Client
    /// </summary>
    public partial interface ICognitiveServicesManagementClient : System.IDisposable
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
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; }

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
        /// Gets the IAccountsOperations.
        /// </summary>
        IAccountsOperations Accounts { get; }

        /// <summary>
        /// Gets the IDeletedAccountsOperations.
        /// </summary>
        IDeletedAccountsOperations DeletedAccounts { get; }

        /// <summary>
        /// Gets the IResourceSkusOperations.
        /// </summary>
        IResourceSkusOperations ResourceSkus { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ICommitmentTiersOperations.
        /// </summary>
        ICommitmentTiersOperations CommitmentTiers { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IDeploymentsOperations.
        /// </summary>
        IDeploymentsOperations Deployments { get; }

        /// <summary>
        /// Gets the ICommitmentPlansOperations.
        /// </summary>
        ICommitmentPlansOperations CommitmentPlans { get; }

        /// <summary>
        /// Check available SKUs.
        /// </summary>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        /// <param name='skus'>
        /// The SKU of the resource.
        /// </param>
        /// <param name='kind'>
        /// The Kind of the resource.
        /// </param>
        /// <param name='type'>
        /// The Type of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SkuAvailabilityListResult>> CheckSkuAvailabilityWithHttpMessagesAsync(string location, IList<string> skus, string kind, string type, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check whether a domain is available.
        /// </summary>
        /// <param name='subdomainName'>
        /// The subdomain name to use.
        /// </param>
        /// <param name='type'>
        /// The Type of the resource.
        /// </param>
        /// <param name='kind'>
        /// The Kind of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DomainAvailability>> CheckDomainAvailabilityWithHttpMessagesAsync(string subdomainName, string type, string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}