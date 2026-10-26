# Segment.PublicApi.Api.ProfilesSyncApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProfilesWarehouse**](ProfilesSyncApi.md#createprofileswarehouse) | **POST** /spaces/{spaceId}/profiles-warehouses | Create Profiles Warehouse |
| [**ListProfilesWarehouseInSpace**](ProfilesSyncApi.md#listprofileswarehouseinspace) | **GET** /spaces/{spaceId}/profiles-warehouses | List Profiles Warehouse in Space |
| [**ListSelectiveSyncsFromWarehouseAndSpace**](ProfilesSyncApi.md#listselectivesyncsfromwarehouseandspace) | **GET** /spaces/{spaceId}/profiles-warehouses/{warehouseId}/selective-syncs | List Selective Syncs from Warehouse And Space |
| [**RemoveProfilesWarehouseFromSpace**](ProfilesSyncApi.md#removeprofileswarehousefromspace) | **DELETE** /spaces/{spaceId}/profiles-warehouses/{warehouseId} | Remove Profiles Warehouse from Space |
| [**UpdateProfilesWarehouseForSpaceWarehouse**](ProfilesSyncApi.md#updateprofileswarehouseforspacewarehouse) | **PATCH** /spaces/{spaceId}/profiles-warehouses/{warehouseId} | Update Profiles Warehouse for Space Warehouse |
| [**UpdateSelectiveSyncForWarehouseAndSpace**](ProfilesSyncApi.md#updateselectivesyncforwarehouseandspace) | **PATCH** /spaces/{spaceId}/profiles-warehouses/{warehouseId}/selective-syncs | Update Selective Sync for Warehouse And Space |

<a id="createprofileswarehouse"></a>
# **CreateProfilesWarehouse**
> CreateProfilesWarehouse201Response CreateProfilesWarehouse (string spaceId, CreateProfilesWarehouseAlphaInput createProfilesWarehouseAlphaInput)

Create Profiles Warehouse

Creates a new Profiles Warehouse.    • When called, this endpoint may generate the `Profiles Sync Warehouse Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateProfilesWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var createProfilesWarehouseAlphaInput = new CreateProfilesWarehouseAlphaInput(); // CreateProfilesWarehouseAlphaInput | 

            try
            {
                // Create Profiles Warehouse
                CreateProfilesWarehouse201Response result = apiInstance.CreateProfilesWarehouse(spaceId, createProfilesWarehouseAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.CreateProfilesWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProfilesWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Profiles Warehouse
    ApiResponse<CreateProfilesWarehouse201Response> response = apiInstance.CreateProfilesWarehouseWithHttpInfo(spaceId, createProfilesWarehouseAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.CreateProfilesWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **createProfilesWarehouseAlphaInput** | [**CreateProfilesWarehouseAlphaInput**](CreateProfilesWarehouseAlphaInput.md) |  |  |

### Return type

[**CreateProfilesWarehouse201Response**](CreateProfilesWarehouse201Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1alpha+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprofileswarehouseinspace"></a>
# **ListProfilesWarehouseInSpace**
> ListProfilesWarehouseInSpace200Response ListProfilesWarehouseInSpace (string spaceId, PaginationInput? pagination = null)

List Profiles Warehouse in Space

Lists all Profile Warehouses for a given space id.    • When called, this endpoint may generate the `Profiles Sync Warehouse Retrieved` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListProfilesWarehouseInSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Profiles Warehouse in Space
                ListProfilesWarehouseInSpace200Response result = apiInstance.ListProfilesWarehouseInSpace(spaceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.ListProfilesWarehouseInSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProfilesWarehouseInSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Profiles Warehouse in Space
    ApiResponse<ListProfilesWarehouseInSpace200Response> response = apiInstance.ListProfilesWarehouseInSpaceWithHttpInfo(spaceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.ListProfilesWarehouseInSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListProfilesWarehouseInSpace200Response**](ListProfilesWarehouseInSpace200Response.md)

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

<a id="listselectivesyncsfromwarehouseandspace"></a>
# **ListSelectiveSyncsFromWarehouseAndSpace**
> ListSelectiveSyncsFromWarehouseAndSpace200Response ListSelectiveSyncsFromWarehouseAndSpace (string spaceId, string warehouseId, PaginationInput? pagination = null)

List Selective Syncs from Warehouse And Space

Returns the schema for a Space Warehouse connection, including Collections and Properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSelectiveSyncsFromWarehouseAndSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var warehouseId = fQyLbqjfwaqg9mr3hDQ7We;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Selective Syncs from Warehouse And Space
                ListSelectiveSyncsFromWarehouseAndSpace200Response result = apiInstance.ListSelectiveSyncsFromWarehouseAndSpace(spaceId, warehouseId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.ListSelectiveSyncsFromWarehouseAndSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSelectiveSyncsFromWarehouseAndSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Selective Syncs from Warehouse And Space
    ApiResponse<ListSelectiveSyncsFromWarehouseAndSpace200Response> response = apiInstance.ListSelectiveSyncsFromWarehouseAndSpaceWithHttpInfo(spaceId, warehouseId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.ListSelectiveSyncsFromWarehouseAndSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **warehouseId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListSelectiveSyncsFromWarehouseAndSpace200Response**](ListSelectiveSyncsFromWarehouseAndSpace200Response.md)

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

<a id="removeprofileswarehousefromspace"></a>
# **RemoveProfilesWarehouseFromSpace**
> RemoveProfilesWarehouseFromSpace200Response RemoveProfilesWarehouseFromSpace (string spaceId, string warehouseId)

Remove Profiles Warehouse from Space

Deletes an existing Profiles Warehouse.    • When called, this endpoint may generate the `Profiles Sync Warehouse Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveProfilesWarehouseFromSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var warehouseId = qABd3NVTPfTLQ3kXWoBhgi;  // string | 

            try
            {
                // Remove Profiles Warehouse from Space
                RemoveProfilesWarehouseFromSpace200Response result = apiInstance.RemoveProfilesWarehouseFromSpace(spaceId, warehouseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.RemoveProfilesWarehouseFromSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveProfilesWarehouseFromSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Profiles Warehouse from Space
    ApiResponse<RemoveProfilesWarehouseFromSpace200Response> response = apiInstance.RemoveProfilesWarehouseFromSpaceWithHttpInfo(spaceId, warehouseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.RemoveProfilesWarehouseFromSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **warehouseId** | **string** |  |  |

### Return type

[**RemoveProfilesWarehouseFromSpace200Response**](RemoveProfilesWarehouseFromSpace200Response.md)

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

<a id="updateprofileswarehouseforspacewarehouse"></a>
# **UpdateProfilesWarehouseForSpaceWarehouse**
> UpdateProfilesWarehouseForSpaceWarehouse200Response UpdateProfilesWarehouseForSpaceWarehouse (string spaceId, string warehouseId, UpdateProfilesWarehouseForSpaceWarehouseAlphaInput updateProfilesWarehouseForSpaceWarehouseAlphaInput)

Update Profiles Warehouse for Space Warehouse

Updates an existing Profiles Warehouse.    • When called, this endpoint may generate the `Profiles Sync Warehouse Updated` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateProfilesWarehouseForSpaceWarehouseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var warehouseId = 3eadBBqVMQD2DEtaWXSkqA;  // string | 
            var updateProfilesWarehouseForSpaceWarehouseAlphaInput = new UpdateProfilesWarehouseForSpaceWarehouseAlphaInput(); // UpdateProfilesWarehouseForSpaceWarehouseAlphaInput | 

            try
            {
                // Update Profiles Warehouse for Space Warehouse
                UpdateProfilesWarehouseForSpaceWarehouse200Response result = apiInstance.UpdateProfilesWarehouseForSpaceWarehouse(spaceId, warehouseId, updateProfilesWarehouseForSpaceWarehouseAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.UpdateProfilesWarehouseForSpaceWarehouse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProfilesWarehouseForSpaceWarehouseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Profiles Warehouse for Space Warehouse
    ApiResponse<UpdateProfilesWarehouseForSpaceWarehouse200Response> response = apiInstance.UpdateProfilesWarehouseForSpaceWarehouseWithHttpInfo(spaceId, warehouseId, updateProfilesWarehouseForSpaceWarehouseAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.UpdateProfilesWarehouseForSpaceWarehouseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **warehouseId** | **string** |  |  |
| **updateProfilesWarehouseForSpaceWarehouseAlphaInput** | [**UpdateProfilesWarehouseForSpaceWarehouseAlphaInput**](UpdateProfilesWarehouseForSpaceWarehouseAlphaInput.md) |  |  |

### Return type

[**UpdateProfilesWarehouseForSpaceWarehouse200Response**](UpdateProfilesWarehouseForSpaceWarehouse200Response.md)

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

<a id="updateselectivesyncforwarehouseandspace"></a>
# **UpdateSelectiveSyncForWarehouseAndSpace**
> UpdateSelectiveSyncForWarehouseAndSpace200Response UpdateSelectiveSyncForWarehouseAndSpace (string spaceId, string warehouseId, UpdateSelectiveSyncForWarehouseAndSpaceAlphaInput updateSelectiveSyncForWarehouseAndSpaceAlphaInput)

Update Selective Sync for Warehouse And Space

Updates the schema for a Space Warehouse connection, including Collections and Properties.    • When called, this endpoint may generate the `Profiles Sync Warehouse Modified` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateSelectiveSyncForWarehouseAndSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProfilesSyncApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var warehouseId = qABd3NVTPfTLQ3kXWoBhgi;  // string | 
            var updateSelectiveSyncForWarehouseAndSpaceAlphaInput = new UpdateSelectiveSyncForWarehouseAndSpaceAlphaInput(); // UpdateSelectiveSyncForWarehouseAndSpaceAlphaInput | 

            try
            {
                // Update Selective Sync for Warehouse And Space
                UpdateSelectiveSyncForWarehouseAndSpace200Response result = apiInstance.UpdateSelectiveSyncForWarehouseAndSpace(spaceId, warehouseId, updateSelectiveSyncForWarehouseAndSpaceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesSyncApi.UpdateSelectiveSyncForWarehouseAndSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSelectiveSyncForWarehouseAndSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Selective Sync for Warehouse And Space
    ApiResponse<UpdateSelectiveSyncForWarehouseAndSpace200Response> response = apiInstance.UpdateSelectiveSyncForWarehouseAndSpaceWithHttpInfo(spaceId, warehouseId, updateSelectiveSyncForWarehouseAndSpaceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesSyncApi.UpdateSelectiveSyncForWarehouseAndSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **warehouseId** | **string** |  |  |
| **updateSelectiveSyncForWarehouseAndSpaceAlphaInput** | [**UpdateSelectiveSyncForWarehouseAndSpaceAlphaInput**](UpdateSelectiveSyncForWarehouseAndSpaceAlphaInput.md) |  |  |

### Return type

[**UpdateSelectiveSyncForWarehouseAndSpace200Response**](UpdateSelectiveSyncForWarehouseAndSpace200Response.md)

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

