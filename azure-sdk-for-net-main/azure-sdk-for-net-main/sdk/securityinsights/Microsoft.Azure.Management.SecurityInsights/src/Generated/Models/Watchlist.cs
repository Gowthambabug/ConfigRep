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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a Watchlist in Azure Security Insights.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Watchlist : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the Watchlist class.
        /// </summary>
        public Watchlist()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Watchlist class.
        /// </summary>
        /// <param name="displayName">The display name of the watchlist</param>
        /// <param name="provider">The provider of the watchlist</param>
        /// <param name="source">The source of the watchlist. Possible values
        /// include: 'Local file', 'Remote storage'</param>
        /// <param name="itemsSearchKey">The search key is used to optimize
        /// query performance when using watchlists for joins with other data.
        /// For example, enable a column with IP addresses to be the designated
        /// SearchKey field, then use this field as the key field when joining
        /// to other event data by IP address.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="watchlistId">The id (a Guid) of the watchlist</param>
        /// <param name="created">The time the watchlist was created</param>
        /// <param name="updated">The last time the watchlist was
        /// updated</param>
        /// <param name="createdBy">Describes a user that created the
        /// watchlist</param>
        /// <param name="updatedBy">Describes a user that updated the
        /// watchlist</param>
        /// <param name="description">A description of the watchlist</param>
        /// <param name="watchlistType">The type of the watchlist</param>
        /// <param name="watchlistAlias">The alias of the watchlist</param>
        /// <param name="isDeleted">A flag that indicates if the watchlist is
        /// deleted or not</param>
        /// <param name="labels">List of labels relevant to this
        /// watchlist</param>
        /// <param name="defaultDuration">The default duration of a watchlist
        /// (in ISO 8601 duration format)</param>
        /// <param name="tenantId">The tenantId where the watchlist belongs
        /// to</param>
        /// <param name="numberOfLinesToSkip">The number of lines in a csv/tsv
        /// content to skip before the header</param>
        /// <param name="rawContent">The raw content that represents to
        /// watchlist items to create. In case of csv/tsv content type, it's
        /// the content of the file that will parsed by the endpoint</param>
        /// <param name="contentType">The content type of the raw content.
        /// Example : text/csv or text/tsv </param>
        /// <param name="uploadStatus">The status of the Watchlist upload :
        /// New, InProgress or Complete. Pls note : When a Watchlist upload
        /// status is equal to InProgress, the Watchlist cannot be
        /// deleted</param>
        /// <param name="watchlistItemsCount">The number of Watchlist Items in
        /// the Watchlist</param>
        public Watchlist(string displayName, string provider, string source, string itemsSearchKey, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string), string watchlistId = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?), UserInfo createdBy = default(UserInfo), UserInfo updatedBy = default(UserInfo), string description = default(string), string watchlistType = default(string), string watchlistAlias = default(string), bool? isDeleted = default(bool?), IList<string> labels = default(IList<string>), System.TimeSpan? defaultDuration = default(System.TimeSpan?), string tenantId = default(string), int? numberOfLinesToSkip = default(int?), string rawContent = default(string), string contentType = default(string), string uploadStatus = default(string), int? watchlistItemsCount = default(int?))
            : base(id, name, type, systemData, etag)
        {
            WatchlistId = watchlistId;
            DisplayName = displayName;
            Provider = provider;
            Source = source;
            Created = created;
            Updated = updated;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            Description = description;
            WatchlistType = watchlistType;
            WatchlistAlias = watchlistAlias;
            IsDeleted = isDeleted;
            Labels = labels;
            DefaultDuration = defaultDuration;
            TenantId = tenantId;
            NumberOfLinesToSkip = numberOfLinesToSkip;
            RawContent = rawContent;
            ItemsSearchKey = itemsSearchKey;
            ContentType = contentType;
            UploadStatus = uploadStatus;
            WatchlistItemsCount = watchlistItemsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id (a Guid) of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.watchlistId")]
        public string WatchlistId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the provider of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the source of the watchlist. Possible values include:
        /// 'Local file', 'Remote storage'
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the time the watchlist was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the last time the watchlist was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets describes a user that created the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public UserInfo CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets describes a user that updated the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedBy")]
        public UserInfo UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a description of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.watchlistType")]
        public string WatchlistType { get; set; }

        /// <summary>
        /// Gets or sets the alias of the watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.watchlistAlias")]
        public string WatchlistAlias { get; set; }

        /// <summary>
        /// Gets or sets a flag that indicates if the watchlist is deleted or
        /// not
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets list of labels relevant to this watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the default duration of a watchlist (in ISO 8601
        /// duration format)
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDuration")]
        public System.TimeSpan? DefaultDuration { get; set; }

        /// <summary>
        /// Gets or sets the tenantId where the watchlist belongs to
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the number of lines in a csv/tsv content to skip
        /// before the header
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfLinesToSkip")]
        public int? NumberOfLinesToSkip { get; set; }

        /// <summary>
        /// Gets or sets the raw content that represents to watchlist items to
        /// create. In case of csv/tsv content type, it's the content of the
        /// file that will parsed by the endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.rawContent")]
        public string RawContent { get; set; }

        /// <summary>
        /// Gets or sets the search key is used to optimize query performance
        /// when using watchlists for joins with other data. For example,
        /// enable a column with IP addresses to be the designated SearchKey
        /// field, then use this field as the key field when joining to other
        /// event data by IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.itemsSearchKey")]
        public string ItemsSearchKey { get; set; }

        /// <summary>
        /// Gets or sets the content type of the raw content. Example :
        /// text/csv or text/tsv
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the status of the Watchlist upload : New, InProgress
        /// or Complete. Pls note : When a Watchlist upload status is equal to
        /// InProgress, the Watchlist cannot be deleted
        /// </summary>
        [JsonProperty(PropertyName = "properties.uploadStatus")]
        public string UploadStatus { get; set; }

        /// <summary>
        /// Gets or sets the number of Watchlist Items in the Watchlist
        /// </summary>
        [JsonProperty(PropertyName = "properties.watchlistItemsCount")]
        public int? WatchlistItemsCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Provider == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Provider");
            }
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (ItemsSearchKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ItemsSearchKey");
            }
        }
    }
}