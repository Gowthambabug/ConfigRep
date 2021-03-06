// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;
using KeyFieldAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

#pragma warning disable SA1402 // File may only contain a single type
#pragma warning disable SA1649 // File name should match first type name

// TODO: Remove when https://github.com/Azure/azure-sdk-for-net/issues/11166 is completed.
namespace Azure.Search.Documents.Tests
{
    public class ReflectableInnerCamelCaseModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class ReflectableCamelCaseModel
    {
        [KeyField]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("myProperty")]
        public string MyProperty { get; set; }

        [JsonPropertyName("inner")]
        public ReflectableInnerCamelCaseModel Inner { get; set; }

        [JsonPropertyName("innerCollection")]
        public ReflectableInnerCamelCaseModel[] InnerCollection { get; set; }
    }
}
