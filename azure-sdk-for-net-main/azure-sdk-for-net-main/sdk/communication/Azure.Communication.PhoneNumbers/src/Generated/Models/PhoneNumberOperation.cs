// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Long running operation. </summary>
    internal partial class PhoneNumberOperation
    {
        /// <summary> Initializes a new instance of PhoneNumberOperation. </summary>
        /// <param name="status"> Status of operation. </param>
        /// <param name="createdDateTime"> The date that the operation was created. </param>
        /// <param name="id"> Id of operation. </param>
        /// <param name="operationType"> The type of operation, e.g. Search. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal PhoneNumberOperation(PhoneNumberOperationStatus status, DateTimeOffset createdDateTime, string id, PhoneNumberOperationType operationType)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Status = status;
            CreatedDateTime = createdDateTime;
            Id = id;
            OperationType = operationType;
        }

        /// <summary> Initializes a new instance of PhoneNumberOperation. </summary>
        /// <param name="status"> Status of operation. </param>
        /// <param name="resourceLocation"> URL for retrieving the result of the operation, if any. </param>
        /// <param name="createdDateTime"> The date that the operation was created. </param>
        /// <param name="error"> The Communication Services error. </param>
        /// <param name="id"> Id of operation. </param>
        /// <param name="operationType"> The type of operation, e.g. Search. </param>
        /// <param name="lastActionDateTime"> The most recent date that the operation was changed. </param>
        internal PhoneNumberOperation(PhoneNumberOperationStatus status, string resourceLocation, DateTimeOffset createdDateTime, CommunicationError error, string id, PhoneNumberOperationType operationType, DateTimeOffset? lastActionDateTime)
        {
            Status = status;
            ResourceLocation = resourceLocation;
            CreatedDateTime = createdDateTime;
            Error = error;
            Id = id;
            OperationType = operationType;
            LastActionDateTime = lastActionDateTime;
        }

        /// <summary> Status of operation. </summary>
        public PhoneNumberOperationStatus Status { get; }
        /// <summary> URL for retrieving the result of the operation, if any. </summary>
        public string ResourceLocation { get; }
        /// <summary> The date that the operation was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> The Communication Services error. </summary>
        public CommunicationError Error { get; }
        /// <summary> Id of operation. </summary>
        public string Id { get; }
        /// <summary> The type of operation, e.g. Search. </summary>
        public PhoneNumberOperationType OperationType { get; }
        /// <summary> The most recent date that the operation was changed. </summary>
        public DateTimeOffset? LastActionDateTime { get; }
    }
}