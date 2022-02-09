// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Elastic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TagRulesOperations operations.
    /// </summary>
    public partial interface ITagRulesOperations
    {
        /// <summary>
        /// List the tag rules for a given monitor resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the Elastic resource
        /// belongs.
        /// </param>
        /// <param name='monitorName'>
        /// Monitor resource name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MonitoringTagRules>>> ListWithHttpMessagesAsync(string resourceGroupName, string monitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a tag rule set for a given monitor resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the Elastic resource
        /// belongs.
        /// </param>
        /// <param name='monitorName'>
        /// Monitor resource name
        /// </param>
        /// <param name='ruleSetName'>
        /// Tag Rule Set resource name
        /// </param>
        /// <param name='properties'>
        /// Properties of the monitoring tag rules.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MonitoringTagRules>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string monitorName, string ruleSetName, MonitoringTagRulesProperties properties = default(MonitoringTagRulesProperties), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a tag rule set for a given monitor resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the Elastic resource
        /// belongs.
        /// </param>
        /// <param name='monitorName'>
        /// Monitor resource name
        /// </param>
        /// <param name='ruleSetName'>
        /// Tag Rule Set resource name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MonitoringTagRules>> GetWithHttpMessagesAsync(string resourceGroupName, string monitorName, string ruleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a tag rule set for a given monitor resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the Elastic resource
        /// belongs.
        /// </param>
        /// <param name='monitorName'>
        /// Monitor resource name
        /// </param>
        /// <param name='ruleSetName'>
        /// Tag Rule Set resource name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string monitorName, string ruleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a tag rule set for a given monitor resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the Elastic resource
        /// belongs.
        /// </param>
        /// <param name='monitorName'>
        /// Monitor resource name
        /// </param>
        /// <param name='ruleSetName'>
        /// Tag Rule Set resource name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string monitorName, string ruleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List the tag rules for a given monitor resource.
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
        /// <exception cref="ResourceProviderDefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MonitoringTagRules>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}