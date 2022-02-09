// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class OrderItemDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("productDetails");
            writer.WriteObjectValue(ProductDetails);
            writer.WritePropertyName("orderItemType");
            writer.WriteStringValue(OrderItemType.ToString());
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences");
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsCollectionDefined(NotificationEmailList))
            {
                writer.WritePropertyName("notificationEmailList");
                writer.WriteStartArray();
                foreach (var item in NotificationEmailList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OrderItemDetails DeserializeOrderItemDetails(JsonElement element)
        {
            ProductDetails productDetails = default;
            OrderItemType orderItemType = default;
            Optional<StageDetails> currentStage = default;
            Optional<IReadOnlyList<StageDetails>> orderItemStageHistory = default;
            Optional<OrderItemPreferences> preferences = default;
            Optional<ForwardShippingDetails> forwardShippingDetails = default;
            Optional<ReverseShippingDetails> reverseShippingDetails = default;
            Optional<IList<string>> notificationEmailList = default;
            Optional<string> cancellationReason = default;
            Optional<OrderItemCancellationEnum> cancellationStatus = default;
            Optional<ActionStatusEnum> deletionStatus = default;
            Optional<string> returnReason = default;
            Optional<OrderItemReturnEnum> returnStatus = default;
            Optional<ResourceProviderDetails> managementRpDetails = default;
            Optional<IReadOnlyList<ResourceProviderDetails>> managementRpDetailsList = default;
            Optional<ErrorDetail> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productDetails"))
                {
                    productDetails = ProductDetails.DeserializeProductDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemType"))
                {
                    orderItemType = new OrderItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentStage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentStage = StageDetails.DeserializeStageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemStageHistory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StageDetails> array = new List<StageDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StageDetails.DeserializeStageDetails(item));
                    }
                    orderItemStageHistory = array;
                    continue;
                }
                if (property.NameEquals("preferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preferences = OrderItemPreferences.DeserializeOrderItemPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardShippingDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    forwardShippingDetails = ForwardShippingDetails.DeserializeForwardShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("notificationEmailList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notificationEmailList = array;
                    continue;
                }
                if (property.NameEquals("cancellationReason"))
                {
                    cancellationReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cancellationStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cancellationStatus = new OrderItemCancellationEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletionStatus = new ActionStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("returnReason"))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("returnStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    returnStatus = new OrderItemReturnEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managementRpDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managementRpDetails = ResourceProviderDetails.DeserializeResourceProviderDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("managementRpDetailsList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderDetails> array = new List<ResourceProviderDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderDetails.DeserializeResourceProviderDetails(item));
                    }
                    managementRpDetailsList = array;
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ErrorDetail>(property.Value.ToString());
                    continue;
                }
            }
            return new OrderItemDetails(productDetails, orderItemType, currentStage.Value, Optional.ToList(orderItemStageHistory), preferences.Value, forwardShippingDetails.Value, reverseShippingDetails.Value, Optional.ToList(notificationEmailList), cancellationReason.Value, Optional.ToNullable(cancellationStatus), Optional.ToNullable(deletionStatus), returnReason.Value, Optional.ToNullable(returnStatus), managementRpDetails.Value, Optional.ToList(managementRpDetailsList), error);
        }
    }
}