# Segment.PublicApi.Api.FunctionsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFunction**](FunctionsApi.md#createfunction) | **POST** /functions | Create Function |
| [**CreateFunctionDeployment**](FunctionsApi.md#createfunctiondeployment) | **POST** /functions/{functionId}/deploy | Create Function Deployment |
| [**CreateInsertFunctionInstance**](FunctionsApi.md#createinsertfunctioninstance) | **POST** /insert-function-instances | Create Insert Function Instance |
| [**DeleteFunction**](FunctionsApi.md#deletefunction) | **DELETE** /functions/{functionId} | Delete Function |
| [**DeleteInsertFunctionInstance**](FunctionsApi.md#deleteinsertfunctioninstance) | **DELETE** /insert-function-instances/{instanceId} | Delete Insert Function Instance |
| [**GetFunction**](FunctionsApi.md#getfunction) | **GET** /functions/{functionId} | Get Function |
| [**GetFunctionVersion**](FunctionsApi.md#getfunctionversion) | **GET** /functions/{functionId}/versions/{versionId} | Get Function Version |
| [**GetInsertFunctionInstance**](FunctionsApi.md#getinsertfunctioninstance) | **GET** /insert-function-instances/{instanceId} | Get Insert Function Instance |
| [**ListFunctionVersions**](FunctionsApi.md#listfunctionversions) | **GET** /functions/{functionId}/versions | List Function Versions |
| [**ListFunctions**](FunctionsApi.md#listfunctions) | **GET** /functions | List Functions |
| [**ListInsertFunctionInstances**](FunctionsApi.md#listinsertfunctioninstances) | **GET** /insert-function-instances | List Insert Function Instances |
| [**RestoreFunctionVersion**](FunctionsApi.md#restorefunctionversion) | **POST** /functions/{functionId}/versions | Restore Function Version |
| [**UpdateFunction**](FunctionsApi.md#updatefunction) | **PATCH** /functions/{functionId} | Update Function |
| [**UpdateInsertFunctionInstance**](FunctionsApi.md#updateinsertfunctioninstance) | **PATCH** /insert-function-instances/{instanceId} | Update Insert Function Instance |

<a id="createfunction"></a>
# **CreateFunction**
> CreateFunction200Response CreateFunction (CreateFunctionV1Input createFunctionV1Input)

Create Function

Creates a Function.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateFunctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var createFunctionV1Input = new CreateFunctionV1Input(); // CreateFunctionV1Input | 

            try
            {
                // Create Function
                CreateFunction200Response result = apiInstance.CreateFunction(createFunctionV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.CreateFunction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFunctionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Function
    ApiResponse<CreateFunction200Response> response = apiInstance.CreateFunctionWithHttpInfo(createFunctionV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.CreateFunctionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFunctionV1Input** | [**CreateFunctionV1Input**](CreateFunctionV1Input.md) |  |  |

### Return type

[**CreateFunction200Response**](CreateFunction200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfunctiondeployment"></a>
# **CreateFunctionDeployment**
> CreateFunctionDeployment200Response CreateFunctionDeployment (string functionId)

Create Function Deployment

Deploys a Function. Only applicable to Source Function instances.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateFunctionDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfn_rh5BDZp6QDHvXFCkibm1pR;  // string | 

            try
            {
                // Create Function Deployment
                CreateFunctionDeployment200Response result = apiInstance.CreateFunctionDeployment(functionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.CreateFunctionDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFunctionDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Function Deployment
    ApiResponse<CreateFunctionDeployment200Response> response = apiInstance.CreateFunctionDeploymentWithHttpInfo(functionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.CreateFunctionDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |

### Return type

[**CreateFunctionDeployment200Response**](CreateFunctionDeployment200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createinsertfunctioninstance"></a>
# **CreateInsertFunctionInstance**
> CreateInsertFunctionInstance200Response CreateInsertFunctionInstance (CreateInsertFunctionInstanceAlphaInput createInsertFunctionInstanceAlphaInput)

Create Insert Function Instance

Creates an insert Function instance connected to the given Destination.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateInsertFunctionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var createInsertFunctionInstanceAlphaInput = new CreateInsertFunctionInstanceAlphaInput(); // CreateInsertFunctionInstanceAlphaInput | 

            try
            {
                // Create Insert Function Instance
                CreateInsertFunctionInstance200Response result = apiInstance.CreateInsertFunctionInstance(createInsertFunctionInstanceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.CreateInsertFunctionInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInsertFunctionInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Insert Function Instance
    ApiResponse<CreateInsertFunctionInstance200Response> response = apiInstance.CreateInsertFunctionInstanceWithHttpInfo(createInsertFunctionInstanceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.CreateInsertFunctionInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInsertFunctionInstanceAlphaInput** | [**CreateInsertFunctionInstanceAlphaInput**](CreateInsertFunctionInstanceAlphaInput.md) |  |  |

### Return type

[**CreateInsertFunctionInstance200Response**](CreateInsertFunctionInstance200Response.md)

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

<a id="deletefunction"></a>
# **DeleteFunction**
> DeleteFunction200Response DeleteFunction (string functionId)

Delete Function

Deletes a Function.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteFunctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 

            try
            {
                // Delete Function
                DeleteFunction200Response result = apiInstance.DeleteFunction(functionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.DeleteFunction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFunctionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Function
    ApiResponse<DeleteFunction200Response> response = apiInstance.DeleteFunctionWithHttpInfo(functionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.DeleteFunctionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |

### Return type

[**DeleteFunction200Response**](DeleteFunction200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteinsertfunctioninstance"></a>
# **DeleteInsertFunctionInstance**
> DeleteInsertFunctionInstance200Response DeleteInsertFunctionInstance (string instanceId)

Delete Insert Function Instance

Deletes an insert Function instance.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteInsertFunctionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var instanceId = 65c2bdbdde6f2d8297f943da;  // string | 

            try
            {
                // Delete Insert Function Instance
                DeleteInsertFunctionInstance200Response result = apiInstance.DeleteInsertFunctionInstance(instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.DeleteInsertFunctionInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInsertFunctionInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Insert Function Instance
    ApiResponse<DeleteInsertFunctionInstance200Response> response = apiInstance.DeleteInsertFunctionInstanceWithHttpInfo(instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.DeleteInsertFunctionInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |

### Return type

[**DeleteInsertFunctionInstance200Response**](DeleteInsertFunctionInstance200Response.md)

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

<a id="getfunction"></a>
# **GetFunction**
> GetFunction200Response GetFunction (string functionId)

Get Function

Gets a Function.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFunctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 

            try
            {
                // Get Function
                GetFunction200Response result = apiInstance.GetFunction(functionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetFunction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFunctionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Function
    ApiResponse<GetFunction200Response> response = apiInstance.GetFunctionWithHttpInfo(functionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.GetFunctionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |

### Return type

[**GetFunction200Response**](GetFunction200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfunctionversion"></a>
# **GetFunctionVersion**
> GetFunctionVersion200Response GetFunctionVersion (string functionId, string versionId)

Get Function Version

Gets a Function version.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFunctionVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 
            var versionId = 2Ma03fahSqLoEzQfV5o2aSfVEHs;  // string | 

            try
            {
                // Get Function Version
                GetFunctionVersion200Response result = apiInstance.GetFunctionVersion(functionId, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetFunctionVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFunctionVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Function Version
    ApiResponse<GetFunctionVersion200Response> response = apiInstance.GetFunctionVersionWithHttpInfo(functionId, versionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.GetFunctionVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |
| **versionId** | **string** |  |  |

### Return type

[**GetFunctionVersion200Response**](GetFunctionVersion200Response.md)

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

<a id="getinsertfunctioninstance"></a>
# **GetInsertFunctionInstance**
> GetInsertFunctionInstance200Response GetInsertFunctionInstance (string instanceId)

Get Insert Function Instance

Gets an insert Function instance.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetInsertFunctionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var instanceId = 65c2bdbcde6f2d8297f943d7;  // string | 

            try
            {
                // Get Insert Function Instance
                GetInsertFunctionInstance200Response result = apiInstance.GetInsertFunctionInstance(instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.GetInsertFunctionInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInsertFunctionInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Insert Function Instance
    ApiResponse<GetInsertFunctionInstance200Response> response = apiInstance.GetInsertFunctionInstanceWithHttpInfo(instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.GetInsertFunctionInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |

### Return type

[**GetInsertFunctionInstance200Response**](GetInsertFunctionInstance200Response.md)

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

<a id="listfunctionversions"></a>
# **ListFunctionVersions**
> ListFunctionVersions200Response ListFunctionVersions (string functionId, PaginationInput? pagination = null)

List Function Versions

Lists versions for a Function in a Workspace.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListFunctionVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Function Versions
                ListFunctionVersions200Response result = apiInstance.ListFunctionVersions(functionId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.ListFunctionVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFunctionVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Function Versions
    ApiResponse<ListFunctionVersions200Response> response = apiInstance.ListFunctionVersionsWithHttpInfo(functionId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.ListFunctionVersionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListFunctionVersions200Response**](ListFunctionVersions200Response.md)

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

<a id="listfunctions"></a>
# **ListFunctions**
> ListFunctions200Response ListFunctions (string resourceType, PaginationInput? pagination = null)

List Functions

Lists all Functions in a Workspace.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListFunctionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var resourceType = SOURCE;  // string | The Function type.  Config API note: equal to `type`.  This parameter exists in v1.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Functions
                ListFunctions200Response result = apiInstance.ListFunctions(resourceType, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.ListFunctions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFunctionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Functions
    ApiResponse<ListFunctions200Response> response = apiInstance.ListFunctionsWithHttpInfo(resourceType, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.ListFunctionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceType** | **string** | The Function type.  Config API note: equal to &#x60;type&#x60;.  This parameter exists in v1. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListFunctions200Response**](ListFunctions200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listinsertfunctioninstances"></a>
# **ListInsertFunctionInstances**
> ListInsertFunctionInstances200Response ListInsertFunctionInstances (string functionId, PaginationInput? pagination = null)

List Insert Function Instances

Lists all insert Function instances connected to the given insert Function.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListInsertFunctionInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = 76365637324e715a67535831;  // string | The insert Function class id to lookup.  This parameter exists in alpha.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Insert Function Instances
                ListInsertFunctionInstances200Response result = apiInstance.ListInsertFunctionInstances(functionId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.ListInsertFunctionInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInsertFunctionInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Insert Function Instances
    ApiResponse<ListInsertFunctionInstances200Response> response = apiInstance.ListInsertFunctionInstancesWithHttpInfo(functionId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.ListInsertFunctionInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** | The insert Function class id to lookup.  This parameter exists in alpha. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListInsertFunctionInstances200Response**](ListInsertFunctionInstances200Response.md)

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

<a id="restorefunctionversion"></a>
# **RestoreFunctionVersion**
> RestoreFunctionVersion200Response RestoreFunctionVersion (string functionId, RestoreFunctionVersionAlphaInput restoreFunctionVersionAlphaInput)

Restore Function Version

Restore an old Function version as the latest version.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RestoreFunctionVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 
            var restoreFunctionVersionAlphaInput = new RestoreFunctionVersionAlphaInput(); // RestoreFunctionVersionAlphaInput | 

            try
            {
                // Restore Function Version
                RestoreFunctionVersion200Response result = apiInstance.RestoreFunctionVersion(functionId, restoreFunctionVersionAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.RestoreFunctionVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreFunctionVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore Function Version
    ApiResponse<RestoreFunctionVersion200Response> response = apiInstance.RestoreFunctionVersionWithHttpInfo(functionId, restoreFunctionVersionAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.RestoreFunctionVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |
| **restoreFunctionVersionAlphaInput** | [**RestoreFunctionVersionAlphaInput**](RestoreFunctionVersionAlphaInput.md) |  |  |

### Return type

[**RestoreFunctionVersion200Response**](RestoreFunctionVersion200Response.md)

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

<a id="updatefunction"></a>
# **UpdateFunction**
> UpdateFunction200Response UpdateFunction (string functionId, UpdateFunctionV1Input updateFunctionV1Input)

Update Function

Updates a Function.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.  Config API omitted fields: - `updateMask` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateFunctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var functionId = sfnc_wXzcDGFR3KmjLDrtSawNHf;  // string | 
            var updateFunctionV1Input = new UpdateFunctionV1Input(); // UpdateFunctionV1Input | 

            try
            {
                // Update Function
                UpdateFunction200Response result = apiInstance.UpdateFunction(functionId, updateFunctionV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.UpdateFunction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFunctionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Function
    ApiResponse<UpdateFunction200Response> response = apiInstance.UpdateFunctionWithHttpInfo(functionId, updateFunctionV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.UpdateFunctionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **functionId** | **string** |  |  |
| **updateFunctionV1Input** | [**UpdateFunctionV1Input**](UpdateFunctionV1Input.md) |  |  |

### Return type

[**UpdateFunction200Response**](UpdateFunction200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateinsertfunctioninstance"></a>
# **UpdateInsertFunctionInstance**
> UpdateInsertFunctionInstance200Response UpdateInsertFunctionInstance (string instanceId, UpdateInsertFunctionInstanceAlphaInput updateInsertFunctionInstanceAlphaInput)

Update Insert Function Instance

Updates an insert Function instance connected to the given Destination.    • In order to successfully call this endpoint, the specified Workspace needs to have the Functions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateInsertFunctionInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FunctionsApi(config);
            var instanceId = 65c2bdbcde6f2d8297f943d8;  // string | 
            var updateInsertFunctionInstanceAlphaInput = new UpdateInsertFunctionInstanceAlphaInput(); // UpdateInsertFunctionInstanceAlphaInput | 

            try
            {
                // Update Insert Function Instance
                UpdateInsertFunctionInstance200Response result = apiInstance.UpdateInsertFunctionInstance(instanceId, updateInsertFunctionInstanceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FunctionsApi.UpdateInsertFunctionInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInsertFunctionInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Insert Function Instance
    ApiResponse<UpdateInsertFunctionInstance200Response> response = apiInstance.UpdateInsertFunctionInstanceWithHttpInfo(instanceId, updateInsertFunctionInstanceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FunctionsApi.UpdateInsertFunctionInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |
| **updateInsertFunctionInstanceAlphaInput** | [**UpdateInsertFunctionInstanceAlphaInput**](UpdateInsertFunctionInstanceAlphaInput.md) |  |  |

### Return type

[**UpdateInsertFunctionInstance200Response**](UpdateInsertFunctionInstance200Response.md)

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

