// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class PathUpdateHeaders
    {
        private readonly Response _response;
        public PathUpdateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The data and time the file or directory was last modified.  Write operations on the file or directory update the last modified time. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates that the service supports requests for partial file content. </summary>
        public string AcceptRanges => _response.Headers.TryGetValue("Accept-Ranges", out string value) ? value : null;
        /// <summary> If the Cache-Control request header has previously been set for the resource, that value is returned in this header. </summary>
        public string CacheControl => _response.Headers.TryGetValue("Cache-Control", out string value) ? value : null;
        /// <summary> If the Content-Disposition request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentDisposition => _response.Headers.TryGetValue("Content-Disposition", out string value) ? value : null;
        /// <summary> If the Content-Encoding request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentEncoding => _response.Headers.TryGetValue("Content-Encoding", out string value) ? value : null;
        /// <summary> If the Content-Language request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentLanguage => _response.Headers.TryGetValue("Content-Language", out string value) ? value : null;
        /// <summary> The size of the resource in bytes. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> Indicates the range of bytes returned in the event that the client requested a subset of the file by setting the Range request header. </summary>
        public string ContentRange => _response.Headers.TryGetValue("Content-Range", out string value) ? value : null;
        /// <summary> The content type specified for the resource. If no content type was specified, the default content type is application/octet-stream. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> An MD5 hash of the request content. This header is only returned for &quot;Flush&quot; operation. This header is returned so that the client can check for message content integrity. This header refers to the content of the request, not actual file content. </summary>
        public string ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out string value) ? value : null;
        /// <summary> User-defined properties associated with the file or directory, in the format of a comma-separated list of name and value pairs &quot;n1=v1, n2=v2, ...&quot;, where each value is a base64 encoded string. Note that the string may only contain ASCII characters in the ISO-8859-1 character set. </summary>
        public string Properties => _response.Headers.TryGetValue("x-ms-properties", out string value) ? value : null;
        /// <summary> When performing setAccessControlRecursive on a directory, the number of paths that are processed with each invocation is limited.  If the number of paths to be processed exceeds this limit, a continuation token is returned in this response header.  When a continuation token is returned in the response, it must be specified in a subsequent invocation of the setAccessControlRecursive operation to continue the setAccessControlRecursive operation on the directory. </summary>
        public string XMsContinuation => _response.Headers.TryGetValue("x-ms-continuation", out string value) ? value : null;
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}