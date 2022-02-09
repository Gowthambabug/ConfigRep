// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class StorageAccountData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(IsSftpEnabled))
            {
                writer.WritePropertyName("isSftpEnabled");
                writer.WriteBooleanValue(IsSftpEnabled.Value);
            }
            if (Optional.IsDefined(IsLocalUserEnabled))
            {
                writer.WritePropertyName("isLocalUserEnabled");
                writer.WriteBooleanValue(IsLocalUserEnabled.Value);
            }
            if (Optional.IsDefined(IsHnsEnabled))
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            if (Optional.IsDefined(AllowBlobPublicAccess))
            {
                writer.WritePropertyName("allowBlobPublicAccess");
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(AllowSharedKeyAccess))
            {
                writer.WritePropertyName("allowSharedKeyAccess");
                writer.WriteBooleanValue(AllowSharedKeyAccess.Value);
            }
            if (Optional.IsDefined(EnableNfsV3))
            {
                writer.WritePropertyName("isNfsV3Enabled");
                writer.WriteBooleanValue(EnableNfsV3.Value);
            }
            if (Optional.IsDefined(AllowCrossTenantReplication))
            {
                writer.WritePropertyName("allowCrossTenantReplication");
                writer.WriteBooleanValue(AllowCrossTenantReplication.Value);
            }
            if (Optional.IsDefined(DefaultToOAuthAuthentication))
            {
                writer.WritePropertyName("defaultToOAuthAuthentication");
                writer.WriteBooleanValue(DefaultToOAuthAuthentication.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(ImmutableStorageWithVersioning))
            {
                writer.WritePropertyName("immutableStorageWithVersioning");
                writer.WriteObjectValue(ImmutableStorageWithVersioning);
            }
            if (Optional.IsDefined(AllowedCopyScope))
            {
                writer.WritePropertyName("allowedCopyScope");
                writer.WriteStringValue(AllowedCopyScope.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageAccountData DeserializeStorageAccountData(JsonElement element)
        {
            Optional<Models.Sku> sku = default;
            Optional<Kind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ExtendedLocation> extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<Endpoints> primaryEndpoints = default;
            Optional<string> primaryLocation = default;
            Optional<AccountStatus> statusOfPrimary = default;
            Optional<DateTimeOffset> lastGeoFailoverTime = default;
            Optional<string> secondaryLocation = default;
            Optional<AccountStatus> statusOfSecondary = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<CustomDomain> customDomain = default;
            Optional<SasPolicy> sasPolicy = default;
            Optional<KeyPolicy> keyPolicy = default;
            Optional<KeyCreationTime> keyCreationTime = default;
            Optional<Endpoints> secondaryEndpoints = default;
            Optional<Encryption> encryption = default;
            Optional<AccessTier> accessTier = default;
            Optional<AzureFilesIdentityBasedAuthentication> azureFilesIdentityBasedAuthentication = default;
            Optional<bool> supportsHttpsTrafficOnly = default;
            Optional<NetworkRuleSet> networkAcls = default;
            Optional<bool> isSftpEnabled = default;
            Optional<bool> isLocalUserEnabled = default;
            Optional<bool> isHnsEnabled = default;
            Optional<GeoReplicationStats> geoReplicationStats = default;
            Optional<bool> failoverInProgress = default;
            Optional<LargeFileSharesState> largeFileSharesState = default;
            Optional<IReadOnlyList<PrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<RoutingPreference> routingPreference = default;
            Optional<BlobRestoreStatus> blobRestoreStatus = default;
            Optional<bool> allowBlobPublicAccess = default;
            Optional<MinimumTlsVersion> minimumTlsVersion = default;
            Optional<bool> allowSharedKeyAccess = default;
            Optional<bool> isNfsV3Enabled = default;
            Optional<bool> allowCrossTenantReplication = default;
            Optional<bool> defaultToOAuthAuthentication = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<ImmutableStorageAccount> immutableStorageWithVersioning = default;
            Optional<AllowedCopyScope> allowedCopyScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Models.Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("primaryEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            primaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primaryLocation"))
                        {
                            primaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfPrimary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            statusOfPrimary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("lastGeoFailoverTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastGeoFailoverTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("secondaryLocation"))
                        {
                            secondaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfSecondary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            statusOfSecondary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("customDomain"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customDomain = CustomDomain.DeserializeCustomDomain(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sasPolicy = SasPolicy.DeserializeSasPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyPolicy = KeyPolicy.DeserializeKeyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyCreationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyCreationTime = KeyCreationTime.DeserializeKeyCreationTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("secondaryEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            secondaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryption = Encryption.DeserializeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessTier = property0.Value.GetString().ToAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureFilesIdentityBasedAuthentication = AzureFilesIdentityBasedAuthentication.DeserializeAzureFilesIdentityBasedAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportsHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkAcls = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isSftpEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isSftpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isLocalUserEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isLocalUserEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHnsEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isHnsEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("geoReplicationStats"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            geoReplicationStats = GeoReplicationStats.DeserializeGeoReplicationStats(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("failoverInProgress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            failoverInProgress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            largeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateEndpointConnectionData> array = new List<PrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routingPreference = RoutingPreference.DeserializeRoutingPreference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("blobRestoreStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            blobRestoreStatus = BlobRestoreStatus.DeserializeBlobRestoreStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowBlobPublicAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowBlobPublicAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minimumTlsVersion = new MinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowSharedKeyAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowSharedKeyAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isNfsV3Enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isNfsV3Enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowCrossTenantReplication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowCrossTenantReplication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultToOAuthAuthentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultToOAuthAuthentication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("immutableStorageWithVersioning"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            immutableStorageWithVersioning = ImmutableStorageAccount.DeserializeImmutableStorageAccount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowedCopyScope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowedCopyScope = new AllowedCopyScope(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageAccountData(id, name, type, systemData, tags, location, sku.Value, Optional.ToNullable(kind), identity, extendedLocation.Value, Optional.ToNullable(provisioningState), primaryEndpoints.Value, primaryLocation.Value, Optional.ToNullable(statusOfPrimary), Optional.ToNullable(lastGeoFailoverTime), secondaryLocation.Value, Optional.ToNullable(statusOfSecondary), Optional.ToNullable(creationTime), customDomain.Value, sasPolicy.Value, keyPolicy.Value, keyCreationTime.Value, secondaryEndpoints.Value, encryption.Value, Optional.ToNullable(accessTier), azureFilesIdentityBasedAuthentication.Value, Optional.ToNullable(supportsHttpsTrafficOnly), networkAcls.Value, Optional.ToNullable(isSftpEnabled), Optional.ToNullable(isLocalUserEnabled), Optional.ToNullable(isHnsEnabled), geoReplicationStats.Value, Optional.ToNullable(failoverInProgress), Optional.ToNullable(largeFileSharesState), Optional.ToList(privateEndpointConnections), routingPreference.Value, blobRestoreStatus.Value, Optional.ToNullable(allowBlobPublicAccess), Optional.ToNullable(minimumTlsVersion), Optional.ToNullable(allowSharedKeyAccess), Optional.ToNullable(isNfsV3Enabled), Optional.ToNullable(allowCrossTenantReplication), Optional.ToNullable(defaultToOAuthAuthentication), Optional.ToNullable(publicNetworkAccess), immutableStorageWithVersioning.Value, Optional.ToNullable(allowedCopyScope));
        }
    }
}