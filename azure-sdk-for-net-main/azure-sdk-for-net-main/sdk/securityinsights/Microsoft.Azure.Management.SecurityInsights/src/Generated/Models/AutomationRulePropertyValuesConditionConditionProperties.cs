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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration of the automation rule condition
    /// </summary>
    public partial class AutomationRulePropertyValuesConditionConditionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRulePropertyValuesConditionConditionProperties class.
        /// </summary>
        public AutomationRulePropertyValuesConditionConditionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRulePropertyValuesConditionConditionProperties class.
        /// </summary>
        /// <param name="propertyName">The property to evaluate. Possible
        /// values include: 'IncidentTitle', 'IncidentDescription',
        /// 'IncidentSeverity', 'IncidentStatus', 'IncidentTactics',
        /// 'IncidentRelatedAnalyticRuleIds', 'IncidentProviderName',
        /// 'AccountAadTenantId', 'AccountAadUserId', 'AccountName',
        /// 'AccountNTDomain', 'AccountPUID', 'AccountSid',
        /// 'AccountObjectGuid', 'AccountUPNSuffix', 'AzureResourceResourceId',
        /// 'AzureResourceSubscriptionId', 'CloudApplicationAppId',
        /// 'CloudApplicationAppName', 'DNSDomainName', 'FileDirectory',
        /// 'FileName', 'FileHashValue', 'HostAzureID', 'HostName',
        /// 'HostNetBiosName', 'HostNTDomain', 'HostOSVersion', 'IoTDeviceId',
        /// 'IoTDeviceName', 'IoTDeviceType', 'IoTDeviceVendor',
        /// 'IoTDeviceModel', 'IoTDeviceOperatingSystem', 'IPAddress',
        /// 'MailboxDisplayName', 'MailboxPrimaryAddress', 'MailboxUPN',
        /// 'MailMessageDeliveryAction', 'MailMessageDeliveryLocation',
        /// 'MailMessageRecipient', 'MailMessageSenderIP',
        /// 'MailMessageSubject', 'MailMessageP1Sender', 'MailMessageP2Sender',
        /// 'MalwareCategory', 'MalwareName', 'ProcessCommandLine',
        /// 'ProcessId', 'RegistryKey', 'RegistryValueData', 'Url'</param>
        /// <param name="operatorProperty">The operator to use for evaluation
        /// the condition. Possible values include: 'Equals', 'NotEquals',
        /// 'Contains', 'NotContains', 'StartsWith', 'NotStartsWith',
        /// 'EndsWith', 'NotEndsWith'</param>
        /// <param name="propertyValues">The values to use for evaluating the
        /// condition</param>
        public AutomationRulePropertyValuesConditionConditionProperties(string propertyName = default(string), string operatorProperty = default(string), IList<string> propertyValues = default(IList<string>))
        {
            PropertyName = propertyName;
            OperatorProperty = operatorProperty;
            PropertyValues = propertyValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the property to evaluate. Possible values include:
        /// 'IncidentTitle', 'IncidentDescription', 'IncidentSeverity',
        /// 'IncidentStatus', 'IncidentTactics',
        /// 'IncidentRelatedAnalyticRuleIds', 'IncidentProviderName',
        /// 'AccountAadTenantId', 'AccountAadUserId', 'AccountName',
        /// 'AccountNTDomain', 'AccountPUID', 'AccountSid',
        /// 'AccountObjectGuid', 'AccountUPNSuffix', 'AzureResourceResourceId',
        /// 'AzureResourceSubscriptionId', 'CloudApplicationAppId',
        /// 'CloudApplicationAppName', 'DNSDomainName', 'FileDirectory',
        /// 'FileName', 'FileHashValue', 'HostAzureID', 'HostName',
        /// 'HostNetBiosName', 'HostNTDomain', 'HostOSVersion', 'IoTDeviceId',
        /// 'IoTDeviceName', 'IoTDeviceType', 'IoTDeviceVendor',
        /// 'IoTDeviceModel', 'IoTDeviceOperatingSystem', 'IPAddress',
        /// 'MailboxDisplayName', 'MailboxPrimaryAddress', 'MailboxUPN',
        /// 'MailMessageDeliveryAction', 'MailMessageDeliveryLocation',
        /// 'MailMessageRecipient', 'MailMessageSenderIP',
        /// 'MailMessageSubject', 'MailMessageP1Sender', 'MailMessageP2Sender',
        /// 'MalwareCategory', 'MalwareName', 'ProcessCommandLine',
        /// 'ProcessId', 'RegistryKey', 'RegistryValueData', 'Url'
        /// </summary>
        [JsonProperty(PropertyName = "propertyName")]
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the operator to use for evaluation the condition.
        /// Possible values include: 'Equals', 'NotEquals', 'Contains',
        /// 'NotContains', 'StartsWith', 'NotStartsWith', 'EndsWith',
        /// 'NotEndsWith'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets the values to use for evaluating the condition
        /// </summary>
        [JsonProperty(PropertyName = "propertyValues")]
        public IList<string> PropertyValues { get; set; }

    }
}
