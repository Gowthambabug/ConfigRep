// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GatewayHostnameConfigurationOperations operations.
    /// </summary>
    public partial interface IGatewayHostnameConfigurationOperations
    {
        /// <summary>
        /// Lists the collection of hostname configurations for the specified
        /// gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<GatewayHostnameConfigurationContract>>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, ODataQuery<GatewayHostnameConfigurationContract> odataQuery = default(ODataQuery<GatewayHostnameConfigurationContract>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks that hostname configuration entity specified by identifier
        /// exists for specified Gateway entity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<GatewayHostnameConfigurationGetEntityTagHeaders>> GetEntityTagWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get details of a hostname configuration
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
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
        Task<AzureOperationResponse<GatewayHostnameConfigurationContract,GatewayHostnameConfigurationGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
        /// </param>
        /// <param name='parameters'>
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. Not required when creating an entity, but
        /// required when updating an entity.
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
        Task<AzureOperationResponse<GatewayHostnameConfigurationContract,GatewayHostnameConfigurationCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, GatewayHostnameConfigurationContract parameters, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified hostname configuration from the specified
        /// Gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the collection of hostname configurations for the specified
        /// gateway.
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
        Task<AzureOperationResponse<IPage<GatewayHostnameConfigurationContract>>> ListByServiceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}