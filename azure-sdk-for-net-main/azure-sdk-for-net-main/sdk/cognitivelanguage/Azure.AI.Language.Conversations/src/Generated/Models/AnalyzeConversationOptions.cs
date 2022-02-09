// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The request body. </summary>
    public partial class AnalyzeConversationOptions
    {
        /// <summary> The name of the target project this request is sending to directly. </summary>
        public string DirectTarget { get; set; }
        /// <summary> The language to use in this request. This will be the language setting when communicating with all other target projects. </summary>
        public string Language { get; set; }
        /// <summary> If true, the service will return more detailed information in the response. </summary>
        public bool? Verbose { get; set; }
        /// <summary> If true, the query will be kept by the service for customers to further review, to improve the model quality. </summary>
        public bool? IsLoggingEnabled { get; set; }
        /// <summary> A dictionary representing the input for each target project. </summary>
        public IDictionary<string, AnalysisParameters> Parameters { get; }
    }
}