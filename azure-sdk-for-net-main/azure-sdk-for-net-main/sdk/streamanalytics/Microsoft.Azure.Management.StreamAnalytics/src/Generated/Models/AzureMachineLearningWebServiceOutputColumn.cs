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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an output column for the Azure Machine Learning web service
    /// endpoint.
    /// </summary>
    public partial class AzureMachineLearningWebServiceOutputColumn
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureMachineLearningWebServiceOutputColumn class.
        /// </summary>
        public AzureMachineLearningWebServiceOutputColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureMachineLearningWebServiceOutputColumn class.
        /// </summary>
        /// <param name="name">The name of the output column.</param>
        /// <param name="dataType">The (Azure Machine Learning supported) data
        /// type of the output column. A list of valid  Azure Machine Learning
        /// data types are described at
        /// https://msdn.microsoft.com/en-us/library/azure/dn905923.aspx
        /// .</param>
        public AzureMachineLearningWebServiceOutputColumn(string name = default(string), string dataType = default(string))
        {
            Name = name;
            DataType = dataType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the output column.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the (Azure Machine Learning supported) data type of
        /// the output column. A list of valid  Azure Machine Learning data
        /// types are described at
        /// https://msdn.microsoft.com/en-us/library/azure/dn905923.aspx .
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

    }
}