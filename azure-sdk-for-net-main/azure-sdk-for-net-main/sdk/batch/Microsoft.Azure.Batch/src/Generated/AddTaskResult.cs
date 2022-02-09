// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result for a single task added as part of a collection of tasks.
    /// </summary>
    public partial class AddTaskResult : IPropertyMetadata
    {
        #region Constructors

        internal AddTaskResult(Models.TaskAddResult protocolObject)
        {
            this.Error = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Error, o => new BatchError(o).Freeze());
            this.ETag = protocolObject.ETag;
            this.LastModified = protocolObject.LastModified;
            this.Location = protocolObject.Location;
            this.Status = UtilitiesInternal.MapEnum<Models.TaskAddStatus, Common.AddTaskStatus>(protocolObject.Status);
            this.TaskId = protocolObject.TaskId;
        }

        #endregion Constructors

        #region AddTaskResult

        /// <summary>
        /// Gets the error caught while attempting to add the task.
        /// </summary>
        public BatchError Error { get; }

        /// <summary>
        /// Gets an ETag associated with a successfully added task.
        /// </summary>
        public string ETag { get; }

        /// <summary>
        /// Gets the last modified time associated with a successfully added task.
        /// </summary>
        public DateTime? LastModified { get; }

        /// <summary>
        /// Gets the URL of a successfully added task.
        /// </summary>
        public string Location { get; }

        /// <summary>
        /// Gets the status of the add task request.
        /// </summary>
        public Common.AddTaskStatus Status { get; }

        /// <summary>
        /// Gets the id of the task which this result applies to.
        /// </summary>
        public string TaskId { get; }

        #endregion // AddTaskResult

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}