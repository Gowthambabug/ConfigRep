// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The maximum size range capability.
    /// </summary>
    public partial class MaxSizeRangeCapability
    {
        /// <summary>
        /// Initializes a new instance of the MaxSizeRangeCapability class.
        /// </summary>
        public MaxSizeRangeCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaxSizeRangeCapability class.
        /// </summary>
        /// <param name="minValue">Minimum value.</param>
        /// <param name="maxValue">Maximum value.</param>
        /// <param name="scaleSize">Scale/step size for discrete values between
        /// the minimum value and the maximum value.</param>
        /// <param name="logSize">Size of transaction log.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public MaxSizeRangeCapability(MaxSizeCapability minValue = default(MaxSizeCapability), MaxSizeCapability maxValue = default(MaxSizeCapability), MaxSizeCapability scaleSize = default(MaxSizeCapability), LogSizeCapability logSize = default(LogSizeCapability), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            MinValue = minValue;
            MaxValue = maxValue;
            ScaleSize = scaleSize;
            LogSize = logSize;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets minimum value.
        /// </summary>
        [JsonProperty(PropertyName = "minValue")]
        public MaxSizeCapability MinValue { get; private set; }

        /// <summary>
        /// Gets maximum value.
        /// </summary>
        [JsonProperty(PropertyName = "maxValue")]
        public MaxSizeCapability MaxValue { get; private set; }

        /// <summary>
        /// Gets scale/step size for discrete values between the minimum value
        /// and the maximum value.
        /// </summary>
        [JsonProperty(PropertyName = "scaleSize")]
        public MaxSizeCapability ScaleSize { get; private set; }

        /// <summary>
        /// Gets size of transaction log.
        /// </summary>
        [JsonProperty(PropertyName = "logSize")]
        public LogSizeCapability LogSize { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
