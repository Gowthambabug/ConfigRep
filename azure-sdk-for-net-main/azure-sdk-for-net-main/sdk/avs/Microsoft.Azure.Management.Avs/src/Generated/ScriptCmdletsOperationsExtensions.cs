// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScriptCmdletsOperations.
    /// </summary>
    public static partial class ScriptCmdletsOperationsExtensions
    {
            /// <summary>
            /// List script cmdlet resources available for a private cloud to create a
            /// script execution resource on a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='scriptPackageName'>
            /// Name of the script package in the private cloud
            /// </param>
            public static IPage<ScriptCmdlet> List(this IScriptCmdletsOperations operations, string resourceGroupName, string privateCloudName, string scriptPackageName)
            {
                return operations.ListAsync(resourceGroupName, privateCloudName, scriptPackageName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List script cmdlet resources available for a private cloud to create a
            /// script execution resource on a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='scriptPackageName'>
            /// Name of the script package in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ScriptCmdlet>> ListAsync(this IScriptCmdletsOperations operations, string resourceGroupName, string privateCloudName, string scriptPackageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateCloudName, scriptPackageName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return information about a script cmdlet resource in a specific package on
            /// a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='scriptPackageName'>
            /// Name of the script package in the private cloud
            /// </param>
            /// <param name='scriptCmdletName'>
            /// Name of the script cmdlet resource in the script package in the private
            /// cloud
            /// </param>
            public static ScriptCmdlet Get(this IScriptCmdletsOperations operations, string resourceGroupName, string privateCloudName, string scriptPackageName, string scriptCmdletName)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName, scriptPackageName, scriptCmdletName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return information about a script cmdlet resource in a specific package on
            /// a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='scriptPackageName'>
            /// Name of the script package in the private cloud
            /// </param>
            /// <param name='scriptCmdletName'>
            /// Name of the script cmdlet resource in the script package in the private
            /// cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScriptCmdlet> GetAsync(this IScriptCmdletsOperations operations, string resourceGroupName, string privateCloudName, string scriptPackageName, string scriptCmdletName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, scriptPackageName, scriptCmdletName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List script cmdlet resources available for a private cloud to create a
            /// script execution resource on a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ScriptCmdlet> ListNext(this IScriptCmdletsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List script cmdlet resources available for a private cloud to create a
            /// script execution resource on a private cloud
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
            public static async Task<IPage<ScriptCmdlet>> ListNextAsync(this IScriptCmdletsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}