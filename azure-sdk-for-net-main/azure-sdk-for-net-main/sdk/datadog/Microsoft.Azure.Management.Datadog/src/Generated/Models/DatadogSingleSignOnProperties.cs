// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatadogSingleSignOnProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatadogSingleSignOnProperties
        /// class.
        /// </summary>
        public DatadogSingleSignOnProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatadogSingleSignOnProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">Possible values include:
        /// 'Accepted', 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleted', 'NotSpecified'</param>
        /// <param name="singleSignOnState">Possible values include: 'Initial',
        /// 'Enable', 'Disable', 'Existing'</param>
        /// <param name="enterpriseAppId">The Id of the Enterprise App used for
        /// Single sign-on.</param>
        /// <param name="singleSignOnUrl">The login URL specific to this
        /// Datadog Organization.</param>
        public DatadogSingleSignOnProperties(string provisioningState = default(string), string singleSignOnState = default(string), string enterpriseAppId = default(string), string singleSignOnUrl = default(string))
        {
            ProvisioningState = provisioningState;
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUrl = singleSignOnUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Accepted', 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled',
        /// 'Deleted', 'NotSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Initial', 'Enable',
        /// 'Disable', 'Existing'
        /// </summary>
        [JsonProperty(PropertyName = "singleSignOnState")]
        public string SingleSignOnState { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Enterprise App used for Single sign-on.
        /// </summary>
        [JsonProperty(PropertyName = "enterpriseAppId")]
        public string EnterpriseAppId { get; set; }

        /// <summary>
        /// Gets the login URL specific to this Datadog Organization.
        /// </summary>
        [JsonProperty(PropertyName = "singleSignOnUrl")]
        public string SingleSignOnUrl { get; private set; }

    }
}
