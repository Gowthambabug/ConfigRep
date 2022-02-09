// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for MongoDB migration outputs
    /// </summary>
    public partial class MongoDbProgress
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbProgress class.
        /// </summary>
        public MongoDbProgress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbProgress class.
        /// </summary>
        /// <param name="bytesCopied">The number of document bytes copied
        /// during the Copying stage</param>
        /// <param name="documentsCopied">The number of documents copied during
        /// the Copying stage</param>
        /// <param name="elapsedTime">The elapsed time in the format
        /// [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format)</param>
        /// <param name="errors">The errors and warnings that have occurred for
        /// the current object. The keys are the error codes.</param>
        /// <param name="eventsPending">The number of oplog events awaiting
        /// replay</param>
        /// <param name="eventsReplayed">The number of oplog events replayed so
        /// far</param>
        /// <param name="state">Possible values include: 'NotStarted',
        /// 'ValidatingInput', 'Initializing', 'Restarting', 'Copying',
        /// 'InitialReplay', 'Replaying', 'Finalizing', 'Complete', 'Canceled',
        /// 'Failed'</param>
        /// <param name="totalBytes">The total number of document bytes on the
        /// source at the beginning of the Copying stage, or -1 if the total
        /// size was unknown</param>
        /// <param name="totalDocuments">The total number of documents on the
        /// source at the beginning of the Copying stage, or -1 if the total
        /// count was unknown</param>
        /// <param name="lastEventTime">The timestamp of the last oplog event
        /// received, or null if no oplog event has been received yet</param>
        /// <param name="lastReplayTime">The timestamp of the last oplog event
        /// replayed, or null if no oplog event has been replayed yet</param>
        /// <param name="name">The name of the progress object. For a
        /// collection, this is the unqualified collection name. For a
        /// database, this is the database name. For the overall migration,
        /// this is null.</param>
        /// <param name="qualifiedName">The qualified name of the progress
        /// object. For a collection, this is the database-qualified name. For
        /// a database, this is the database name. For the overall migration,
        /// this is null.</param>
        public MongoDbProgress(long bytesCopied, long documentsCopied, string elapsedTime, IDictionary<string, MongoDbError> errors, long eventsPending, long eventsReplayed, string state, long totalBytes, long totalDocuments, System.DateTimeOffset? lastEventTime = default(System.DateTimeOffset?), System.DateTimeOffset? lastReplayTime = default(System.DateTimeOffset?), string name = default(string), string qualifiedName = default(string))
        {
            BytesCopied = bytesCopied;
            DocumentsCopied = documentsCopied;
            ElapsedTime = elapsedTime;
            Errors = errors;
            EventsPending = eventsPending;
            EventsReplayed = eventsReplayed;
            LastEventTime = lastEventTime;
            LastReplayTime = lastReplayTime;
            Name = name;
            QualifiedName = qualifiedName;
            State = state;
            TotalBytes = totalBytes;
            TotalDocuments = totalDocuments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of document bytes copied during the Copying
        /// stage
        /// </summary>
        [JsonProperty(PropertyName = "bytesCopied")]
        public long BytesCopied { get; set; }

        /// <summary>
        /// Gets or sets the number of documents copied during the Copying
        /// stage
        /// </summary>
        [JsonProperty(PropertyName = "documentsCopied")]
        public long DocumentsCopied { get; set; }

        /// <summary>
        /// Gets or sets the elapsed time in the format
        /// [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format)
        /// </summary>
        [JsonProperty(PropertyName = "elapsedTime")]
        public string ElapsedTime { get; set; }

        /// <summary>
        /// Gets or sets the errors and warnings that have occurred for the
        /// current object. The keys are the error codes.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IDictionary<string, MongoDbError> Errors { get; set; }

        /// <summary>
        /// Gets or sets the number of oplog events awaiting replay
        /// </summary>
        [JsonProperty(PropertyName = "eventsPending")]
        public long EventsPending { get; set; }

        /// <summary>
        /// Gets or sets the number of oplog events replayed so far
        /// </summary>
        [JsonProperty(PropertyName = "eventsReplayed")]
        public long EventsReplayed { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the last oplog event received, or
        /// null if no oplog event has been received yet
        /// </summary>
        [JsonProperty(PropertyName = "lastEventTime")]
        public System.DateTimeOffset? LastEventTime { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the last oplog event replayed, or
        /// null if no oplog event has been replayed yet
        /// </summary>
        [JsonProperty(PropertyName = "lastReplayTime")]
        public System.DateTimeOffset? LastReplayTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the progress object. For a collection,
        /// this is the unqualified collection name. For a database, this is
        /// the database name. For the overall migration, this is null.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the qualified name of the progress object. For a
        /// collection, this is the database-qualified name. For a database,
        /// this is the database name. For the overall migration, this is null.
        /// </summary>
        [JsonProperty(PropertyName = "qualifiedName")]
        public string QualifiedName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NotStarted',
        /// 'ValidatingInput', 'Initializing', 'Restarting', 'Copying',
        /// 'InitialReplay', 'Replaying', 'Finalizing', 'Complete', 'Canceled',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the total number of document bytes on the source at
        /// the beginning of the Copying stage, or -1 if the total size was
        /// unknown
        /// </summary>
        [JsonProperty(PropertyName = "totalBytes")]
        public long TotalBytes { get; set; }

        /// <summary>
        /// Gets or sets the total number of documents on the source at the
        /// beginning of the Copying stage, or -1 if the total count was
        /// unknown
        /// </summary>
        [JsonProperty(PropertyName = "totalDocuments")]
        public long TotalDocuments { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ElapsedTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ElapsedTime");
            }
            if (Errors == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Errors");
            }
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}