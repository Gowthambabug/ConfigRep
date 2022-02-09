// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DatabaseBackupSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("databaseType");
            writer.WriteStringValue(DatabaseType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ConnectionStringName))
            {
                writer.WritePropertyName("connectionStringName");
                writer.WriteStringValue(ConnectionStringName);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseBackupSetting DeserializeDatabaseBackupSetting(JsonElement element)
        {
            DatabaseType databaseType = default;
            Optional<string> name = default;
            Optional<string> connectionStringName = default;
            Optional<string> connectionString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseType"))
                {
                    databaseType = new DatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStringName"))
                {
                    connectionStringName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionString"))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseBackupSetting(databaseType, name.Value, connectionStringName.Value, connectionString.Value);
        }
    }
}