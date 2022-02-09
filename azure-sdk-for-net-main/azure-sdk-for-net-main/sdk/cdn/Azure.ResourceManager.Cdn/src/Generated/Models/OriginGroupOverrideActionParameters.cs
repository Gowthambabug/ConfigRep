// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the origin group override action. </summary>
    public partial class OriginGroupOverrideActionParameters
    {
        /// <summary> Initializes a new instance of OriginGroupOverrideActionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="originGroup"> defines the OriginGroup that would override the DefaultOriginGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroup"/> is null. </exception>
        public OriginGroupOverrideActionParameters(OriginGroupOverrideActionParametersOdataType odataType, WritableSubResource originGroup)
        {
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            OdataType = odataType;
            OriginGroup = originGroup;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public OriginGroupOverrideActionParametersOdataType OdataType { get; set; }
        /// <summary> defines the OriginGroup that would override the DefaultOriginGroup. </summary>
        public WritableSubResource OriginGroup { get; set; }
    }
}