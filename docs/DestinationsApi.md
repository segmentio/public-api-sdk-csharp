# Segment.PublicApi.Api.DestinationsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDestination**](DestinationsApi.md#createdestination) | **POST** /destinations | Create Destination |
| [**CreateDestinationSubscription**](DestinationsApi.md#createdestinationsubscription) | **POST** /destinations/{destinationId}/subscriptions | Create Destination Subscription |
| [**DeleteDestination**](DestinationsApi.md#deletedestination) | **DELETE** /destinations/{destinationId} | Delete Destination |
| [**GetDestination**](DestinationsApi.md#getdestination) | **GET** /destinations/{destinationId} | Get Destination |
| [**GetSubscriptionFromDestination**](DestinationsApi.md#getsubscriptionfromdestination) | **GET** /destinations/{destinationId}/subscriptions/{id} | Get Subscription from Destination |
| [**ListDeliveryMetricsSummaryFromDestination**](DestinationsApi.md#listdeliverymetricssummaryfromdestination) | **GET** /destinations/{destinationId}/delivery-metrics | List Delivery Metrics Summary from Destination |
| [**ListDestinations**](DestinationsApi.md#listdestinations) | **GET** /destinations | List Destinations |
| [**ListSubscriptionsFromDestination**](DestinationsApi.md#listsubscriptionsfromdestination) | **GET** /destinations/{destinationId}/subscriptions | List Subscriptions from Destination |
| [**RemoveSubscriptionFromDestination**](DestinationsApi.md#removesubscriptionfromdestination) | **DELETE** /destinations/{destinationId}/subscriptions/{id} | Remove Subscription from Destination |
| [**UpdateDestination**](DestinationsApi.md#updatedestination) | **PATCH** /destinations/{destinationId} | Update Destination |
| [**UpdateSubscriptionForDestination**](DestinationsApi.md#updatesubscriptionfordestination) | **PATCH** /destinations/{destinationId}/subscriptions/{id} | Update Subscription for Destination |

<a id="createdestination"></a>
# **CreateDestination**
> CreateDestination200Response CreateDestination (CreateDestinationV1Input createDestinationV1Input)

Create Destination

Creates a new Destination.    • When called, this endpoint may generate the `Integration Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var createDestinationV1Input = new CreateDestinationV1Input(); // CreateDestinationV1Input | 

            try
            {
                // Create Destination
                CreateDestination200Response result = apiInstance.CreateDestination(createDestinationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.CreateDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Destination
    ApiResponse<CreateDestination200Response> response = apiInstance.CreateDestinationWithHttpInfo(createDestinationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.CreateDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDestinationV1Input** | [**CreateDestinationV1Input**](CreateDestinationV1Input.md) |  |  |

### Return type

[**CreateDestination200Response**](CreateDestination200Response.md)

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

<a id="createdestinationsubscription"></a>
# **CreateDestinationSubscription**
> CreateDestinationSubscription200Response CreateDestinationSubscription (string destinationId, CreateDestinationSubscriptionAlphaInput createDestinationSubscriptionAlphaInput)

Create Destination Subscription

Creates a new Destination subscription.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Destination Subscriptions feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 5 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateDestinationSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var createDestinationSubscriptionAlphaInput = new CreateDestinationSubscriptionAlphaInput(); // CreateDestinationSubscriptionAlphaInput | 

            try
            {
                // Create Destination Subscription
                CreateDestinationSubscription200Response result = apiInstance.CreateDestinationSubscription(destinationId, createDestinationSubscriptionAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.CreateDestinationSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDestinationSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Destination Subscription
    ApiResponse<CreateDestinationSubscription200Response> response = apiInstance.CreateDestinationSubscriptionWithHttpInfo(destinationId, createDestinationSubscriptionAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.CreateDestinationSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **createDestinationSubscriptionAlphaInput** | [**CreateDestinationSubscriptionAlphaInput**](CreateDestinationSubscriptionAlphaInput.md) |  |  |

### Return type

[**CreateDestinationSubscription200Response**](CreateDestinationSubscription200Response.md)

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

<a id="deletedestination"></a>
# **DeleteDestination**
> DeleteDestination200Response DeleteDestination (string destinationId)

Delete Destination

Deletes an existing Destination.    • When called, this endpoint may generate the `Integration Deleted` event in the [audit trail](/tag/Audit-Trail).  Config API omitted fields: - `catalogId`       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = 65c2bdbede6f2d8297f943db;  // string | 

            try
            {
                // Delete Destination
                DeleteDestination200Response result = apiInstance.DeleteDestination(destinationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.DeleteDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Destination
    ApiResponse<DeleteDestination200Response> response = apiInstance.DeleteDestinationWithHttpInfo(destinationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.DeleteDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |

### Return type

[**DeleteDestination200Response**](DeleteDestination200Response.md)

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

<a id="getdestination"></a>
# **GetDestination**
> GetDestination200Response GetDestination (string destinationId)

Get Destination

Returns a Destination by its id.        Config API omitted fields: - `catalogId` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = qtiZHLLqqsHmpvLXNtP5du;  // string | 

            try
            {
                // Get Destination
                GetDestination200Response result = apiInstance.GetDestination(destinationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.GetDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Destination
    ApiResponse<GetDestination200Response> response = apiInstance.GetDestinationWithHttpInfo(destinationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.GetDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |

### Return type

[**GetDestination200Response**](GetDestination200Response.md)

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

<a id="getsubscriptionfromdestination"></a>
# **GetSubscriptionFromDestination**
> GetSubscriptionFromDestination200Response GetSubscriptionFromDestination (string destinationId, string id)

Get Subscription from Destination

Gets a Destination subscription by id.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Destination Subscriptions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetSubscriptionFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var id = kyMKN6LUgMvF8dwRMEz3cX;  // string | 

            try
            {
                // Get Subscription from Destination
                GetSubscriptionFromDestination200Response result = apiInstance.GetSubscriptionFromDestination(destinationId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.GetSubscriptionFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Subscription from Destination
    ApiResponse<GetSubscriptionFromDestination200Response> response = apiInstance.GetSubscriptionFromDestinationWithHttpInfo(destinationId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.GetSubscriptionFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**GetSubscriptionFromDestination200Response**](GetSubscriptionFromDestination200Response.md)

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

<a id="listdeliverymetricssummaryfromdestination"></a>
# **ListDeliveryMetricsSummaryFromDestination**
> ListDeliveryMetricsSummaryFromDestination200Response ListDeliveryMetricsSummaryFromDestination (string destinationId, string sourceId, string? startTime = null, string? endTime = null, string? granularity = null)

List Delivery Metrics Summary from Destination

Get an event delivery metrics summary from a Destination.  Based on the granularity chosen, there are restrictions on the time range you can query:  **Minute**: - Max time range: 4 hours - Oldest possible start time: 48 hours in the past  **Hour**: - Max Time range: 7 days - Oldest possible start time: 7 days in the past  **Day**: - Max time range: 14 days - Oldest possible start time: 14 days in the past

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListDeliveryMetricsSummaryFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | The id of the Source linked to the Destination.  Config API note: analogous to `parent`.  This parameter exists in beta.
            var startTime = 2006-01-02T15:04:05.000Z;  // string? | Filter events that happened after this time.  Defaults to: - 1 hour ago if granularity is `MINUTE`. - 7 days ago if granularity is `HOUR`. - 30 days ago if granularity is `DAY`.  This parameter exists in beta. (optional) 
            var endTime = 2006-01-02T15:04:05.000Z;  // string? | Filter events that happened before this time. Defaults to now if not set.  This parameter exists in beta. (optional) 
            var granularity = DAY;  // string? | The granularity to filter metrics to. Either `MINUTE`, `HOUR` or `DAY`.  Defaults to `MINUTE` if not set.  This parameter exists in beta. (optional) 

            try
            {
                // List Delivery Metrics Summary from Destination
                ListDeliveryMetricsSummaryFromDestination200Response result = apiInstance.ListDeliveryMetricsSummaryFromDestination(destinationId, sourceId, startTime, endTime, granularity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.ListDeliveryMetricsSummaryFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDeliveryMetricsSummaryFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Delivery Metrics Summary from Destination
    ApiResponse<ListDeliveryMetricsSummaryFromDestination200Response> response = apiInstance.ListDeliveryMetricsSummaryFromDestinationWithHttpInfo(destinationId, sourceId, startTime, endTime, granularity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.ListDeliveryMetricsSummaryFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **sourceId** | **string** | The id of the Source linked to the Destination.  Config API note: analogous to &#x60;parent&#x60;.  This parameter exists in beta. |  |
| **startTime** | **string?** | Filter events that happened after this time.  Defaults to: - 1 hour ago if granularity is &#x60;MINUTE&#x60;. - 7 days ago if granularity is &#x60;HOUR&#x60;. - 30 days ago if granularity is &#x60;DAY&#x60;.  This parameter exists in beta. | [optional]  |
| **endTime** | **string?** | Filter events that happened before this time. Defaults to now if not set.  This parameter exists in beta. | [optional]  |
| **granularity** | **string?** | The granularity to filter metrics to. Either &#x60;MINUTE&#x60;, &#x60;HOUR&#x60; or &#x60;DAY&#x60;.  Defaults to &#x60;MINUTE&#x60; if not set.  This parameter exists in beta. | [optional]  |

### Return type

[**ListDeliveryMetricsSummaryFromDestination200Response**](ListDeliveryMetricsSummaryFromDestination200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdestinations"></a>
# **ListDestinations**
> ListDestinations200Response ListDestinations (PaginationInput? pagination = null)

List Destinations

Returns a list of Destinations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListDestinationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Required pagination params for the request.  This parameter exists in v1. (optional) 

            try
            {
                // List Destinations
                ListDestinations200Response result = apiInstance.ListDestinations(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.ListDestinations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDestinationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Destinations
    ApiResponse<ListDestinations200Response> response = apiInstance.ListDestinationsWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.ListDestinationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Required pagination params for the request.  This parameter exists in v1. | [optional]  |

### Return type

[**ListDestinations200Response**](ListDestinations200Response.md)

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

<a id="listsubscriptionsfromdestination"></a>
# **ListSubscriptionsFromDestination**
> ListSubscriptionsFromDestination200Response ListSubscriptionsFromDestination (string destinationId, PaginationInput? pagination = null)

List Subscriptions from Destination

Lists subscriptions for a Destination.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Destination Subscriptions feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSubscriptionsFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination options.  This parameter exists in alpha. (optional) 

            try
            {
                // List Subscriptions from Destination
                ListSubscriptionsFromDestination200Response result = apiInstance.ListSubscriptionsFromDestination(destinationId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.ListSubscriptionsFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubscriptionsFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Subscriptions from Destination
    ApiResponse<ListSubscriptionsFromDestination200Response> response = apiInstance.ListSubscriptionsFromDestinationWithHttpInfo(destinationId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.ListSubscriptionsFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination options.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListSubscriptionsFromDestination200Response**](ListSubscriptionsFromDestination200Response.md)

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

<a id="removesubscriptionfromdestination"></a>
# **RemoveSubscriptionFromDestination**
> RemoveSubscriptionFromDestination200Response RemoveSubscriptionFromDestination (string destinationId, string id)

Remove Subscription from Destination

Deletes an existing Destination subscription.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Destination Subscriptions feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 5 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveSubscriptionFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var id = zXCqmEMHJojkD45GcBAPt;  // string | 

            try
            {
                // Remove Subscription from Destination
                RemoveSubscriptionFromDestination200Response result = apiInstance.RemoveSubscriptionFromDestination(destinationId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.RemoveSubscriptionFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSubscriptionFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Subscription from Destination
    ApiResponse<RemoveSubscriptionFromDestination200Response> response = apiInstance.RemoveSubscriptionFromDestinationWithHttpInfo(destinationId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.RemoveSubscriptionFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**RemoveSubscriptionFromDestination200Response**](RemoveSubscriptionFromDestination200Response.md)

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

<a id="updatedestination"></a>
# **UpdateDestination**
> UpdateDestination200Response UpdateDestination (string destinationId, UpdateDestinationV1Input updateDestinationV1Input)

Update Destination

Updates an existing Destination.  **Note**: if you attempt to update read-only settings for your destination you'll encounter the following behavior:    * If only read-only properties are being updated, the endpoint will return an HTTP 400 error.   * If there's a mix of writable and read-only properties in the payload, the request will be accepted, the writable properties will be updated and the read-only properties ignored.     • When called, this endpoint may generate the `Integration Disabled` event in the [audit trail](/tag/Audit-Trail).  Config API omitted fields: - `updateMask`          

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = qtiZHLLqqsHmpvLXNtP5du;  // string | 
            var updateDestinationV1Input = new UpdateDestinationV1Input(); // UpdateDestinationV1Input | 

            try
            {
                // Update Destination
                UpdateDestination200Response result = apiInstance.UpdateDestination(destinationId, updateDestinationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.UpdateDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Destination
    ApiResponse<UpdateDestination200Response> response = apiInstance.UpdateDestinationWithHttpInfo(destinationId, updateDestinationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.UpdateDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **updateDestinationV1Input** | [**UpdateDestinationV1Input**](UpdateDestinationV1Input.md) |  |  |

### Return type

[**UpdateDestination200Response**](UpdateDestination200Response.md)

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

<a id="updatesubscriptionfordestination"></a>
# **UpdateSubscriptionForDestination**
> UpdateSubscriptionForDestination200Response UpdateSubscriptionForDestination (string destinationId, string id, UpdateSubscriptionForDestinationAlphaInput updateSubscriptionForDestinationAlphaInput)

Update Subscription for Destination

Updates an existing Destination subscription.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Destination Subscriptions feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 5 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateSubscriptionForDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationsApi(config);
            var destinationId = qtiZHLLqqsHmpvLXNtP5du;  // string | 
            var id = pJtn52LjrcD1TrQcm2ZSwp;  // string | 
            var updateSubscriptionForDestinationAlphaInput = new UpdateSubscriptionForDestinationAlphaInput(); // UpdateSubscriptionForDestinationAlphaInput | 

            try
            {
                // Update Subscription for Destination
                UpdateSubscriptionForDestination200Response result = apiInstance.UpdateSubscriptionForDestination(destinationId, id, updateSubscriptionForDestinationAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationsApi.UpdateSubscriptionForDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscriptionForDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Subscription for Destination
    ApiResponse<UpdateSubscriptionForDestination200Response> response = apiInstance.UpdateSubscriptionForDestinationWithHttpInfo(destinationId, id, updateSubscriptionForDestinationAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationsApi.UpdateSubscriptionForDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **id** | **string** |  |  |
| **updateSubscriptionForDestinationAlphaInput** | [**UpdateSubscriptionForDestinationAlphaInput**](UpdateSubscriptionForDestinationAlphaInput.md) |  |  |

### Return type

[**UpdateSubscriptionForDestination200Response**](UpdateSubscriptionForDestination200Response.md)

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

