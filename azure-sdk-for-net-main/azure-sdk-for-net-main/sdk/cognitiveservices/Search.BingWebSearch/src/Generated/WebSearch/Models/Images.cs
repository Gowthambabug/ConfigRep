// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines an image answer
    /// </summary>
    public partial class Images : SearchResultsAnswer
    {
        /// <summary>
        /// Initializes a new instance of the Images class.
        /// </summary>
        public Images()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Images class.
        /// </summary>
        /// <param name="value">A list of image objects that are relevant to
        /// the query. If there are no results, the List is empty.</param>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="totalEstimatedMatches">The estimated number of
        /// webpages that are relevant to the query. Use this number along with
        /// the count and offset query parameters to page the results.</param>
        public Images(IList<ImageObject> value, string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>), QueryContext queryContext = default(QueryContext), long? totalEstimatedMatches = default(long?), bool? isFamilyFriendly = default(bool?), int? nextOffset = default(int?), IList<Query> queryExpansions = default(IList<Query>), IList<Query> similarTerms = default(IList<Query>), IList<Query> relatedSearches = default(IList<Query>))
            : base(id, webSearchUrl, followUpQueries, queryContext, totalEstimatedMatches, isFamilyFriendly)
        {
            NextOffset = nextOffset;
            Value = value;
            QueryExpansions = queryExpansions;
            SimilarTerms = similarTerms;
            RelatedSearches = relatedSearches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextOffset")]
        public int? NextOffset { get; private set; }

        /// <summary>
        /// Gets or sets a list of image objects that are relevant to the
        /// query. If there are no results, the List is empty.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ImageObject> Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryExpansions")]
        public IList<Query> QueryExpansions { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "similarTerms")]
        public IList<Query> SimilarTerms { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedSearches")]
        public IList<Query> RelatedSearches { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (QueryExpansions != null)
            {
                foreach (var element in QueryExpansions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SimilarTerms != null)
            {
                foreach (var element1 in SimilarTerms)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (RelatedSearches != null)
            {
                foreach (var element2 in RelatedSearches)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
