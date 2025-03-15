/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 58.0.1
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
    public interface IWorkspacesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Workspace
        /// </summary>
        /// <remarks>
        /// Returns the Workspace associated with the token used to access this resource.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetWorkspace200Response</returns>
        GetWorkspace200Response GetWorkspace(int operationIndex = 0);

        /// <summary>
        /// Get Workspace
        /// </summary>
        /// <remarks>
        /// Returns the Workspace associated with the token used to access this resource.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetWorkspace200Response</returns>
        ApiResponse<GetWorkspace200Response> GetWorkspaceWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkspacesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Workspace
        /// </summary>
        /// <remarks>
        /// Returns the Workspace associated with the token used to access this resource.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetWorkspace200Response</returns>
        System.Threading.Tasks.Task<GetWorkspace200Response> GetWorkspaceAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Workspace
        /// </summary>
        /// <remarks>
        /// Returns the Workspace associated with the token used to access this resource.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetWorkspace200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetWorkspace200Response>> GetWorkspaceWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkspacesApi : IWorkspacesApiSync, IWorkspacesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkspacesApi : IWorkspacesApi
    {
        private Segment.PublicApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkspacesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkspacesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="WorkspacesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkspacesApi(Segment.PublicApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WorkspacesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WorkspacesApi(Segment.PublicApi.Client.ISynchronousClient client, Segment.PublicApi.Client.IAsynchronousClient asyncClient, Segment.PublicApi.Client.IReadableConfiguration configuration)
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
        /// Get Workspace Returns the Workspace associated with the token used to access this resource.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetWorkspace200Response</returns>
        public GetWorkspace200Response GetWorkspace(int operationIndex = 0)
        {
            Segment.PublicApi.Client.ApiResponse<GetWorkspace200Response> localVarResponse = GetWorkspaceWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Workspace Returns the Workspace associated with the token used to access this resource.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetWorkspace200Response</returns>
        public Segment.PublicApi.Client.ApiResponse<GetWorkspace200Response> GetWorkspaceWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "WorkspacesApi.GetWorkspace";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetWorkspace200Response>("/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorkspace", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Workspace Returns the Workspace associated with the token used to access this resource.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetWorkspace200Response</returns>
        public async System.Threading.Tasks.Task<GetWorkspace200Response> GetWorkspaceAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Segment.PublicApi.Client.ApiResponse<GetWorkspace200Response> localVarResponse = await GetWorkspaceWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Workspace Returns the Workspace associated with the token used to access this resource.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetWorkspace200Response)</returns>
        public async System.Threading.Tasks.Task<Segment.PublicApi.Client.ApiResponse<GetWorkspace200Response>> GetWorkspaceWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "WorkspacesApi.GetWorkspace";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetWorkspace200Response>("/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorkspace", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
