// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ApplicationErrorResponse
    {
        internal static ApplicationErrorResponse DeserializeApplicationErrorResponse(JsonElement element)
        {
            Optional<string> httpStatus = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpStatus"))
                {
                    httpStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationErrorResponse(httpStatus.Value, errorCode.Value, errorMessage.Value);
        }
    }
}
