// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// <summary> A Class representing a ServerBlobAuditingPolicy along with the instance operations that can be performed on it. </summary>
    public partial class ServerBlobAuditingPolicy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerBlobAuditingPolicy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string blobAuditingPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverBlobAuditingPolicyClientDiagnostics;
        private readonly ServerBlobAuditingPoliciesRestOperations _serverBlobAuditingPolicyRestClient;
        private readonly ServerBlobAuditingPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicy"/> class for mocking. </summary>
        protected ServerBlobAuditingPolicy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerBlobAuditingPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerBlobAuditingPolicy(ArmClient client, ServerBlobAuditingPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerBlobAuditingPolicy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverBlobAuditingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string serverBlobAuditingPolicyApiVersion);
            _serverBlobAuditingPolicyRestClient = new ServerBlobAuditingPoliciesRestOperations(_serverBlobAuditingPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverBlobAuditingPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/auditingSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServerBlobAuditingPolicyData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// OperationId: ServerBlobAuditingPolicies_Get
        /// <summary> Gets a server&apos;s blob auditing policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerBlobAuditingPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicy.Get");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverBlobAuditingPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// OperationId: ServerBlobAuditingPolicies_Get
        /// <summary> Gets a server&apos;s blob auditing policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicy.Get");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _serverBlobAuditingPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}