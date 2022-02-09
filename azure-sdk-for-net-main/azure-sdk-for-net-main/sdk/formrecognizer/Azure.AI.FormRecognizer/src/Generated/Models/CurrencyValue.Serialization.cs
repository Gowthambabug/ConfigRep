// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial struct CurrencyValue
    {
        internal static CurrencyValue DeserializeCurrencyValue(JsonElement element)
        {
            double amount = default;
            Optional<string> currencySymbol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"))
                {
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currencySymbol"))
                {
                    currencySymbol = property.Value.GetString();
                    continue;
                }
            }
            return new CurrencyValue(amount, currencySymbol.Value);
        }
    }
}