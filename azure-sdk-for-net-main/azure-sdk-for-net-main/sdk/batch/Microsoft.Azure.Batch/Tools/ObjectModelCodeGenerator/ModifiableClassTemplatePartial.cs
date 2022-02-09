// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

﻿namespace ObjectModelCodeGenerator
{
    using CodeGenerationLibrary;

    public partial class ModifiableClassTemplate
    {
        public ModifiableClassTemplate(ObjectModelTypeData type)
        {
            this._typeField = type;
        }
    }
}
