// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    public partial class PatchManagementGroupOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName");
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(ParentGroupId))
            {
                if (ParentGroupId != null)
                {
                    writer.WritePropertyName("parentGroupId");
                    writer.WriteStringValue(ParentGroupId);
                }
                else
                {
                    writer.WriteNull("parentGroupId");
                }
            }
            writer.WriteEndObject();
        }
    }
}