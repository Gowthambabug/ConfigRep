// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Core.TestFramework.Models
{
    /// <summary> Condition to apply for the sanitization or transform. If the condition is not met, sanitization/transform is not performed. </summary>
    public partial class Condition
    {
        /// <summary> Initializes a new instance of Condition. </summary>
        public Condition()
        {
        }

        /// <summary> Gets or sets the uri regex. </summary>
        public string UriRegex { get; set; }
        /// <summary> Header condition to apply. </summary>
        public HeaderCondition ResponseHeader { get; set; }
    }
}