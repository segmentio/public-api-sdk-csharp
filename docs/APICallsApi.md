# Segment.PublicApi.Api.APICallsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDailyPerSourceAPICallsUsage**](APICallsApi.md#getdailypersourceapicallsusage) | **GET** /usage/api-calls/sources/daily | Get Daily Per Source API Calls Usage |
| [**GetDailyWorkspaceAPICallsUsage**](APICallsApi.md#getdailyworkspaceapicallsusage) | **GET** /usage/api-calls/daily | Get Daily Workspace API Calls Usage |

<a id="getdailypersourceapicallsusage"></a>
# **GetDailyPerSourceAPICallsUsage**
> GetDailyPerSourceAPICallsUsage200Response GetDailyPerSourceAPICallsUsage (string period, PaginationInput? pagination = null)

Get Daily Per Source API Calls Usage

Provides daily cumulative per-source API call counts for a usage period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDailyPerSourceAPICallsUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new APICallsApi(config);
            var period = 2021-02-01;  // string | The start of the usage month in the ISO-8601 format.  This parameter exists in v1.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination input for per Source API calls counts.  This parameter exists in v1. (optional) 

            try
            {
                // Get Daily Per Source API Calls Usage
                GetDailyPerSourceAPICallsUsage200Response result = apiInstance.GetDailyPerSourceAPICallsUsage(period, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APICallsApi.GetDailyPerSourceAPICallsUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDailyPerSourceAPICallsUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Daily Per Source API Calls Usage
    ApiResponse<GetDailyPerSourceAPICallsUsage200Response> response = apiInstance.GetDailyPerSourceAPICallsUsageWithHttpInfo(period, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APICallsApi.GetDailyPerSourceAPICallsUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | The start of the usage month in the ISO-8601 format.  This parameter exists in v1. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination input for per Source API calls counts.  This parameter exists in v1. | [optional]  |

### Return type

[**GetDailyPerSourceAPICallsUsage200Response**](GetDailyPerSourceAPICallsUsage200Response.md)

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

<a id="getdailyworkspaceapicallsusage"></a>
# **GetDailyWorkspaceAPICallsUsage**
> GetDailyWorkspaceAPICallsUsage200Response GetDailyWorkspaceAPICallsUsage (string period, PaginationInput? pagination = null)

Get Daily Workspace API Calls Usage

Provides daily cumulative API call counts for a usage period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDailyWorkspaceAPICallsUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new APICallsApi(config);
            var period = 2021-02-01;  // string | The start of the usage month in the ISO-8601 format.  This parameter exists in v1.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination input for Workspace API call counts.  This parameter exists in v1. (optional) 

            try
            {
                // Get Daily Workspace API Calls Usage
                GetDailyWorkspaceAPICallsUsage200Response result = apiInstance.GetDailyWorkspaceAPICallsUsage(period, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APICallsApi.GetDailyWorkspaceAPICallsUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDailyWorkspaceAPICallsUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Daily Workspace API Calls Usage
    ApiResponse<GetDailyWorkspaceAPICallsUsage200Response> response = apiInstance.GetDailyWorkspaceAPICallsUsageWithHttpInfo(period, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APICallsApi.GetDailyWorkspaceAPICallsUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | The start of the usage month in the ISO-8601 format.  This parameter exists in v1. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination input for Workspace API call counts.  This parameter exists in v1. | [optional]  |

### Return type

[**GetDailyWorkspaceAPICallsUsage200Response**](GetDailyWorkspaceAPICallsUsage200Response.md)

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

