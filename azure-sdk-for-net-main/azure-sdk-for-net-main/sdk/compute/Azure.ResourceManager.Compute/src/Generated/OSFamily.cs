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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a OSFamily along with the instance operations that can be performed on it. </summary>
    public partial class OSFamily : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OSFamily"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string osFamilyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _oSFamilyCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _oSFamilyCloudServiceOperatingSystemsRestClient;
        private readonly OSFamilyData _data;

        /// <summary> Initializes a new instance of the <see cref="OSFamily"/> class for mocking. </summary>
        protected OSFamily()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "OSFamily"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OSFamily(ArmClient client, OSFamilyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OSFamily"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OSFamily(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _oSFamilyCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string oSFamilyCloudServiceOperatingSystemsApiVersion);
            _oSFamilyCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_oSFamilyCloudServiceOperatingSystemsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, oSFamilyCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/cloudServiceOsFamilies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OSFamilyData Data
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

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<OSFamily>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _oSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamily.Get");
            scope.Start();
            try
            {
                var response = await _oSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _oSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OSFamily> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _oSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamily.Get");
            scope.Start();
            try
            {
                var response = _oSFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _oSFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}