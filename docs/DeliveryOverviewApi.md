# Segment.PublicApi.Api.DeliveryOverviewApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEgressFailedMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getegressfailedmetricsfromdeliveryoverview) | **GET** /delivery-overview/failed-delivery | Get Egress Failed Metrics from Delivery Overview |
| [**GetEgressSuccessMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getegresssuccessmetricsfromdeliveryoverview) | **GET** /delivery-overview/successful-delivery | Get Egress Success Metrics from Delivery Overview |
| [**GetFilteredAtDestinationMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getfilteredatdestinationmetricsfromdeliveryoverview) | **GET** /delivery-overview/filtered-at-destination | Get Filtered At Destination Metrics from Delivery Overview |
| [**GetFilteredAtSourceMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getfilteredatsourcemetricsfromdeliveryoverview) | **GET** /delivery-overview/filtered-at-source | Get Filtered At Source Metrics from Delivery Overview |
| [**GetIngressFailedMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getingressfailedmetricsfromdeliveryoverview) | **GET** /delivery-overview/failed-on-ingest | Get Ingress Failed Metrics from Delivery Overview |
| [**GetIngressSuccessMetricsFromDeliveryOverview**](DeliveryOverviewApi.md#getingresssuccessmetricsfromdeliveryoverview) | **GET** /delivery-overview/successfully-received | Get Ingress Success Metrics from Delivery Overview |

<a id="getegressfailedmetricsfromdeliveryoverview"></a>
# **GetEgressFailedMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetEgressFailedMetricsFromDeliveryOverview (string sourceId, string destinationConfigId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewDestinationFilterBy? filter = null, PaginationInput? pagination = null)

Get Egress Failed Metrics from Delivery Overview

Get events that failed to be delivered to Destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetEgressFailedMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var destinationConfigId = fP7qoQw2HTWt9WdMr718gn;  // string | The id tied to a Workspace Destination.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, `discard Reason`, `app Version`, `subscription Id`, `activationId`, `audienceId`, and `spaceId`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewDestinationFilterBy?(); // DeliveryOverviewDestinationFilterBy? | An optional filter for `event Name`, `event Type`, `discard Reason`, `app Version`, `subscription Id`, `activationId`, `audienceId`, and/or `spaceId` that can be applied in addition to a `group By`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Egress Failed Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetEgressFailedMetricsFromDeliveryOverview(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetEgressFailedMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEgressFailedMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Egress Failed Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetEgressFailedMetricsFromDeliveryOverviewWithHttpInfo(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetEgressFailedMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **destinationConfigId** | **string** | The id tied to a Workspace Destination.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;app Version&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, and &#x60;spaceId&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewDestinationFilterBy?**](DeliveryOverviewDestinationFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;app Version&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, and/or &#x60;spaceId&#x60; that can be applied in addition to a &#x60;group By&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getegresssuccessmetricsfromdeliveryoverview"></a>
# **GetEgressSuccessMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetEgressSuccessMetricsFromDeliveryOverview (string sourceId, string destinationConfigId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewDestinationFilterBy? filter = null, PaginationInput? pagination = null)

Get Egress Success Metrics from Delivery Overview

Get events successfully delivered to Destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetEgressSuccessMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var destinationConfigId = fP7qoQw2HTWt9WdMr718gn;  // string | The id tied to a Workspace Destination.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, `discard Reason`, `app Version`, `subscription Id`, `activationId`, `audienceId`, and `spaceId`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewDestinationFilterBy?(); // DeliveryOverviewDestinationFilterBy? | An optional filter for `event Name`, `event Type`, `discard Reason`, `appVersion`, `subscription Id`, `activationId`, `audienceId`, or `spaceId` that can be applied in addition to a `group By`. If you would like to view retry attempts for a successful delivery, you can filter `discard Reason` from `successes.attempt.1` through `successes.attempt.10`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Egress Success Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetEgressSuccessMetricsFromDeliveryOverview(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetEgressSuccessMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEgressSuccessMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Egress Success Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetEgressSuccessMetricsFromDeliveryOverviewWithHttpInfo(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetEgressSuccessMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **destinationConfigId** | **string** | The id tied to a Workspace Destination.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;app Version&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, and &#x60;spaceId&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewDestinationFilterBy?**](DeliveryOverviewDestinationFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;appVersion&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, or &#x60;spaceId&#x60; that can be applied in addition to a &#x60;group By&#x60;. If you would like to view retry attempts for a successful delivery, you can filter &#x60;discard Reason&#x60; from &#x60;successes.attempt.1&#x60; through &#x60;successes.attempt.10&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilteredatdestinationmetricsfromdeliveryoverview"></a>
# **GetFilteredAtDestinationMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetFilteredAtDestinationMetricsFromDeliveryOverview (string sourceId, string destinationConfigId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewDestinationFilterBy? filter = null, PaginationInput? pagination = null)

Get Filtered At Destination Metrics from Delivery Overview

Get events that were filtered at Destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFilteredAtDestinationMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var destinationConfigId = fP7qoQw2HTWt9WdMr718gn;  // string | The id tied to a Workspace Destination.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, `discard Reason`, `app Version`, `subscription Id`, `activationId`, `audienceId`, and `spaceId`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewDestinationFilterBy?(); // DeliveryOverviewDestinationFilterBy? | An optional filter for `event Name`, `event Type`, `discard Reason`, `app Version`, `subscription Id`, `activationId`, `audienceId`, and/or `spaceId` that can be applied in addition to a `group By`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Filtered At Destination Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetFilteredAtDestinationMetricsFromDeliveryOverview(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetFilteredAtDestinationMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilteredAtDestinationMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filtered At Destination Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetFilteredAtDestinationMetricsFromDeliveryOverviewWithHttpInfo(sourceId, destinationConfigId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetFilteredAtDestinationMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **destinationConfigId** | **string** | The id tied to a Workspace Destination.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;app Version&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, and &#x60;spaceId&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewDestinationFilterBy?**](DeliveryOverviewDestinationFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, &#x60;app Version&#x60;, &#x60;subscription Id&#x60;, &#x60;activationId&#x60;, &#x60;audienceId&#x60;, and/or &#x60;spaceId&#x60; that can be applied in addition to a &#x60;group By&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilteredatsourcemetricsfromdeliveryoverview"></a>
# **GetFilteredAtSourceMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetFilteredAtSourceMetricsFromDeliveryOverview (string sourceId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewSourceFilterBy? filter = null, PaginationInput? pagination = null)

Get Filtered At Source Metrics from Delivery Overview

Get events that were filtered at Source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFilteredAtSourceMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, `discard Reason`, and `app Version`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewSourceFilterBy?(); // DeliveryOverviewSourceFilterBy? | An optional filter for `event Name`, `event Type`, `discard Reason`, and/or `app Version` that can be applied in addition to a `group By`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Optional params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Filtered At Source Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetFilteredAtSourceMetricsFromDeliveryOverview(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetFilteredAtSourceMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilteredAtSourceMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filtered At Source Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetFilteredAtSourceMetricsFromDeliveryOverviewWithHttpInfo(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetFilteredAtSourceMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, and &#x60;app Version&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewSourceFilterBy?**](DeliveryOverviewSourceFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, and/or &#x60;app Version&#x60; that can be applied in addition to a &#x60;group By&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getingressfailedmetricsfromdeliveryoverview"></a>
# **GetIngressFailedMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetIngressFailedMetricsFromDeliveryOverview (string sourceId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewSourceFilterBy? filter = null, PaginationInput? pagination = null)

Get Ingress Failed Metrics from Delivery Overview

Get events that failed on ingest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetIngressFailedMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, `discard Reason`, and/or `appVersion`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewSourceFilterBy?(); // DeliveryOverviewSourceFilterBy? | An optional filter for `event Name`, `event Type`, `discard Reason`, and/or `app Version` that can be applied in addition to a `group By`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Optional params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Ingress Failed Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetIngressFailedMetricsFromDeliveryOverview(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetIngressFailedMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIngressFailedMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ingress Failed Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetIngressFailedMetricsFromDeliveryOverviewWithHttpInfo(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetIngressFailedMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, and/or &#x60;appVersion&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewSourceFilterBy?**](DeliveryOverviewSourceFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, &#x60;discard Reason&#x60;, and/or &#x60;app Version&#x60; that can be applied in addition to a &#x60;group By&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getingresssuccessmetricsfromdeliveryoverview"></a>
# **GetIngressSuccessMetricsFromDeliveryOverview**
> GetEgressFailedMetricsFromDeliveryOverview200Response GetIngressSuccessMetricsFromDeliveryOverview (string sourceId, string startTime, string endTime, string granularity, List<string>? groupBy = null, DeliveryOverviewSuccessfullyReceivedFilterBy? filter = null, PaginationInput? pagination = null)

Get Ingress Success Metrics from Delivery Overview

Get events that were successfully received by Segment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetIngressSuccessMetricsFromDeliveryOverviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeliveryOverviewApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The sourceId for the Workspace.  This parameter exists in beta.
            var startTime = 2024-01-01T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta.
            var endTime = 2024-01-03T00:00:00Z;  // string | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta.
            var granularity = DAY;  // string | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta.
            var groupBy = new List<string>?(); // List<string>? | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: `event Name`, `event Type`, and/or `app Version`.  This parameter exists in beta. (optional) 
            var filter = new DeliveryOverviewSuccessfullyReceivedFilterBy?(); // DeliveryOverviewSuccessfullyReceivedFilterBy? | An optional filter for `event Name`, `event Type`, and/or `app Version` that can be applied in addition to a `group By`.  This parameter exists in beta. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Optional params to specify the page cursor and count.  This parameter exists in beta. (optional) 

            try
            {
                // Get Ingress Success Metrics from Delivery Overview
                GetEgressFailedMetricsFromDeliveryOverview200Response result = apiInstance.GetIngressSuccessMetricsFromDeliveryOverview(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryOverviewApi.GetIngressSuccessMetricsFromDeliveryOverview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIngressSuccessMetricsFromDeliveryOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Ingress Success Metrics from Delivery Overview
    ApiResponse<GetEgressFailedMetricsFromDeliveryOverview200Response> response = apiInstance.GetIngressSuccessMetricsFromDeliveryOverviewWithHttpInfo(sourceId, startTime, endTime, granularity, groupBy, filter, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryOverviewApi.GetIngressSuccessMetricsFromDeliveryOverviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | The sourceId for the Workspace.  This parameter exists in beta. |  |
| **startTime** | **string** | The ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive.  This parameter exists in beta. |  |
| **endTime** | **string** | The ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive.  This parameter exists in beta. |  |
| **granularity** | **string** | The size of each bucket in the requested window.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 14 days - Oldest possible start time: 30 days in the past  **Day**: - Max time range: 30 days - Oldest possible start time: 30 days in the past  This parameter exists in beta. |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | A comma-delimited list of strings representing one or more dimensions to group the result by.  Valid options are: &#x60;event Name&#x60;, &#x60;event Type&#x60;, and/or &#x60;app Version&#x60;.  This parameter exists in beta. | [optional]  |
| **filter** | [**DeliveryOverviewSuccessfullyReceivedFilterBy?**](DeliveryOverviewSuccessfullyReceivedFilterBy?.md) | An optional filter for &#x60;event Name&#x60;, &#x60;event Type&#x60;, and/or &#x60;app Version&#x60; that can be applied in addition to a &#x60;group By&#x60;.  This parameter exists in beta. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional params to specify the page cursor and count.  This parameter exists in beta. | [optional]  |

### Return type

[**GetEgressFailedMetricsFromDeliveryOverview200Response**](GetEgressFailedMetricsFromDeliveryOverview200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

