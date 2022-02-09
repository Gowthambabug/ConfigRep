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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkProfile and their operations over its parent. </summary>
    public partial class NetworkProfileCollection : ArmCollection, IEnumerable<NetworkProfile>, IAsyncEnumerable<NetworkProfile>
    {
        private readonly ClientDiagnostics _networkProfileClientDiagnostics;
        private readonly NetworkProfilesRestOperations _networkProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkProfileCollection"/> class for mocking. </summary>
        protected NetworkProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkProfile.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkProfile.ResourceType, out string networkProfileApiVersion);
            _networkProfileRestClient = new NetworkProfilesRestOperations(_networkProfileClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkProfileCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string networkProfileName, NetworkProfileData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkProfileCreateOrUpdateOperation(Client, response);
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

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkProfileCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string networkProfileName, NetworkProfileData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkProfileRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, parameters, cancellationToken);
                var operation = new NetworkProfileCreateOrUpdateOperation(Client, response);
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

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public async virtual Task<Response<NetworkProfile>> GetAsync(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkProfileClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkProfile(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public virtual Response<NetworkProfile> Get(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _networkProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, expand, cancellationToken);
                if (response.Value == null)
                    throw _networkProfileClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkProfile(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkProfile" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkProfile> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkProfile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkProfileRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkProfile(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkProfile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkProfileRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkProfile(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkProfile" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkProfile> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkProfile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkProfileRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkProfile(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkProfile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkProfileRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkProfile(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkProfileName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkProfileName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public async virtual Task<Response<NetworkProfile>> GetIfExistsAsync(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkProfile>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkProfile(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkProfileName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkProfileName"/> is null. </exception>
        public virtual Response<NetworkProfile> GetIfExists(string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkProfileName, nameof(networkProfileName));

            using var scope = _networkProfileClientDiagnostics.CreateScope("NetworkProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkProfileName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkProfile>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkProfile(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkProfile> IEnumerable<NetworkProfile>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkProfile> IAsyncEnumerable<NetworkProfile>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}