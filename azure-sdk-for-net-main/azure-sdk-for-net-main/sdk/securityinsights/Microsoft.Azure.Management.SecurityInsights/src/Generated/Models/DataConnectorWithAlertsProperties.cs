// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data connector properties.
    /// </summary>
    public partial class DataConnectorWithAlertsProperties
    {
        /// <summary>
        /// Initializes a new instance of the DataConnectorWithAlertsProperties
        /// class.
        /// </summary>
        public DataConnectorWithAlertsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataConnectorWithAlertsProperties
        /// class.
        /// </summary>
        /// <param name="dataTypes">The available data types for the
        /// connector.</param>
        public DataConnectorWithAlertsProperties(AlertsDataTypeOfDataConnector dataTypes = default(AlertsDataTypeOfDataConnector))
        {
            DataTypes = dataTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the available data types for the connector.
        /// </summary>
        [JsonProperty(PropertyName = "dataTypes")]
        public AlertsDataTypeOfDataConnector DataTypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataTypes != null)
            {
                DataTypes.Validate();
            }
        }
    }
}
