// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachine and their operations over its parent. </summary>
    public partial class VirtualMachineCollection : ArmCollection, IEnumerable<VirtualMachine>, IAsyncEnumerable<VirtualMachine>
    {
        private readonly ClientDiagnostics _virtualMachineClientDiagnostics;
        private readonly VirtualMachinesRestOperations _virtualMachineRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class for mocking. </summary>
        protected VirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachine.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VirtualMachine.ResourceType, out string virtualMachineApiVersion);
            _virtualMachineRestClient = new VirtualMachinesRestOperations(_virtualMachineClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualMachineCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string vmName, VirtualMachineData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineCreateOrUpdateOperation(Client, _virtualMachineClientDiagnostics, Pipeline, _virtualMachineRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualMachineCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string vmName, VirtualMachineData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters, cancellationToken);
                var operation = new VirtualMachineCreateOrUpdateOperation(Client, _virtualMachineClientDiagnostics, Pipeline, _virtualMachineRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the model view or the instance view of a virtual machine. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachine>> GetAsync(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualMachineClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the model view or the instance view of a virtual machine. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<VirtualMachine> Get(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmName, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualMachineClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the virtual machines in the specified resource group. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachine> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachine>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachine>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the virtual machines in the specified resource group. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachine> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachine> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachine> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachine>> GetIfExistsAsync(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the virtual machine that is managed by the platform and can change outside of control plane operations. &apos;UserData&apos; retrieves the UserData property as part of the VM model view that was provided by the user during the VM Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<VirtualMachine> GetIfExists(string vmName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachine> IEnumerable<VirtualMachine>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachine> IAsyncEnumerable<VirtualMachine>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}