// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework.Models;

namespace Azure.Core.TestFramework
{
    internal partial class TestProxyRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TestProxyRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public TestProxyRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateStartPlaybackRequest(StartInformation body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/playback/start", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Start playback for a test. </summary>
        /// <param name="body"> File location of the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<IReadOnlyDictionary<string, string>, TestProxyStartPlaybackHeaders>> StartPlaybackAsync(StartInformation body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateStartPlaybackRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new TestProxyStartPlaybackHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, string> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetString());
                        }
                        value = dictionary;
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Start playback for a test. </summary>
        /// <param name="body"> File location of the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<IReadOnlyDictionary<string, string>, TestProxyStartPlaybackHeaders> StartPlayback(StartInformation body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateStartPlaybackRequest(body);
            _pipeline.Send(message, cancellationToken);
            var headers = new TestProxyStartPlaybackHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, string> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetString());
                        }
                        value = dictionary;
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopPlaybackRequest(string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/playback/stop", false);
            request.Uri = uri;
            request.Headers.Add("x-recording-id", xRecordingId);
            return message;
        }

        /// <summary> Stop playback for a test. </summary>
        /// <param name="xRecordingId"> The recording ID to stop playback for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="xRecordingId"/> is null. </exception>
        public async Task<Response> StopPlaybackAsync(string xRecordingId, CancellationToken cancellationToken = default)
        {
            if (xRecordingId == null)
            {
                throw new ArgumentNullException(nameof(xRecordingId));
            }

            using var message = CreateStopPlaybackRequest(xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop playback for a test. </summary>
        /// <param name="xRecordingId"> The recording ID to stop playback for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="xRecordingId"/> is null. </exception>
        public Response StopPlayback(string xRecordingId, CancellationToken cancellationToken = default)
        {
            if (xRecordingId == null)
            {
                throw new ArgumentNullException(nameof(xRecordingId));
            }

            using var message = CreateStopPlaybackRequest(xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStartRecordRequest(StartInformation body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/record/start", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Start recording for a test. </summary>
        /// <param name="body"> File location of the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<TestProxyStartRecordHeaders>> StartRecordAsync(StartInformation body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateStartRecordRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new TestProxyStartRecordHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Start recording for a test. </summary>
        /// <param name="body"> File location of the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<TestProxyStartRecordHeaders> StartRecord(StartInformation body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateStartRecordRequest(body);
            _pipeline.Send(message, cancellationToken);
            var headers = new TestProxyStartRecordHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopRecordRequest(string xRecordingId, IDictionary<string, string> variables)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/record/stop", false);
            request.Uri = uri;
            request.Headers.Add("x-recording-id", xRecordingId);
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            foreach (var item in variables)
            {
                content.JsonWriter.WritePropertyName(item.Key);
                content.JsonWriter.WriteStringValue(item.Value);
            }
            content.JsonWriter.WriteEndObject();
            request.Content = content;
            return message;
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="xRecordingId"> The recording ID. </param>
        /// <param name="variables"> Variables for the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="xRecordingId"/> or <paramref name="variables"/> is null. </exception>
        public async Task<Response> StopRecordAsync(string xRecordingId, IDictionary<string, string> variables, CancellationToken cancellationToken = default)
        {
            if (xRecordingId == null)
            {
                throw new ArgumentNullException(nameof(xRecordingId));
            }
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            using var message = CreateStopRecordRequest(xRecordingId, variables);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="xRecordingId"> The recording ID. </param>
        /// <param name="variables"> Variables for the recording. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="xRecordingId"/> or <paramref name="variables"/> is null. </exception>
        public Response StopRecord(string xRecordingId, IDictionary<string, string> variables, CancellationToken cancellationToken = default)
        {
            if (xRecordingId == null)
            {
                throw new ArgumentNullException(nameof(xRecordingId));
            }
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            using var message = CreateStopRecordRequest(xRecordingId, variables);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddBodyKeySanitizerRequest(BodyKeySanitizer sanitizer, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/addsanitizer", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "BodyKeySanitizer");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sanitizer);
            request.Content = content;
            return message;
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="sanitizer"> The body for a header regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public async Task<Response> AddBodyKeySanitizerAsync(BodyKeySanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddBodyKeySanitizerRequest(sanitizer, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="sanitizer"> The body for a header regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public Response AddBodyKeySanitizer(BodyKeySanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddBodyKeySanitizerRequest(sanitizer, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddHeaderSanitizerRequest(HeaderRegexSanitizer sanitizer, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/addsanitizer", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "HeaderRegexSanitizer");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sanitizer);
            request.Content = content;
            return message;
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="sanitizer"> The body for a header regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public async Task<Response> AddHeaderSanitizerAsync(HeaderRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddHeaderSanitizerRequest(sanitizer, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop recording for a test. </summary>
        /// <param name="sanitizer"> The body for a header regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public Response AddHeaderSanitizer(HeaderRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddHeaderSanitizerRequest(sanitizer, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddUriSanitizerRequest(UriRegexSanitizer sanitizer, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/addsanitizer", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "UriRegexSanitizer");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sanitizer);
            request.Content = content;
            return message;
        }

        /// <summary> Add a sanitizer. </summary>
        /// <param name="sanitizer"> The body for a URI regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public async Task<Response> AddUriSanitizerAsync(UriRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddUriSanitizerRequest(sanitizer, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a sanitizer. </summary>
        /// <param name="sanitizer"> The body for a URI regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public Response AddUriSanitizer(UriRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddUriSanitizerRequest(sanitizer, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddBodyRegexSanitizerRequest(BodyRegexSanitizer sanitizer, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/addsanitizer", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "BodyRegexSanitizer");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sanitizer);
            request.Content = content;
            return message;
        }

        /// <summary> Add a sanitizer. </summary>
        /// <param name="sanitizer"> The body for a body regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public async Task<Response> AddBodyRegexSanitizerAsync(BodyRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddBodyRegexSanitizerRequest(sanitizer, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a sanitizer. </summary>
        /// <param name="sanitizer"> The body for a body regex sanitizer. </param>
        /// <param name="xRecordingId"> The recording ID to apply the sanitizer to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sanitizer"/> is null. </exception>
        public Response AddBodyRegexSanitizer(BodyRegexSanitizer sanitizer, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (sanitizer == null)
            {
                throw new ArgumentNullException(nameof(sanitizer));
            }

            using var message = CreateAddBodyRegexSanitizerRequest(sanitizer, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddBodilessMatcherRequest(string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/setmatcher", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "BodilessMatcher");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            return message;
        }

        /// <summary> Add a bodiless matcher. </summary>
        /// <param name="xRecordingId"> The recording ID to apply the matcher to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> AddBodilessMatcherAsync(string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAddBodilessMatcherRequest(xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a bodiless matcher. </summary>
        /// <param name="xRecordingId"> The recording ID to apply the matcher to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response AddBodilessMatcher(string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAddBodilessMatcherRequest(xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddCustomMatcherRequest(CustomDefaultMatcher matcher, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/setmatcher", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "CustomDefaultMatcher");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(matcher);
            request.Content = content;
            return message;
        }

        /// <summary> Add a custom matcher. </summary>
        /// <param name="matcher"> The body for a custom matcher. </param>
        /// <param name="xRecordingId"> The recording ID to apply the matcher to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matcher"/> is null. </exception>
        public async Task<Response> AddCustomMatcherAsync(CustomDefaultMatcher matcher, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (matcher == null)
            {
                throw new ArgumentNullException(nameof(matcher));
            }

            using var message = CreateAddCustomMatcherRequest(matcher, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a custom matcher. </summary>
        /// <param name="matcher"> The body for a custom matcher. </param>
        /// <param name="xRecordingId"> The recording ID to apply the matcher to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matcher"/> is null. </exception>
        public Response AddCustomMatcher(CustomDefaultMatcher matcher, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (matcher == null)
            {
                throw new ArgumentNullException(nameof(matcher));
            }

            using var message = CreateAddCustomMatcherRequest(matcher, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddHeaderTransformRequest(HeaderTransform transform, string xRecordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/admin/addtransform", false);
            request.Uri = uri;
            request.Headers.Add("x-abstraction-identifier", "HeaderTransform");
            if (xRecordingId != null)
            {
                request.Headers.Add("x-recording-id", xRecordingId);
            }
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(transform);
            request.Content = content;
            return message;
        }

        /// <summary> Add a header transform. </summary>
        /// <param name="transform"> The body for a header transform. </param>
        /// <param name="xRecordingId"> The recording ID to apply the transform to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transform"/> is null. </exception>
        public async Task<Response> AddHeaderTransformAsync(HeaderTransform transform, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (transform == null)
            {
                throw new ArgumentNullException(nameof(transform));
            }

            using var message = CreateAddHeaderTransformRequest(transform, xRecordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a header transform. </summary>
        /// <param name="transform"> The body for a header transform. </param>
        /// <param name="xRecordingId"> The recording ID to apply the transform to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transform"/> is null. </exception>
        public Response AddHeaderTransform(HeaderTransform transform, string xRecordingId = null, CancellationToken cancellationToken = default)
        {
            if (transform == null)
            {
                throw new ArgumentNullException(nameof(transform));
            }

            using var message = CreateAddHeaderTransformRequest(transform, xRecordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
