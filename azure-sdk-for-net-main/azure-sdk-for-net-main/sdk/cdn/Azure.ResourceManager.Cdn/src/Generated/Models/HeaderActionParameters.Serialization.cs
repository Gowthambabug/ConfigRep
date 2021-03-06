// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class HeaderActionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType.ToString());
            writer.WritePropertyName("headerAction");
            writer.WriteStringValue(HeaderAction.ToString());
            writer.WritePropertyName("headerName");
            writer.WriteStringValue(HeaderName);
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static HeaderActionParameters DeserializeHeaderActionParameters(JsonElement element)
        {
            HeaderActionParametersOdataType odataType = default;
            HeaderAction headerAction = default;
            string headerName = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = new HeaderActionParametersOdataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("headerAction"))
                {
                    headerAction = new HeaderAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("headerName"))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new HeaderActionParameters(odataType, headerAction, headerName, value.Value);
        }
    }
}
