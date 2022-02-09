// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SyncMember data model. </summary>
    public partial class SyncMemberData : Resource
    {
        /// <summary> Initializes a new instance of SyncMemberData. </summary>
        public SyncMemberData()
        {
        }

        /// <summary> Initializes a new instance of SyncMemberData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseType"> Database type of the sync member. </param>
        /// <param name="syncAgentId"> ARM resource id of the sync agent in the sync member. </param>
        /// <param name="sqlServerDatabaseId"> SQL Server database id of the sync member. </param>
        /// <param name="syncMemberAzureDatabaseResourceId"> ARM resource id of the sync member logical database, for sync members in Azure. </param>
        /// <param name="usePrivateLinkConnection"> Whether to use private link connection. </param>
        /// <param name="privateEndpointName"> Private endpoint name of the sync member if use private link connection is enabled, for sync members in Azure. </param>
        /// <param name="serverName"> Server name of the member database in the sync member. </param>
        /// <param name="databaseName"> Database name of the member database in the sync member. </param>
        /// <param name="userName"> User name of the member database in the sync member. </param>
        /// <param name="password"> Password of the member database in the sync member. </param>
        /// <param name="syncDirection"> Sync direction of the sync member. </param>
        /// <param name="syncState"> Sync state of the sync member. </param>
        internal SyncMemberData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, SyncMemberDbType? databaseType, string syncAgentId, Guid? sqlServerDatabaseId, string syncMemberAzureDatabaseResourceId, bool? usePrivateLinkConnection, string privateEndpointName, string serverName, string databaseName, string userName, string password, SyncDirection? syncDirection, SyncMemberState? syncState) : base(id, name, type, systemData)
        {
            DatabaseType = databaseType;
            SyncAgentId = syncAgentId;
            SqlServerDatabaseId = sqlServerDatabaseId;
            SyncMemberAzureDatabaseResourceId = syncMemberAzureDatabaseResourceId;
            UsePrivateLinkConnection = usePrivateLinkConnection;
            PrivateEndpointName = privateEndpointName;
            ServerName = serverName;
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;
            SyncDirection = syncDirection;
            SyncState = syncState;
        }

        /// <summary> Database type of the sync member. </summary>
        public SyncMemberDbType? DatabaseType { get; set; }
        /// <summary> ARM resource id of the sync agent in the sync member. </summary>
        public string SyncAgentId { get; set; }
        /// <summary> SQL Server database id of the sync member. </summary>
        public Guid? SqlServerDatabaseId { get; set; }
        /// <summary> ARM resource id of the sync member logical database, for sync members in Azure. </summary>
        public string SyncMemberAzureDatabaseResourceId { get; set; }
        /// <summary> Whether to use private link connection. </summary>
        public bool? UsePrivateLinkConnection { get; set; }
        /// <summary> Private endpoint name of the sync member if use private link connection is enabled, for sync members in Azure. </summary>
        public string PrivateEndpointName { get; }
        /// <summary> Server name of the member database in the sync member. </summary>
        public string ServerName { get; set; }
        /// <summary> Database name of the member database in the sync member. </summary>
        public string DatabaseName { get; set; }
        /// <summary> User name of the member database in the sync member. </summary>
        public string UserName { get; set; }
        /// <summary> Password of the member database in the sync member. </summary>
        public string Password { get; set; }
        /// <summary> Sync direction of the sync member. </summary>
        public SyncDirection? SyncDirection { get; set; }
        /// <summary> Sync state of the sync member. </summary>
        public SyncMemberState? SyncState { get; }
    }
}