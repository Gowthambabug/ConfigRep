// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OperationStatusOperations operations.
    /// </summary>
    public partial interface IOperationStatusOperations
    {
        /// <summary>
        /// List Async Operations, currently in progress, in a cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationStatusResult>>> ListWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Async Operation status
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='operationId'>
        /// operation Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationStatusResult>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Async Operations, currently in progress, in a cluster
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationStatusResult>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}