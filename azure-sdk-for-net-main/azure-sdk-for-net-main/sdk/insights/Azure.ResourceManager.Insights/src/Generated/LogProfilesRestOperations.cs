// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class LogProfilesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LogProfilesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public LogProfilesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string logProfileName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/logprofiles/", false);
            uri.AppendPath(logProfileName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var message = CreateDeleteRequest(logProfileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public Response Delete(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var message = CreateDeleteRequest(logProfileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string logProfileName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/logprofiles/", false);
            uri.AppendPath(logProfileName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public async Task<Response<LogProfileResource>> GetAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var message = CreateGetRequest(logProfileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public Response<LogProfileResource> Get(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var message = CreateGetRequest(logProfileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string logProfileName, LogProfileResource parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/logprofiles/", false);
            uri.AppendPath(logProfileName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update a log profile in Azure Monitoring REST API. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<LogProfileResource>> CreateOrUpdateAsync(string logProfileName, LogProfileResource parameters, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(logProfileName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update a log profile in Azure Monitoring REST API. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public Response<LogProfileResource> CreateOrUpdate(string logProfileName, LogProfileResource parameters, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(logProfileName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string logProfileName, LogProfileResourcePatch logProfilesResource)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/logprofiles/", false);
            uri.AppendPath(logProfileName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(logProfilesResource);
            request.Content = content;
            return message;
        }

        /// <summary> Updates an existing LogProfilesResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="logProfilesResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="logProfilesResource"/> is null. </exception>
        public async Task<Response<LogProfileResource>> UpdateAsync(string logProfileName, LogProfileResourcePatch logProfilesResource, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (logProfilesResource == null)
            {
                throw new ArgumentNullException(nameof(logProfilesResource));
            }

            using var message = CreateUpdateRequest(logProfileName, logProfilesResource);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing LogProfilesResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="logProfilesResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="logProfilesResource"/> is null. </exception>
        public Response<LogProfileResource> Update(string logProfileName, LogProfileResourcePatch logProfilesResource, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (logProfilesResource == null)
            {
                throw new ArgumentNullException(nameof(logProfilesResource));
            }

            using var message = CreateUpdateRequest(logProfileName, logProfilesResource);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogProfileResource.DeserializeLogProfileResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/logprofiles", false);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List the log profiles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<LogProfileCollection>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogProfileCollection.DeserializeLogProfileCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List the log profiles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LogProfileCollection> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogProfileCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogProfileCollection.DeserializeLogProfileCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}