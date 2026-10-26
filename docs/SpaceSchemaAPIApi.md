# Segment.PublicApi.Api.SpaceSchemaAPIApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListEntityPaths**](SpaceSchemaAPIApi.md#listentitypaths) | **GET** /spaces/{spaceId}/entity-paths | List Entity Paths |
| [**ListEvents**](SpaceSchemaAPIApi.md#listevents) | **GET** /spaces/{spaceId}/events | List Events |
| [**ListPropertiesFromEntity**](SpaceSchemaAPIApi.md#listpropertiesfromentity) | **GET** /spaces/{spaceId}/entities/{entitySlug}/properties | List Properties from Entity |
| [**ListPropertiesFromEvent**](SpaceSchemaAPIApi.md#listpropertiesfromevent) | **GET** /spaces/{spaceId}/events/{eventName}/properties | List Properties from Event |
| [**ListSampleValuesFromEntityProperty**](SpaceSchemaAPIApi.md#listsamplevaluesfromentityproperty) | **GET** /spaces/{spaceId}/entities/{entitySlug}/properties/{propertyName}/sample-values | List Sample Values from Entity Property |
| [**ListSampleValuesFromEventProperty**](SpaceSchemaAPIApi.md#listsamplevaluesfromeventproperty) | **GET** /spaces/{spaceId}/events/{eventName}/properties/{propertyName}/sample-values | List Sample Values from Event Property |
| [**ListSampleValuesFromTrait**](SpaceSchemaAPIApi.md#listsamplevaluesfromtrait) | **GET** /spaces/{spaceId}/traits/{traitKey}/sample-values | List Sample Values from Trait |
| [**ListTraits**](SpaceSchemaAPIApi.md#listtraits) | **GET** /spaces/{spaceId}/traits | List Traits |

<a id="listentitypaths"></a>
# **ListEntityPaths**
> ListEntityPaths200Response ListEntityPaths (string spaceId, PaginationInput? pagination = null, string? search = null)

List Entity Paths

Returns a list of Entity Paths for a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListEntityPathsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination params. Defaults to count 200.  This parameter exists in alpha. (optional) 
            var search = "search_example";  // string? | Filter paths by entity name or path name.  This parameter exists in alpha. (optional) 

            try
            {
                // List Entity Paths
                ListEntityPaths200Response result = apiInstance.ListEntityPaths(spaceId, pagination, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListEntityPaths: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEntityPathsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Entity Paths
    ApiResponse<ListEntityPaths200Response> response = apiInstance.ListEntityPathsWithHttpInfo(spaceId, pagination, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListEntityPathsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination params. Defaults to count 200.  This parameter exists in alpha. | [optional]  |
| **search** | **string?** | Filter paths by entity name or path name.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListEntityPaths200Response**](ListEntityPaths200Response.md)

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

<a id="listevents"></a>
# **ListEvents**
> ListEvents200Response ListEvents (string spaceId, PaginationInput? pagination = null, string? sortBy = null, string? sortDir = null, string? search = null)

List Events

Returns a list of Events for a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination params. Defaults to count 200.  This parameter exists in alpha. (optional) 
            var sortBy = lastSeenAt;  // string? | Field to sort by. Defaults to 'lastSeenAt'.  This parameter exists in alpha. (optional) 
            var sortDir = desc;  // string? | Sort direction. Defaults to 'desc'.  This parameter exists in alpha. (optional) 
            var search = "search_example";  // string? | Filter events by name substring.  This parameter exists in alpha. (optional) 

            try
            {
                // List Events
                ListEvents200Response result = apiInstance.ListEvents(spaceId, pagination, sortBy, sortDir, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Events
    ApiResponse<ListEvents200Response> response = apiInstance.ListEventsWithHttpInfo(spaceId, pagination, sortBy, sortDir, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination params. Defaults to count 200.  This parameter exists in alpha. | [optional]  |
| **sortBy** | **string?** | Field to sort by. Defaults to &#39;lastSeenAt&#39;.  This parameter exists in alpha. | [optional]  |
| **sortDir** | **string?** | Sort direction. Defaults to &#39;desc&#39;.  This parameter exists in alpha. | [optional]  |
| **search** | **string?** | Filter events by name substring.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListEvents200Response**](ListEvents200Response.md)

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

<a id="listpropertiesfromentity"></a>
# **ListPropertiesFromEntity**
> ListPropertiesFromEntity200Response ListPropertiesFromEntity (string spaceId, string entitySlug, PaginationInput? pagination = null, bool? includeSampleValues = null, decimal? samplesCount = null)

List Properties from Entity

Returns a list of Properties for an Entity in a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.  <div style=\"background-color: #e8f4fd; border: 1px solid #90caf9; border-radius: 6px; padding: 16px; margin: 16px 0; color: #0d47a1; line-height: 1.5;\">   <ul style=\"margin: 0; padding-left: 20px; font-size: 13px;\">     <li style=\"margin-bottom: 6px;\"><strong>Forward-only pagination</strong>: this endpoint does not support backward traversal. The <code>pagination.previous</code> field is always absent; use <code>pagination.next</code> to advance through pages.</li>   </ul> </div>    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListPropertiesFromEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var entitySlug = my-entity;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination params. Defaults to count 200.  This parameter exists in alpha. (optional) 
            var includeSampleValues = true;  // bool? | When true, include sample values for each property. Defaults to false.  This parameter exists in alpha. (optional) 
            var samplesCount = 8.14D;  // decimal? | Max number of sample values to return per property. Defaults to 20, min 1, max 100.  This parameter exists in alpha. (optional) 

            try
            {
                // List Properties from Entity
                ListPropertiesFromEntity200Response result = apiInstance.ListPropertiesFromEntity(spaceId, entitySlug, pagination, includeSampleValues, samplesCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListPropertiesFromEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPropertiesFromEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Properties from Entity
    ApiResponse<ListPropertiesFromEntity200Response> response = apiInstance.ListPropertiesFromEntityWithHttpInfo(spaceId, entitySlug, pagination, includeSampleValues, samplesCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListPropertiesFromEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **entitySlug** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination params. Defaults to count 200.  This parameter exists in alpha. | [optional]  |
| **includeSampleValues** | **bool?** | When true, include sample values for each property. Defaults to false.  This parameter exists in alpha. | [optional]  |
| **samplesCount** | **decimal?** | Max number of sample values to return per property. Defaults to 20, min 1, max 100.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListPropertiesFromEntity200Response**](ListPropertiesFromEntity200Response.md)

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

<a id="listpropertiesfromevent"></a>
# **ListPropertiesFromEvent**
> ListPropertiesFromEvent200Response ListPropertiesFromEvent (string spaceId, string eventName, PaginationInput? pagination = null, string? sortBy = null, string? sortDir = null, string? search = null, bool? includeSampleValues = null, decimal? samplesCount = null)

List Properties from Event

Returns a list of Properties for an Event in a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListPropertiesFromEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var eventName = Order Completed;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination params. Defaults to count 200.  This parameter exists in alpha. (optional) 
            var sortBy = name;  // string? | Field to sort by. Defaults to 'lastSeenAt'.  This parameter exists in alpha. (optional) 
            var sortDir = asc;  // string? | Sort direction. Defaults to 'desc'.  This parameter exists in alpha. (optional) 
            var search = "search_example";  // string? | Filter properties by name substring.  This parameter exists in alpha. (optional) 
            var includeSampleValues = true;  // bool? | When true, include sample values for each property. Defaults to false.  This parameter exists in alpha. (optional) 
            var samplesCount = 8.14D;  // decimal? | Max number of sample values to return per property. Defaults to 20, min 1, max 100.  This parameter exists in alpha. (optional) 

            try
            {
                // List Properties from Event
                ListPropertiesFromEvent200Response result = apiInstance.ListPropertiesFromEvent(spaceId, eventName, pagination, sortBy, sortDir, search, includeSampleValues, samplesCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListPropertiesFromEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPropertiesFromEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Properties from Event
    ApiResponse<ListPropertiesFromEvent200Response> response = apiInstance.ListPropertiesFromEventWithHttpInfo(spaceId, eventName, pagination, sortBy, sortDir, search, includeSampleValues, samplesCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListPropertiesFromEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **eventName** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination params. Defaults to count 200.  This parameter exists in alpha. | [optional]  |
| **sortBy** | **string?** | Field to sort by. Defaults to &#39;lastSeenAt&#39;.  This parameter exists in alpha. | [optional]  |
| **sortDir** | **string?** | Sort direction. Defaults to &#39;desc&#39;.  This parameter exists in alpha. | [optional]  |
| **search** | **string?** | Filter properties by name substring.  This parameter exists in alpha. | [optional]  |
| **includeSampleValues** | **bool?** | When true, include sample values for each property. Defaults to false.  This parameter exists in alpha. | [optional]  |
| **samplesCount** | **decimal?** | Max number of sample values to return per property. Defaults to 20, min 1, max 100.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListPropertiesFromEvent200Response**](ListPropertiesFromEvent200Response.md)

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

<a id="listsamplevaluesfromentityproperty"></a>
# **ListSampleValuesFromEntityProperty**
> ListSampleValuesFromEntityProperty200Response ListSampleValuesFromEntityProperty (string spaceId, string entitySlug, string propertyName)

List Sample Values from Entity Property

Returns sample values for an Entity Property in a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSampleValuesFromEntityPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var entitySlug = my-entity;  // string | 
            var propertyName = email;  // string | 

            try
            {
                // List Sample Values from Entity Property
                ListSampleValuesFromEntityProperty200Response result = apiInstance.ListSampleValuesFromEntityProperty(spaceId, entitySlug, propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromEntityProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSampleValuesFromEntityPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sample Values from Entity Property
    ApiResponse<ListSampleValuesFromEntityProperty200Response> response = apiInstance.ListSampleValuesFromEntityPropertyWithHttpInfo(spaceId, entitySlug, propertyName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromEntityPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **entitySlug** | **string** |  |  |
| **propertyName** | **string** |  |  |

### Return type

[**ListSampleValuesFromEntityProperty200Response**](ListSampleValuesFromEntityProperty200Response.md)

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

<a id="listsamplevaluesfromeventproperty"></a>
# **ListSampleValuesFromEventProperty**
> ListSampleValuesFromEventProperty200Response ListSampleValuesFromEventProperty (string spaceId, string eventName, string propertyName, EventPropertyType propertyType)

List Sample Values from Event Property

Returns sample values for an Event Property in a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSampleValuesFromEventPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var eventName = Order Completed;  // string | 
            var propertyName = revenue;  // string | 
            var propertyType = new EventPropertyType(); // EventPropertyType | The property type.  This parameter exists in alpha.

            try
            {
                // List Sample Values from Event Property
                ListSampleValuesFromEventProperty200Response result = apiInstance.ListSampleValuesFromEventProperty(spaceId, eventName, propertyName, propertyType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromEventProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSampleValuesFromEventPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sample Values from Event Property
    ApiResponse<ListSampleValuesFromEventProperty200Response> response = apiInstance.ListSampleValuesFromEventPropertyWithHttpInfo(spaceId, eventName, propertyName, propertyType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromEventPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **eventName** | **string** |  |  |
| **propertyName** | **string** |  |  |
| **propertyType** | [**EventPropertyType**](EventPropertyType.md) | The property type.  This parameter exists in alpha. |  |

### Return type

[**ListSampleValuesFromEventProperty200Response**](ListSampleValuesFromEventProperty200Response.md)

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

<a id="listsamplevaluesfromtrait"></a>
# **ListSampleValuesFromTrait**
> ListSampleValuesFromTrait200Response ListSampleValuesFromTrait (string spaceId, string traitKey, string? collection = null)

List Sample Values from Trait

Returns sample values for a Trait in a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSampleValuesFromTraitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var traitKey = email;  // string | 
            var collection = "accounts";  // string? | Collection to get trait values for. Defaults to 'users'.  This parameter exists in alpha. (optional) 

            try
            {
                // List Sample Values from Trait
                ListSampleValuesFromTrait200Response result = apiInstance.ListSampleValuesFromTrait(spaceId, traitKey, collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromTrait: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSampleValuesFromTraitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sample Values from Trait
    ApiResponse<ListSampleValuesFromTrait200Response> response = apiInstance.ListSampleValuesFromTraitWithHttpInfo(spaceId, traitKey, collection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListSampleValuesFromTraitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **traitKey** | **string** |  |  |
| **collection** | **string?** | Collection to get trait values for. Defaults to &#39;users&#39;.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListSampleValuesFromTrait200Response**](ListSampleValuesFromTrait200Response.md)

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

<a id="listtraits"></a>
# **ListTraits**
> ListTraits200Response ListTraits (string spaceId, PaginationInput? pagination = null, string? sortBy = null, string? sortDir = null, string? search = null, string? collection = null, bool? includeSampleValues = null, decimal? samplesCount = null)

List Traits

Returns a list of Traits for a Space.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.  <div style=\"background-color: #e8f4fd; border: 1px solid #90caf9; border-radius: 6px; padding: 16px; margin: 16px 0; color: #0d47a1; line-height: 1.5;\">   <ul style=\"margin: 0; padding-left: 20px; font-size: 13px;\">     <li style=\"margin-bottom: 6px;\"><strong>Forward-only pagination</strong>: this endpoint does not support backward traversal. The <code>pagination.previous</code> field is always absent; use <code>pagination.next</code> to advance through pages.</li>     <li style=\"margin-bottom: 6px;\"><strong>Approximate total count</strong>: <code>pagination.totalEntries</code> is an upper bound that decreases as you paginate — the final page reflects the exact deduplicated count.</li>     <li style=\"margin-bottom: 6px;\"><strong>Duplicate entries</strong>: when sorting by <code>lastSeenAt</code>, duplicate trait entries may appear across pages for Spaces with more than 2,500 traits. Sorting by <code>trait</code> is not affected.</li>   </ul> </div>    The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListTraitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceSchemaAPIApi(config);
            var spaceId = spaceId;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination params. Defaults to count 200.  This parameter exists in alpha. (optional) 
            var sortBy = trait;  // string? | Field to sort by. Defaults to 'trait'.  This parameter exists in alpha. (optional) 
            var sortDir = asc;  // string? | Sort direction. Defaults to 'asc'.  This parameter exists in alpha. (optional) 
            var search = "search_example";  // string? | Filter traits by key substring.  This parameter exists in alpha. (optional) 
            var collection = "accounts";  // string? | Collection to list traits for. Defaults to 'users'.  This parameter exists in alpha. (optional) 
            var includeSampleValues = true;  // bool? | When true, include sample values for each trait. Defaults to false.  This parameter exists in alpha. (optional) 
            var samplesCount = 8.14D;  // decimal? | Max number of sample values to return per trait. Defaults to 20, min 1, max 100.  This parameter exists in alpha. (optional) 

            try
            {
                // List Traits
                ListTraits200Response result = apiInstance.ListTraits(spaceId, pagination, sortBy, sortDir, search, collection, includeSampleValues, samplesCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceSchemaAPIApi.ListTraits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTraitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Traits
    ApiResponse<ListTraits200Response> response = apiInstance.ListTraitsWithHttpInfo(spaceId, pagination, sortBy, sortDir, search, collection, includeSampleValues, samplesCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceSchemaAPIApi.ListTraitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination params. Defaults to count 200.  This parameter exists in alpha. | [optional]  |
| **sortBy** | **string?** | Field to sort by. Defaults to &#39;trait&#39;.  This parameter exists in alpha. | [optional]  |
| **sortDir** | **string?** | Sort direction. Defaults to &#39;asc&#39;.  This parameter exists in alpha. | [optional]  |
| **search** | **string?** | Filter traits by key substring.  This parameter exists in alpha. | [optional]  |
| **collection** | **string?** | Collection to list traits for. Defaults to &#39;users&#39;.  This parameter exists in alpha. | [optional]  |
| **includeSampleValues** | **bool?** | When true, include sample values for each trait. Defaults to false.  This parameter exists in alpha. | [optional]  |
| **samplesCount** | **decimal?** | Max number of sample values to return per trait. Defaults to 20, min 1, max 100.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListTraits200Response**](ListTraits200Response.md)

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

