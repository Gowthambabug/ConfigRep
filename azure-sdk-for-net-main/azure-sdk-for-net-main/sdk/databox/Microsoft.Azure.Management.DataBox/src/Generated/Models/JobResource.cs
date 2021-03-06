// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the JobResource class.
        /// </summary>
        public JobResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobResource class.
        /// </summary>
        /// <param name="location">The location of the resource. This will be
        /// one of the supported and registered Azure Regions (e.g. West US,
        /// East US, Southeast Asia, etc.). The region of a resource cannot be
        /// changed once it is created, but if an identical region is specified
        /// on update the request will succeed.</param>
        /// <param name="sku">The sku type.</param>
        /// <param name="transferType">Type of the data transfer. Possible
        /// values include: 'ImportToAzure', 'ExportFromAzure'</param>
        /// <param name="tags">The list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource (across resource groups).</param>
        /// <param name="identity">Msi identity of the resource</param>
        /// <param name="isCancellable">Describes whether the job is
        /// cancellable or not.</param>
        /// <param name="isDeletable">Describes whether the job is deletable or
        /// not.</param>
        /// <param name="isShippingAddressEditable">Describes whether the
        /// shipping address is editable or not.</param>
        /// <param name="isPrepareToShipEnabled">Is Prepare To Ship Enabled on
        /// this job</param>
        /// <param name="status">Name of the stage which is in progress.
        /// Possible values include: 'DeviceOrdered', 'DevicePrepared',
        /// 'Dispatched', 'Delivered', 'PickedUp', 'AtAzureDC', 'DataCopy',
        /// 'Completed', 'CompletedWithErrors', 'Cancelled',
        /// 'Failed_IssueReportedAtCustomer', 'Failed_IssueDetectedAtAzureDC',
        /// 'Aborted', 'CompletedWithWarnings', 'ReadyToDispatchFromAzureDC',
        /// 'ReadyToReceiveAtAzureDC', 'Created', 'ShippedToAzureDC',
        /// 'AwaitingShipmentDetails', 'PreparingToShipFromAzureDC',
        /// 'ShippedToCustomer'</param>
        /// <param name="startTime">Time at which the job was started in UTC
        /// ISO 8601 format.</param>
        /// <param name="error">Top level error for the job.</param>
        /// <param name="details">Details of a job run. This field will only be
        /// sent for expand details filter.</param>
        /// <param name="cancellationReason">Reason for cancellation.</param>
        /// <param name="deliveryType">Delivery type of Job. Possible values
        /// include: 'NonScheduled', 'Scheduled'</param>
        /// <param name="deliveryInfo">Delivery Info of Job.</param>
        /// <param name="isCancellableWithoutFee">Flag to indicate cancellation
        /// of scheduled job.</param>
        /// <param name="name">Name of the object.</param>
        /// <param name="id">Id of the object.</param>
        /// <param name="type">Type of the object.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public JobResource(string location, Sku sku, TransferType transferType, IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), bool? isCancellable = default(bool?), bool? isDeletable = default(bool?), bool? isShippingAddressEditable = default(bool?), bool? isPrepareToShipEnabled = default(bool?), string status = default(string), System.DateTime? startTime = default(System.DateTime?), CloudError error = default(CloudError), JobDetails details = default(JobDetails), string cancellationReason = default(string), JobDeliveryType? deliveryType = default(JobDeliveryType?), JobDeliveryInfo deliveryInfo = default(JobDeliveryInfo), bool? isCancellableWithoutFee = default(bool?), string name = default(string), string id = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(location, sku, tags, identity)
        {
            TransferType = transferType;
            IsCancellable = isCancellable;
            IsDeletable = isDeletable;
            IsShippingAddressEditable = isShippingAddressEditable;
            IsPrepareToShipEnabled = isPrepareToShipEnabled;
            Status = status;
            StartTime = startTime;
            Error = error;
            Details = details;
            CancellationReason = cancellationReason;
            DeliveryType = deliveryType;
            DeliveryInfo = deliveryInfo;
            IsCancellableWithoutFee = isCancellableWithoutFee;
            Name = name;
            Id = id;
            Type = type;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the data transfer. Possible values include:
        /// 'ImportToAzure', 'ExportFromAzure'
        /// </summary>
        [JsonProperty(PropertyName = "properties.transferType")]
        public TransferType TransferType { get; set; }

        /// <summary>
        /// Gets describes whether the job is cancellable or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCancellable")]
        public bool? IsCancellable { get; private set; }

        /// <summary>
        /// Gets describes whether the job is deletable or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDeletable")]
        public bool? IsDeletable { get; private set; }

        /// <summary>
        /// Gets describes whether the shipping address is editable or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isShippingAddressEditable")]
        public bool? IsShippingAddressEditable { get; private set; }

        /// <summary>
        /// Gets is Prepare To Ship Enabled on this job
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPrepareToShipEnabled")]
        public bool? IsPrepareToShipEnabled { get; private set; }

        /// <summary>
        /// Gets name of the stage which is in progress. Possible values
        /// include: 'DeviceOrdered', 'DevicePrepared', 'Dispatched',
        /// 'Delivered', 'PickedUp', 'AtAzureDC', 'DataCopy', 'Completed',
        /// 'CompletedWithErrors', 'Cancelled',
        /// 'Failed_IssueReportedAtCustomer', 'Failed_IssueDetectedAtAzureDC',
        /// 'Aborted', 'CompletedWithWarnings', 'ReadyToDispatchFromAzureDC',
        /// 'ReadyToReceiveAtAzureDC', 'Created', 'ShippedToAzureDC',
        /// 'AwaitingShipmentDetails', 'PreparingToShipFromAzureDC',
        /// 'ShippedToCustomer'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets time at which the job was started in UTC ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets top level error for the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public CloudError Error { get; private set; }

        /// <summary>
        /// Gets or sets details of a job run. This field will only be sent for
        /// expand details filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public JobDetails Details { get; set; }

        /// <summary>
        /// Gets reason for cancellation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cancellationReason")]
        public string CancellationReason { get; private set; }

        /// <summary>
        /// Gets or sets delivery type of Job. Possible values include:
        /// 'NonScheduled', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deliveryType")]
        public JobDeliveryType? DeliveryType { get; set; }

        /// <summary>
        /// Gets or sets delivery Info of Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deliveryInfo")]
        public JobDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// Gets flag to indicate cancellation of scheduled job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCancellableWithoutFee")]
        public bool? IsCancellableWithoutFee { get; private set; }

        /// <summary>
        /// Gets name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets id of the object.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets type of the object.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Details != null)
            {
                Details.Validate();
            }
        }
    }
}
