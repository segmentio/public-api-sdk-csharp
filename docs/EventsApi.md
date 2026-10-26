# Segment.PublicApi.Api.EventsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEventsVolumeFromWorkspace**](EventsApi.md#geteventsvolumefromworkspace) | **GET** /events/volume | Get Events Volume from Workspace |

<a id="geteventsvolumefromworkspace"></a>
# **GetEventsVolumeFromWorkspace**
> GetEventsVolumeFromWorkspace200Response GetEventsVolumeFromWorkspace (string granularity, string startTime, string endTime, List<string>? groupBy = null, List<string>? sourceId = null, List<string>? eventName = null, List<string>? eventType = null, List<string>? appVersion = null, PaginationInput? pagination = null)

Get Events Volume from Workspace

Enumerates the Workspace event volumes over time in minute increments.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetEventsVolumeFromWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EventsApi(config);
            var granularity = DAY;  // string | The size of each bucket in the requested window.  This parameter exists in v1.
            var startTime = 2021-10-28T00:00:00Z;  // string | The ISO8601 formatted timestamp that corresponds to the beginning of the requested time frame, inclusive.  This parameter exists in v1.
            var endTime = 2021-10-29T16:40:00Z;  // string | The ISO8601 formatted timestamp that corresponds to the end of the requested time frame, noninclusive. Segment recommends that you lag queries 1 minute behind clock time to reduce the risk for latency to impact the counts.  This parameter exists in v1.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings that represents the dimensions to group the result by. The options are: `eventName`, `eventType` and `source`.  This parameter exists in v1. (optional) 
            var sourceId = new List<string>?(); // List<string>? | A list of strings which filters the results to the given SourceIds.  This parameter exists in v1. (optional) 
            var eventName = new List<string>?(); // List<string>? | A list of strings which filters the results to the given EventNames.  This parameter exists in v1. (optional) 
            var eventType = new List<string>?(); // List<string>? | A list of strings which filters the results to the given EventTypes.  This parameter exists in v1. (optional) 
            var appVersion = new List<string>?(); // List<string>? | A list of strings which filters the results to the given AppVersions.  This parameter exists in v1. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination input for event volume by Workspace.  This parameter exists in v1. (optional) 

            try
            {
                // Get Events Volume from Workspace
                GetEventsVolumeFromWorkspace200Response result = apiInstance.GetEventsVolumeFromWorkspace(granularity, startTime, endTime, groupBy, sourceId, eventName, eventType, appVersion, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsVolumeFromWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsVolumeFromWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Events Volume from Workspace
    ApiResponse<GetEventsVolumeFromWorkspace200Response> response = apiInstance.GetEventsVolumeFromWorkspaceWithHttpInfo(granularity, startTime, endTime, groupBy, sourceId, eventName, eventType, appVersion, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsVolumeFromWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **granularity** | **string** | The size of each bucket in the requested window.  This parameter exists in v1. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp that corresponds to the beginning of the requested time frame, inclusive.  This parameter exists in v1. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp that corresponds to the end of the requested time frame, noninclusive. Segment recommends that you lag queries 1 minute behind clock time to reduce the risk for latency to impact the counts.  This parameter exists in v1. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings that represents the dimensions to group the result by. The options are: &#x60;eventName&#x60;, &#x60;eventType&#x60; and &#x60;source&#x60;.  This parameter exists in v1. | [optional]  |
| **sourceId** | [**List&lt;string&gt;?**](string.md) | A list of strings which filters the results to the given SourceIds.  This parameter exists in v1. | [optional]  |
| **eventName** | [**List&lt;string&gt;?**](string.md) | A list of strings which filters the results to the given EventNames.  This parameter exists in v1. | [optional]  |
| **eventType** | [**List&lt;string&gt;?**](string.md) | A list of strings which filters the results to the given EventTypes.  This parameter exists in v1. | [optional]  |
| **appVersion** | [**List&lt;string&gt;?**](string.md) | A list of strings which filters the results to the given AppVersions.  This parameter exists in v1. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination input for event volume by Workspace.  This parameter exists in v1. | [optional]  |

### Return type

[**GetEventsVolumeFromWorkspace200Response**](GetEventsVolumeFromWorkspace200Response.md)

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

