# Segment.PublicApi.Api.WarehousesApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddConnectionFromSourceToWarehouse**](WarehousesApi.md#addconnectionfromsourcetowarehouse) | **POST** /warehouses/{warehouseId}/connected-sources/{sourceId} | Add Connection from Source to Warehouse |
| [**CreateValidationInWarehouse**](WarehousesApi.md#createvalidationinwarehouse) | **POST** /warehouses/validation | Create Validation in Warehouse |
| [**CreateWarehouse**](WarehousesApi.md#createwarehouse) | **POST** /warehouses | Create Warehouse |
| [**DeleteWarehouse**](WarehousesApi.md#deletewarehouse) | **DELETE** /warehouses/{warehouseId} | Delete Warehouse |
| [**GetConnectionStateFromWarehouse**](WarehousesApi.md#getconnectionstatefromwarehouse) | **GET** /warehouses/{warehouseId}/connection-state | Get Connection State from Warehouse |
| [**GetWarehouse**](WarehousesApi.md#getwarehouse) | **GET** /warehouses/{warehouseId} | Get Warehouse |
| [**ListConnectedSourcesFromWarehouse**](WarehousesApi.md#listconnectedsourcesfromwarehouse) | **GET** /warehouses/{warehouseId}/connected-sources | List Connected Sources from Warehouse |
| [**ListWarehouses**](WarehousesApi.md#listwarehouses) | **GET** /warehouses | List Warehouses |
| [**RemoveSourceConnectionFromWarehouse**](WarehousesApi.md#removesourceconnectionfromwarehouse) | **DELETE** /warehouses/{warehouseId}/connected-sources/{sourceId} | Remove Source Connection from Warehouse |
| [**UpdateWarehouse**](WarehousesApi.md#updatewarehouse) | **PATCH** /warehouses/{warehouseId} | Update Warehouse |

<a id="addconnectionfromsourcetowarehouse"></a>
# **AddConnectionFromSourceToWarehouse**
> AddConnectionFromSourceToWarehouse201Response AddConnectionFromSourceToWarehouse (string warehouseId, string sourceId)

Add Connection from Source to Warehouse

Connects a Source to a Warehouse.    • When called, this endpoint may generate the `Storage Destination Modified` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddConnectionFromSourceToWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 

            try
            {
                // Add Connection from Source to Warehouse
                AddConnectionFromSourceToWarehouse201Response result = apiInstance.AddConnectionFromSourceToWarehouse(warehouseId, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.AddConnectionFromSourceToWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddConnectionFromSourceToWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Connection from Source to Warehouse
    ApiResponse<AddConnectionFromSourceToWarehouse201Response> response = apiInstance.AddConnectionFromSourceToWarehouseWithHttpInfo(warehouseId, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.AddConnectionFromSourceToWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **sourceId** | **string** |  |  |

### Return type

[**AddConnectionFromSourceToWarehouse201Response**](AddConnectionFromSourceToWarehouse201Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createvalidationinwarehouse"></a>
# **CreateValidationInWarehouse**
> CreateValidationInWarehouse200Response CreateValidationInWarehouse (CreateValidationInWarehouseV1Input createValidationInWarehouseV1Input)

Create Validation in Warehouse

Validates input settings against a Warehouse.    • When called, this endpoint may generate the `Storage Destination Settings Validation` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateValidationInWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var createValidationInWarehouseV1Input = new CreateValidationInWarehouseV1Input(); // CreateValidationInWarehouseV1Input | 

            try
            {
                // Create Validation in Warehouse
                CreateValidationInWarehouse200Response result = apiInstance.CreateValidationInWarehouse(createValidationInWarehouseV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.CreateValidationInWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateValidationInWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Validation in Warehouse
    ApiResponse<CreateValidationInWarehouse200Response> response = apiInstance.CreateValidationInWarehouseWithHttpInfo(createValidationInWarehouseV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.CreateValidationInWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createValidationInWarehouseV1Input** | [**CreateValidationInWarehouseV1Input**](CreateValidationInWarehouseV1Input.md) |  |  |

### Return type

[**CreateValidationInWarehouse200Response**](CreateValidationInWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createwarehouse"></a>
# **CreateWarehouse**
> CreateWarehouse201Response CreateWarehouse (CreateWarehouseV1Input createWarehouseV1Input)

Create Warehouse

Creates a new Warehouse.    • When called, this endpoint may generate the `Storage Destination Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var createWarehouseV1Input = new CreateWarehouseV1Input(); // CreateWarehouseV1Input | 

            try
            {
                // Create Warehouse
                CreateWarehouse201Response result = apiInstance.CreateWarehouse(createWarehouseV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.CreateWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Warehouse
    ApiResponse<CreateWarehouse201Response> response = apiInstance.CreateWarehouseWithHttpInfo(createWarehouseV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.CreateWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWarehouseV1Input** | [**CreateWarehouseV1Input**](CreateWarehouseV1Input.md) |  |  |

### Return type

[**CreateWarehouse201Response**](CreateWarehouse201Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewarehouse"></a>
# **DeleteWarehouse**
> DeleteWarehouse200Response DeleteWarehouse (string warehouseId)

Delete Warehouse

Deletes an existing Warehouse.    • When called, this endpoint may generate the `Storage Destination Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = createdWarehouseId;  // string | 

            try
            {
                // Delete Warehouse
                DeleteWarehouse200Response result = apiInstance.DeleteWarehouse(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.DeleteWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Warehouse
    ApiResponse<DeleteWarehouse200Response> response = apiInstance.DeleteWarehouseWithHttpInfo(warehouseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.DeleteWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |

### Return type

[**DeleteWarehouse200Response**](DeleteWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconnectionstatefromwarehouse"></a>
# **GetConnectionStateFromWarehouse**
> GetConnectionStateFromWarehouse200Response GetConnectionStateFromWarehouse (string warehouseId)

Get Connection State from Warehouse

Verifies the state of Warehouse connection settings.   The rate limit for this endpoint is 200 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetConnectionStateFromWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 

            try
            {
                // Get Connection State from Warehouse
                GetConnectionStateFromWarehouse200Response result = apiInstance.GetConnectionStateFromWarehouse(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.GetConnectionStateFromWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectionStateFromWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Connection State from Warehouse
    ApiResponse<GetConnectionStateFromWarehouse200Response> response = apiInstance.GetConnectionStateFromWarehouseWithHttpInfo(warehouseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.GetConnectionStateFromWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |

### Return type

[**GetConnectionStateFromWarehouse200Response**](GetConnectionStateFromWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwarehouse"></a>
# **GetWarehouse**
> GetWarehouse200Response GetWarehouse (string warehouseId)

Get Warehouse

Returns a Warehouse by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 

            try
            {
                // Get Warehouse
                GetWarehouse200Response result = apiInstance.GetWarehouse(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.GetWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Warehouse
    ApiResponse<GetWarehouse200Response> response = apiInstance.GetWarehouseWithHttpInfo(warehouseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.GetWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |

### Return type

[**GetWarehouse200Response**](GetWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconnectedsourcesfromwarehouse"></a>
# **ListConnectedSourcesFromWarehouse**
> ListConnectedSourcesFromWarehouse200Response ListConnectedSourcesFromWarehouse (string warehouseId, PaginationInput? pagination = null)

List Connected Sources from Warehouse

Returns the list of Sources that are connected to a Warehouse.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListConnectedSourcesFromWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Connected Sources from Warehouse
                ListConnectedSourcesFromWarehouse200Response result = apiInstance.ListConnectedSourcesFromWarehouse(warehouseId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.ListConnectedSourcesFromWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConnectedSourcesFromWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Connected Sources from Warehouse
    ApiResponse<ListConnectedSourcesFromWarehouse200Response> response = apiInstance.ListConnectedSourcesFromWarehouseWithHttpInfo(warehouseId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.ListConnectedSourcesFromWarehouseWithHttpInfo: " + e.Message);
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

[**ListConnectedSourcesFromWarehouse200Response**](ListConnectedSourcesFromWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listwarehouses"></a>
# **ListWarehouses**
> ListWarehouses200Response ListWarehouses (PaginationInput? pagination = null)

List Warehouses

Returns a list of Warehouses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListWarehousesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v2. (optional) 

            try
            {
                // List Warehouses
                ListWarehouses200Response result = apiInstance.ListWarehouses(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.ListWarehouses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWarehousesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Warehouses
    ApiResponse<ListWarehouses200Response> response = apiInstance.ListWarehousesWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.ListWarehousesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v2. | [optional]  |

### Return type

[**ListWarehouses200Response**](ListWarehouses200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removesourceconnectionfromwarehouse"></a>
# **RemoveSourceConnectionFromWarehouse**
> RemoveSourceConnectionFromWarehouse200Response RemoveSourceConnectionFromWarehouse (string warehouseId, string sourceId)

Remove Source Connection from Warehouse

Disconnects a Source from a Warehouse.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveSourceConnectionFromWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 

            try
            {
                // Remove Source Connection from Warehouse
                RemoveSourceConnectionFromWarehouse200Response result = apiInstance.RemoveSourceConnectionFromWarehouse(warehouseId, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.RemoveSourceConnectionFromWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSourceConnectionFromWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Source Connection from Warehouse
    ApiResponse<RemoveSourceConnectionFromWarehouse200Response> response = apiInstance.RemoveSourceConnectionFromWarehouseWithHttpInfo(warehouseId, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.RemoveSourceConnectionFromWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **sourceId** | **string** |  |  |

### Return type

[**RemoveSourceConnectionFromWarehouse200Response**](RemoveSourceConnectionFromWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewarehouse"></a>
# **UpdateWarehouse**
> UpdateWarehouse200Response UpdateWarehouse (string warehouseId, UpdateWarehouseV1Input updateWarehouseV1Input)

Update Warehouse

Updates an existing Warehouse.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Storage Destination Modified * Storage Destination Enabled       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WarehousesApi(config);
            var warehouseId = kjU72LCJexvrqL7G4TMHHN;  // string | 
            var updateWarehouseV1Input = new UpdateWarehouseV1Input(); // UpdateWarehouseV1Input | 

            try
            {
                // Update Warehouse
                UpdateWarehouse200Response result = apiInstance.UpdateWarehouse(warehouseId, updateWarehouseV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehousesApi.UpdateWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Warehouse
    ApiResponse<UpdateWarehouse200Response> response = apiInstance.UpdateWarehouseWithHttpInfo(warehouseId, updateWarehouseV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehousesApi.UpdateWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **string** |  |  |
| **updateWarehouseV1Input** | [**UpdateWarehouseV1Input**](UpdateWarehouseV1Input.md) |  |  |

### Return type

[**UpdateWarehouse200Response**](UpdateWarehouse200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json, application/vnd.segment.v2+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

