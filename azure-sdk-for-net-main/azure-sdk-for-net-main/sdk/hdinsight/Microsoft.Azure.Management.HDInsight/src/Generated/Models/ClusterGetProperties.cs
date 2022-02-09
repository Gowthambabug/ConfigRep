// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of cluster.
    /// </summary>
    public partial class ClusterGetProperties
    {
        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>
        public ClusterGetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>
        /// <param name="clusterDefinition">The cluster definition.</param>
        /// <param name="clusterVersion">The version of the cluster.</param>
        /// <param name="clusterHdpVersion">The hdp version of the
        /// cluster.</param>
        /// <param name="osType">The type of operating system. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="tier">The cluster tier. Possible values include:
        /// 'Standard', 'Premium'</param>
        /// <param name="clusterId">The cluster id.</param>
        /// <param name="kafkaRestProperties">The cluster kafka rest proxy
        /// configuration.</param>
        /// <param name="securityProfile">The security profile.</param>
        /// <param name="computeProfile">The compute profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response. Possible values include: 'InProgress',
        /// 'Failed', 'Succeeded', 'Canceled', 'Deleting'</param>
        /// <param name="createdDate">The date on which the cluster was
        /// created.</param>
        /// <param name="clusterState">The state of the cluster.</param>
        /// <param name="quotaInfo">The quota information.</param>
        /// <param name="errors">The list of errors.</param>
        /// <param name="connectivityEndpoints">The list of connectivity
        /// endpoints.</param>
        /// <param name="diskEncryptionProperties">The disk encryption
        /// properties.</param>
        /// <param name="encryptionInTransitProperties">The
        /// encryption-in-transit properties.</param>
        /// <param name="storageProfile">The storage profile.</param>
        /// <param name="minSupportedTlsVersion">The minimal supported tls
        /// version.</param>
        /// <param name="excludedServicesConfig">The excluded services
        /// config.</param>
        /// <param name="networkProperties">The network properties.</param>
        /// <param name="computeIsolationProperties">The compute isolation
        /// properties.</param>
        /// <param name="privateLinkConfigurations">The private link
        /// configurations.</param>
        /// <param name="privateEndpointConnections">The list of private
        /// endpoint connections.</param>
        public ClusterGetProperties(ClusterDefinition clusterDefinition, string clusterVersion = default(string), string clusterHdpVersion = default(string), string osType = default(string), string tier = default(string), string clusterId = default(string), KafkaRestProperties kafkaRestProperties = default(KafkaRestProperties), SecurityProfile securityProfile = default(SecurityProfile), ComputeProfile computeProfile = default(ComputeProfile), string provisioningState = default(string), string createdDate = default(string), string clusterState = default(string), QuotaInfo quotaInfo = default(QuotaInfo), IList<Errors> errors = default(IList<Errors>), IList<ConnectivityEndpoint> connectivityEndpoints = default(IList<ConnectivityEndpoint>), DiskEncryptionProperties diskEncryptionProperties = default(DiskEncryptionProperties), EncryptionInTransitProperties encryptionInTransitProperties = default(EncryptionInTransitProperties), StorageProfile storageProfile = default(StorageProfile), string minSupportedTlsVersion = default(string), ExcludedServicesConfig excludedServicesConfig = default(ExcludedServicesConfig), NetworkProperties networkProperties = default(NetworkProperties), ComputeIsolationProperties computeIsolationProperties = default(ComputeIsolationProperties), IList<PrivateLinkConfiguration> privateLinkConfigurations = default(IList<PrivateLinkConfiguration>), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>))
        {
            ClusterVersion = clusterVersion;
            ClusterHdpVersion = clusterHdpVersion;
            OsType = osType;
            Tier = tier;
            ClusterId = clusterId;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            ProvisioningState = provisioningState;
            CreatedDate = createdDate;
            ClusterState = clusterState;
            QuotaInfo = quotaInfo;
            Errors = errors;
            ConnectivityEndpoints = connectivityEndpoints;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            StorageProfile = storageProfile;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            ExcludedServicesConfig = excludedServicesConfig;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterVersion")]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets the hdp version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterHdpVersion")]
        public string ClusterHdpVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the cluster tier. Possible values include: 'Standard',
        /// 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the cluster id.
        /// </summary>
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets the cluster definition.
        /// </summary>
        [JsonProperty(PropertyName = "clusterDefinition")]
        public ClusterDefinition ClusterDefinition { get; set; }

        /// <summary>
        /// Gets or sets the cluster kafka rest proxy configuration.
        /// </summary>
        [JsonProperty(PropertyName = "kafkaRestProperties")]
        public KafkaRestProperties KafkaRestProperties { get; set; }

        /// <summary>
        /// Gets or sets the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets the compute profile.
        /// </summary>
        [JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state, which only appears in the
        /// response. Possible values include: 'InProgress', 'Failed',
        /// 'Succeeded', 'Canceled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the date on which the cluster was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the state of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterState")]
        public string ClusterState { get; set; }

        /// <summary>
        /// Gets or sets the quota information.
        /// </summary>
        [JsonProperty(PropertyName = "quotaInfo")]
        public QuotaInfo QuotaInfo { get; set; }

        /// <summary>
        /// Gets or sets the list of errors.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<Errors> Errors { get; set; }

        /// <summary>
        /// Gets or sets the list of connectivity endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "connectivityEndpoints")]
        public IList<ConnectivityEndpoint> ConnectivityEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionProperties")]
        public DiskEncryptionProperties DiskEncryptionProperties { get; set; }

        /// <summary>
        /// Gets or sets the encryption-in-transit properties.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionInTransitProperties")]
        public EncryptionInTransitProperties EncryptionInTransitProperties { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the minimal supported tls version.
        /// </summary>
        [JsonProperty(PropertyName = "minSupportedTlsVersion")]
        public string MinSupportedTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets the excluded services config.
        /// </summary>
        [JsonProperty(PropertyName = "excludedServicesConfig")]
        public ExcludedServicesConfig ExcludedServicesConfig { get; set; }

        /// <summary>
        /// Gets or sets the network properties.
        /// </summary>
        [JsonProperty(PropertyName = "networkProperties")]
        public NetworkProperties NetworkProperties { get; set; }

        /// <summary>
        /// Gets or sets the compute isolation properties.
        /// </summary>
        [JsonProperty(PropertyName = "computeIsolationProperties")]
        public ComputeIsolationProperties ComputeIsolationProperties { get; set; }

        /// <summary>
        /// Gets or sets the private link configurations.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkConfigurations")]
        public IList<PrivateLinkConfiguration> PrivateLinkConfigurations { get; set; }

        /// <summary>
        /// Gets the list of private endpoint connections.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClusterDefinition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterDefinition");
            }
            if (PrivateLinkConfigurations != null)
            {
                foreach (var element in PrivateLinkConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (PrivateEndpointConnections != null)
            {
                foreach (var element1 in PrivateEndpointConnections)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}