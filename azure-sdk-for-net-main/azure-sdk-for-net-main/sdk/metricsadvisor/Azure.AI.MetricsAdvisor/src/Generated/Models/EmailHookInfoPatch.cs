// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EmailHookInfoPatch. </summary>
    internal partial class EmailHookInfoPatch : HookInfoPatch
    {
        /// <summary> Initializes a new instance of EmailHookInfoPatch. </summary>
        public EmailHookInfoPatch()
        {
            HookType = NotificationHookKind.Email;
        }

        /// <summary> Gets or sets the hook parameter. </summary>
        public EmailHookParameterPatch HookParameter { get; set; }
    }
}