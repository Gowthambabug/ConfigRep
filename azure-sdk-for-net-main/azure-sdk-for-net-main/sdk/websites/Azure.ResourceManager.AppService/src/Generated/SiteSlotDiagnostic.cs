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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteSlotDiagnostic along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotDiagnostic : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotDiagnostic"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDiagnosticsRestClient;
        private readonly DiagnosticCategoryData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnostic"/> class for mocking. </summary>
        protected SiteSlotDiagnostic()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotDiagnostic(ArmClient client, DiagnosticCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotDiagnostic(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteSlotDiagnosticDiagnosticsApiVersion);
            _siteSlotDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(_siteSlotDiagnosticDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/diagnostics";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticCategoryData Data
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

        /// <summary> Gets a collection of SiteSlotDiagnosticAnalyses in the SiteSlotDiagnosticAnalysis. </summary>
        /// <returns> An object representing collection of SiteSlotDiagnosticAnalyses and their operations over a SiteSlotDiagnosticAnalysis. </returns>
        public virtual SiteSlotDiagnosticAnalysisCollection GetSiteSlotDiagnosticAnalyses()
        {
            return new SiteSlotDiagnosticAnalysisCollection(Client, Id);
        }

        /// <summary> Gets a collection of SiteSlotDiagnosticDetectors in the SiteSlotDiagnosticDetector. </summary>
        /// <returns> An object representing collection of SiteSlotDiagnosticDetectors and their operations over a SiteSlotDiagnosticDetector. </returns>
        public virtual SiteSlotDiagnosticDetectorCollection GetSiteSlotDiagnosticDetectors()
        {
            return new SiteSlotDiagnosticDetectorCollection(Client, Id);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategorySlot
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotDiagnostic>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnostic.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategorySlot
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotDiagnostic> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnostic.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
