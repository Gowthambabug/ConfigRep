// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.Conversations
{
    /// <summary> A wrap up of non-linked intent response. </summary>
    public partial class NoneLinkedTargetIntentResult : TargetIntentResult
    {
        /// <summary> Initializes a new instance of NoneLinkedTargetIntentResult. </summary>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal NoneLinkedTargetIntentResult(double confidence) : base(confidence)
        {
            TargetKind = Conversations.TargetKind.NonLinked;
        }

        /// <summary> Initializes a new instance of NoneLinkedTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        internal NoneLinkedTargetIntentResult(TargetKind targetKind, string apiVersion, double confidence, ConversationResult result) : base(targetKind, apiVersion, confidence)
        {
            Result = result;
            TargetKind = targetKind;
        }

        /// <summary> The actual response from a Conversation project. </summary>
        public ConversationResult Result { get; }
    }
}