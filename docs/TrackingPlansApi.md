# Segment.PublicApi.Api.TrackingPlansApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddSourceToTrackingPlan**](TrackingPlansApi.md#addsourcetotrackingplan) | **POST** /tracking-plans/{trackingPlanId}/sources | Add Source to Tracking Plan |
| [**CreateTrackingPlan**](TrackingPlansApi.md#createtrackingplan) | **POST** /tracking-plans | Create Tracking Plan |
| [**DeleteTrackingPlan**](TrackingPlansApi.md#deletetrackingplan) | **DELETE** /tracking-plans/{trackingPlanId} | Delete Tracking Plan |
| [**GetTrackingPlan**](TrackingPlansApi.md#gettrackingplan) | **GET** /tracking-plans/{trackingPlanId} | Get Tracking Plan |
| [**ListRulesFromTrackingPlan**](TrackingPlansApi.md#listrulesfromtrackingplan) | **GET** /tracking-plans/{trackingPlanId}/rules | List Rules from Tracking Plan |
| [**ListSourcesFromTrackingPlan**](TrackingPlansApi.md#listsourcesfromtrackingplan) | **GET** /tracking-plans/{trackingPlanId}/sources | List Sources from Tracking Plan |
| [**ListTrackingPlans**](TrackingPlansApi.md#listtrackingplans) | **GET** /tracking-plans | List Tracking Plans |
| [**RemoveRulesFromTrackingPlan**](TrackingPlansApi.md#removerulesfromtrackingplan) | **DELETE** /tracking-plans/{trackingPlanId}/rules | Remove Rules from Tracking Plan |
| [**RemoveSourceFromTrackingPlan**](TrackingPlansApi.md#removesourcefromtrackingplan) | **DELETE** /tracking-plans/{trackingPlanId}/sources | Remove Source from Tracking Plan |
| [**ReplaceRulesInTrackingPlan**](TrackingPlansApi.md#replacerulesintrackingplan) | **PUT** /tracking-plans/{trackingPlanId}/rules | Replace Rules in Tracking Plan |
| [**UpdateRulesInTrackingPlan**](TrackingPlansApi.md#updaterulesintrackingplan) | **PATCH** /tracking-plans/{trackingPlanId}/rules | Update Rules in Tracking Plan |
| [**UpdateTrackingPlan**](TrackingPlansApi.md#updatetrackingplan) | **PATCH** /tracking-plans/{trackingPlanId} | Update Tracking Plan |

<a id="addsourcetotrackingplan"></a>
# **AddSourceToTrackingPlan**
> AddSourceToTrackingPlan200Response AddSourceToTrackingPlan (string trackingPlanId, AddSourceToTrackingPlanV1Input addSourceToTrackingPlanV1Input)

Add Source to Tracking Plan

Connects a Source to a Tracking Plan.    • When called, this endpoint may generate the `Source Modified` event in the [audit trail](/tag/Audit-Trail).   • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddSourceToTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var addSourceToTrackingPlanV1Input = new AddSourceToTrackingPlanV1Input(); // AddSourceToTrackingPlanV1Input | 

            try
            {
                // Add Source to Tracking Plan
                AddSourceToTrackingPlan200Response result = apiInstance.AddSourceToTrackingPlan(trackingPlanId, addSourceToTrackingPlanV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.AddSourceToTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSourceToTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Source to Tracking Plan
    ApiResponse<AddSourceToTrackingPlan200Response> response = apiInstance.AddSourceToTrackingPlanWithHttpInfo(trackingPlanId, addSourceToTrackingPlanV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.AddSourceToTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **addSourceToTrackingPlanV1Input** | [**AddSourceToTrackingPlanV1Input**](AddSourceToTrackingPlanV1Input.md) |  |  |

### Return type

[**AddSourceToTrackingPlan200Response**](AddSourceToTrackingPlan200Response.md)

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

<a id="createtrackingplan"></a>
# **CreateTrackingPlan**
> CreateTrackingPlan200Response CreateTrackingPlan (CreateTrackingPlanV1Input createTrackingPlanV1Input)

Create Tracking Plan

Creates a Tracking Plan.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var createTrackingPlanV1Input = new CreateTrackingPlanV1Input(); // CreateTrackingPlanV1Input | 

            try
            {
                // Create Tracking Plan
                CreateTrackingPlan200Response result = apiInstance.CreateTrackingPlan(createTrackingPlanV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.CreateTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tracking Plan
    ApiResponse<CreateTrackingPlan200Response> response = apiInstance.CreateTrackingPlanWithHttpInfo(createTrackingPlanV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.CreateTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTrackingPlanV1Input** | [**CreateTrackingPlanV1Input**](CreateTrackingPlanV1Input.md) |  |  |

### Return type

[**CreateTrackingPlan200Response**](CreateTrackingPlan200Response.md)

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

<a id="deletetrackingplan"></a>
# **DeleteTrackingPlan**
> DeleteTrackingPlan200Response DeleteTrackingPlan (string trackingPlanId)

Delete Tracking Plan

Deletes a Tracking Plan.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 

            try
            {
                // Delete Tracking Plan
                DeleteTrackingPlan200Response result = apiInstance.DeleteTrackingPlan(trackingPlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.DeleteTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Tracking Plan
    ApiResponse<DeleteTrackingPlan200Response> response = apiInstance.DeleteTrackingPlanWithHttpInfo(trackingPlanId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.DeleteTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |

### Return type

[**DeleteTrackingPlan200Response**](DeleteTrackingPlan200Response.md)

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

<a id="gettrackingplan"></a>
# **GetTrackingPlan**
> GetTrackingPlan200Response GetTrackingPlan (string trackingPlanId)

Get Tracking Plan

Returns a Tracking Plan.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 

            try
            {
                // Get Tracking Plan
                GetTrackingPlan200Response result = apiInstance.GetTrackingPlan(trackingPlanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.GetTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tracking Plan
    ApiResponse<GetTrackingPlan200Response> response = apiInstance.GetTrackingPlanWithHttpInfo(trackingPlanId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.GetTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |

### Return type

[**GetTrackingPlan200Response**](GetTrackingPlan200Response.md)

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

<a id="listrulesfromtrackingplan"></a>
# **ListRulesFromTrackingPlan**
> ListRulesFromTrackingPlan200Response ListRulesFromTrackingPlan (string trackingPlanId, PaginationInput? pagination = null)

List Rules from Tracking Plan

Lists Tracking Plan rules.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 200 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListRulesFromTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination options.  This parameter exists in v1. (optional) 

            try
            {
                // List Rules from Tracking Plan
                ListRulesFromTrackingPlan200Response result = apiInstance.ListRulesFromTrackingPlan(trackingPlanId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.ListRulesFromTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRulesFromTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Rules from Tracking Plan
    ApiResponse<ListRulesFromTrackingPlan200Response> response = apiInstance.ListRulesFromTrackingPlanWithHttpInfo(trackingPlanId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.ListRulesFromTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination options.  This parameter exists in v1. | [optional]  |

### Return type

[**ListRulesFromTrackingPlan200Response**](ListRulesFromTrackingPlan200Response.md)

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

<a id="listsourcesfromtrackingplan"></a>
# **ListSourcesFromTrackingPlan**
> ListSourcesFromTrackingPlan200Response ListSourcesFromTrackingPlan (string trackingPlanId, PaginationInput? pagination = null)

List Sources from Tracking Plan

Lists Sources connected to a Tracking Plan.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.   This endpoint requires the user to have at least the following permission(s):   * Source Read-only  * Tracking Plan Read-only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSourcesFromTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination options.  This parameter exists in v1. (optional) 

            try
            {
                // List Sources from Tracking Plan
                ListSourcesFromTrackingPlan200Response result = apiInstance.ListSourcesFromTrackingPlan(trackingPlanId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.ListSourcesFromTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSourcesFromTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sources from Tracking Plan
    ApiResponse<ListSourcesFromTrackingPlan200Response> response = apiInstance.ListSourcesFromTrackingPlanWithHttpInfo(trackingPlanId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.ListSourcesFromTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination options.  This parameter exists in v1. | [optional]  |

### Return type

[**ListSourcesFromTrackingPlan200Response**](ListSourcesFromTrackingPlan200Response.md)

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

<a id="listtrackingplans"></a>
# **ListTrackingPlans**
> ListTrackingPlans200Response ListTrackingPlans (string? type = null, PaginationInput? pagination = null)

List Tracking Plans

Returns a list of Tracking Plans.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListTrackingPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var type = LIVE;  // string? | Requests Tracking Plans of a certain type. If omitted, lists all types.  This parameter exists in v1. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination options.  This parameter exists in v1. (optional) 

            try
            {
                // List Tracking Plans
                ListTrackingPlans200Response result = apiInstance.ListTrackingPlans(type, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.ListTrackingPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTrackingPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Tracking Plans
    ApiResponse<ListTrackingPlans200Response> response = apiInstance.ListTrackingPlansWithHttpInfo(type, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.ListTrackingPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Requests Tracking Plans of a certain type. If omitted, lists all types.  This parameter exists in v1. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination options.  This parameter exists in v1. | [optional]  |

### Return type

[**ListTrackingPlans200Response**](ListTrackingPlans200Response.md)

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

<a id="removerulesfromtrackingplan"></a>
# **RemoveRulesFromTrackingPlan**
> RemoveRulesFromTrackingPlan200Response RemoveRulesFromTrackingPlan (string trackingPlanId, List<RemoveRuleV1> rules)

Remove Rules from Tracking Plan

Deletes Tracking Plan rules.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveRulesFromTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var rules = new List<RemoveRuleV1>(); // List<RemoveRuleV1> | Rules to delete.  This parameter exists in v1.

            try
            {
                // Remove Rules from Tracking Plan
                RemoveRulesFromTrackingPlan200Response result = apiInstance.RemoveRulesFromTrackingPlan(trackingPlanId, rules);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.RemoveRulesFromTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveRulesFromTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Rules from Tracking Plan
    ApiResponse<RemoveRulesFromTrackingPlan200Response> response = apiInstance.RemoveRulesFromTrackingPlanWithHttpInfo(trackingPlanId, rules);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.RemoveRulesFromTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **rules** | [**List&lt;RemoveRuleV1&gt;**](RemoveRuleV1.md) | Rules to delete.  This parameter exists in v1. |  |

### Return type

[**RemoveRulesFromTrackingPlan200Response**](RemoveRulesFromTrackingPlan200Response.md)

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

<a id="removesourcefromtrackingplan"></a>
# **RemoveSourceFromTrackingPlan**
> RemoveSourceFromTrackingPlan200Response RemoveSourceFromTrackingPlan (string trackingPlanId, string sourceId)

Remove Source from Tracking Plan

Disconnects a Source from a Tracking Plan.    • When called, this endpoint may generate the `Source Modified` event in the [audit trail](/tag/Audit-Trail).   • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveSourceFromTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | The id of the Source associated with the Tracking Plan.  Config API note: analogous to `sourceName`.  This parameter exists in v1.

            try
            {
                // Remove Source from Tracking Plan
                RemoveSourceFromTrackingPlan200Response result = apiInstance.RemoveSourceFromTrackingPlan(trackingPlanId, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.RemoveSourceFromTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSourceFromTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Source from Tracking Plan
    ApiResponse<RemoveSourceFromTrackingPlan200Response> response = apiInstance.RemoveSourceFromTrackingPlanWithHttpInfo(trackingPlanId, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.RemoveSourceFromTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **sourceId** | **string** | The id of the Source associated with the Tracking Plan.  Config API note: analogous to &#x60;sourceName&#x60;.  This parameter exists in v1. |  |

### Return type

[**RemoveSourceFromTrackingPlan200Response**](RemoveSourceFromTrackingPlan200Response.md)

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

<a id="replacerulesintrackingplan"></a>
# **ReplaceRulesInTrackingPlan**
> ReplaceRulesInTrackingPlan200Response ReplaceRulesInTrackingPlan (string trackingPlanId, ReplaceRulesInTrackingPlanV1Input replaceRulesInTrackingPlanV1Input)

Replace Rules in Tracking Plan

Replaces Tracking Plan rules.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ReplaceRulesInTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var replaceRulesInTrackingPlanV1Input = new ReplaceRulesInTrackingPlanV1Input(); // ReplaceRulesInTrackingPlanV1Input | 

            try
            {
                // Replace Rules in Tracking Plan
                ReplaceRulesInTrackingPlan200Response result = apiInstance.ReplaceRulesInTrackingPlan(trackingPlanId, replaceRulesInTrackingPlanV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.ReplaceRulesInTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceRulesInTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace Rules in Tracking Plan
    ApiResponse<ReplaceRulesInTrackingPlan200Response> response = apiInstance.ReplaceRulesInTrackingPlanWithHttpInfo(trackingPlanId, replaceRulesInTrackingPlanV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.ReplaceRulesInTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **replaceRulesInTrackingPlanV1Input** | [**ReplaceRulesInTrackingPlanV1Input**](ReplaceRulesInTrackingPlanV1Input.md) |  |  |

### Return type

[**ReplaceRulesInTrackingPlan200Response**](ReplaceRulesInTrackingPlan200Response.md)

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

<a id="updaterulesintrackingplan"></a>
# **UpdateRulesInTrackingPlan**
> UpdateRulesInTrackingPlan200Response UpdateRulesInTrackingPlan (string trackingPlanId, UpdateRulesInTrackingPlanV1Input updateRulesInTrackingPlanV1Input)

Update Rules in Tracking Plan

Updates Tracking Plan rules.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateRulesInTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var updateRulesInTrackingPlanV1Input = new UpdateRulesInTrackingPlanV1Input(); // UpdateRulesInTrackingPlanV1Input | 

            try
            {
                // Update Rules in Tracking Plan
                UpdateRulesInTrackingPlan200Response result = apiInstance.UpdateRulesInTrackingPlan(trackingPlanId, updateRulesInTrackingPlanV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.UpdateRulesInTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRulesInTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Rules in Tracking Plan
    ApiResponse<UpdateRulesInTrackingPlan200Response> response = apiInstance.UpdateRulesInTrackingPlanWithHttpInfo(trackingPlanId, updateRulesInTrackingPlanV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.UpdateRulesInTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **updateRulesInTrackingPlanV1Input** | [**UpdateRulesInTrackingPlanV1Input**](UpdateRulesInTrackingPlanV1Input.md) |  |  |

### Return type

[**UpdateRulesInTrackingPlan200Response**](UpdateRulesInTrackingPlan200Response.md)

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

<a id="updatetrackingplan"></a>
# **UpdateTrackingPlan**
> UpdateTrackingPlan200Response UpdateTrackingPlan (string trackingPlanId, UpdateTrackingPlanV1Input updateTrackingPlanV1Input)

Update Tracking Plan

Updates a Tracking Plan.    • In order to successfully call this endpoint, the specified Workspace needs to have the Protocols feature enabled. Please reach out to your customer success manager for more information.  Config API omitted fields: - `updateMask`       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateTrackingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TrackingPlansApi(config);
            var trackingPlanId = tp_sprout_rVGCC6WdrNxjCf6JpCHP;  // string | 
            var updateTrackingPlanV1Input = new UpdateTrackingPlanV1Input(); // UpdateTrackingPlanV1Input | 

            try
            {
                // Update Tracking Plan
                UpdateTrackingPlan200Response result = apiInstance.UpdateTrackingPlan(trackingPlanId, updateTrackingPlanV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingPlansApi.UpdateTrackingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTrackingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Tracking Plan
    ApiResponse<UpdateTrackingPlan200Response> response = apiInstance.UpdateTrackingPlanWithHttpInfo(trackingPlanId, updateTrackingPlanV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingPlansApi.UpdateTrackingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingPlanId** | **string** |  |  |
| **updateTrackingPlanV1Input** | [**UpdateTrackingPlanV1Input**](UpdateTrackingPlanV1Input.md) |  |  |

### Return type

[**UpdateTrackingPlan200Response**](UpdateTrackingPlan200Response.md)

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

