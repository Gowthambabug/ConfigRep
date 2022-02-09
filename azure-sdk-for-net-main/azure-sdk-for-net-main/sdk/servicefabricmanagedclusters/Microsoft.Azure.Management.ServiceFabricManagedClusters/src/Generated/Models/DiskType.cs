// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{

    /// <summary>
    /// Defines values for DiskType.
    /// </summary>
    public static class DiskType
    {
        /// <summary>
        /// Standard HDD locally redundant storage. Best for backup,
        /// non-critical, and infrequent access.
        /// </summary>
        public const string StandardLRS = "Standard_LRS";
        /// <summary>
        /// Standard SSD locally redundant storage. Best for web servers,
        /// lightly used enterprise applications and dev/test.
        /// </summary>
        public const string StandardSSDLRS = "StandardSSD_LRS";
        /// <summary>
        /// Premium SSD locally redundant storage. Best for production and
        /// performance sensitive workloads.
        /// </summary>
        public const string PremiumLRS = "Premium_LRS";
    }
}