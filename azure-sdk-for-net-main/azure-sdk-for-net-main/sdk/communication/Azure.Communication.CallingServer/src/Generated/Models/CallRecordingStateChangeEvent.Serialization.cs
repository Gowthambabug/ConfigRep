// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallRecordingStateChangeEvent
    {
        internal static CallRecordingStateChangeEvent DeserializeCallRecordingStateChangeEvent(JsonElement element)
        {
            Optional<string> recordingId = default;
            CallRecordingState state = default;
            DateTimeOffset startDateTime = default;
            Optional<string> serverCallId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = new CallRecordingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startDateTime"))
                {
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
            }
            return new CallRecordingStateChangeEvent(recordingId.Value, state, startDateTime, serverCallId.Value);
        }
    }
}
