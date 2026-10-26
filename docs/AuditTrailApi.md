# Segment.PublicApi.Api.AuditTrailApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListAuditEvents**](AuditTrailApi.md#listauditevents) | **GET** /audit-events | List Audit Events |

<a id="listauditevents"></a>
# **ListAuditEvents**
> ListAuditEvents200Response ListAuditEvents (string? startTime = null, string? endTime = null, string? resourceId = null, string? resourceType = null, PaginationInput? pagination = null)

List Audit Events

Returns a list of Audit Trail events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListAuditEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuditTrailApi(config);
            var startTime = "startTime_example";  // string? | Filter response to events that happened after this time.  This parameter exists in v1. (optional) 
            var endTime = "endTime_example";  // string? | Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. (optional) 
            var resourceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string? | Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. (optional) 
            var resourceType = "resourceType_example";  // string? | Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Audit Events
                ListAuditEvents200Response result = apiInstance.ListAuditEvents(startTime, endTime, resourceId, resourceType, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditTrailApi.ListAuditEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAuditEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Audit Events
    ApiResponse<ListAuditEvents200Response> response = apiInstance.ListAuditEventsWithHttpInfo(startTime, endTime, resourceId, resourceType, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditTrailApi.ListAuditEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **string?** | Filter response to events that happened after this time.  This parameter exists in v1. | [optional]  |
| **endTime** | **string?** | Filter response to events that happened before this time. Defaults to the current time, or the end time from the pagination cursor.  This parameter exists in v1. | [optional]  |
| **resourceId** | **string?** | Filter response to events that affect a specific resource, for example, a single Source.  This parameter exists in v1. | [optional]  |
| **resourceType** | **string?** | Filter response to events that affect a specific type, for example, Sources, Warehouses, and Tracking Plans.  This parameter exists in v1. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListAuditEvents200Response**](ListAuditEvents200Response.md)

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

