// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Personalizer
{
    /// <summary> Learning settings specifying how to train the model. </summary>
    public partial class PersonalizerPolicy
    {
        /// <summary> Initializes a new instance of PersonalizerPolicy. </summary>
        /// <param name="name"> Name of the learning settings. </param>
        /// <param name="arguments"> Arguments of the learning settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="arguments"/> is null. </exception>
        public PersonalizerPolicy(string name, string arguments)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (arguments == null)
            {
                throw new ArgumentNullException(nameof(arguments));
            }

            Name = name;
            Arguments = arguments;
        }

        /// <summary> Name of the learning settings. </summary>
        public string Name { get; set; }
        /// <summary> Arguments of the learning settings. </summary>
        public string Arguments { get; set; }
    }
}