// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL. </summary>
    public enum AfdQueryStringCachingBehavior
    {
        /// <summary> IgnoreQueryString. </summary>
        IgnoreQueryString,
        /// <summary> UseQueryString. </summary>
        UseQueryString,
        /// <summary> NotSet. </summary>
        NotSet
    }
}