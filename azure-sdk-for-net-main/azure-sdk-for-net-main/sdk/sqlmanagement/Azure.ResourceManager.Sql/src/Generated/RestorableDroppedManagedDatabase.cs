// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a RestorableDroppedManagedDatabase along with the instance operations that can be performed on it. </summary>
    public partial class RestorableDroppedManagedDatabase : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorableDroppedManagedDatabase"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorableDroppedManagedDatabaseClientDiagnostics;
        private readonly RestorableDroppedManagedDatabasesRestOperations _restorableDroppedManagedDatabaseRestClient;
        private readonly RestorableDroppedManagedDatabaseData _data;

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabase"/> class for mocking. </summary>
        protected RestorableDroppedManagedDatabase()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RestorableDroppedManagedDatabase"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorableDroppedManagedDatabase(ArmClient client, RestorableDroppedManagedDatabaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabase"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorableDroppedManagedDatabase(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDroppedManagedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string restorableDroppedManagedDatabaseApiVersion);
            _restorableDroppedManagedDatabaseRestClient = new RestorableDroppedManagedDatabasesRestOperations(_restorableDroppedManagedDatabaseClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorableDroppedManagedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/restorableDroppedDatabases";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorableDroppedManagedDatabaseData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ManagedRestorableDroppedDbBackupShortTermRetentionPolicies in the ManagedRestorableDroppedDbBackupShortTermRetentionPolicy. </summary>
        /// <returns> An object representing collection of ManagedRestorableDroppedDbBackupShortTermRetentionPolicies and their operations over a ManagedRestorableDroppedDbBackupShortTermRetentionPolicy. </returns>
        public virtual ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection GetManagedRestorableDroppedDbBackupShortTermRetentionPolicies()
        {
            return new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection(Client, Id);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Gets a restorable dropped managed database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _restorableDroppedManagedDatabaseClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Gets a restorable dropped managed database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableDroppedManagedDatabase> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _restorableDroppedManagedDatabaseClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabase> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabase> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<RestorableDroppedManagedDatabase>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: RestorableDroppedManagedDatabases_Get
        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<RestorableDroppedManagedDatabase> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabase.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new RestorableDroppedManagedDatabase(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}