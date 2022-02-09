// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation Result Entity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OperationResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        public OperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        /// <param name="id">ID of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="status">status of the Operation result. Possible
        /// values include: 'Succeeded', 'Canceled', 'Failed',
        /// 'Running'</param>
        /// <param name="startTime">The operation start time</param>
        /// <param name="endTime">The operation end time</param>
        /// <param name="percentComplete">Percentage completed.</param>
        /// <param name="operationKind">The kind of the operation.</param>
        /// <param name="operationState">The state of the operation.</param>
        /// <param name="code">The code of the error.</param>
        /// <param name="message">The error message.</param>
        public OperationResult(string id = default(string), string name = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), double? percentComplete = default(double?), string operationKind = default(string), string operationState = default(string), string code = default(string), string message = default(string))
        {
            Id = id;
            Name = name;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            PercentComplete = percentComplete;
            OperationKind = operationKind;
            OperationState = operationState;
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets status of the Operation result. Possible values
        /// include: 'Succeeded', 'Canceled', 'Failed', 'Running'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the operation start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the operation end time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets percentage completed.
        /// </summary>
        [JsonProperty(PropertyName = "percentComplete")]
        public double? PercentComplete { get; set; }

        /// <summary>
        /// Gets or sets the kind of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationKind")]
        public string OperationKind { get; set; }

        /// <summary>
        /// Gets or sets the state of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationState")]
        public string OperationState { get; set; }

        /// <summary>
        /// Gets or sets the code of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error.code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "error.message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PercentComplete != null)
            {
                if (PercentComplete > 100)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "PercentComplete", 100);
                }
                if (PercentComplete < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "PercentComplete", 0);
                }
            }
        }
    }
}