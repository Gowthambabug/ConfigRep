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
using Azure.Monitor.Query.Models;

namespace Azure.Monitor.Query
{
    internal partial class MetricsRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MetricsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MetricsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceUri, string timespan, TimeSpan? interval, string metricnames, string aggregation, int? top, string orderby, string filter, ResultType? resultType, string metricnamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.Insights/metrics", false);
            if (timespan != null)
            {
                uri.AppendQuery("timespan", timespan, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value, "P", true);
            }
            if (metricnames != null)
            {
                uri.AppendQuery("metricnames", metricnames, true);
            }
            if (aggregation != null)
            {
                uri.AppendQuery("aggregation", aggregation, true);
            }
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("orderby", orderby, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (resultType != null)
            {
                uri.AppendQuery("resultType", resultType.Value.ToSerialString(), true);
            }
            uri.AppendQuery("api-version", "2018-01-01", true);
            if (metricnamespace != null)
            {
                uri.AppendQuery("metricnamespace", metricnamespace, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> **Lists the metric values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. Special case: If a metricname itself has a comma in it then use %2 to indicate it. Eg: &apos;Metric,Name1&apos; should be **&apos;Metric%2Name1&apos;**. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="top">
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </param>
        /// <param name="orderby">
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned. Example: Metric contains metadata A, B and C. - Return all time series of C where A = a1 and B = b1 or b2 **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; or B eq &apos;b2&apos; and C eq &apos;*&apos;** - Invalid variant: **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; and C eq &apos;*&apos; or B = &apos;b2&apos;** This is invalid because the logical or operator cannot separate two different metadata names. - Return all time series where A = a1, B = b1 and C = c1: **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; and C eq &apos;c1&apos;** - Return all time series where A = a1 **$filter=A eq &apos;a1&apos; and B eq &apos;*&apos; and C eq &apos;*&apos;**. Special case: When dimension name or dimension value uses round brackets. Eg: When dimension name is **dim (test) 1** Instead of using $filter= &quot;dim (test) 1 eq &apos;*&apos; &quot; use **$filter= &quot;dim %2528test%2529 1 eq &apos;*&apos; &quot;** When dimension name is **dim (test) 3** and dimension value is **dim3 (test) val** Instead of using $filter= &quot;dim (test) 3 eq &apos;dim3 (test) val&apos; &quot; use **$filter= &quot;dim %2528test%2529 3 eq &apos;dim3 %2528test%2529 val&apos; &quot;**. </param>
        /// <param name="resultType"> Reduces the set of data collected. The syntax allowed depends on the operation. See the operation&apos;s description for details. </param>
        /// <param name="metricnamespace"> Metric namespace to query metric definitions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<MetricsQueryResult>> ListAsync(string resourceUri, string timespan = null, TimeSpan? interval = null, string metricnames = null, string aggregation = null, int? top = null, string orderby = null, string filter = null, ResultType? resultType = null, string metricnamespace = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri, timespan, interval, metricnames, aggregation, top, orderby, filter, resultType, metricnamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MetricsQueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MetricsQueryResult.DeserializeMetricsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> **Lists the metric values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. Special case: If a metricname itself has a comma in it then use %2 to indicate it. Eg: &apos;Metric,Name1&apos; should be **&apos;Metric%2Name1&apos;**. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="top">
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </param>
        /// <param name="orderby">
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned. Example: Metric contains metadata A, B and C. - Return all time series of C where A = a1 and B = b1 or b2 **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; or B eq &apos;b2&apos; and C eq &apos;*&apos;** - Invalid variant: **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; and C eq &apos;*&apos; or B = &apos;b2&apos;** This is invalid because the logical or operator cannot separate two different metadata names. - Return all time series where A = a1, B = b1 and C = c1: **$filter=A eq &apos;a1&apos; and B eq &apos;b1&apos; and C eq &apos;c1&apos;** - Return all time series where A = a1 **$filter=A eq &apos;a1&apos; and B eq &apos;*&apos; and C eq &apos;*&apos;**. Special case: When dimension name or dimension value uses round brackets. Eg: When dimension name is **dim (test) 1** Instead of using $filter= &quot;dim (test) 1 eq &apos;*&apos; &quot; use **$filter= &quot;dim %2528test%2529 1 eq &apos;*&apos; &quot;** When dimension name is **dim (test) 3** and dimension value is **dim3 (test) val** Instead of using $filter= &quot;dim (test) 3 eq &apos;dim3 (test) val&apos; &quot; use **$filter= &quot;dim %2528test%2529 3 eq &apos;dim3 %2528test%2529 val&apos; &quot;**. </param>
        /// <param name="resultType"> Reduces the set of data collected. The syntax allowed depends on the operation. See the operation&apos;s description for details. </param>
        /// <param name="metricnamespace"> Metric namespace to query metric definitions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<MetricsQueryResult> List(string resourceUri, string timespan = null, TimeSpan? interval = null, string metricnames = null, string aggregation = null, int? top = null, string orderby = null, string filter = null, ResultType? resultType = null, string metricnamespace = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri, timespan, interval, metricnames, aggregation, top, orderby, filter, resultType, metricnamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MetricsQueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MetricsQueryResult.DeserializeMetricsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}