// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BillingRoleAssignmentsOperations operations.
    /// </summary>
    public partial interface IBillingRoleAssignmentsOperations
    {
        /// <summary>
        /// Gets a role assignment for the caller on a billing account. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByBillingAccountWithHttpMessagesAsync(string billingAccountName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a role assignment for the caller on a billing account. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByBillingAccountWithHttpMessagesAsync(string billingAccountName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a role assignment for the caller on an invoice section. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The ID that uniquely identifies an invoice section.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByInvoiceSectionWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a role assignment for the caller on an invoice section. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The ID that uniquely identifies an invoice section.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByInvoiceSectionWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a role assignment for the caller on a billing profile. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByBillingProfileWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a role assignment for the caller on a billing profile. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// The ID that uniquely identifies a role assignment.
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
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByBillingProfileWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on a billing account. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByBillingAccountWithHttpMessagesAsync(string billingAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on an invoice section.
        /// The operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The ID that uniquely identifies an invoice section.
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByInvoiceSectionWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on a billing profile. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByBillingProfileWithHttpMessagesAsync(string billingAccountName, string billingProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on a billing account. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Partner Agreement or Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByBillingAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on an invoice section.
        /// The operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByInvoiceSectionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the role assignments for the caller on a billing profile. The
        /// operation is supported for billing accounts with agreement type
        /// Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        Task<AzureOperationResponse<IPage<BillingRoleAssignment>>> ListByBillingProfileNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}