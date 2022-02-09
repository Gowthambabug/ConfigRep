// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response body for find similar face operation.
    /// </summary>
    public partial class SimilarFace
    {
        /// <summary>
        /// Initializes a new instance of the SimilarFace class.
        /// </summary>
        public SimilarFace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimilarFace class.
        /// </summary>
        /// <param name="confidence">Similarity confidence of the candidate
        /// face. The higher confidence, the more similar. Range between
        /// [0,1].</param>
        /// <param name="faceId">FaceId of candidate face when find by faceIds.
        /// faceId is created by Face - Detect and will expire at the time
        /// specified by faceIdTimeToLive after the detection call</param>
        /// <param name="persistedFaceId">PersistedFaceId of candidate face
        /// when find by faceListId. persistedFaceId in face list is persisted
        /// and will not expire. As showed in below response</param>
        public SimilarFace(double confidence, System.Guid? faceId = default(System.Guid?), System.Guid? persistedFaceId = default(System.Guid?))
        {
            FaceId = faceId;
            PersistedFaceId = persistedFaceId;
            Confidence = confidence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets faceId of candidate face when find by faceIds. faceId
        /// is created by Face - Detect and will expire at the time specified
        /// by faceIdTimeToLive after the detection call
        /// </summary>
        [JsonProperty(PropertyName = "faceId")]
        public System.Guid? FaceId { get; set; }

        /// <summary>
        /// Gets or sets persistedFaceId of candidate face when find by
        /// faceListId. persistedFaceId in face list is persisted and will not
        /// expire. As showed in below response
        /// </summary>
        [JsonProperty(PropertyName = "persistedFaceId")]
        public System.Guid? PersistedFaceId { get; set; }

        /// <summary>
        /// Gets or sets similarity confidence of the candidate face. The
        /// higher confidence, the more similar. Range between [0,1].
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}