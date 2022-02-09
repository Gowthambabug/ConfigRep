// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallRecordingProperties
    {
        internal static CallRecordingProperties DeserializeCallRecordingProperties(JsonElement element)
        {
            CallRecordingState recordingState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingState"))
                {
                    recordingState = new CallRecordingState(property.Value.GetString());
                    continue;
                }
            }
            return new CallRecordingProperties(recordingState);
        }
    }
}