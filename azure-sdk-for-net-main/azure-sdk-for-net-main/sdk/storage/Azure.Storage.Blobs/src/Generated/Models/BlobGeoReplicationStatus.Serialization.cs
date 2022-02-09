// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    internal static partial class BlobGeoReplicationStatusExtensions
    {
        public static string ToSerialString(this BlobGeoReplicationStatus value) => value switch
        {
            BlobGeoReplicationStatus.Live => "live",
            BlobGeoReplicationStatus.Bootstrap => "bootstrap",
            BlobGeoReplicationStatus.Unavailable => "unavailable",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobGeoReplicationStatus value.")
        };

        public static BlobGeoReplicationStatus ToBlobGeoReplicationStatus(this string value)
        {
            if (string.Equals(value, "live", StringComparison.InvariantCultureIgnoreCase)) return BlobGeoReplicationStatus.Live;
            if (string.Equals(value, "bootstrap", StringComparison.InvariantCultureIgnoreCase)) return BlobGeoReplicationStatus.Bootstrap;
            if (string.Equals(value, "unavailable", StringComparison.InvariantCultureIgnoreCase)) return BlobGeoReplicationStatus.Unavailable;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobGeoReplicationStatus value.");
        }
    }
}