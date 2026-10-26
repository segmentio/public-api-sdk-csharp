# Segment.PublicApi.Api.SelectiveSyncApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAdvancedSyncScheduleFromWarehouse**](SelectiveSyncApi.md#getadvancedsyncschedulefromwarehouse) | **GET** /warehouses/{warehouseId}/advanced-sync-schedule | Get Advanced Sync Schedule from Warehouse |
| [**ListSelectiveSyncsFromWarehouseAndSource**](SelectiveSyncApi.md#listselectivesyncsfromwarehouseandsource) | **GET** /warehouses/{warehouseId}/connected-sources/{sourceId}/selective-syncs | List Selective Syncs from Warehouse And Source |
| [**ListSyncsFromWarehouse**](SelectiveSyncApi.md#listsyncsfromwarehouse) | **GET** /warehouses/{warehouseId}/syncs | List Syncs from Warehouse |
| [**ListSyncsFromWarehouseAndSource**](SelectiveSyncApi.md#listsyncsfromwarehouseandsource) | **GET** /warehouses/{warehouseId}/connected-sources/{sourceId}/syncs | List Syncs from Warehouse And Source |
| [**ReplaceAdvancedSyncScheduleForWarehouse**](SelectiveSyncApi.md#replaceadvancedsyncscheduleforwarehouse) | **PUT** /warehouses/{warehouseId}/advanced-sync-schedule | Replace Advanced Sync Schedule for Warehouse |
| [**UpdateSelectiveSyncForWarehouse**](SelectiveSyncApi.md#updateselectivesyncforwarehouse) | **PATCH** /warehouses/{warehouseId}/selective-sync | Update Selective Sync for Warehouse |

<a id="getadvancedsyncschedulefromwarehouse"></a>
# **GetAdvancedSyncScheduleFromWarehouse**
> GetAdvancedSyncScheduleFromWarehouse200Response GetAdvancedSyncScheduleFromWarehouse (string warehouseId)

Get Advanced Sync Schedule from Warehouse

Returns the advanced sync schedule for a Warehouse.   The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetAdvancedSyncScheduleFromWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 

            try
            {
                // Get Advanced Sync Schedule from Warehouse
                GetAdvancedSyncScheduleFromWarehouse200Response result = apiInstance.GetAdvancedSyncScheduleFromWarehouse(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.GetAdvancedSyncScheduleFromWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedSyncScheduleFromWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Advanced Sync Schedule from Warehouse
    ApiResponse<GetAdvancedSyncScheduleFromWarehouse200Response> response = apiInstance.GetAdvancedSyncScheduleFromWarehouseWithHttpInfo(warehouseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.GetAdvancedSyncScheduleFromWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |

### Return type

[**GetAdvancedSyncScheduleFromWarehouse200Response**](GetAdvancedSyncScheduleFromWarehouse200Response.md)

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

<a id="listselectivesyncsfromwarehouseandsource"></a>
# **ListSelectiveSyncsFromWarehouseAndSource**
> ListSelectiveSyncsFromWarehouseAndSource200Response ListSelectiveSyncsFromWarehouseAndSource (string warehouseId, string sourceId, PaginationInput? pagination = null)

List Selective Syncs from Warehouse And Source

Returns the schema for a Warehouse, including Sources, Collections, and Properties.   The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSelectiveSyncsFromWarehouseAndSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Selective Syncs from Warehouse And Source
                ListSelectiveSyncsFromWarehouseAndSource200Response result = apiInstance.ListSelectiveSyncsFromWarehouseAndSource(warehouseId, sourceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.ListSelectiveSyncsFromWarehouseAndSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSelectiveSyncsFromWarehouseAndSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Selective Syncs from Warehouse And Source
    ApiResponse<ListSelectiveSyncsFromWarehouseAndSource200Response> response = apiInstance.ListSelectiveSyncsFromWarehouseAndSourceWithHttpInfo(warehouseId, sourceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.ListSelectiveSyncsFromWarehouseAndSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **sourceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListSelectiveSyncsFromWarehouseAndSource200Response**](ListSelectiveSyncsFromWarehouseAndSource200Response.md)

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

<a id="listsyncsfromwarehouse"></a>
# **ListSyncsFromWarehouse**
> ListSyncsFromWarehouse200Response ListSyncsFromWarehouse (string warehouseId, PaginationInput? pagination = null)

List Syncs from Warehouse

Returns the overview of syncs for every Source connected to a Warehouse.   The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSyncsFromWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Syncs from Warehouse
                ListSyncsFromWarehouse200Response result = apiInstance.ListSyncsFromWarehouse(warehouseId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.ListSyncsFromWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSyncsFromWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Syncs from Warehouse
    ApiResponse<ListSyncsFromWarehouse200Response> response = apiInstance.ListSyncsFromWarehouseWithHttpInfo(warehouseId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.ListSyncsFromWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListSyncsFromWarehouse200Response**](ListSyncsFromWarehouse200Response.md)

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

<a id="listsyncsfromwarehouseandsource"></a>
# **ListSyncsFromWarehouseAndSource**
> ListSyncsFromWarehouseAndSource200Response ListSyncsFromWarehouseAndSource (string warehouseId, string sourceId, PaginationInput? pagination = null)

List Syncs from Warehouse And Source

Returns the overview of syncs for a Source connected to a Warehouse.   The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSyncsFromWarehouseAndSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Syncs from Warehouse And Source
                ListSyncsFromWarehouseAndSource200Response result = apiInstance.ListSyncsFromWarehouseAndSource(warehouseId, sourceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.ListSyncsFromWarehouseAndSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSyncsFromWarehouseAndSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Syncs from Warehouse And Source
    ApiResponse<ListSyncsFromWarehouseAndSource200Response> response = apiInstance.ListSyncsFromWarehouseAndSourceWithHttpInfo(warehouseId, sourceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.ListSyncsFromWarehouseAndSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **sourceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListSyncsFromWarehouseAndSource200Response**](ListSyncsFromWarehouseAndSource200Response.md)

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

<a id="replaceadvancedsyncscheduleforwarehouse"></a>
# **ReplaceAdvancedSyncScheduleForWarehouse**
> ReplaceAdvancedSyncScheduleForWarehouse200Response ReplaceAdvancedSyncScheduleForWarehouse (string warehouseId, ReplaceAdvancedSyncScheduleForWarehouseV1Input replaceAdvancedSyncScheduleForWarehouseV1Input)

Replace Advanced Sync Schedule for Warehouse

Updates the advanced sync schedule for a Warehouse, replacing the sync schedule with a new schedule.   The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ReplaceAdvancedSyncScheduleForWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var replaceAdvancedSyncScheduleForWarehouseV1Input = new ReplaceAdvancedSyncScheduleForWarehouseV1Input(); // ReplaceAdvancedSyncScheduleForWarehouseV1Input | 

            try
            {
                // Replace Advanced Sync Schedule for Warehouse
                ReplaceAdvancedSyncScheduleForWarehouse200Response result = apiInstance.ReplaceAdvancedSyncScheduleForWarehouse(warehouseId, replaceAdvancedSyncScheduleForWarehouseV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.ReplaceAdvancedSyncScheduleForWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceAdvancedSyncScheduleForWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace Advanced Sync Schedule for Warehouse
    ApiResponse<ReplaceAdvancedSyncScheduleForWarehouse200Response> response = apiInstance.ReplaceAdvancedSyncScheduleForWarehouseWithHttpInfo(warehouseId, replaceAdvancedSyncScheduleForWarehouseV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.ReplaceAdvancedSyncScheduleForWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **replaceAdvancedSyncScheduleForWarehouseV1Input** | [**ReplaceAdvancedSyncScheduleForWarehouseV1Input**](ReplaceAdvancedSyncScheduleForWarehouseV1Input.md) |  |  |

### Return type

[**ReplaceAdvancedSyncScheduleForWarehouse200Response**](ReplaceAdvancedSyncScheduleForWarehouse200Response.md)

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

<a id="updateselectivesyncforwarehouse"></a>
# **UpdateSelectiveSyncForWarehouse**
> UpdateSelectiveSyncForWarehouse200Response UpdateSelectiveSyncForWarehouse (string warehouseId, UpdateSelectiveSyncForWarehouseV1Input updateSelectiveSyncForWarehouseV1Input)

Update Selective Sync for Warehouse

Configures the schema for a Warehouse, including Sources, Collections, and Properties.    • When called, this endpoint may generate the `Storage Destination Modified` event in the [audit trail](/tag/Audit-Trail).          The rate limit for this endpoint is 2 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateSelectiveSyncForWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SelectiveSyncApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var updateSelectiveSyncForWarehouseV1Input = new UpdateSelectiveSyncForWarehouseV1Input(); // UpdateSelectiveSyncForWarehouseV1Input | 

            try
            {
                // Update Selective Sync for Warehouse
                UpdateSelectiveSyncForWarehouse200Response result = apiInstance.UpdateSelectiveSyncForWarehouse(warehouseId, updateSelectiveSyncForWarehouseV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.UpdateSelectiveSyncForWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSelectiveSyncForWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Selective Sync for Warehouse
    ApiResponse<UpdateSelectiveSyncForWarehouse200Response> response = apiInstance.UpdateSelectiveSyncForWarehouseWithHttpInfo(warehouseId, updateSelectiveSyncForWarehouseV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SelectiveSyncApi.UpdateSelectiveSyncForWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **updateSelectiveSyncForWarehouseV1Input** | [**UpdateSelectiveSyncForWarehouseV1Input**](UpdateSelectiveSyncForWarehouseV1Input.md) |  |  |

### Return type

[**UpdateSelectiveSyncForWarehouse200Response**](UpdateSelectiveSyncForWarehouse200Response.md)

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

