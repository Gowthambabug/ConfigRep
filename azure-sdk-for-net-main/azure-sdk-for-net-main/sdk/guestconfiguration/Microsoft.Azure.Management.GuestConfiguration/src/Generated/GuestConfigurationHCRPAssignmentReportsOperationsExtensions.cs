// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GuestConfigurationHCRPAssignmentReportsOperations.
    /// </summary>
    public static partial class GuestConfigurationHCRPAssignmentReportsOperationsExtensions
    {
            /// <summary>
            /// List all reports for the guest configuration assignment, latest report
            /// first.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='machineName'>
            /// The name of the ARC machine.
            /// </param>
            public static GuestConfigurationAssignmentReportList List(this IGuestConfigurationHCRPAssignmentReportsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string machineName)
            {
                return operations.ListAsync(resourceGroupName, guestConfigurationAssignmentName, machineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all reports for the guest configuration assignment, latest report
            /// first.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='machineName'>
            /// The name of the ARC machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignmentReportList> ListAsync(this IGuestConfigurationHCRPAssignmentReportsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string machineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, guestConfigurationAssignmentName, machineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a report for the guest configuration assignment, by reportId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='reportId'>
            /// The GUID for the guest configuration assignment report.
            /// </param>
            /// <param name='machineName'>
            /// The name of the ARC machine.
            /// </param>
            public static GuestConfigurationAssignmentReport Get(this IGuestConfigurationHCRPAssignmentReportsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string reportId, string machineName)
            {
                return operations.GetAsync(resourceGroupName, guestConfigurationAssignmentName, reportId, machineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a report for the guest configuration assignment, by reportId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='reportId'>
            /// The GUID for the guest configuration assignment report.
            /// </param>
            /// <param name='machineName'>
            /// The name of the ARC machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignmentReport> GetAsync(this IGuestConfigurationHCRPAssignmentReportsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string reportId, string machineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, guestConfigurationAssignmentName, reportId, machineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
