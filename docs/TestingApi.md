# Segment.PublicApi.Api.TestingApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Echo**](TestingApi.md#echo) | **GET** /echo | Echo |

<a id="echo"></a>
# **Echo**
> Echo200Response Echo (string message, decimal? delay = null, bool? triggerError = null, bool? triggerMultipleErrors = null, bool? triggerUnexpectedError = null, decimal? statusCode = null)

Echo

Public Echo endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class EchoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TestingApi(config);
            var message = Hello, World!;  // string | Sets the response `message` field. The response contains this field's entry.  This parameter exists in alpha.
            var delay = 8.14D;  // decimal? | The desired response delay, in milliseconds.  This parameter exists in alpha. (optional) 
            var triggerError = true;  // bool? | If `true`, returns an HTTP `4xx` error that contains the string in `message`.  This parameter exists in alpha. (optional) 
            var triggerMultipleErrors = true;  // bool? | If `true`, returns an HTTP `4xx` error that contains the value of the `message` field in the error message array.  This has no effect if the request sets `triggerError`.  This parameter exists in alpha. (optional) 
            var triggerUnexpectedError = true;  // bool? | If `true`, triggers a `500` error.  This has no effect if the request sets either `triggerError` or `triggerMultipleErrors`.  This parameter exists in alpha. (optional) 
            var statusCode = 8.14D;  // decimal? | Sets the HTTP status code to return.  This parameter exists in alpha. (optional) 

            try
            {
                // Echo
                Echo200Response result = apiInstance.Echo(message, delay, triggerError, triggerMultipleErrors, triggerUnexpectedError, statusCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestingApi.Echo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EchoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Echo
    ApiResponse<Echo200Response> response = apiInstance.EchoWithHttpInfo(message, delay, triggerError, triggerMultipleErrors, triggerUnexpectedError, statusCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestingApi.EchoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | **string** | Sets the response &#x60;message&#x60; field. The response contains this field&#39;s entry.  This parameter exists in alpha. |  |
| **delay** | **decimal?** | The desired response delay, in milliseconds.  This parameter exists in alpha. | [optional]  |
| **triggerError** | **bool?** | If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the string in &#x60;message&#x60;.  This parameter exists in alpha. | [optional]  |
| **triggerMultipleErrors** | **bool?** | If &#x60;true&#x60;, returns an HTTP &#x60;4xx&#x60; error that contains the value of the &#x60;message&#x60; field in the error message array.  This has no effect if the request sets &#x60;triggerError&#x60;.  This parameter exists in alpha. | [optional]  |
| **triggerUnexpectedError** | **bool?** | If &#x60;true&#x60;, triggers a &#x60;500&#x60; error.  This has no effect if the request sets either &#x60;triggerError&#x60; or &#x60;triggerMultipleErrors&#x60;.  This parameter exists in alpha. | [optional]  |
| **statusCode** | **decimal?** | Sets the HTTP status code to return.  This parameter exists in alpha. | [optional]  |

### Return type

[**Echo200Response**](Echo200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

