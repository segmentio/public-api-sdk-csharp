# Segment.PublicApi.Api.DestinationFiltersApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFilterForDestination**](DestinationFiltersApi.md#createfilterfordestination) | **POST** /destination/{destinationId}/filters | Create Filter for Destination |
| [**GetFilterInDestination**](DestinationFiltersApi.md#getfilterindestination) | **GET** /destination/{destinationId}/filters/{filterId} | Get Filter in Destination |
| [**ListFiltersFromDestination**](DestinationFiltersApi.md#listfiltersfromdestination) | **GET** /destination/{destinationId}/filters | List Filters from Destination |
| [**PreviewDestinationFilter**](DestinationFiltersApi.md#previewdestinationfilter) | **POST** /destination/filters/preview | Preview Destination Filter |
| [**RemoveFilterFromDestination**](DestinationFiltersApi.md#removefilterfromdestination) | **DELETE** /destination/{destinationId}/filters/{filterId} | Remove Filter from Destination |
| [**UpdateFilterForDestination**](DestinationFiltersApi.md#updatefilterfordestination) | **PATCH** /destination/{destinationId}/filters/{filterId} | Update Filter for Destination |

<a id="createfilterfordestination"></a>
# **CreateFilterForDestination**
> CreateFilterForDestination200Response CreateFilterForDestination (string destinationId, CreateFilterForDestinationV1Input createFilterForDestinationV1Input)

Create Filter for Destination

Creates a filter in a Destination.    • When called, this endpoint may generate the `Destination Filter Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateFilterForDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var createFilterForDestinationV1Input = new CreateFilterForDestinationV1Input(); // CreateFilterForDestinationV1Input | 

            try
            {
                // Create Filter for Destination
                CreateFilterForDestination200Response result = apiInstance.CreateFilterForDestination(destinationId, createFilterForDestinationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.CreateFilterForDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFilterForDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Filter for Destination
    ApiResponse<CreateFilterForDestination200Response> response = apiInstance.CreateFilterForDestinationWithHttpInfo(destinationId, createFilterForDestinationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.CreateFilterForDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **createFilterForDestinationV1Input** | [**CreateFilterForDestinationV1Input**](CreateFilterForDestinationV1Input.md) |  |  |

### Return type

[**CreateFilterForDestination200Response**](CreateFilterForDestination200Response.md)

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

<a id="getfilterindestination"></a>
# **GetFilterInDestination**
> GetFilterInDestination200Response GetFilterInDestination (string destinationId, string filterId)

Get Filter in Destination

Gets a Destination filter by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFilterInDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var filterId = xx6AySGeFExzdv2Gw2EuhV;  // string | 

            try
            {
                // Get Filter in Destination
                GetFilterInDestination200Response result = apiInstance.GetFilterInDestination(destinationId, filterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.GetFilterInDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilterInDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filter in Destination
    ApiResponse<GetFilterInDestination200Response> response = apiInstance.GetFilterInDestinationWithHttpInfo(destinationId, filterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.GetFilterInDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **filterId** | **string** |  |  |

### Return type

[**GetFilterInDestination200Response**](GetFilterInDestination200Response.md)

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

<a id="listfiltersfromdestination"></a>
# **ListFiltersFromDestination**
> ListFiltersFromDestination200Response ListFiltersFromDestination (string destinationId, PaginationInput? pagination = null)

List Filters from Destination

Lists filters for a Destination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListFiltersFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var destinationId = qtiZHLLqqsHmpvLXNtP5du;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination options.  This parameter exists in v1. (optional) 

            try
            {
                // List Filters from Destination
                ListFiltersFromDestination200Response result = apiInstance.ListFiltersFromDestination(destinationId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.ListFiltersFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFiltersFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Filters from Destination
    ApiResponse<ListFiltersFromDestination200Response> response = apiInstance.ListFiltersFromDestinationWithHttpInfo(destinationId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.ListFiltersFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination options.  This parameter exists in v1. | [optional]  |

### Return type

[**ListFiltersFromDestination200Response**](ListFiltersFromDestination200Response.md)

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

<a id="previewdestinationfilter"></a>
# **PreviewDestinationFilter**
> PreviewDestinationFilter200Response PreviewDestinationFilter (PreviewDestinationFilterV1Input previewDestinationFilterV1Input)

Preview Destination Filter

Simulates the application of a Destination filter to a provided JSON payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class PreviewDestinationFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var previewDestinationFilterV1Input = new PreviewDestinationFilterV1Input(); // PreviewDestinationFilterV1Input | 

            try
            {
                // Preview Destination Filter
                PreviewDestinationFilter200Response result = apiInstance.PreviewDestinationFilter(previewDestinationFilterV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.PreviewDestinationFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreviewDestinationFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Preview Destination Filter
    ApiResponse<PreviewDestinationFilter200Response> response = apiInstance.PreviewDestinationFilterWithHttpInfo(previewDestinationFilterV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.PreviewDestinationFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **previewDestinationFilterV1Input** | [**PreviewDestinationFilterV1Input**](PreviewDestinationFilterV1Input.md) |  |  |

### Return type

[**PreviewDestinationFilter200Response**](PreviewDestinationFilter200Response.md)

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

<a id="removefilterfromdestination"></a>
# **RemoveFilterFromDestination**
> RemoveFilterFromDestination200Response RemoveFilterFromDestination (string destinationId, string filterId)

Remove Filter from Destination

Deletes a Destination filter.    • When called, this endpoint may generate the `Destination Filter Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveFilterFromDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var filterId = 2c0vbGYWOBwbKszg0F0CoLSS01b;  // string | 

            try
            {
                // Remove Filter from Destination
                RemoveFilterFromDestination200Response result = apiInstance.RemoveFilterFromDestination(destinationId, filterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.RemoveFilterFromDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveFilterFromDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Filter from Destination
    ApiResponse<RemoveFilterFromDestination200Response> response = apiInstance.RemoveFilterFromDestinationWithHttpInfo(destinationId, filterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.RemoveFilterFromDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **filterId** | **string** |  |  |

### Return type

[**RemoveFilterFromDestination200Response**](RemoveFilterFromDestination200Response.md)

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

<a id="updatefilterfordestination"></a>
# **UpdateFilterForDestination**
> UpdateFilterForDestination200Response UpdateFilterForDestination (string destinationId, string filterId, UpdateFilterForDestinationV1Input updateFilterForDestinationV1Input)

Update Filter for Destination

Updates a filter in a Destination.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Destination Filter Enabled * Destination Filter Disabled       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateFilterForDestinationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DestinationFiltersApi(config);
            var destinationId = fP7qoQw2HTWt9WdMr718gn;  // string | 
            var filterId = xx6AySGeFExzdv2Gw2EuhV;  // string | 
            var updateFilterForDestinationV1Input = new UpdateFilterForDestinationV1Input(); // UpdateFilterForDestinationV1Input | 

            try
            {
                // Update Filter for Destination
                UpdateFilterForDestination200Response result = apiInstance.UpdateFilterForDestination(destinationId, filterId, updateFilterForDestinationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DestinationFiltersApi.UpdateFilterForDestination: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFilterForDestinationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Filter for Destination
    ApiResponse<UpdateFilterForDestination200Response> response = apiInstance.UpdateFilterForDestinationWithHttpInfo(destinationId, filterId, updateFilterForDestinationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DestinationFiltersApi.UpdateFilterForDestinationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationId** | **string** |  |  |
| **filterId** | **string** |  |  |
| **updateFilterForDestinationV1Input** | [**UpdateFilterForDestinationV1Input**](UpdateFilterForDestinationV1Input.md) |  |  |

### Return type

[**UpdateFilterForDestination200Response**](UpdateFilterForDestination200Response.md)

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

