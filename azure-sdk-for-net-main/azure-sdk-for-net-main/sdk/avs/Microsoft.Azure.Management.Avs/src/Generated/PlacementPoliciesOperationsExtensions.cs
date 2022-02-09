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
    /// Extension methods for PlacementPoliciesOperations.
    /// </summary>
    public static partial class PlacementPoliciesOperationsExtensions
    {
            /// <summary>
            /// List placement policies in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            public static IPage<PlacementPolicy> List(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, privateCloudName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List placement policies in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PlacementPolicy>> ListAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a placement policy by name in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            public static PlacementPolicy Get(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a placement policy by name in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlacementPolicy> GetAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicy'>
            /// A placement policy in the private cloud cluster
            /// </param>
            public static PlacementPolicy CreateOrUpdate(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicy'>
            /// A placement policy in the private cloud cluster
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlacementPolicy> CreateOrUpdateAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicyUpdate'>
            /// The placement policy properties that may be updated
            /// </param>
            public static PlacementPolicy Update(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate)
            {
                return operations.UpdateAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicyUpdate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicyUpdate'>
            /// The placement policy properties that may be updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlacementPolicy> UpdateAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicyUpdate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            public static void Delete(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName)
            {
                operations.DeleteAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicy'>
            /// A placement policy in the private cloud cluster
            /// </param>
            public static PlacementPolicy BeginCreateOrUpdate(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicy'>
            /// A placement policy in the private cloud cluster
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlacementPolicy> BeginCreateOrUpdateAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicyUpdate'>
            /// The placement policy properties that may be updated
            /// </param>
            public static PlacementPolicy BeginUpdate(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate)
            {
                return operations.BeginUpdateAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicyUpdate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='placementPolicyUpdate'>
            /// The placement policy properties that may be updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlacementPolicy> BeginUpdateAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, placementPolicyUpdate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            public static void BeginDelete(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName)
            {
                operations.BeginDeleteAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a placement policy in a private cloud cluster
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
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='placementPolicyName'>
            /// Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement
            /// policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPlacementPoliciesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, placementPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List placement policies in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PlacementPolicy> ListNext(this IPlacementPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List placement policies in a private cloud cluster
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
            public static async Task<IPage<PlacementPolicy>> ListNextAsync(this IPlacementPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}