# Segment.PublicApi.Api.SpaceFiltersApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFilterForSpace**](SpaceFiltersApi.md#createfilterforspace) | **POST** /filters | Create Filter for Space |
| [**DeleteFilterById**](SpaceFiltersApi.md#deletefilterbyid) | **DELETE** /filters/{id} | Delete Filter By Id |
| [**GetFilterById**](SpaceFiltersApi.md#getfilterbyid) | **GET** /filters/{id} | Get Filter By Id |
| [**ListFiltersForSpace**](SpaceFiltersApi.md#listfiltersforspace) | **GET** /filters | List Filters for Space |
| [**UpdateFilterById**](SpaceFiltersApi.md#updatefilterbyid) | **PATCH** /filters/{id} | Update Filter By Id |

<a id="createfilterforspace"></a>
# **CreateFilterForSpace**
> CreateFilterForSpace200Response CreateFilterForSpace (CreateFilterForSpaceInput createFilterForSpaceInput)

Create Filter for Space

Creates a filter for a space. A space filter applies to events coming from all Sources connected to a space.    • This endpoint is in **Beta** testing.  Please submit any feedback by sending an email to friends@segment.com.    • In order to successfully call this endpoint, the specified Workspace needs to have the Space Filters feature enabled. Please reach out to your customer success manager for more information.   • When called, this endpoint may generate the `Filter Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateFilterForSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceFiltersApi(config);
            var createFilterForSpaceInput = new CreateFilterForSpaceInput(); // CreateFilterForSpaceInput | 

            try
            {
                // Create Filter for Space
                CreateFilterForSpace200Response result = apiInstance.CreateFilterForSpace(createFilterForSpaceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceFiltersApi.CreateFilterForSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFilterForSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Filter for Space
    ApiResponse<CreateFilterForSpace200Response> response = apiInstance.CreateFilterForSpaceWithHttpInfo(createFilterForSpaceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceFiltersApi.CreateFilterForSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFilterForSpaceInput** | [**CreateFilterForSpaceInput**](CreateFilterForSpaceInput.md) |  |  |

### Return type

[**CreateFilterForSpace200Response**](CreateFilterForSpace200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefilterbyid"></a>
# **DeleteFilterById**
> DeleteFilterById200Response DeleteFilterById (string id)

Delete Filter By Id

Deletes a filter by id.    • This endpoint is in **Beta** testing.  Please submit any feedback by sending an email to friends@segment.com.    • In order to successfully call this endpoint, the specified Workspace needs to have the Space Filters feature enabled. Please reach out to your customer success manager for more information.   • When called, this endpoint may generate the `Filter Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteFilterByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceFiltersApi(config);
            var id = <id>;  // string | 

            try
            {
                // Delete Filter By Id
                DeleteFilterById200Response result = apiInstance.DeleteFilterById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceFiltersApi.DeleteFilterById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFilterByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Filter By Id
    ApiResponse<DeleteFilterById200Response> response = apiInstance.DeleteFilterByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceFiltersApi.DeleteFilterByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**DeleteFilterById200Response**](DeleteFilterById200Response.md)

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

<a id="getfilterbyid"></a>
# **GetFilterById**
> GetFilterById200Response GetFilterById (string id)

Get Filter By Id

Gets a filter by id.  • This endpoint is in **Beta** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Space Filters feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetFilterByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceFiltersApi(config);
            var id = <id>;  // string | 

            try
            {
                // Get Filter By Id
                GetFilterById200Response result = apiInstance.GetFilterById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceFiltersApi.GetFilterById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilterByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filter By Id
    ApiResponse<GetFilterById200Response> response = apiInstance.GetFilterByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceFiltersApi.GetFilterByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**GetFilterById200Response**](GetFilterById200Response.md)

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

<a id="listfiltersforspace"></a>
# **ListFiltersForSpace**
> ListFiltersForSpace200Response ListFiltersForSpace (string integrationId, ListFiltersPaginationInput? pagination = null)

List Filters for Space

Lists filters for a space.  • This endpoint is in **Beta** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Space Filters feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListFiltersForSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceFiltersApi(config);
            var integrationId = <id>;  // string | The Space Id for which to fetch filters  This parameter exists in beta.
            var pagination = new ListFiltersPaginationInput?(); // ListFiltersPaginationInput? | Pagination parameters.  This parameter exists in beta. (optional) 

            try
            {
                // List Filters for Space
                ListFiltersForSpace200Response result = apiInstance.ListFiltersForSpace(integrationId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceFiltersApi.ListFiltersForSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFiltersForSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Filters for Space
    ApiResponse<ListFiltersForSpace200Response> response = apiInstance.ListFiltersForSpaceWithHttpInfo(integrationId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceFiltersApi.ListFiltersForSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integrationId** | **string** | The Space Id for which to fetch filters  This parameter exists in beta. |  |
| **pagination** | [**ListFiltersPaginationInput?**](ListFiltersPaginationInput?.md) | Pagination parameters.  This parameter exists in beta. | [optional]  |

### Return type

[**ListFiltersForSpace200Response**](ListFiltersForSpace200Response.md)

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

<a id="updatefilterbyid"></a>
# **UpdateFilterById**
> UpdateFilterById200Response UpdateFilterById (string id, UpdateFilterByIdInput updateFilterByIdInput)

Update Filter By Id

Updates a filter by id and replaces the existing filter.    • This endpoint is in **Beta** testing.  Please submit any feedback by sending an email to friends@segment.com.    • In order to successfully call this endpoint, the specified Workspace needs to have the Space Filters feature enabled. Please reach out to your customer success manager for more information.   • When called, this endpoint may generate the `Filter Updated` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateFilterByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SpaceFiltersApi(config);
            var id = <id>;  // string | 
            var updateFilterByIdInput = new UpdateFilterByIdInput(); // UpdateFilterByIdInput | 

            try
            {
                // Update Filter By Id
                UpdateFilterById200Response result = apiInstance.UpdateFilterById(id, updateFilterByIdInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpaceFiltersApi.UpdateFilterById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFilterByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Filter By Id
    ApiResponse<UpdateFilterById200Response> response = apiInstance.UpdateFilterByIdWithHttpInfo(id, updateFilterByIdInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpaceFiltersApi.UpdateFilterByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **updateFilterByIdInput** | [**UpdateFilterByIdInput**](UpdateFilterByIdInput.md) |  |  |

### Return type

[**UpdateFilterById200Response**](UpdateFilterById200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

