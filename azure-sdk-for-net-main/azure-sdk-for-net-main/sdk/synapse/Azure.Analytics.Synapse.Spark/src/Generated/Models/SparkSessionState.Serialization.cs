// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionState
    {
        internal static SparkSessionState DeserializeSparkSessionState(JsonElement element)
        {
            Optional<DateTimeOffset?> notStartedAt = default;
            Optional<DateTimeOffset?> startingAt = default;
            Optional<DateTimeOffset?> idleAt = default;
            Optional<DateTimeOffset?> deadAt = default;
            Optional<DateTimeOffset?> shuttingDownAt = default;
            Optional<DateTimeOffset?> killedAt = default;
            Optional<DateTimeOffset?> recoveringAt = default;
            Optional<DateTimeOffset?> busyAt = default;
            Optional<DateTimeOffset?> errorAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notStartedAt = null;
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startingAt = null;
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("idleAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idleAt = null;
                        continue;
                    }
                    idleAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadAt = null;
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("shuttingDownAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        shuttingDownAt = null;
                        continue;
                    }
                    shuttingDownAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        killedAt = null;
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recoveringAt = null;
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("busyAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        busyAt = null;
                        continue;
                    }
                    busyAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorAt = null;
                        continue;
                    }
                    errorAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkSessionState(Optional.ToNullable(notStartedAt), Optional.ToNullable(startingAt), Optional.ToNullable(idleAt), Optional.ToNullable(deadAt), Optional.ToNullable(shuttingDownAt), Optional.ToNullable(killedAt), Optional.ToNullable(recoveringAt), Optional.ToNullable(busyAt), Optional.ToNullable(errorAt), currentState.Value, jobCreationRequest.Value);
        }
    }
}