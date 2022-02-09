// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization. </summary>
    public partial class HttpSettings
    {
        /// <summary> Initializes a new instance of HttpSettings. </summary>
        public HttpSettings()
        {
        }

        /// <summary> Initializes a new instance of HttpSettings. </summary>
        /// <param name="requireHttps"> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="routes"> The configuration settings of the paths HTTP requests. </param>
        /// <param name="forwardProxy"> The configuration settings of a forward proxy used to make the requests. </param>
        internal HttpSettings(bool? requireHttps, HttpSettingsRoutes routes, ForwardProxy forwardProxy)
        {
            RequireHttps = requireHttps;
            Routes = routes;
            ForwardProxy = forwardProxy;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? RequireHttps { get; set; }
        /// <summary> The configuration settings of the paths HTTP requests. </summary>
        public HttpSettingsRoutes Routes { get; set; }
        /// <summary> The configuration settings of a forward proxy used to make the requests. </summary>
        public ForwardProxy ForwardProxy { get; set; }
    }
}