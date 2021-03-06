// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RoutingIntentOperations operations.
    /// </summary>
    public partial interface IRoutingIntentOperations
    {
        /// <summary>
        /// Creates a RoutingIntent resource if it doesn't exist else updates
        /// the existing RoutingIntent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RoutingIntent.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routingIntentName'>
        /// The name of the per VirtualHub singleton Routing Intent resource.
        /// </param>
        /// <param name='routingIntentParameters'>
        /// Parameters supplied to create or update RoutingIntent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RoutingIntent>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routingIntentName, RoutingIntent routingIntentParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of a RoutingIntent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RoutingIntent.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routingIntentName'>
        /// The name of the RoutingIntent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RoutingIntent>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routingIntentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a RoutingIntent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RoutingIntent.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routingIntentName'>
        /// The name of the RoutingIntent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routingIntentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of all RoutingIntent child resources of the
        /// VirtualHub.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RoutingIntent>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a RoutingIntent resource if it doesn't exist else updates
        /// the existing RoutingIntent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RoutingIntent.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routingIntentName'>
        /// The name of the per VirtualHub singleton Routing Intent resource.
        /// </param>
        /// <param name='routingIntentParameters'>
        /// Parameters supplied to create or update RoutingIntent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RoutingIntent>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routingIntentName, RoutingIntent routingIntentParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a RoutingIntent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RoutingIntent.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routingIntentName'>
        /// The name of the RoutingIntent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routingIntentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of all RoutingIntent child resources of the
        /// VirtualHub.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RoutingIntent>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
