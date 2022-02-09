// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AttachedDatabaseConfigurationsOperations operations.
    /// </summary>
    public partial interface IAttachedDatabaseConfigurationsOperations
    {
        /// <summary>
        /// Checks that the attached database configuration resource name is
        /// valid and is not already in use.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
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
        Task<AzureOperationResponse<CheckNameResult>> CheckNameAvailabilityWithHttpMessagesAsync(string resourceGroupName, string clusterName, AttachedDatabaseConfigurationsCheckNameRequest resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the list of attached database configurations of the given
        /// Kusto cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
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
        Task<AzureOperationResponse<IEnumerable<AttachedDatabaseConfiguration>>> ListByClusterWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns an attached database configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
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
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterName, string attachedDatabaseConfigurationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an attached database configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
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
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string attachedDatabaseConfigurationName, AttachedDatabaseConfiguration parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string attachedDatabaseConfigurationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an attached database configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
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
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string attachedDatabaseConfigurationName, AttachedDatabaseConfiguration parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string attachedDatabaseConfigurationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
