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
    /// The binding to an Azure Machine Learning web service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.MachineLearning/WebService")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMachineLearningWebServiceFunctionBinding : FunctionBinding
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureMachineLearningWebServiceFunctionBinding class.
        /// </summary>
        public AzureMachineLearningWebServiceFunctionBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureMachineLearningWebServiceFunctionBinding class.
        /// </summary>
        /// <param name="endpoint">The Request-Response execute endpoint of the
        /// Azure Machine Learning web service. Find out more here:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs</param>
        /// <param name="apiKey">The API key used to authenticate with
        /// Request-Response endpoint.</param>
        /// <param name="inputs">The inputs for the Azure Machine Learning web
        /// service endpoint.</param>
        /// <param name="outputs">A list of outputs from the Azure Machine
        /// Learning web service endpoint execution.</param>
        /// <param name="batchSize">Number between 1 and 10000 describing
        /// maximum number of rows for every Azure ML RRS execute request.
        /// Default is 1000.</param>
        public AzureMachineLearningWebServiceFunctionBinding(string endpoint = default(string), string apiKey = default(string), AzureMachineLearningWebServiceInputs inputs = default(AzureMachineLearningWebServiceInputs), IList<AzureMachineLearningWebServiceOutputColumn> outputs = default(IList<AzureMachineLearningWebServiceOutputColumn>), int? batchSize = default(int?))
        {
            Endpoint = endpoint;
            ApiKey = apiKey;
            Inputs = inputs;
            Outputs = outputs;
            BatchSize = batchSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Request-Response execute endpoint of the Azure
        /// Machine Learning web service. Find out more here:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the API key used to authenticate with Request-Response
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the inputs for the Azure Machine Learning web service
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputs")]
        public AzureMachineLearningWebServiceInputs Inputs { get; set; }

        /// <summary>
        /// Gets or sets a list of outputs from the Azure Machine Learning web
        /// service endpoint execution.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<AzureMachineLearningWebServiceOutputColumn> Outputs { get; set; }

        /// <summary>
        /// Gets or sets number between 1 and 10000 describing maximum number
        /// of rows for every Azure ML RRS execute request. Default is 1000.
        /// </summary>
        [JsonProperty(PropertyName = "properties.batchSize")]
        public int? BatchSize { get; set; }

    }
}
