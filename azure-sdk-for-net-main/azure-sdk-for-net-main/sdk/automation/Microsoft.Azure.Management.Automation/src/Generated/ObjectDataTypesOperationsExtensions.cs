// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ObjectDataTypesOperations.
    /// </summary>
    public static partial class ObjectDataTypesOperationsExtensions
    {
            /// <summary>
            /// Retrieve a list of fields of a given type identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/objectdatatypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            /// <param name='typeName'>
            /// The name of type.
            /// </param>
            public static IEnumerable<TypeField> ListFieldsByModuleAndType(this IObjectDataTypesOperations operations, string resourceGroupName, string automationAccountName, string moduleName, string typeName)
            {
                return operations.ListFieldsByModuleAndTypeAsync(resourceGroupName, automationAccountName, moduleName, typeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of fields of a given type identified by module name.
            /// <see href="http://aka.ms/azureautomationsdk/objectdatatypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='moduleName'>
            /// The name of module.
            /// </param>
            /// <param name='typeName'>
            /// The name of type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<TypeField>> ListFieldsByModuleAndTypeAsync(this IObjectDataTypesOperations operations, string resourceGroupName, string automationAccountName, string moduleName, string typeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFieldsByModuleAndTypeWithHttpMessagesAsync(resourceGroupName, automationAccountName, moduleName, typeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of fields of a given type across all accessible modules.
            /// <see href="http://aka.ms/azureautomationsdk/objectdatatypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='typeName'>
            /// The name of type.
            /// </param>
            public static IEnumerable<TypeField> ListFieldsByType(this IObjectDataTypesOperations operations, string resourceGroupName, string automationAccountName, string typeName)
            {
                return operations.ListFieldsByTypeAsync(resourceGroupName, automationAccountName, typeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of fields of a given type across all accessible modules.
            /// <see href="http://aka.ms/azureautomationsdk/objectdatatypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='typeName'>
            /// The name of type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<TypeField>> ListFieldsByTypeAsync(this IObjectDataTypesOperations operations, string resourceGroupName, string automationAccountName, string typeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFieldsByTypeWithHttpMessagesAsync(resourceGroupName, automationAccountName, typeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
