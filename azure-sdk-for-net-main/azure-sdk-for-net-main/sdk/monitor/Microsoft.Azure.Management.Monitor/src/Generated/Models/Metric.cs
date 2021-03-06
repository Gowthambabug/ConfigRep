// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result data of a query.
    /// </summary>
    public partial class Metric
    {
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        /// <param name="id">the metric Id.</param>
        /// <param name="type">the resource type of the metric
        /// resource.</param>
        /// <param name="name">the name and the display name of the metric,
        /// i.e. it is localizable string.</param>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds', 'ByteSeconds', 'Unspecified', 'Cores',
        /// 'MilliCores', 'NanoCores', 'BitsPerSecond'</param>
        /// <param name="timeseries">the time series returned when a data query
        /// is performed.</param>
        /// <param name="displayDescription">Detailed description of this
        /// metric.</param>
        /// <param name="errorCode">'Success' or the error details on query
        /// failures for this metric.</param>
        /// <param name="errorMessage">Error message encountered querying this
        /// specific metric.</param>
        public Metric(string id, string type, LocalizableString name, string unit, IList<TimeSeriesElement> timeseries, string displayDescription = default(string), string errorCode = default(string), string errorMessage = default(string))
        {
            Id = id;
            Type = type;
            Name = name;
            DisplayDescription = displayDescription;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Unit = unit;
            Timeseries = timeseries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metric Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the resource type of the metric resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name and the display name of the metric, i.e. it
        /// is localizable string.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets detailed description of this metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets 'Success' or the error details on query failures for
        /// this metric.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets error message encountered querying this specific
        /// metric.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds', 'ByteSeconds', 'Unspecified', 'Cores',
        /// 'MilliCores', 'NanoCores', 'BitsPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the time series returned when a data query is
        /// performed.
        /// </summary>
        [JsonProperty(PropertyName = "timeseries")]
        public IList<TimeSeriesElement> Timeseries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Unit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Unit");
            }
            if (Timeseries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timeseries");
            }
            if (Name != null)
            {
                Name.Validate();
            }
        }
    }
}
