// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    public partial class AzureMediaServicesClient : ServiceClient<AzureMediaServicesClient>, IAzureMediaServicesClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The unique identifier for a Microsoft Azure subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The version of the API to be used with the client request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IMediaservicesOperations.
        /// </summary>
        public virtual IMediaservicesOperations Mediaservices { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the ILocationsOperations.
        /// </summary>
        public virtual ILocationsOperations Locations { get; private set; }

        /// <summary>
        /// Gets the IAccountFiltersOperations.
        /// </summary>
        public virtual IAccountFiltersOperations AccountFilters { get; private set; }

        /// <summary>
        /// Gets the IAssetsOperations.
        /// </summary>
        public virtual IAssetsOperations Assets { get; private set; }

        /// <summary>
        /// Gets the IAssetFiltersOperations.
        /// </summary>
        public virtual IAssetFiltersOperations AssetFilters { get; private set; }

        /// <summary>
        /// Gets the IContentKeyPoliciesOperations.
        /// </summary>
        public virtual IContentKeyPoliciesOperations ContentKeyPolicies { get; private set; }

        /// <summary>
        /// Gets the ITransformsOperations.
        /// </summary>
        public virtual ITransformsOperations Transforms { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IStreamingPoliciesOperations.
        /// </summary>
        public virtual IStreamingPoliciesOperations StreamingPolicies { get; private set; }

        /// <summary>
        /// Gets the IStreamingLocatorsOperations.
        /// </summary>
        public virtual IStreamingLocatorsOperations StreamingLocators { get; private set; }

        /// <summary>
        /// Gets the ILiveEventsOperations.
        /// </summary>
        public virtual ILiveEventsOperations LiveEvents { get; private set; }

        /// <summary>
        /// Gets the ILiveOutputsOperations.
        /// </summary>
        public virtual ILiveOutputsOperations LiveOutputs { get; private set; }

        /// <summary>
        /// Gets the IStreamingEndpointsOperations.
        /// </summary>
        public virtual IStreamingEndpointsOperations StreamingEndpoints { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AzureMediaServicesClient.Dispose(). False: will not dispose provided httpClient</param>
        protected AzureMediaServicesClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AzureMediaServicesClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AzureMediaServicesClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AzureMediaServicesClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AzureMediaServicesClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureMediaServicesClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AzureMediaServicesClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureMediaServicesClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureMediaServicesClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureMediaServicesClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureMediaServicesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureMediaServicesClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Operations = new Operations(this);
            Mediaservices = new MediaservicesOperations(this);
            PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            Locations = new LocationsOperations(this);
            AccountFilters = new AccountFiltersOperations(this);
            Assets = new AssetsOperations(this);
            AssetFilters = new AssetFiltersOperations(this);
            ContentKeyPolicies = new ContentKeyPoliciesOperations(this);
            Transforms = new TransformsOperations(this);
            Jobs = new JobsOperations(this);
            StreamingPolicies = new StreamingPoliciesOperations(this);
            StreamingLocators = new StreamingLocatorsOperations(this);
            LiveEvents = new LiveEventsOperations(this);
            LiveOutputs = new LiveOutputsOperations(this);
            StreamingEndpoints = new StreamingEndpointsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2021-06-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ContentKeyPolicyPlayReadyContentKeyLocation>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ContentKeyPolicyPlayReadyContentKeyLocation>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ContentKeyPolicyRestriction>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ContentKeyPolicyRestriction>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ContentKeyPolicyConfiguration>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ContentKeyPolicyConfiguration>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ContentKeyPolicyRestrictionTokenKey>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ContentKeyPolicyRestrictionTokenKey>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Preset>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Preset>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Codec>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Codec>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Layer>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Layer>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<TrackDescriptor>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<TrackDescriptor>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<InputDefinition>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<InputDefinition>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Overlay>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Overlay>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Format>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Format>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<JobInput>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<JobInput>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ClipTime>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ClipTime>("@odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<JobOutput>("@odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<JobOutput>("@odata.type"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
