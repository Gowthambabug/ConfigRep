// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaByCounterKeysOperations.
    /// </summary>
    public static partial class QuotaByCounterKeysOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of current quota counter periods associated with the
            /// counter-key configured in the policy on the specified service instance. The
            /// api does not support paging yet.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-product-with-rules#a-namepolicies-ato-configure-call-rate-limit-and-quota-policies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            public static QuotaCounterCollection ListByService(this IQuotaByCounterKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey)
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, quotaCounterKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of current quota counter periods associated with the
            /// counter-key configured in the policy on the specified service instance. The
            /// api does not support paging yet.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-product-with-rules#a-namepolicies-ato-configure-call-rate-limit-and-quota-policies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaCounterCollection> ListByServiceAsync(this IQuotaByCounterKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, quotaCounterKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates all the quota counter values specified with the existing quota
            /// counter key to a value in the specified service instance. This should be
            /// used for reset of the quota counter values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='parameters'>
            /// The value of the quota counter to be applied to all quota counter periods.
            /// </param>
            public static QuotaCounterCollection Update(this IQuotaByCounterKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, QuotaCounterValueUpdateContract parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, quotaCounterKey, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates all the quota counter values specified with the existing quota
            /// counter key to a value in the specified service instance. This should be
            /// used for reset of the quota counter values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='quotaCounterKey'>
            /// Quota counter key identifier.This is the result of expression defined in
            /// counter-key attribute of the quota-by-key policy.For Example, if you
            /// specify counter-key="boo" in the policy, then it’s accessible by "boo"
            /// counter key. But if it’s defined as counter-key="@("b"+"a")" then it will
            /// be accessible by "ba" key
            /// </param>
            /// <param name='parameters'>
            /// The value of the quota counter to be applied to all quota counter periods.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaCounterCollection> UpdateAsync(this IQuotaByCounterKeysOperations operations, string resourceGroupName, string serviceName, string quotaCounterKey, QuotaCounterValueUpdateContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, quotaCounterKey, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}