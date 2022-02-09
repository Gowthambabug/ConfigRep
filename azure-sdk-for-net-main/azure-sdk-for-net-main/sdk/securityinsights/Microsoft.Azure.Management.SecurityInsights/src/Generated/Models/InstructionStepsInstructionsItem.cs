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
    using System.Linq;

    public partial class InstructionStepsInstructionsItem : ConnectorInstructionModelBase
    {
        /// <summary>
        /// Initializes a new instance of the InstructionStepsInstructionsItem
        /// class.
        /// </summary>
        public InstructionStepsInstructionsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstructionStepsInstructionsItem
        /// class.
        /// </summary>
        /// <param name="type">The kind of the setting. Possible values
        /// include: 'CopyableLabel', 'InstructionStepsGroup',
        /// 'InfoMessage'</param>
        /// <param name="parameters">The parameters for the setting</param>
        public InstructionStepsInstructionsItem(string type, object parameters = default(object))
            : base(type, parameters)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}