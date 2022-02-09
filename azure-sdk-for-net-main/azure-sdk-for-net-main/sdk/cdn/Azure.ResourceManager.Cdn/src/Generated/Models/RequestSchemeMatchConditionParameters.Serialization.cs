// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RequestSchemeMatchConditionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType.ToString());
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition");
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues");
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RequestSchemeMatchConditionParameters DeserializeRequestSchemeMatchConditionParameters(JsonElement element)
        {
            RequestSchemeMatchConditionParametersOdataType odataType = default;
            RequestSchemeMatchConditionParametersOperator @operator = default;
            Optional<bool> negateCondition = default;
            Optional<IList<RequestSchemeMatchConditionParametersMatchValuesItem>> matchValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = new RequestSchemeMatchConditionParametersOdataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = new RequestSchemeMatchConditionParametersOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RequestSchemeMatchConditionParametersMatchValuesItem> array = new List<RequestSchemeMatchConditionParametersMatchValuesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RequestSchemeMatchConditionParametersMatchValuesItem(item.GetString()));
                    }
                    matchValues = array;
                    continue;
                }
            }
            return new RequestSchemeMatchConditionParameters(odataType, @operator, Optional.ToNullable(negateCondition), Optional.ToList(matchValues));
        }
    }
}