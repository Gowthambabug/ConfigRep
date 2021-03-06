// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceRegistriesOperations.
    /// </summary>
    public static partial class ServiceRegistriesOperationsExtensions
    {
            /// <summary>
            /// Get the Service Registry and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            public static ServiceRegistryResource Get(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, serviceRegistryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the Service Registry and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRegistryResource> GetAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, serviceRegistryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the default Service Registry or update the existing Service
            /// Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            public static ServiceRegistryResource CreateOrUpdate(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, serviceRegistryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the default Service Registry or update the existing Service
            /// Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRegistryResource> CreateOrUpdateAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, serviceRegistryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disable the default Service Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            public static void Delete(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, serviceRegistryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disable the default Service Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, serviceRegistryName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Handles requests to list all resources in a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static IPage<ServiceRegistryResource> List(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceRegistryResource>> ListAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the default Service Registry or update the existing Service
            /// Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            public static ServiceRegistryResource BeginCreateOrUpdate(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, serviceRegistryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the default Service Registry or update the existing Service
            /// Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceRegistryResource> BeginCreateOrUpdateAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, serviceRegistryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disable the default Service Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            public static void BeginDelete(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceName, serviceRegistryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disable the default Service Registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='serviceRegistryName'>
            /// The name of Service Registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServiceRegistriesOperations operations, string resourceGroupName, string serviceName, string serviceRegistryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceName, serviceRegistryName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Handles requests to list all resources in a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceRegistryResource> ListNext(this IServiceRegistriesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a Service.
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
            public static async Task<IPage<ServiceRegistryResource>> ListNextAsync(this IServiceRegistriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
