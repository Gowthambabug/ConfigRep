// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _vaultClientDiagnostics;
        private VaultsRestOperations _vaultRestClient;
        private ClientDiagnostics _vaultsClientDiagnostics;
        private VaultsRestOperations _vaultsRestClient;
        private ClientDiagnostics _managedHsmClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmRestClient;
        private ClientDiagnostics _managedHsmsClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics VaultClientDiagnostics => _vaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", Vault.ResourceType.Namespace, DiagnosticOptions);
        private VaultsRestOperations VaultRestClient => _vaultRestClient ??= new VaultsRestOperations(VaultClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(Vault.ResourceType));
        private ClientDiagnostics VaultsClientDiagnostics => _vaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private VaultsRestOperations VaultsRestClient => _vaultsRestClient ??= new VaultsRestOperations(VaultsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ManagedHsmClientDiagnostics => _managedHsmClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ManagedHsm.ResourceType.Namespace, DiagnosticOptions);
        private ManagedHsmsRestOperations ManagedHsmRestClient => _managedHsmRestClient ??= new ManagedHsmsRestOperations(ManagedHsmClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ManagedHsm.ResourceType));
        private ClientDiagnostics ManagedHsmsClientDiagnostics => _managedHsmsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ManagedHsmsRestOperations ManagedHsmsRestClient => _managedHsmsRestClient ??= new ManagedHsmsRestOperations(ManagedHsmsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            Client.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedVaults in the DeletedVault. </summary>
        /// <returns> An object representing collection of DeletedVaults and their operations over a DeletedVault. </returns>
        public virtual DeletedVaultCollection GetDeletedVaults()
        {
            return new DeletedVaultCollection(Client, Id);
        }

        /// <summary> Gets a collection of DeletedManagedHsms in the DeletedManagedHsm. </summary>
        /// <returns> An object representing collection of DeletedManagedHsms and their operations over a DeletedManagedHsm. </returns>
        public virtual DeletedManagedHsmCollection GetDeletedManagedHsms()
        {
            return new DeletedManagedHsmCollection(Client, Id);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListBySubscription
        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Vault> GetVaultsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = await VaultRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = await VaultRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListBySubscription
        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Vault> GetVaults(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = VaultRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVaults");
                scope.Start();
                try
                {
                    var response = VaultRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListDeleted
        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedVault" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedVault> GetDeletedVaultsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedVault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = await VaultsRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedVault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = await VaultsRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListDeleted
        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedVault" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedVault> GetDeletedVaults(CancellationToken cancellationToken = default)
        {
            Page<DeletedVault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = VaultsRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedVault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedVaults");
                scope.Start();
                try
                {
                    var response = VaultsRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedVault(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_CheckNameAvailability
        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CheckNameAvailabilityResult>> CheckKeyVaultNameAvailabilityAsync(VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = await VaultsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, vaultName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_CheckNameAvailability
        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckKeyVaultNameAvailability(VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = VaultsClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = VaultsRestClient.CheckNameAvailability(Id.SubscriptionId, vaultName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListBySubscription
        /// <summary> The List operation gets information about the managed HSM Pools associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedHsm> GetManagedHsmsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedHsm>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedHsm>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListBySubscription
        /// <summary> The List operation gets information about the managed HSM Pools associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedHsm> GetManagedHsms(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedHsm> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedHsm> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListDeleted
        /// <summary> The List operation gets information about the deleted managed HSMs associated with the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedManagedHsm> GetDeletedManagedHsmsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedManagedHsm>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmsRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedManagedHsm>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = await ManagedHsmsRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListDeleted
        /// <summary> The List operation gets information about the deleted managed HSMs associated with the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedManagedHsm> GetDeletedManagedHsms(CancellationToken cancellationToken = default)
        {
            Page<DeletedManagedHsm> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmsRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedManagedHsm> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedHsmsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedManagedHsms");
                scope.Start();
                try
                {
                    var response = ManagedHsmsRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedManagedHsm(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}