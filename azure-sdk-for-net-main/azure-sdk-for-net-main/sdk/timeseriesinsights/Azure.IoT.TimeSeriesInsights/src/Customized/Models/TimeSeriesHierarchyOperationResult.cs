// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Result of an operation on a particular time series hierarchy. Hierarchy object is set when operation
    /// is successful and error object is set when operation is unsuccessful.
    /// </summary>
    [CodeGenModel("TimeSeriesHierarchyOrError")]
    public partial class TimeSeriesHierarchyOperationResult
    {
        // This class declaration changes the class name; do not remove.
        // The class name change is to make it clearer to the user that it represents
        // a hierarchy operation result.
    }
}
