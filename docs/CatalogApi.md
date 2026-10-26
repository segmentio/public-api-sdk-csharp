# Segment.PublicApi.Api.CatalogApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDestinationMetadata**](CatalogApi.md#getdestinationmetadata) | **GET** /catalog/destinations/{destinationMetadataId} | Get Destination Metadata |
| [**GetDestinationsCatalog**](CatalogApi.md#getdestinationscatalog) | **GET** /catalog/destinations | Get Destinations Catalog |
| [**GetSourceMetadata**](CatalogApi.md#getsourcemetadata) | **GET** /catalog/sources/{sourceMetadataId} | Get Source Metadata |
| [**GetSourcesCatalog**](CatalogApi.md#getsourcescatalog) | **GET** /catalog/sources | Get Sources Catalog |
| [**GetWarehouseMetadata**](CatalogApi.md#getwarehousemetadata) | **GET** /catalog/warehouses/{warehouseMetadataId} | Get Warehouse Metadata |
| [**GetWarehousesCatalog**](CatalogApi.md#getwarehousescatalog) | **GET** /catalog/warehouses | Get Warehouses Catalog |

<a id="getdestinationmetadata"></a>
# **GetDestinationMetadata**
> GetDestinationMetadata200Response GetDestinationMetadata (string destinationMetadataId)

Get Destination Metadata

Returns a Destination catalog item by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDestinationMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var destinationMetadataId = 54521fd525e721e32a72ee91;  // string | 

            try
            {
                // Get Destination Metadata
                GetDestinationMetadata200Response result = apiInstance.GetDestinationMetadata(destinationMetadataId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetDestinationMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDestinationMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Destination Metadata
    ApiResponse<GetDestinationMetadata200Response> response = apiInstance.GetDestinationMetadataWithHttpInfo(destinationMetadataId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetDestinationMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinationMetadataId** | **string** |  |  |

### Return type

[**GetDestinationMetadata200Response**](GetDestinationMetadata200Response.md)

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

<a id="getdestinationscatalog"></a>
# **GetDestinationsCatalog**
> GetDestinationsCatalog200Response GetDestinationsCatalog (PaginationInput? pagination = null)

Get Destinations Catalog

Returns a list of all available Destinations in the Segment catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetDestinationsCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Required pagination parameters used to filter the Destinations catalog.  This parameter exists in v1. (optional) 

            try
            {
                // Get Destinations Catalog
                GetDestinationsCatalog200Response result = apiInstance.GetDestinationsCatalog(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetDestinationsCatalog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDestinationsCatalogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Destinations Catalog
    ApiResponse<GetDestinationsCatalog200Response> response = apiInstance.GetDestinationsCatalogWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetDestinationsCatalogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Required pagination parameters used to filter the Destinations catalog.  This parameter exists in v1. | [optional]  |

### Return type

[**GetDestinationsCatalog200Response**](GetDestinationsCatalog200Response.md)

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

<a id="getsourcemetadata"></a>
# **GetSourceMetadata**
> GetSourceMetadata200Response GetSourceMetadata (string sourceMetadataId)

Get Source Metadata

Returns a Source catalog item by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetSourceMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var sourceMetadataId = 1bow82lmk;  // string | 

            try
            {
                // Get Source Metadata
                GetSourceMetadata200Response result = apiInstance.GetSourceMetadata(sourceMetadataId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetSourceMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSourceMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Source Metadata
    ApiResponse<GetSourceMetadata200Response> response = apiInstance.GetSourceMetadataWithHttpInfo(sourceMetadataId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetSourceMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceMetadataId** | **string** |  |  |

### Return type

[**GetSourceMetadata200Response**](GetSourceMetadata200Response.md)

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

<a id="getsourcescatalog"></a>
# **GetSourcesCatalog**
> GetSourcesCatalog200Response GetSourcesCatalog (PaginationInput? pagination = null)

Get Sources Catalog

Returns a list of all available Sources in the Segment catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetSourcesCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // Get Sources Catalog
                GetSourcesCatalog200Response result = apiInstance.GetSourcesCatalog(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetSourcesCatalog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSourcesCatalogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Sources Catalog
    ApiResponse<GetSourcesCatalog200Response> response = apiInstance.GetSourcesCatalogWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetSourcesCatalogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**GetSourcesCatalog200Response**](GetSourcesCatalog200Response.md)

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

<a id="getwarehousemetadata"></a>
# **GetWarehouseMetadata**
> GetWarehouseMetadata200Response GetWarehouseMetadata (string warehouseMetadataId)

Get Warehouse Metadata

Returns a Warehouse catalog item by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetWarehouseMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var warehouseMetadataId = 55d3d3aea3c;  // string | 

            try
            {
                // Get Warehouse Metadata
                GetWarehouseMetadata200Response result = apiInstance.GetWarehouseMetadata(warehouseMetadataId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetWarehouseMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWarehouseMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Warehouse Metadata
    ApiResponse<GetWarehouseMetadata200Response> response = apiInstance.GetWarehouseMetadataWithHttpInfo(warehouseMetadataId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetWarehouseMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseMetadataId** | **string** |  |  |

### Return type

[**GetWarehouseMetadata200Response**](GetWarehouseMetadata200Response.md)

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

<a id="getwarehousescatalog"></a>
# **GetWarehousesCatalog**
> GetWarehousesCatalog200Response GetWarehousesCatalog (PaginationInput? pagination = null)

Get Warehouses Catalog

Returns a list of all available Warehouses in the Segment catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetWarehousesCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CatalogApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Optional pagination params used to filter the Warehouses catalog.  This parameter exists in v1. (optional) 

            try
            {
                // Get Warehouses Catalog
                GetWarehousesCatalog200Response result = apiInstance.GetWarehousesCatalog(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.GetWarehousesCatalog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWarehousesCatalogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Warehouses Catalog
    ApiResponse<GetWarehousesCatalog200Response> response = apiInstance.GetWarehousesCatalogWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.GetWarehousesCatalogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional pagination params used to filter the Warehouses catalog.  This parameter exists in v1. | [optional]  |

### Return type

[**GetWarehousesCatalog200Response**](GetWarehousesCatalog200Response.md)

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

