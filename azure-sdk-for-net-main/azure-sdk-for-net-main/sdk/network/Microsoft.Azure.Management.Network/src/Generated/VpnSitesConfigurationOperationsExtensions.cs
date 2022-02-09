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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VpnSitesConfigurationOperations.
    /// </summary>
    public static partial class VpnSitesConfigurationOperationsExtensions
    {
            /// <summary>
            /// Gives the sas-url to download the configurations for vpn-sites in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which configuration of all vpn-sites is
            /// needed.
            /// </param>
            /// <param name='request'>
            /// Parameters supplied to download vpn-sites configuration.
            /// </param>
            public static void Download(this IVpnSitesConfigurationOperations operations, string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request)
            {
                operations.DownloadAsync(resourceGroupName, virtualWANName, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gives the sas-url to download the configurations for vpn-sites in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which configuration of all vpn-sites is
            /// needed.
            /// </param>
            /// <param name='request'>
            /// Parameters supplied to download vpn-sites configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DownloadAsync(this IVpnSitesConfigurationOperations operations, string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DownloadWithHttpMessagesAsync(resourceGroupName, virtualWANName, request, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gives the sas-url to download the configurations for vpn-sites in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which configuration of all vpn-sites is
            /// needed.
            /// </param>
            /// <param name='request'>
            /// Parameters supplied to download vpn-sites configuration.
            /// </param>
            public static void BeginDownload(this IVpnSitesConfigurationOperations operations, string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request)
            {
                operations.BeginDownloadAsync(resourceGroupName, virtualWANName, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gives the sas-url to download the configurations for vpn-sites in a
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='virtualWANName'>
            /// The name of the VirtualWAN for which configuration of all vpn-sites is
            /// needed.
            /// </param>
            /// <param name='request'>
            /// Parameters supplied to download vpn-sites configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDownloadAsync(this IVpnSitesConfigurationOperations operations, string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDownloadWithHttpMessagesAsync(resourceGroupName, virtualWANName, request, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
