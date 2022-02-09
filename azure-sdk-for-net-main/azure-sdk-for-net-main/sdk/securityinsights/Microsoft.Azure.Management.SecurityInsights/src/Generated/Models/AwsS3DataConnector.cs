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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents Amazon Web Services S3 data connector.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonWebServicesS3")]
    [Rest.Serialization.JsonTransformation]
    public partial class AwsS3DataConnector : DataConnector
    {
        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnector class.
        /// </summary>
        public AwsS3DataConnector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnector class.
        /// </summary>
        /// <param name="destinationTable">The logs destination table name in
        /// LogAnalytics.</param>
        /// <param name="sqsUrls">The AWS sqs urls for the connector.</param>
        /// <param name="roleArn">The Aws Role Arn that is used to access the
        /// Aws account.</param>
        /// <param name="dataTypes">The available data types for the
        /// connector.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        public AwsS3DataConnector(string destinationTable, IList<string> sqsUrls, string roleArn, AwsS3DataConnectorDataTypes dataTypes, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string))
            : base(id, name, type, systemData, etag)
        {
            DestinationTable = destinationTable;
            SqsUrls = sqsUrls;
            RoleArn = roleArn;
            DataTypes = dataTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the logs destination table name in LogAnalytics.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationTable")]
        public string DestinationTable { get; set; }

        /// <summary>
        /// Gets or sets the AWS sqs urls for the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sqsUrls")]
        public IList<string> SqsUrls { get; set; }

        /// <summary>
        /// Gets or sets the Aws Role Arn that is used to access the Aws
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleArn")]
        public string RoleArn { get; set; }

        /// <summary>
        /// Gets or sets the available data types for the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataTypes")]
        public AwsS3DataConnectorDataTypes DataTypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DestinationTable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationTable");
            }
            if (SqsUrls == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SqsUrls");
            }
            if (RoleArn == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleArn");
            }
            if (DataTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataTypes");
            }
            if (DataTypes != null)
            {
                DataTypes.Validate();
            }
        }
    }
}