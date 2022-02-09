// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionsOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionsOperations
    {
        /// <summary>
        /// List private endpoint connections
        /// </summary>
        /// <remarks>
        /// List private endpoint connection properties
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<PrivateEndpointConnection>>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get private endpoint connection
        /// </summary>
        /// <remarks>
        /// Get private endpoint connection properties
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update private endpoint connection
        /// </summary>
        /// <remarks>
        /// Update the status of a private endpoint connection with the
        /// specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='properties'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> UpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection
        /// </summary>
        /// <remarks>
        /// Delete private endpoint connection with the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update private endpoint connection
        /// </summary>
        /// <remarks>
        /// Update the status of a private endpoint connection with the
        /// specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='properties'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection
        /// </summary>
        /// <remarks>
        /// Delete private endpoint connection with the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}