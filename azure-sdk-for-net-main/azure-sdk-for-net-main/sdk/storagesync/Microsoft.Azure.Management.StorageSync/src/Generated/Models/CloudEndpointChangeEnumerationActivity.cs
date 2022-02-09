// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cloud endpoint change enumeration activity object
    /// </summary>
    public partial class CloudEndpointChangeEnumerationActivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CloudEndpointChangeEnumerationActivity class.
        /// </summary>
        public CloudEndpointChangeEnumerationActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CloudEndpointChangeEnumerationActivity class.
        /// </summary>
        /// <param name="lastUpdatedTimestamp">Last updated timestamp</param>
        /// <param name="operationState">Change enumeration operation state.
        /// Possible values include: 'InitialEnumerationInProgress',
        /// 'EnumerationInProgress'</param>
        /// <param name="statusCode">When non-zero, indicates an issue that is
        /// delaying change enumeration</param>
        /// <param name="startedTimestamp">Timestamp when change enumeration
        /// started</param>
        /// <param name="processedFilesCount">Count of files processed</param>
        /// <param name="processedDirectoriesCount">Count of directories
        /// processed</param>
        /// <param name="totalFilesCount">Total count of files
        /// enumerated</param>
        /// <param name="totalDirectoriesCount">Total count of directories
        /// enumerated</param>
        /// <param name="totalSizeBytes">Total enumerated size in bytes</param>
        /// <param name="progressPercent">Progress percentage for change
        /// enumeration run, excluding processing of deletes</param>
        /// <param name="minutesRemaining">Estimate of time remaining for the
        /// enumeration run</param>
        /// <param name="totalCountsState">Change enumeration total counts
        /// state. Possible values include: 'Calculating', 'Final'</param>
        /// <param name="deletesProgressPercent">Progress percentage for
        /// processing deletes. This is done separately from the rest of the
        /// enumeration run</param>
        public CloudEndpointChangeEnumerationActivity(System.DateTime? lastUpdatedTimestamp = default(System.DateTime?), string operationState = default(string), int? statusCode = default(int?), System.DateTime? startedTimestamp = default(System.DateTime?), long? processedFilesCount = default(long?), long? processedDirectoriesCount = default(long?), long? totalFilesCount = default(long?), long? totalDirectoriesCount = default(long?), long? totalSizeBytes = default(long?), int? progressPercent = default(int?), int? minutesRemaining = default(int?), string totalCountsState = default(string), int? deletesProgressPercent = default(int?))
        {
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            OperationState = operationState;
            StatusCode = statusCode;
            StartedTimestamp = startedTimestamp;
            ProcessedFilesCount = processedFilesCount;
            ProcessedDirectoriesCount = processedDirectoriesCount;
            TotalFilesCount = totalFilesCount;
            TotalDirectoriesCount = totalDirectoriesCount;
            TotalSizeBytes = totalSizeBytes;
            ProgressPercent = progressPercent;
            MinutesRemaining = minutesRemaining;
            TotalCountsState = totalCountsState;
            DeletesProgressPercent = deletesProgressPercent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets last updated timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.DateTime? LastUpdatedTimestamp { get; private set; }

        /// <summary>
        /// Gets change enumeration operation state. Possible values include:
        /// 'InitialEnumerationInProgress', 'EnumerationInProgress'
        /// </summary>
        [JsonProperty(PropertyName = "operationState")]
        public string OperationState { get; private set; }

        /// <summary>
        /// Gets when non-zero, indicates an issue that is delaying change
        /// enumeration
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; private set; }

        /// <summary>
        /// Gets timestamp when change enumeration started
        /// </summary>
        [JsonProperty(PropertyName = "startedTimestamp")]
        public System.DateTime? StartedTimestamp { get; private set; }

        /// <summary>
        /// Gets count of files processed
        /// </summary>
        [JsonProperty(PropertyName = "processedFilesCount")]
        public long? ProcessedFilesCount { get; private set; }

        /// <summary>
        /// Gets count of directories processed
        /// </summary>
        [JsonProperty(PropertyName = "processedDirectoriesCount")]
        public long? ProcessedDirectoriesCount { get; private set; }

        /// <summary>
        /// Gets total count of files enumerated
        /// </summary>
        [JsonProperty(PropertyName = "totalFilesCount")]
        public long? TotalFilesCount { get; private set; }

        /// <summary>
        /// Gets total count of directories enumerated
        /// </summary>
        [JsonProperty(PropertyName = "totalDirectoriesCount")]
        public long? TotalDirectoriesCount { get; private set; }

        /// <summary>
        /// Gets total enumerated size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "totalSizeBytes")]
        public long? TotalSizeBytes { get; private set; }

        /// <summary>
        /// Gets progress percentage for change enumeration run, excluding
        /// processing of deletes
        /// </summary>
        [JsonProperty(PropertyName = "progressPercent")]
        public int? ProgressPercent { get; private set; }

        /// <summary>
        /// Gets estimate of time remaining for the enumeration run
        /// </summary>
        [JsonProperty(PropertyName = "minutesRemaining")]
        public int? MinutesRemaining { get; private set; }

        /// <summary>
        /// Gets change enumeration total counts state. Possible values
        /// include: 'Calculating', 'Final'
        /// </summary>
        [JsonProperty(PropertyName = "totalCountsState")]
        public string TotalCountsState { get; private set; }

        /// <summary>
        /// Gets progress percentage for processing deletes. This is done
        /// separately from the rest of the enumeration run
        /// </summary>
        [JsonProperty(PropertyName = "deletesProgressPercent")]
        public int? DeletesProgressPercent { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProcessedFilesCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ProcessedFilesCount", 0);
            }
            if (ProcessedDirectoriesCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ProcessedDirectoriesCount", 0);
            }
            if (TotalFilesCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalFilesCount", 0);
            }
            if (TotalDirectoriesCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalDirectoriesCount", 0);
            }
            if (TotalSizeBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalSizeBytes", 0);
            }
            if (ProgressPercent > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ProgressPercent", 100);
            }
            if (ProgressPercent < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ProgressPercent", 0);
            }
            if (MinutesRemaining < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinutesRemaining", 0);
            }
            if (DeletesProgressPercent > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "DeletesProgressPercent", 100);
            }
            if (DeletesProgressPercent < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "DeletesProgressPercent", 0);
            }
        }
    }
}