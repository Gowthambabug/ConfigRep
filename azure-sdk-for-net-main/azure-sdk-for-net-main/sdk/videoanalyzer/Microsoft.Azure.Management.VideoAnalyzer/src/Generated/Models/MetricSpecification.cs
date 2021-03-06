// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A metric emitted by service.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">The metric name.</param>
        /// <param name="displayName">The metric display name.</param>
        /// <param name="displayDescription">The metric display
        /// description.</param>
        /// <param name="unit">The metric unit. Possible values include:
        /// 'Bytes', 'Count', 'Milliseconds'</param>
        /// <param name="aggregationType">The metric aggregation type. Possible
        /// values include: 'Average', 'Count', 'Total'</param>
        /// <param name="lockAggregationType">The metric lock aggregation type.
        /// Possible values include: 'Average', 'Count', 'Total'</param>
        /// <param name="supportedAggregationTypes">Supported aggregation
        /// types.</param>
        /// <param name="dimensions">The metric dimensions.</param>
        /// <param name="enableRegionalMdmAccount">Indicates whether regional
        /// MDM account is enabled.</param>
        /// <param name="sourceMdmAccount">The source MDM account.</param>
        /// <param name="sourceMdmNamespace">The source MDM namespace.</param>
        /// <param name="supportedTimeGrainTypes">The supported time grain
        /// types.</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), MetricUnit unit = default(MetricUnit), MetricAggregationType aggregationType = default(MetricAggregationType), MetricAggregationType? lockAggregationType = default(MetricAggregationType?), IList<string> supportedAggregationTypes = default(IList<string>), IList<MetricDimension> dimensions = default(IList<MetricDimension>), bool enableRegionalMdmAccount = default(bool), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), IList<string> supportedTimeGrainTypes = default(IList<string>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            LockAggregationType = lockAggregationType;
            SupportedAggregationTypes = supportedAggregationTypes;
            Dimensions = dimensions;
            EnableRegionalMdmAccount = enableRegionalMdmAccount;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the metric name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the metric display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the metric display description.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; private set; }

        /// <summary>
        /// Gets the metric unit. Possible values include: 'Bytes', 'Count',
        /// 'Milliseconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public MetricUnit Unit { get; private set; }

        /// <summary>
        /// Gets the metric aggregation type. Possible values include:
        /// 'Average', 'Count', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public MetricAggregationType AggregationType { get; private set; }

        /// <summary>
        /// Gets the metric lock aggregation type. Possible values include:
        /// 'Average', 'Count', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "lockAggregationType")]
        public MetricAggregationType? LockAggregationType { get; private set; }

        /// <summary>
        /// Gets or sets supported aggregation types.
        /// </summary>
        [JsonProperty(PropertyName = "supportedAggregationTypes")]
        public IList<string> SupportedAggregationTypes { get; set; }

        /// <summary>
        /// Gets the metric dimensions.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimension> Dimensions { get; private set; }

        /// <summary>
        /// Gets indicates whether regional MDM account is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableRegionalMdmAccount")]
        public bool EnableRegionalMdmAccount { get; private set; }

        /// <summary>
        /// Gets the source MDM account.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; private set; }

        /// <summary>
        /// Gets the source MDM namespace.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; private set; }

        /// <summary>
        /// Gets the supported time grain types.
        /// </summary>
        [JsonProperty(PropertyName = "supportedTimeGrainTypes")]
        public IList<string> SupportedTimeGrainTypes { get; private set; }

    }
}
