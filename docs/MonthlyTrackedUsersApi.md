# Segment.PublicApi.Api.MonthlyTrackedUsersApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDailyPerSourceMTUUsage**](MonthlyTrackedUsersApi.md#getdailypersourcemtuusage) | **GET** /usage/mtu/sources/daily | Get Daily Per Source MTU Usage |
| [**GetDailyWorkspaceMTUUsage**](MonthlyTrackedUsersApi.md#getdailyworkspacemtuusage) | **GET** /usage/mtu/daily | Get Daily Workspace MTU Usage |

<a id="getdailypersourcemtuusage"></a>
# **GetDailyPerSourceMTUUsage**
> GetDailyPerSourceMTUUsage200Response GetDailyPerSourceMTUUsage (string period, PaginationInput? pagination = null)

Get Daily Per Source MTU Usage

Provides daily cumulative per-source MTU counts for a usage period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDailyPerSourceMTUUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MonthlyTrackedUsersApi(config);
            var period = 2021-02-01;  // string | The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination input for per Source MTU counts.  This parameter exists in v1. (optional) 

            try
            {
                // Get Daily Per Source MTU Usage
                GetDailyPerSourceMTUUsage200Response result = apiInstance.GetDailyPerSourceMTUUsage(period, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonthlyTrackedUsersApi.GetDailyPerSourceMTUUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDailyPerSourceMTUUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Daily Per Source MTU Usage
    ApiResponse<GetDailyPerSourceMTUUsage200Response> response = apiInstance.GetDailyPerSourceMTUUsageWithHttpInfo(period, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonthlyTrackedUsersApi.GetDailyPerSourceMTUUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | The start of the usage month, in the ISO-8601 format.  This parameter exists in v1. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination input for per Source MTU counts.  This parameter exists in v1. | [optional]  |

### Return type

[**GetDailyPerSourceMTUUsage200Response**](GetDailyPerSourceMTUUsage200Response.md)

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

<a id="getdailyworkspacemtuusage"></a>
# **GetDailyWorkspaceMTUUsage**
> GetDailyWorkspaceMTUUsage200Response GetDailyWorkspaceMTUUsage (string period, PaginationInput? pagination = null)

Get Daily Workspace MTU Usage

Provides daily cumulative MTU counts for a usage period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDailyWorkspaceMTUUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MonthlyTrackedUsersApi(config);
            var period = 2021-02-01;  // string | The start of the usage month, in the ISO-8601 format.  This parameter exists in v1.
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination input for Workspace MTU counts.  This parameter exists in v1. (optional) 

            try
            {
                // Get Daily Workspace MTU Usage
                GetDailyWorkspaceMTUUsage200Response result = apiInstance.GetDailyWorkspaceMTUUsage(period, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonthlyTrackedUsersApi.GetDailyWorkspaceMTUUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDailyWorkspaceMTUUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Daily Workspace MTU Usage
    ApiResponse<GetDailyWorkspaceMTUUsage200Response> response = apiInstance.GetDailyWorkspaceMTUUsageWithHttpInfo(period, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonthlyTrackedUsersApi.GetDailyWorkspaceMTUUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **period** | **string** | The start of the usage month, in the ISO-8601 format.  This parameter exists in v1. |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination input for Workspace MTU counts.  This parameter exists in v1. | [optional]  |

### Return type

[**GetDailyWorkspaceMTUUsage200Response**](GetDailyWorkspaceMTUUsage200Response.md)

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

