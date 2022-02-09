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
using Azure.ResourceManager.EdgeOrder.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _addressResourceClientDiagnostics;
        private EdgeOrderManagementRestOperations _addressResourceRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private EdgeOrderManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _orderItemResourceClientDiagnostics;
        private EdgeOrderManagementRestOperations _orderItemResourceRestClient;

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

        private ClientDiagnostics AddressResourceClientDiagnostics => _addressResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", AddressResource.ResourceType.Namespace, DiagnosticOptions);
        private EdgeOrderManagementRestOperations AddressResourceRestClient => _addressResourceRestClient ??= new EdgeOrderManagementRestOperations(AddressResourceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(AddressResource.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private EdgeOrderManagementRestOperations DefaultRestClient => _defaultRestClient ??= new EdgeOrderManagementRestOperations(DefaultClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics OrderItemResourceClientDiagnostics => _orderItemResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", OrderItemResource.ResourceType.Namespace, DiagnosticOptions);
        private EdgeOrderManagementRestOperations OrderItemResourceRestClient => _orderItemResourceRestClient ??= new EdgeOrderManagementRestOperations(OrderItemResourceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(OrderItemResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            Client.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListAddressesAtSubscriptionLevel
        /// <summary> Lists all the addresses available under the subscription. </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AddressResource> GetAddressResourcesAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AddressResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AddressResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAddressResources");
                scope.Start();
                try
                {
                    var response = await AddressResourceRestClient.ListAddressesAtSubscriptionLevelAsync(Id.SubscriptionId, filter, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AddressResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AddressResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAddressResources");
                scope.Start();
                try
                {
                    var response = await AddressResourceRestClient.ListAddressesAtSubscriptionLevelNextPageAsync(nextLink, Id.SubscriptionId, filter, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListAddressesAtSubscriptionLevel
        /// <summary> Lists all the addresses available under the subscription. </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AddressResource> GetAddressResources(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<AddressResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AddressResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAddressResources");
                scope.Start();
                try
                {
                    var response = AddressResourceRestClient.ListAddressesAtSubscriptionLevel(Id.SubscriptionId, filter, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AddressResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AddressResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAddressResources");
                scope.Start();
                try
                {
                    var response = AddressResourceRestClient.ListAddressesAtSubscriptionLevelNextPage(nextLink, Id.SubscriptionId, filter, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AddressResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListProductFamilies
        /// <summary> This method provides the list of product families for the given subscription. </summary>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductFamily> GetProductFamiliesAsync(ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProductFamily>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamilies");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListProductFamiliesAsync(Id.SubscriptionId, productFamiliesRequest, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProductFamily>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamilies");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListProductFamiliesNextPageAsync(nextLink, Id.SubscriptionId, productFamiliesRequest, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListProductFamilies
        /// <summary> This method provides the list of product families for the given subscription. </summary>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductFamily> GetProductFamilies(ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ProductFamily> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamilies");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListProductFamilies(Id.SubscriptionId, productFamiliesRequest, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProductFamily> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamilies");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListProductFamiliesNextPage(nextLink, Id.SubscriptionId, productFamiliesRequest, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListConfigurations
        /// <summary> This method provides the list of configurations for the given product family, product line and product under subscription. </summary>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductConfiguration> GetConfigurationsAsync(ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProductConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetConfigurations");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListConfigurationsAsync(Id.SubscriptionId, configurationsRequest, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProductConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetConfigurations");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListConfigurationsNextPageAsync(nextLink, Id.SubscriptionId, configurationsRequest, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListConfigurations
        /// <summary> This method provides the list of configurations for the given product family, product line and product under subscription. </summary>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductConfiguration> GetConfigurations(ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ProductConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetConfigurations");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListConfigurations(Id.SubscriptionId, configurationsRequest, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProductConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetConfigurations");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListConfigurationsNextPage(nextLink, Id.SubscriptionId, configurationsRequest, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListProductFamiliesMetadata
        /// <summary> This method provides the list of product families metadata for the given subscription. </summary>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadataAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProductFamiliesMetadataDetails>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamiliesMetadata");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListProductFamiliesMetadataAsync(Id.SubscriptionId, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProductFamiliesMetadataDetails>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamiliesMetadata");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListProductFamiliesMetadataNextPageAsync(nextLink, Id.SubscriptionId, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListProductFamiliesMetadata
        /// <summary> This method provides the list of product families metadata for the given subscription. </summary>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadata(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ProductFamiliesMetadataDetails> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamiliesMetadata");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListProductFamiliesMetadata(Id.SubscriptionId, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProductFamiliesMetadataDetails> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProductFamiliesMetadata");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListProductFamiliesMetadataNextPage(nextLink, Id.SubscriptionId, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListOrderAtSubscriptionLevel
        /// <summary> Lists order at subscription level. </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrderResource> GetOrderResourcesAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OrderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListOrderAtSubscriptionLevelAsync(Id.SubscriptionId, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OrderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.ListOrderAtSubscriptionLevelNextPageAsync(nextLink, Id.SubscriptionId, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListOrderAtSubscriptionLevel
        /// <summary> Lists order at subscription level. </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrderResource> GetOrderResources(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<OrderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListOrderAtSubscriptionLevel(Id.SubscriptionId, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OrderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderResources");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.ListOrderAtSubscriptionLevelNextPage(nextLink, Id.SubscriptionId, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListOrderItemsAtSubscriptionLevel
        /// <summary> Lists order item at subscription level. </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OrderItemResource> GetOrderItemResourcesAsync(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OrderItemResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = OrderItemResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderItemResources");
                scope.Start();
                try
                {
                    var response = await OrderItemResourceRestClient.ListOrderItemsAtSubscriptionLevelAsync(Id.SubscriptionId, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OrderItemResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = OrderItemResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderItemResources");
                scope.Start();
                try
                {
                    var response = await OrderItemResourceRestClient.ListOrderItemsAtSubscriptionLevelNextPageAsync(nextLink, Id.SubscriptionId, filter, expand, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ListOrderItemsAtSubscriptionLevel
        /// <summary> Lists order item at subscription level. </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OrderItemResource> GetOrderItemResources(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<OrderItemResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = OrderItemResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderItemResources");
                scope.Start();
                try
                {
                    var response = OrderItemResourceRestClient.ListOrderItemsAtSubscriptionLevel(Id.SubscriptionId, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OrderItemResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = OrderItemResourceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetOrderItemResources");
                scope.Start();
                try
                {
                    var response = OrderItemResourceRestClient.ListOrderItemsAtSubscriptionLevelNextPage(nextLink, Id.SubscriptionId, filter, expand, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OrderItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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