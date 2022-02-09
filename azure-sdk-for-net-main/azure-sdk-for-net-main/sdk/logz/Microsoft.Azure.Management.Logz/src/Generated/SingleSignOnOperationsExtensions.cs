// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logz
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SingleSignOnOperations.
    /// </summary>
    public static partial class SingleSignOnOperationsExtensions
    {
            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            public static IPage<LogzSingleSignOnResource> List(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName)
            {
                return operations.ListAsync(resourceGroupName, monitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LogzSingleSignOnResource>> ListAsync(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, monitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static LogzSingleSignOnResource CreateOrUpdate(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName, LogzSingleSignOnResource body = default(LogzSingleSignOnResource))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, monitorName, configurationName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogzSingleSignOnResource> CreateOrUpdateAsync(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName, LogzSingleSignOnResource body = default(LogzSingleSignOnResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Logz single sign-on resource for the given Monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            public static LogzSingleSignOnResource Get(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, monitorName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Logz single sign-on resource for the given Monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogzSingleSignOnResource> GetAsync(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static LogzSingleSignOnResource BeginCreateOrUpdate(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName, LogzSingleSignOnResource body = default(LogzSingleSignOnResource))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, monitorName, configurationName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogzSingleSignOnResource> BeginCreateOrUpdateAsync(this ISingleSignOnOperations operations, string resourceGroupName, string monitorName, string configurationName, LogzSingleSignOnResource body = default(LogzSingleSignOnResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LogzSingleSignOnResource> ListNext(this ISingleSignOnOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LogzSingleSignOnResource>> ListNextAsync(this ISingleSignOnOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}