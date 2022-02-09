// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    internal partial class SessionsList
    {
        internal static SessionsList DeserializeSessionsList(JsonElement element)
        {
            IReadOnlyList<RenderingSession> sessions = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessions"))
                {
                    List<RenderingSession> array = new List<RenderingSession>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RenderingSession.DeserializeRenderingSession(item));
                    }
                    sessions = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SessionsList(sessions, nextLink.Value);
        }
    }
}