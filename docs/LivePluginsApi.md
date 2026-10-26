# Segment.PublicApi.Api.LivePluginsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLivePlugin**](LivePluginsApi.md#createliveplugin) | **POST** /sources/{sourceId}/live-plugins/create | Create Live Plugin |
| [**DeleteLivePluginCode**](LivePluginsApi.md#deleteliveplugincode) | **DELETE** /sources/{sourceId}/live-plugins/delete-code | Delete Live Plugin Code |
| [**GetLatestFromLivePlugins**](LivePluginsApi.md#getlatestfromliveplugins) | **GET** /sources/{sourceId}/live-plugins/latest | Get Latest from Live Plugins |

<a id="createliveplugin"></a>
# **CreateLivePlugin**
> CreateLivePlugin200Response CreateLivePlugin (string sourceId, CreateLivePluginAlphaInput createLivePluginAlphaInput)

Create Live Plugin

Creates or updates a Live Plugin for your Source with given code.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Live Plugins feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateLivePluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LivePluginsApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var createLivePluginAlphaInput = new CreateLivePluginAlphaInput(); // CreateLivePluginAlphaInput | 

            try
            {
                // Create Live Plugin
                CreateLivePlugin200Response result = apiInstance.CreateLivePlugin(sourceId, createLivePluginAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LivePluginsApi.CreateLivePlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLivePluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Live Plugin
    ApiResponse<CreateLivePlugin200Response> response = apiInstance.CreateLivePluginWithHttpInfo(sourceId, createLivePluginAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LivePluginsApi.CreateLivePluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **createLivePluginAlphaInput** | [**CreateLivePluginAlphaInput**](CreateLivePluginAlphaInput.md) |  |  |

### Return type

[**CreateLivePlugin200Response**](CreateLivePlugin200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteliveplugincode"></a>
# **DeleteLivePluginCode**
> DeleteLivePluginCode200Response DeleteLivePluginCode (string sourceId)

Delete Live Plugin Code

Delete the Live Plugin code for a Source. This will not disable Live Plugins for the Source, but will remove any existing code.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Live Plugins feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteLivePluginCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LivePluginsApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 

            try
            {
                // Delete Live Plugin Code
                DeleteLivePluginCode200Response result = apiInstance.DeleteLivePluginCode(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LivePluginsApi.DeleteLivePluginCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLivePluginCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Live Plugin Code
    ApiResponse<DeleteLivePluginCode200Response> response = apiInstance.DeleteLivePluginCodeWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LivePluginsApi.DeleteLivePluginCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**DeleteLivePluginCode200Response**](DeleteLivePluginCode200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlatestfromliveplugins"></a>
# **GetLatestFromLivePlugins**
> GetLatestFromLivePlugins200Response GetLatestFromLivePlugins (string sourceId)

Get Latest from Live Plugins

Get the latest Live Plugins for your Source.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Live Plugins feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetLatestFromLivePluginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LivePluginsApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 

            try
            {
                // Get Latest from Live Plugins
                GetLatestFromLivePlugins200Response result = apiInstance.GetLatestFromLivePlugins(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LivePluginsApi.GetLatestFromLivePlugins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestFromLivePluginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Latest from Live Plugins
    ApiResponse<GetLatestFromLivePlugins200Response> response = apiInstance.GetLatestFromLivePluginsWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LivePluginsApi.GetLatestFromLivePluginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**GetLatestFromLivePlugins200Response**](GetLatestFromLivePlugins200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

