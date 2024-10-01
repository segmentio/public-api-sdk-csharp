/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.3.0
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
    public interface IMonthlyTrackedUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Daily Per Source MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative per-source MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetDailyPerSourceMTUUsage200Response</returns>
        GetDailyPerSourceMTUUsage200Response GetDailyPerSourceMTUUsage(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);

        /// <summary>
        /// Get Daily Per Source MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative per-source MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetDailyPerSourceMTUUsage200Response</returns>
        ApiResponse<GetDailyPerSourceMTUUsage200Response> GetDailyPerSourceMTUUsageWithHttpInfo(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);
        /// <summary>
        /// Get Daily Workspace MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetDailyWorkspaceMTUUsage200Response</returns>
        GetDailyWorkspaceMTUUsage200Response GetDailyWorkspaceMTUUsage(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);

        /// <summary>
        /// Get Daily Workspace MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetDailyWorkspaceMTUUsage200Response</returns>
        ApiResponse<GetDailyWorkspaceMTUUsage200Response> GetDailyWorkspaceMTUUsageWithHttpInfo(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonthlyTrackedUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Daily Per Source MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative per-source MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDailyPerSourceMTUUsage200Response</returns>
        System.Threading.Tasks.Task<GetDailyPerSourceMTUUsage200Response> GetDailyPerSourceMTUUsageAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Daily Per Source MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative per-source MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDailyPerSourceMTUUsage200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetDailyPerSourceMTUUsage200Response>> GetDailyPerSourceMTUUsageWithHttpInfoAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Daily Workspace MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDailyWorkspaceMTUUsage200Response</returns>
        System.Threading.Tasks.Task<GetDailyWorkspaceMTUUsage200Response> GetDailyWorkspaceMTUUsageAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Daily Workspace MTU Usage
        /// </summary>
        /// <remarks>
        /// Provides daily cumulative MTU counts for a usage period.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDailyWorkspaceMTUUsage200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetDailyWorkspaceMTUUsage200Response>> GetDailyWorkspaceMTUUsageWithHttpInfoAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonthlyTrackedUsersApi : IMonthlyTrackedUsersApiSync, IMonthlyTrackedUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MonthlyTrackedUsersApi : IMonthlyTrackedUsersApi
    {
        private Segment.PublicApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyTrackedUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthlyTrackedUsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyTrackedUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthlyTrackedUsersApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MonthlyTrackedUsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MonthlyTrackedUsersApi(Segment.PublicApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MonthlyTrackedUsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MonthlyTrackedUsersApi(Segment.PublicApi.Client.ISynchronousClient client, Segment.PublicApi.Client.IAsynchronousClient asyncClient, Segment.PublicApi.Client.IReadableConfiguration configuration)
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
        /// Get Daily Per Source MTU Usage Provides daily cumulative per-source MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetDailyPerSourceMTUUsage200Response</returns>
        public GetDailyPerSourceMTUUsage200Response GetDailyPerSourceMTUUsage(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            Segment.PublicApi.Client.ApiResponse<GetDailyPerSourceMTUUsage200Response> localVarResponse = GetDailyPerSourceMTUUsageWithHttpInfo(period, pagination);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Daily Per Source MTU Usage Provides daily cumulative per-source MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetDailyPerSourceMTUUsage200Response</returns>
        public Segment.PublicApi.Client.ApiResponse<GetDailyPerSourceMTUUsage200Response> GetDailyPerSourceMTUUsageWithHttpInfo(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            // verify the required parameter 'period' is set
            if (period == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'period' when calling MonthlyTrackedUsersApi->GetDailyPerSourceMTUUsage");
            }

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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "MonthlyTrackedUsersApi.GetDailyPerSourceMTUUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetDailyPerSourceMTUUsage200Response>("/usage/mtu/sources/daily", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDailyPerSourceMTUUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Daily Per Source MTU Usage Provides daily cumulative per-source MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDailyPerSourceMTUUsage200Response</returns>
        public async System.Threading.Tasks.Task<GetDailyPerSourceMTUUsage200Response> GetDailyPerSourceMTUUsageAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Segment.PublicApi.Client.ApiResponse<GetDailyPerSourceMTUUsage200Response> localVarResponse = await GetDailyPerSourceMTUUsageWithHttpInfoAsync(period, pagination, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Daily Per Source MTU Usage Provides daily cumulative per-source MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for per Source MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDailyPerSourceMTUUsage200Response)</returns>
        public async System.Threading.Tasks.Task<Segment.PublicApi.Client.ApiResponse<GetDailyPerSourceMTUUsage200Response>> GetDailyPerSourceMTUUsageWithHttpInfoAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'period' is set
            if (period == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'period' when calling MonthlyTrackedUsersApi->GetDailyPerSourceMTUUsage");
            }


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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "MonthlyTrackedUsersApi.GetDailyPerSourceMTUUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetDailyPerSourceMTUUsage200Response>("/usage/mtu/sources/daily", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDailyPerSourceMTUUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Daily Workspace MTU Usage Provides daily cumulative MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetDailyWorkspaceMTUUsage200Response</returns>
        public GetDailyWorkspaceMTUUsage200Response GetDailyWorkspaceMTUUsage(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            Segment.PublicApi.Client.ApiResponse<GetDailyWorkspaceMTUUsage200Response> localVarResponse = GetDailyWorkspaceMTUUsageWithHttpInfo(period, pagination);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Daily Workspace MTU Usage Provides daily cumulative MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetDailyWorkspaceMTUUsage200Response</returns>
        public Segment.PublicApi.Client.ApiResponse<GetDailyWorkspaceMTUUsage200Response> GetDailyWorkspaceMTUUsageWithHttpInfo(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0)
        {
            // verify the required parameter 'period' is set
            if (period == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'period' when calling MonthlyTrackedUsersApi->GetDailyWorkspaceMTUUsage");
            }

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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "MonthlyTrackedUsersApi.GetDailyWorkspaceMTUUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetDailyWorkspaceMTUUsage200Response>("/usage/mtu/daily", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDailyWorkspaceMTUUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Daily Workspace MTU Usage Provides daily cumulative MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDailyWorkspaceMTUUsage200Response</returns>
        public async System.Threading.Tasks.Task<GetDailyWorkspaceMTUUsage200Response> GetDailyWorkspaceMTUUsageAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Segment.PublicApi.Client.ApiResponse<GetDailyWorkspaceMTUUsage200Response> localVarResponse = await GetDailyWorkspaceMTUUsageWithHttpInfoAsync(period, pagination, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Daily Workspace MTU Usage Provides daily cumulative MTU counts for a usage period.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="period">The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.</param>
        /// <param name="pagination">Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDailyWorkspaceMTUUsage200Response)</returns>
        public async System.Threading.Tasks.Task<Segment.PublicApi.Client.ApiResponse<GetDailyWorkspaceMTUUsage200Response>> GetDailyWorkspaceMTUUsageWithHttpInfoAsync(string period, PaginationInput? pagination = default(PaginationInput?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'period' is set
            if (period == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'period' when calling MonthlyTrackedUsersApi->GetDailyWorkspaceMTUUsage");
            }


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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "period", period));
            if (pagination != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "pagination", pagination));
            }

            localVarRequestOptions.Operation = "MonthlyTrackedUsersApi.GetDailyWorkspaceMTUUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetDailyWorkspaceMTUUsage200Response>("/usage/mtu/daily", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDailyWorkspaceMTUUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
