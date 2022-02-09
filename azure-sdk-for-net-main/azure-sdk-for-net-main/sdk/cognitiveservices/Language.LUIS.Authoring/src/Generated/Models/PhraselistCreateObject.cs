// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for creating a phraselist model.
    /// </summary>
    public partial class PhraselistCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        public PhraselistCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        /// <param name="phrases">List of comma-separated phrases that
        /// represent the Phraselist.</param>
        /// <param name="name">The Phraselist name.</param>
        /// <param name="isExchangeable">An interchangeable phrase list feature
        /// serves as a list of synonyms for training. A non-exchangeable
        /// phrase list serves as separate features for training. So, if your
        /// non-interchangeable phrase list contains 5 phrases, they will be
        /// mapped to 5 separate features. You can think of the
        /// non-interchangeable phrase list as an additional bag of words to
        /// add to LUIS existing vocabulary features. It is used as a lexicon
        /// lookup feature where its value is 1 if the lexicon contains a given
        /// word or 0 if it doesn’t.  Default value is true.</param>
        /// <param name="enabledForAllModels">Indicates if the Phraselist is
        /// enabled for all models in the application.</param>
        public PhraselistCreateObject(string phrases = default(string), string name = default(string), bool? isExchangeable = default(bool?), bool? enabledForAllModels = default(bool?))
        {
            Phrases = phrases;
            Name = name;
            IsExchangeable = isExchangeable;
            EnabledForAllModels = enabledForAllModels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of comma-separated phrases that represent the
        /// Phraselist.
        /// </summary>
        [JsonProperty(PropertyName = "phrases")]
        public string Phrases { get; set; }

        /// <summary>
        /// Gets or sets the Phraselist name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an interchangeable phrase list feature serves as a
        /// list of synonyms for training. A non-exchangeable phrase list
        /// serves as separate features for training. So, if your
        /// non-interchangeable phrase list contains 5 phrases, they will be
        /// mapped to 5 separate features. You can think of the
        /// non-interchangeable phrase list as an additional bag of words to
        /// add to LUIS existing vocabulary features. It is used as a lexicon
        /// lookup feature where its value is 1 if the lexicon contains a given
        /// word or 0 if it doesn’t.  Default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "isExchangeable")]
        public bool? IsExchangeable { get; set; }

        /// <summary>
        /// Gets or sets indicates if the Phraselist is enabled for all models
        /// in the application.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForAllModels")]
        public bool? EnabledForAllModels { get; set; }

    }
}