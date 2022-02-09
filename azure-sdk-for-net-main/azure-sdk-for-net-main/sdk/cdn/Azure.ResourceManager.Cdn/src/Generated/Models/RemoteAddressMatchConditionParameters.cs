// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RemoteAddress match conditions. </summary>
    public partial class RemoteAddressMatchConditionParameters
    {
        /// <summary> Initializes a new instance of RemoteAddressMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public RemoteAddressMatchConditionParameters(RemoteAddressMatchConditionParametersOdataType odataType, RemoteAddressOperator @operator)
        {
            OdataType = odataType;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<TransformCategory>();
        }

        /// <summary> Initializes a new instance of RemoteAddressMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal RemoteAddressMatchConditionParameters(RemoteAddressMatchConditionParametersOdataType odataType, RemoteAddressOperator @operator, bool? negateCondition, IList<string> matchValues, IList<TransformCategory> transforms)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public RemoteAddressMatchConditionParametersOdataType OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RemoteAddressOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<TransformCategory> Transforms { get; }
    }
}