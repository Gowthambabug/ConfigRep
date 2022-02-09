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
    /// Defines values for ServiceCorrelationScheme.
    /// </summary>
    public static class ServiceCorrelationScheme
    {
        /// <summary>
        /// Aligned affinity ensures that the primaries of the partitions of
        /// the affinitized services are collocated on the same nodes. This is
        /// the default and is the same as selecting the Affinity scheme. The
        /// value is 0.
        /// </summary>
        public const string AlignedAffinity = "AlignedAffinity";
        /// <summary>
        /// Non-Aligned affinity guarantees that all replicas of each service
        /// will be placed on the same nodes. Unlike Aligned Affinity, this
        /// does not guarantee that replicas of particular role will be
        /// collocated. The value is 1.
        /// </summary>
        public const string NonAlignedAffinity = "NonAlignedAffinity";
    }
}