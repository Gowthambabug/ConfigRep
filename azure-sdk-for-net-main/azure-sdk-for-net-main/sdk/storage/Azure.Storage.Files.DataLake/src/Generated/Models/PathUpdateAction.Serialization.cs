// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    internal static partial class PathUpdateActionExtensions
    {
        public static string ToSerialString(this PathUpdateAction value) => value switch
        {
            PathUpdateAction.Append => "append",
            PathUpdateAction.Flush => "flush",
            PathUpdateAction.SetProperties => "setProperties",
            PathUpdateAction.SetAccessControl => "setAccessControl",
            PathUpdateAction.SetAccessControlRecursive => "setAccessControlRecursive",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathUpdateAction value.")
        };

        public static PathUpdateAction ToPathUpdateAction(this string value)
        {
            if (string.Equals(value, "append", StringComparison.InvariantCultureIgnoreCase)) return PathUpdateAction.Append;
            if (string.Equals(value, "flush", StringComparison.InvariantCultureIgnoreCase)) return PathUpdateAction.Flush;
            if (string.Equals(value, "setProperties", StringComparison.InvariantCultureIgnoreCase)) return PathUpdateAction.SetProperties;
            if (string.Equals(value, "setAccessControl", StringComparison.InvariantCultureIgnoreCase)) return PathUpdateAction.SetAccessControl;
            if (string.Equals(value, "setAccessControlRecursive", StringComparison.InvariantCultureIgnoreCase)) return PathUpdateAction.SetAccessControlRecursive;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathUpdateAction value.");
        }
    }
}