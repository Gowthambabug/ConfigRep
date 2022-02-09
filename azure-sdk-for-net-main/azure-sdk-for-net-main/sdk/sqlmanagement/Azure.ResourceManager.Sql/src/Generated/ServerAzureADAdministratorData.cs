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
    /// <summary> A class representing the ServerAzureADAdministrator data model. </summary>
    public partial class ServerAzureADAdministratorData : Resource
    {
        /// <summary> Initializes a new instance of ServerAzureADAdministratorData. </summary>
        public ServerAzureADAdministratorData()
        {
        }

        /// <summary> Initializes a new instance of ServerAzureADAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> Type of the sever administrator. </param>
        /// <param name="login"> Login name of the server administrator. </param>
        /// <param name="sid"> SID (object ID) of the server administrator. </param>
        /// <param name="tenantId"> Tenant ID of the administrator. </param>
        /// <param name="azureADOnlyAuthentication"> Azure Active Directory only Authentication enabled. </param>
        internal ServerAzureADAdministratorData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, AdministratorType? administratorType, string login, Guid? sid, Guid? tenantId, bool? azureADOnlyAuthentication) : base(id, name, type, systemData)
        {
            AdministratorType = administratorType;
            Login = login;
            Sid = sid;
            TenantId = tenantId;
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
        }

        /// <summary> Type of the sever administrator. </summary>
        public AdministratorType? AdministratorType { get; set; }
        /// <summary> Login name of the server administrator. </summary>
        public string Login { get; set; }
        /// <summary> SID (object ID) of the server administrator. </summary>
        public Guid? Sid { get; set; }
        /// <summary> Tenant ID of the administrator. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? AzureADOnlyAuthentication { get; }
    }
}