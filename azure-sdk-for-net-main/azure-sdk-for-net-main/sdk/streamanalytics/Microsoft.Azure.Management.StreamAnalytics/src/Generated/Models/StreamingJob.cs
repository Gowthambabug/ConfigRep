// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A streaming job object, containing all information associated with the
    /// named streaming job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StreamingJob : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the StreamingJob class.
        /// </summary>
        public StreamingJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingJob class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="sku">Describes the SKU of the streaming job. Required
        /// on PUT (CreateOrReplace) requests.</param>
        /// <param name="jobId">A GUID uniquely identifying the streaming job.
        /// This GUID is generated upon creation of the streaming job.</param>
        /// <param name="provisioningState">Describes the provisioning status
        /// of the streaming job.</param>
        /// <param name="jobState">Describes the state of the streaming
        /// job.</param>
        /// <param name="jobType">Describes the type of the job. Valid modes
        /// are `Cloud` and 'Edge'. Possible values include: 'Cloud',
        /// 'Edge'</param>
        /// <param name="outputStartMode">This property should only be utilized
        /// when it is desired that the job be started immediately upon
        /// creation. Value may be JobStartTime, CustomTime, or
        /// LastOutputEventTime to indicate whether the starting point of the
        /// output event stream should start whenever the job is started, start
        /// at a custom user time stamp specified via the outputStartTime
        /// property, or start from the last event output time. Possible values
        /// include: 'JobStartTime', 'CustomTime',
        /// 'LastOutputEventTime'</param>
        /// <param name="outputStartTime">Value is either an ISO-8601 formatted
        /// time stamp that indicates the starting point of the output event
        /// stream, or null to indicate that the output event stream will start
        /// whenever the streaming job is started. This property must have a
        /// value if outputStartMode is set to CustomTime.</param>
        /// <param name="lastOutputEventTime">Value is either an ISO-8601
        /// formatted timestamp indicating the last output event time of the
        /// streaming job or null indicating that output has not yet been
        /// produced. In case of multiple outputs or multiple streams, this
        /// shows the latest value in that set.</param>
        /// <param name="eventsOutOfOrderPolicy">Indicates the policy to apply
        /// to events that arrive out of order in the input event stream.
        /// Possible values include: 'Adjust', 'Drop'</param>
        /// <param name="outputErrorPolicy">Indicates the policy to apply to
        /// events that arrive at the output and cannot be written to the
        /// external storage due to being malformed (missing column values,
        /// column values of wrong type or size). Possible values include:
        /// 'Stop', 'Drop'</param>
        /// <param name="eventsOutOfOrderMaxDelayInSeconds">The maximum
        /// tolerable delay in seconds where out-of-order events can be
        /// adjusted to be back in order.</param>
        /// <param name="eventsLateArrivalMaxDelayInSeconds">The maximum
        /// tolerable delay in seconds where events arriving late could be
        /// included.  Supported range is -1 to 1814399 (20.23:59:59 days) and
        /// -1 is used to specify wait indefinitely. If the property is absent,
        /// it is interpreted to have a value of -1.</param>
        /// <param name="dataLocale">The data locale of the stream analytics
        /// job. Value should be the name of a supported .NET Culture from the
        /// set
        /// https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx.
        /// Defaults to 'en-US' if none specified.</param>
        /// <param name="compatibilityLevel">Controls certain runtime behaviors
        /// of the streaming job. Possible values include: '1.0', '1.2'</param>
        /// <param name="createdDate">Value is an ISO-8601 formatted UTC
        /// timestamp indicating when the streaming job was created.</param>
        /// <param name="inputs">A list of one or more inputs to the streaming
        /// job. The name property for each input is required when specifying
        /// this property in a PUT request. This property cannot be modify via
        /// a PATCH operation. You must use the PATCH API available for the
        /// individual input.</param>
        /// <param name="transformation">Indicates the query and the number of
        /// streaming units to use for the streaming job. The name property of
        /// the transformation is required when specifying this property in a
        /// PUT request. This property cannot be modify via a PATCH operation.
        /// You must use the PATCH API available for the individual
        /// transformation.</param>
        /// <param name="outputs">A list of one or more outputs for the
        /// streaming job. The name property for each output is required when
        /// specifying this property in a PUT request. This property cannot be
        /// modify via a PATCH operation. You must use the PATCH API available
        /// for the individual output.</param>
        /// <param name="functions">A list of one or more functions for the
        /// streaming job. The name property for each function is required when
        /// specifying this property in a PUT request. This property cannot be
        /// modify via a PATCH operation. You must use the PATCH API available
        /// for the individual transformation.</param>
        /// <param name="etag">The current entity tag for the streaming job.
        /// This is an opaque string. You can use it to detect whether the
        /// resource has changed between requests. You can also use it in the
        /// If-Match or If-None-Match headers for write operations for
        /// optimistic concurrency.</param>
        /// <param name="jobStorageAccount">The properties that are associated
        /// with an Azure Storage account with MSI</param>
        /// <param name="contentStoragePolicy">Valid values are
        /// JobStorageAccount and SystemAccount. If set to JobStorageAccount,
        /// this requires the user to also specify jobStorageAccount property.
        /// Possible values include: 'SystemAccount',
        /// 'JobStorageAccount'</param>
        /// <param name="cluster">The cluster which streaming jobs will run
        /// on.</param>
        /// <param name="identity">Describes the system-assigned managed
        /// identity assigned to this job that can be used to authenticate with
        /// inputs and outputs.</param>
        public StreamingJob(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), Sku sku = default(Sku), string jobId = default(string), string provisioningState = default(string), string jobState = default(string), string jobType = default(string), string outputStartMode = default(string), System.DateTime? outputStartTime = default(System.DateTime?), System.DateTime? lastOutputEventTime = default(System.DateTime?), string eventsOutOfOrderPolicy = default(string), string outputErrorPolicy = default(string), int? eventsOutOfOrderMaxDelayInSeconds = default(int?), int? eventsLateArrivalMaxDelayInSeconds = default(int?), string dataLocale = default(string), string compatibilityLevel = default(string), System.DateTime? createdDate = default(System.DateTime?), IList<Input> inputs = default(IList<Input>), Transformation transformation = default(Transformation), IList<Output> outputs = default(IList<Output>), IList<Function> functions = default(IList<Function>), string etag = default(string), JobStorageAccount jobStorageAccount = default(JobStorageAccount), string contentStoragePolicy = default(string), ClusterInfo cluster = default(ClusterInfo), Identity identity = default(Identity))
            : base(id, name, type, tags, location)
        {
            Sku = sku;
            JobId = jobId;
            ProvisioningState = provisioningState;
            JobState = jobState;
            JobType = jobType;
            OutputStartMode = outputStartMode;
            OutputStartTime = outputStartTime;
            LastOutputEventTime = lastOutputEventTime;
            EventsOutOfOrderPolicy = eventsOutOfOrderPolicy;
            OutputErrorPolicy = outputErrorPolicy;
            EventsOutOfOrderMaxDelayInSeconds = eventsOutOfOrderMaxDelayInSeconds;
            EventsLateArrivalMaxDelayInSeconds = eventsLateArrivalMaxDelayInSeconds;
            DataLocale = dataLocale;
            CompatibilityLevel = compatibilityLevel;
            CreatedDate = createdDate;
            Inputs = inputs;
            Transformation = transformation;
            Outputs = outputs;
            Functions = functions;
            Etag = etag;
            JobStorageAccount = jobStorageAccount;
            ContentStoragePolicy = contentStoragePolicy;
            Cluster = cluster;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the SKU of the streaming job. Required on
        /// PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets a GUID uniquely identifying the streaming job. This GUID is
        /// generated upon creation of the streaming job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobId")]
        public string JobId { get; private set; }

        /// <summary>
        /// Gets describes the provisioning status of the streaming job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets describes the state of the streaming job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobState")]
        public string JobState { get; private set; }

        /// <summary>
        /// Gets or sets describes the type of the job. Valid modes are `Cloud`
        /// and 'Edge'. Possible values include: 'Cloud', 'Edge'
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobType")]
        public string JobType { get; set; }

        /// <summary>
        /// Gets or sets this property should only be utilized when it is
        /// desired that the job be started immediately upon creation. Value
        /// may be JobStartTime, CustomTime, or LastOutputEventTime to indicate
        /// whether the starting point of the output event stream should start
        /// whenever the job is started, start at a custom user time stamp
        /// specified via the outputStartTime property, or start from the last
        /// event output time. Possible values include: 'JobStartTime',
        /// 'CustomTime', 'LastOutputEventTime'
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputStartMode")]
        public string OutputStartMode { get; set; }

        /// <summary>
        /// Gets or sets value is either an ISO-8601 formatted time stamp that
        /// indicates the starting point of the output event stream, or null to
        /// indicate that the output event stream will start whenever the
        /// streaming job is started. This property must have a value if
        /// outputStartMode is set to CustomTime.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputStartTime")]
        public System.DateTime? OutputStartTime { get; set; }

        /// <summary>
        /// Gets value is either an ISO-8601 formatted timestamp indicating the
        /// last output event time of the streaming job or null indicating that
        /// output has not yet been produced. In case of multiple outputs or
        /// multiple streams, this shows the latest value in that set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastOutputEventTime")]
        public System.DateTime? LastOutputEventTime { get; private set; }

        /// <summary>
        /// Gets or sets indicates the policy to apply to events that arrive
        /// out of order in the input event stream. Possible values include:
        /// 'Adjust', 'Drop'
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventsOutOfOrderPolicy")]
        public string EventsOutOfOrderPolicy { get; set; }

        /// <summary>
        /// Gets or sets indicates the policy to apply to events that arrive at
        /// the output and cannot be written to the external storage due to
        /// being malformed (missing column values, column values of wrong type
        /// or size). Possible values include: 'Stop', 'Drop'
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputErrorPolicy")]
        public string OutputErrorPolicy { get; set; }

        /// <summary>
        /// Gets or sets the maximum tolerable delay in seconds where
        /// out-of-order events can be adjusted to be back in order.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventsOutOfOrderMaxDelayInSeconds")]
        public int? EventsOutOfOrderMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the maximum tolerable delay in seconds where events
        /// arriving late could be included.  Supported range is -1 to 1814399
        /// (20.23:59:59 days) and -1 is used to specify wait indefinitely. If
        /// the property is absent, it is interpreted to have a value of -1.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventsLateArrivalMaxDelayInSeconds")]
        public int? EventsLateArrivalMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the data locale of the stream analytics job. Value
        /// should be the name of a supported .NET Culture from the set
        /// https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx.
        /// Defaults to 'en-US' if none specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataLocale")]
        public string DataLocale { get; set; }

        /// <summary>
        /// Gets or sets controls certain runtime behaviors of the streaming
        /// job. Possible values include: '1.0', '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.compatibilityLevel")]
        public string CompatibilityLevel { get; set; }

        /// <summary>
        /// Gets value is an ISO-8601 formatted UTC timestamp indicating when
        /// the streaming job was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets a list of one or more inputs to the streaming job. The
        /// name property for each input is required when specifying this
        /// property in a PUT request. This property cannot be modify via a
        /// PATCH operation. You must use the PATCH API available for the
        /// individual input.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputs")]
        public IList<Input> Inputs { get; set; }

        /// <summary>
        /// Gets or sets indicates the query and the number of streaming units
        /// to use for the streaming job. The name property of the
        /// transformation is required when specifying this property in a PUT
        /// request. This property cannot be modify via a PATCH operation. You
        /// must use the PATCH API available for the individual transformation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.transformation")]
        public Transformation Transformation { get; set; }

        /// <summary>
        /// Gets or sets a list of one or more outputs for the streaming job.
        /// The name property for each output is required when specifying this
        /// property in a PUT request. This property cannot be modify via a
        /// PATCH operation. You must use the PATCH API available for the
        /// individual output.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<Output> Outputs { get; set; }

        /// <summary>
        /// Gets or sets a list of one or more functions for the streaming job.
        /// The name property for each function is required when specifying
        /// this property in a PUT request. This property cannot be modify via
        /// a PATCH operation. You must use the PATCH API available for the
        /// individual transformation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.functions")]
        public IList<Function> Functions { get; set; }

        /// <summary>
        /// Gets the current entity tag for the streaming job. This is an
        /// opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets the properties that are associated with an Azure
        /// Storage account with MSI
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobStorageAccount")]
        public JobStorageAccount JobStorageAccount { get; set; }

        /// <summary>
        /// Gets or sets valid values are JobStorageAccount and SystemAccount.
        /// If set to JobStorageAccount, this requires the user to also specify
        /// jobStorageAccount property. Possible values include:
        /// 'SystemAccount', 'JobStorageAccount'
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentStoragePolicy")]
        public string ContentStoragePolicy { get; set; }

        /// <summary>
        /// Gets or sets the cluster which streaming jobs will run on.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cluster")]
        public ClusterInfo Cluster { get; set; }

        /// <summary>
        /// Gets or sets describes the system-assigned managed identity
        /// assigned to this job that can be used to authenticate with inputs
        /// and outputs.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

    }
}
