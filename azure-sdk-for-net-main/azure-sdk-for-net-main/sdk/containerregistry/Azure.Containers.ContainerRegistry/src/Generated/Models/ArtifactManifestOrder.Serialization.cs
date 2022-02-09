// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    internal static partial class ArtifactManifestOrderExtensions
    {
        public static string ToSerialString(this ArtifactManifestOrder value) => value switch
        {
            ArtifactManifestOrder.None => "none",
            ArtifactManifestOrder.LastUpdatedOnDescending => "timedesc",
            ArtifactManifestOrder.LastUpdatedOnAscending => "timeasc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArtifactManifestOrder value.")
        };

        public static ArtifactManifestOrder ToArtifactManifestOrder(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrder.None;
            if (string.Equals(value, "timedesc", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrder.LastUpdatedOnDescending;
            if (string.Equals(value, "timeasc", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrder.LastUpdatedOnAscending;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArtifactManifestOrder value.");
        }
    }
}