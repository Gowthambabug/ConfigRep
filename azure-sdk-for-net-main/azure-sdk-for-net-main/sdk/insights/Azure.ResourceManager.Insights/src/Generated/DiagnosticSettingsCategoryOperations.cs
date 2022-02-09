// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The DiagnosticSettingsCategory service client. </summary>
    public partial class DiagnosticSettingsCategoryOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DiagnosticSettingsCategoryRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of DiagnosticSettingsCategoryOperations for mocking. </summary>
        protected DiagnosticSettingsCategoryOperations()
        {
        }

        /// <summary> Initializes a new instance of DiagnosticSettingsCategoryOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal DiagnosticSettingsCategoryOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new DiagnosticSettingsCategoryRestOperations(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticSettingsCategoryResource>> GetAsync(string resourceUri, string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceUri, name, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticSettingsCategoryResource> Get(string resourceUri, string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceUri, name, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticSettingsCategoryResourceCollection>> ListAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryOperations.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceUri, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticSettingsCategoryResourceCollection> List(string resourceUri, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryOperations.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceUri, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}