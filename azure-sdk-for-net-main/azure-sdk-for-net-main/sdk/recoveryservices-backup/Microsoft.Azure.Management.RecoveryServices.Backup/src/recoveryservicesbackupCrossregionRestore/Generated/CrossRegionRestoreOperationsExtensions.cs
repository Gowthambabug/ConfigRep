// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CrossRegionRestoreOperations.
    /// </summary>
    public static partial class CrossRegionRestoreOperationsExtensions
    {
            /// <summary>
            /// Restores the specified backed up data in a different region as compared to
            /// where the data is backed up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// resource cross region restore request
            /// </param>
            public static void Trigger(this ICrossRegionRestoreOperations operations, string azureRegion, CrossRegionRestoreRequest parameters)
            {
                operations.TriggerAsync(azureRegion, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restores the specified backed up data in a different region as compared to
            /// where the data is backed up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// resource cross region restore request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TriggerAsync(this ICrossRegionRestoreOperations operations, string azureRegion, CrossRegionRestoreRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TriggerWithHttpMessagesAsync(azureRegion, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restores the specified backed up data in a different region as compared to
            /// where the data is backed up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// resource cross region restore request
            /// </param>
            public static void BeginTrigger(this ICrossRegionRestoreOperations operations, string azureRegion, CrossRegionRestoreRequest parameters)
            {
                operations.BeginTriggerAsync(azureRegion, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restores the specified backed up data in a different region as compared to
            /// where the data is backed up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// resource cross region restore request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginTriggerAsync(this ICrossRegionRestoreOperations operations, string azureRegion, CrossRegionRestoreRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginTriggerWithHttpMessagesAsync(azureRegion, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
