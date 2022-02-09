// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceFabricsOperations.
    /// </summary>
    public static partial class ServiceFabricsOperationsExtensions
    {
            /// <summary>
            /// List service fabrics in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ServiceFabric> List(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, ODataQuery<ServiceFabric> odataQuery = default(ODataQuery<ServiceFabric>))
            {
                return operations.ListAsync(resourceGroupName, labName, userName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List service fabrics in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceFabric>> ListAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, ODataQuery<ServiceFabric> odataQuery = default(ODataQuery<ServiceFabric>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, userName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get service fabric.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($expand=applicableSchedule)'
            /// </param>
            public static ServiceFabric Get(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, labName, userName, name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get service fabric.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($expand=applicableSchedule)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceFabric> GetAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, userName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Service Fabric. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            public static ServiceFabric CreateOrUpdate(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabric serviceFabric)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, labName, userName, name, serviceFabric).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Service Fabric. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceFabric> CreateOrUpdateAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabric serviceFabric, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, serviceFabric, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void Delete(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.DeleteAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Modify properties of service fabrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            public static ServiceFabric Update(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabricFragment serviceFabric)
            {
                return operations.UpdateAsync(resourceGroupName, labName, userName, name, serviceFabric).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify properties of service fabrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceFabric> UpdateAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabricFragment serviceFabric, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, serviceFabric, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the applicable start/stop schedules, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static ApplicableSchedule ListApplicableSchedules(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                return operations.ListApplicableSchedulesAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the applicable start/stop schedules, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicableSchedule> ListApplicableSchedulesAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListApplicableSchedulesWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Start a service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void Start(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.StartAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start a service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stop a service fabric This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void Stop(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.StopAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stop a service fabric This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or replace an existing Service Fabric. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            public static ServiceFabric BeginCreateOrUpdate(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabric serviceFabric)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, labName, userName, name, serviceFabric).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Service Fabric. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='serviceFabric'>
            /// A Service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceFabric> BeginCreateOrUpdateAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, ServiceFabric serviceFabric, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, serviceFabric, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void BeginDelete(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Start a service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void BeginStart(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.BeginStartAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start a service fabric. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stop a service fabric This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            public static void BeginStop(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.BeginStopAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stop a service fabric This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the service Fabric.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IServiceFabricsOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List service fabrics in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceFabric> ListNext(this IServiceFabricsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List service fabrics in a given user profile.
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
            public static async Task<IPage<ServiceFabric>> ListNextAsync(this IServiceFabricsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
