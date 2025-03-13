/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.0
 * Contact: friends@segment.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Segment.PublicApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Audit Events
        /// </summary>
        /// <remarks>
        /// Returns a list of Audit Trail events.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListAuditEvents200Response</returns>
        ListAuditEvents200Response ListAuditEvents(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);

        /// <summary>
        /// List Audit Events
        /// </summary>
        /// <remarks>
        /// Returns a list of Audit Trail events.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListAuditEvents200Response</returns>
        ApiResponse<ListAuditEvents200Response> ListAuditEventsWithHttpInfo(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Audit Events
        /// </summary>
        /// <remarks>
        /// Returns a list of Audit Trail events.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListAuditEvents200Response</returns>
        System.Threading.Tasks.Task<ListAuditEvents200Response> ListAuditEventsAsync(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Audit Events
        /// </summary>
        /// <remarks>
        /// Returns a list of Audit Trail events.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListAuditEvents200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListAuditEvents200Response>> ListAuditEventsWithHttpInfoAsync(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailApi : IAuditTrailApiSync, IAuditTrailApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditTrailApi : IAuditTrailApi
    {
        private Segment.PublicApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditTrailApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditTrailApi(string basePath)
        {
            this.Configuration = Segment.PublicApi.Client.Configuration.MergeConfigurations(
                Segment.PublicApi.Client.GlobalConfiguration.Instance,
                new Segment.PublicApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Segment.PublicApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Segment.PublicApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Segment.PublicApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditTrailApi(Segment.PublicApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Segment.PublicApi.Client.Configuration.MergeConfigurations(
                Segment.PublicApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Segment.PublicApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Segment.PublicApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Segment.PublicApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuditTrailApi(Segment.PublicApi.Client.ISynchronousClient client, Segment.PublicApi.Client.IAsynchronousClient asyncClient, Segment.PublicApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Segment.PublicApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Segment.PublicApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Segment.PublicApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Segment.PublicApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Segment.PublicApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List Audit Events Returns a list of Audit Trail events.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListAuditEvents200Response</returns>
        public ListAuditEvents200Response ListAuditEvents(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            Segment.PublicApi.Client.ApiResponse<ListAuditEvents200Response> localVarResponse = ListAuditEventsWithHttpInfo(startTime, endTime, resourceId, resourceType, pagination);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Audit Events Returns a list of Audit Trail events.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListAuditEvents200Response</returns>
        public Segment.PublicApi.Client.ApiResponse<ListAuditEvents200Response> ListAuditEventsWithHttpInfo(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            Segment.PublicApi.Client.RequestOptions localVarRequestOptions = new Segment.PublicApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.segment.v1+json",
                "application/json",
                "application/vnd.segment.v1beta+json",
                "application/vnd.segment.v1alpha+json"
            };

            var localVarContentType = Segment.PublicApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Segment.PublicApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }
            if (resourceId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "resourceId", resourceId));
            }
            if (resourceType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "resourceType", resourceType));
            }
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "AuditTrailApi.ListAuditEvents";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListAuditEvents200Response>("/audit-events", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAuditEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Audit Events Returns a list of Audit Trail events.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListAuditEvents200Response</returns>
        public async System.Threading.Tasks.Task<ListAuditEvents200Response> ListAuditEventsAsync(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Segment.PublicApi.Client.ApiResponse<ListAuditEvents200Response> localVarResponse = await ListAuditEventsWithHttpInfoAsync(startTime, endTime, resourceId, resourceType, pagination, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Audit Events Returns a list of Audit Trail events.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Filter response to events that happened after this time.  This parameter exists in v1. (optional)</param>
        /// <param name="endTime">Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceId">Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional)</param>
        /// <param name="resourceType">Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional)</param>
        /// <param name="pagination">Defines the pagination parameters.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListAuditEvents200Response)</returns>
        public async System.Threading.Tasks.Task<Segment.PublicApi.Client.ApiResponse<ListAuditEvents200Response>> ListAuditEventsWithHttpInfoAsync(string? startTime = default(string?), string? endTime = default(string?), string? resourceId = default(string?), string? resourceType = default(string?), PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Segment.PublicApi.Client.RequestOptions localVarRequestOptions = new Segment.PublicApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.segment.v1+json",
                "application/json",
                "application/vnd.segment.v1beta+json",
                "application/vnd.segment.v1alpha+json"
            };

            var localVarContentType = Segment.PublicApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Segment.PublicApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }
            if (resourceId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "resourceId", resourceId));
            }
            if (resourceType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "resourceType", resourceType));
            }
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "AuditTrailApi.ListAuditEvents";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListAuditEvents200Response>("/audit-events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAuditEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
