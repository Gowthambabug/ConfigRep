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
    /// The execution information for a job schedule.
    /// </summary>
    public partial class JobScheduleExecutionInformation : IPropertyMetadata
    {
        #region Constructors

        internal JobScheduleExecutionInformation(Models.JobScheduleExecutionInformation protocolObject)
        {
            this.EndTime = protocolObject.EndTime;
            this.NextRunTime = protocolObject.NextRunTime;
            this.RecentJob = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.RecentJob, o => new RecentJob(o).Freeze());
        }

        #endregion Constructors

        #region JobScheduleExecutionInformation

        /// <summary>
        /// Gets the completion time of the job schedule. This property is only returned for completed job schedules.
        /// </summary>
        public DateTime? EndTime { get; }

        /// <summary>
        /// Gets the time at which the next job will be scheduled under this job schedule. This property is only returned 
        /// for active job schedules.
        /// </summary>
        public DateTime? NextRunTime { get; }

        /// <summary>
        /// Gets the information about the most recent job under the job schedule. Note that this element is only returned 
        /// if the job schedule contains at least one job under it.
        /// </summary>
        public RecentJob RecentJob { get; }

        #endregion // JobScheduleExecutionInformation

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