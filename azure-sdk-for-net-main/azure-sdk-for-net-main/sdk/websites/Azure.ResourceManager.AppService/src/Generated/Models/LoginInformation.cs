// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the login flow of users using App Service Authentication/Authorization. </summary>
    public partial class LoginInformation
    {
        /// <summary> Initializes a new instance of LoginInformation. </summary>
        public LoginInformation()
        {
            AllowedExternalRedirectUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LoginInformation. </summary>
        /// <param name="routes"> The routes that specify the endpoints used for login and logout requests. </param>
        /// <param name="tokenStore"> The configuration settings of the token store. </param>
        /// <param name="preserveUrlFragmentsForLogins"> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="allowedExternalRedirectUrls">
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </param>
        /// <param name="cookieExpiration"> The configuration settings of the session cookie&apos;s expiration. </param>
        /// <param name="nonce"> The configuration settings of the nonce used in the login flow. </param>
        internal LoginInformation(LoginRoutes routes, TokenStore tokenStore, bool? preserveUrlFragmentsForLogins, IList<string> allowedExternalRedirectUrls, CookieExpiration cookieExpiration, Nonce nonce)
        {
            Routes = routes;
            TokenStore = tokenStore;
            PreserveUrlFragmentsForLogins = preserveUrlFragmentsForLogins;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            CookieExpiration = cookieExpiration;
            Nonce = nonce;
        }

        /// <summary> The routes that specify the endpoints used for login and logout requests. </summary>
        public LoginRoutes Routes { get; set; }
        /// <summary> The configuration settings of the token store. </summary>
        public TokenStore TokenStore { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? PreserveUrlFragmentsForLogins { get; set; }
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        public IList<string> AllowedExternalRedirectUrls { get; }
        /// <summary> The configuration settings of the session cookie&apos;s expiration. </summary>
        public CookieExpiration CookieExpiration { get; set; }
        /// <summary> The configuration settings of the nonce used in the login flow. </summary>
        public Nonce Nonce { get; set; }
    }
}
