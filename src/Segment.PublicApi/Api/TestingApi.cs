/*
 * Segment Public API
 *
 * The Segment Public API helps you manage your Segment Workspaces and its resources. You can use the API to perform CRUD (create, read, update, delete) operations at no extra charge. This includes working with resources such as Sources, Destinations, Warehouses, Tracking Plans, and the Segment Destinations and Sources Catalogs.  All CRUD endpoints in the API follow REST conventions and use standard HTTP methods. Different URL endpoints represent different resources in a Workspace.  See the next sections for more information on how to use the Segment Public API. 
 *
 * The version of the OpenAPI document: 54.2.0
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
    public interface ITestingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Echo
        /// </summary>
        /// <remarks>
        /// Public Echo endpoint.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Echo200Response</returns>
        Echo200Response Echo(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0);

        /// <summary>
        /// Echo
        /// </summary>
        /// <remarks>
        /// Public Echo endpoint.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Echo200Response</returns>
        ApiResponse<Echo200Response> EchoWithHttpInfo(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITestingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Echo
        /// </summary>
        /// <remarks>
        /// Public Echo endpoint.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Echo200Response</returns>
        System.Threading.Tasks.Task<Echo200Response> EchoAsync(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Echo
        /// </summary>
        /// <remarks>
        /// Public Echo endpoint.
        /// </remarks>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Echo200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Echo200Response>> EchoWithHttpInfoAsync(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITestingApi : ITestingApiSync, ITestingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TestingApi : ITestingApi
    {
        private Segment.PublicApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TestingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TestingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TestingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TestingApi(Segment.PublicApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TestingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TestingApi(Segment.PublicApi.Client.ISynchronousClient client, Segment.PublicApi.Client.IAsynchronousClient asyncClient, Segment.PublicApi.Client.IReadableConfiguration configuration)
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
        /// Echo Public Echo endpoint.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Echo200Response</returns>
        public Echo200Response Echo(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0)
        {
            Segment.PublicApi.Client.ApiResponse<Echo200Response> localVarResponse = EchoWithHttpInfo(message, delay, triggerError, triggerMultipleErrors, triggerUnexpectedError, statusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Echo Public Echo endpoint.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Echo200Response</returns>
        public Segment.PublicApi.Client.ApiResponse<Echo200Response> EchoWithHttpInfo(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0)
        {
            // verify the required parameter 'message' is set
            if (message == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'message' when calling TestingApi->Echo");
            }

            Segment.PublicApi.Client.RequestOptions localVarRequestOptions = new Segment.PublicApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.segment.v1+json",
                "application/json",
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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "message", message));
            if (delay != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "delay", delay));
            }
            if (triggerError != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerError", triggerError));
            }
            if (triggerMultipleErrors != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerMultipleErrors", triggerMultipleErrors));
            }
            if (triggerUnexpectedError != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerUnexpectedError", triggerUnexpectedError));
            }
            if (statusCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "statusCode", statusCode));
            }

            localVarRequestOptions.Operation = "TestingApi.Echo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Echo200Response>("/echo", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Echo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Echo Public Echo endpoint.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Echo200Response</returns>
        public async System.Threading.Tasks.Task<Echo200Response> EchoAsync(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Segment.PublicApi.Client.ApiResponse<Echo200Response> localVarResponse = await EchoWithHttpInfoAsync(message, delay, triggerError, triggerMultipleErrors, triggerUnexpectedError, statusCode, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Echo Public Echo endpoint.
        /// </summary>
        /// <exception cref="Segment.PublicApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="message">Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha.</param>
        /// <param name="delay">The desired response delay, in milliseconds.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerError">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerMultipleErrors">If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="triggerUnexpectedError">If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. (optional)</param>
        /// <param name="statusCode">Sets the HTTP status code to return.  This parameter exists in alpha. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Echo200Response)</returns>
        public async System.Threading.Tasks.Task<Segment.PublicApi.Client.ApiResponse<Echo200Response>> EchoWithHttpInfoAsync(string message, decimal? delay = default(decimal?), bool? triggerError = default(bool?), bool? triggerMultipleErrors = default(bool?), bool? triggerUnexpectedError = default(bool?), decimal? statusCode = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'message' is set
            if (message == null)
            {
                throw new Segment.PublicApi.Client.ApiException(400, "Missing required parameter 'message' when calling TestingApi->Echo");
            }


            Segment.PublicApi.Client.RequestOptions localVarRequestOptions = new Segment.PublicApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.segment.v1+json",
                "application/json",
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

            localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "message", message));
            if (delay != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "delay", delay));
            }
            if (triggerError != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerError", triggerError));
            }
            if (triggerMultipleErrors != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerMultipleErrors", triggerMultipleErrors));
            }
            if (triggerUnexpectedError != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "triggerUnexpectedError", triggerUnexpectedError));
            }
            if (statusCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Segment.PublicApi.Client.ClientUtils.ParameterToMultiMap("", "statusCode", statusCode));
            }

            localVarRequestOptions.Operation = "TestingApi.Echo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Echo200Response>("/echo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Echo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}