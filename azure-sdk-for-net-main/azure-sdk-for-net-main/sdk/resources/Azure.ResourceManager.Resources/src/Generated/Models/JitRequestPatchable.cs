// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Information about JIT request. </summary>
    internal partial class JitRequestPatchable
    {
        /// <summary> Initializes a new instance of JitRequestPatchable. </summary>
        public JitRequestPatchable()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Jit request tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
