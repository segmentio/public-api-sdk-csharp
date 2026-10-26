# Segment.PublicApi.Api.SourcesApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLabelsToSource**](SourcesApi.md#addlabelstosource) | **POST** /sources/{sourceId}/labels | Add Labels to Source |
| [**CreateSource**](SourcesApi.md#createsource) | **POST** /sources | Create Source |
| [**CreateWriteKeyForSource**](SourcesApi.md#createwritekeyforsource) | **POST** /sources/{sourceId}/writekey | Create Write Key for Source |
| [**DeleteSource**](SourcesApi.md#deletesource) | **DELETE** /sources/{sourceId} | Delete Source |
| [**GetSource**](SourcesApi.md#getsource) | **GET** /sources/{sourceId} | Get Source |
| [**ListConnectedDestinationsFromSource**](SourcesApi.md#listconnecteddestinationsfromsource) | **GET** /sources/{sourceId}/connected-destinations | List Connected Destinations from Source |
| [**ListConnectedWarehousesFromSource**](SourcesApi.md#listconnectedwarehousesfromsource) | **GET** /sources/{sourceId}/connected-warehouses | List Connected Warehouses from Source |
| [**ListSchemaSettingsInSource**](SourcesApi.md#listschemasettingsinsource) | **GET** /sources/{sourceId}/settings | List Schema Settings in Source |
| [**ListSources**](SourcesApi.md#listsources) | **GET** /sources | List Sources |
| [**RemoveWriteKeyFromSource**](SourcesApi.md#removewritekeyfromsource) | **DELETE** /sources/{sourceId}/writekey/{writeKey} | Remove Write Key from Source |
| [**ReplaceLabelsInSource**](SourcesApi.md#replacelabelsinsource) | **PUT** /sources/{sourceId}/labels | Replace Labels in Source |
| [**UpdateSchemaSettingsInSource**](SourcesApi.md#updateschemasettingsinsource) | **PATCH** /sources/{sourceId}/settings | Update Schema Settings in Source |
| [**UpdateSource**](SourcesApi.md#updatesource) | **PATCH** /sources/{sourceId} | Update Source |

<a id="addlabelstosource"></a>
# **AddLabelsToSource**
> AddLabelsToSource200Response AddLabelsToSource (string sourceId, AddLabelsToSourceV1Input addLabelsToSourceV1Input)

Add Labels to Source

Adds an existing label to a Source.    • When called, this endpoint may generate the `Source Modified` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddLabelsToSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 
            var addLabelsToSourceV1Input = new AddLabelsToSourceV1Input(); // AddLabelsToSourceV1Input | 

            try
            {
                // Add Labels to Source
                AddLabelsToSource200Response result = apiInstance.AddLabelsToSource(sourceId, addLabelsToSourceV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.AddLabelsToSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLabelsToSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Labels to Source
    ApiResponse<AddLabelsToSource200Response> response = apiInstance.AddLabelsToSourceWithHttpInfo(sourceId, addLabelsToSourceV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.AddLabelsToSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **addLabelsToSourceV1Input** | [**AddLabelsToSourceV1Input**](AddLabelsToSourceV1Input.md) |  |  |

### Return type

[**AddLabelsToSource200Response**](AddLabelsToSource200Response.md)

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

<a id="createsource"></a>
# **CreateSource**
> CreateSource201Response CreateSource (CreateSourceV1Input createSourceV1Input)

Create Source

Creates a new Source.    • When called, this endpoint may generate the `Source Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var createSourceV1Input = new CreateSourceV1Input(); // CreateSourceV1Input | 

            try
            {
                // Create Source
                CreateSource201Response result = apiInstance.CreateSource(createSourceV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.CreateSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Source
    ApiResponse<CreateSource201Response> response = apiInstance.CreateSourceWithHttpInfo(createSourceV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.CreateSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSourceV1Input** | [**CreateSourceV1Input**](CreateSourceV1Input.md) |  |  |

### Return type

[**CreateSource201Response**](CreateSource201Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createwritekeyforsource"></a>
# **CreateWriteKeyForSource**
> CreateWriteKeyForSource200Response CreateWriteKeyForSource (string sourceId)

Create Write Key for Source

Creates a new Write Key for the Source.    • When called, this endpoint may generate the `Source Modified` event in the [audit trail](/tag/Audit-Trail). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateWriteKeyForSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = idR4zzU9iGcGJgoAX891nf;  // string | 

            try
            {
                // Create Write Key for Source
                CreateWriteKeyForSource200Response result = apiInstance.CreateWriteKeyForSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.CreateWriteKeyForSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWriteKeyForSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Write Key for Source
    ApiResponse<CreateWriteKeyForSource200Response> response = apiInstance.CreateWriteKeyForSourceWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.CreateWriteKeyForSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**CreateWriteKeyForSource200Response**](CreateWriteKeyForSource200Response.md)

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

<a id="deletesource"></a>
# **DeleteSource**
> DeleteSource200Response DeleteSource (string sourceId)

Delete Source

Deletes an existing Source.    • When called, this endpoint may generate the `Source Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = rYxTjyaPtAELCjnFE5EYfM;  // string | 

            try
            {
                // Delete Source
                DeleteSource200Response result = apiInstance.DeleteSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.DeleteSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Source
    ApiResponse<DeleteSource200Response> response = apiInstance.DeleteSourceWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.DeleteSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**DeleteSource200Response**](DeleteSource200Response.md)

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

<a id="getsource"></a>
# **GetSource**
> GetSource200Response GetSource (string sourceId)

Get Source

Returns a Source by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 

            try
            {
                // Get Source
                GetSource200Response result = apiInstance.GetSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.GetSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Source
    ApiResponse<GetSource200Response> response = apiInstance.GetSourceWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.GetSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**GetSource200Response**](GetSource200Response.md)

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

<a id="listconnecteddestinationsfromsource"></a>
# **ListConnectedDestinationsFromSource**
> ListConnectedDestinationsFromSource200Response ListConnectedDestinationsFromSource (string sourceId, PaginationInput? pagination = null)

List Connected Destinations from Source

Returns a list of Destinations connected to a Source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListConnectedDestinationsFromSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Required pagination params for the request.  This parameter exists in alpha. (optional) 

            try
            {
                // List Connected Destinations from Source
                ListConnectedDestinationsFromSource200Response result = apiInstance.ListConnectedDestinationsFromSource(sourceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.ListConnectedDestinationsFromSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConnectedDestinationsFromSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Connected Destinations from Source
    ApiResponse<ListConnectedDestinationsFromSource200Response> response = apiInstance.ListConnectedDestinationsFromSourceWithHttpInfo(sourceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.ListConnectedDestinationsFromSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Required pagination params for the request.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListConnectedDestinationsFromSource200Response**](ListConnectedDestinationsFromSource200Response.md)

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

<a id="listconnectedwarehousesfromsource"></a>
# **ListConnectedWarehousesFromSource**
> ListConnectedWarehousesFromSource200Response ListConnectedWarehousesFromSource (string sourceId, PaginationInput? pagination = null)

List Connected Warehouses from Source

Returns a list of Warehouses connected to a Source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListConnectedWarehousesFromSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Required pagination params for the request.  This parameter exists in alpha. (optional) 

            try
            {
                // List Connected Warehouses from Source
                ListConnectedWarehousesFromSource200Response result = apiInstance.ListConnectedWarehousesFromSource(sourceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.ListConnectedWarehousesFromSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConnectedWarehousesFromSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Connected Warehouses from Source
    ApiResponse<ListConnectedWarehousesFromSource200Response> response = apiInstance.ListConnectedWarehousesFromSourceWithHttpInfo(sourceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.ListConnectedWarehousesFromSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Required pagination params for the request.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListConnectedWarehousesFromSource200Response**](ListConnectedWarehousesFromSource200Response.md)

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

<a id="listschemasettingsinsource"></a>
# **ListSchemaSettingsInSource**
> ListSchemaSettingsInSource200Response ListSchemaSettingsInSource (string sourceId)

List Schema Settings in Source

Retrieves the schema configuration settings for a Source. If Protocols is not enabled for the Source, the configurations specific to Protocols will have default values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSchemaSettingsInSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 

            try
            {
                // List Schema Settings in Source
                ListSchemaSettingsInSource200Response result = apiInstance.ListSchemaSettingsInSource(sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.ListSchemaSettingsInSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSchemaSettingsInSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Schema Settings in Source
    ApiResponse<ListSchemaSettingsInSource200Response> response = apiInstance.ListSchemaSettingsInSourceWithHttpInfo(sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.ListSchemaSettingsInSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |

### Return type

[**ListSchemaSettingsInSource200Response**](ListSchemaSettingsInSource200Response.md)

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

<a id="listsources"></a>
# **ListSources**
> ListSources200Response ListSources (PaginationInput? pagination = null)

List Sources

Returns a list of Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Sources
                ListSources200Response result = apiInstance.ListSources(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.ListSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sources
    ApiResponse<ListSources200Response> response = apiInstance.ListSourcesWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.ListSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListSources200Response**](ListSources200Response.md)

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

<a id="removewritekeyfromsource"></a>
# **RemoveWriteKeyFromSource**
> RemoveWriteKeyFromSource200Response RemoveWriteKeyFromSource (string sourceId, string writeKey)

Remove Write Key from Source

Removes a Write Key from a Source.    • When called, this endpoint may generate the `Source Modified` event in the [audit trail](/tag/Audit-Trail). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveWriteKeyFromSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = idR4zzU9iGcGJgoAX891nf;  // string | 
            var writeKey = wk123;  // string | 

            try
            {
                // Remove Write Key from Source
                RemoveWriteKeyFromSource200Response result = apiInstance.RemoveWriteKeyFromSource(sourceId, writeKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.RemoveWriteKeyFromSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveWriteKeyFromSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Write Key from Source
    ApiResponse<RemoveWriteKeyFromSource200Response> response = apiInstance.RemoveWriteKeyFromSourceWithHttpInfo(sourceId, writeKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.RemoveWriteKeyFromSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **writeKey** | **string** |  |  |

### Return type

[**RemoveWriteKeyFromSource200Response**](RemoveWriteKeyFromSource200Response.md)

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

<a id="replacelabelsinsource"></a>
# **ReplaceLabelsInSource**
> ReplaceLabelsInSource200Response ReplaceLabelsInSource (string sourceId, ReplaceLabelsInSourceV1Input replaceLabelsInSourceV1Input)

Replace Labels in Source

Replaces all labels in a Source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ReplaceLabelsInSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = rh5BDZp6QDHvXFCkibm1pR;  // string | 
            var replaceLabelsInSourceV1Input = new ReplaceLabelsInSourceV1Input(); // ReplaceLabelsInSourceV1Input | 

            try
            {
                // Replace Labels in Source
                ReplaceLabelsInSource200Response result = apiInstance.ReplaceLabelsInSource(sourceId, replaceLabelsInSourceV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.ReplaceLabelsInSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceLabelsInSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace Labels in Source
    ApiResponse<ReplaceLabelsInSource200Response> response = apiInstance.ReplaceLabelsInSourceWithHttpInfo(sourceId, replaceLabelsInSourceV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.ReplaceLabelsInSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **replaceLabelsInSourceV1Input** | [**ReplaceLabelsInSourceV1Input**](ReplaceLabelsInSourceV1Input.md) |  |  |

### Return type

[**ReplaceLabelsInSource200Response**](ReplaceLabelsInSource200Response.md)

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

<a id="updateschemasettingsinsource"></a>
# **UpdateSchemaSettingsInSource**
> UpdateSchemaSettingsInSource200Response UpdateSchemaSettingsInSource (string sourceId, UpdateSchemaSettingsInSourceV1Input updateSchemaSettingsInSourceV1Input)

Update Schema Settings in Source

Updates the schema configuration for a Source. If Protocols is not enabled for the Source, any updates to Protocols-specific configurations will not be applied.        Config API omitted fields: - `updateMask`       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateSchemaSettingsInSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var updateSchemaSettingsInSourceV1Input = new UpdateSchemaSettingsInSourceV1Input(); // UpdateSchemaSettingsInSourceV1Input | 

            try
            {
                // Update Schema Settings in Source
                UpdateSchemaSettingsInSource200Response result = apiInstance.UpdateSchemaSettingsInSource(sourceId, updateSchemaSettingsInSourceV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.UpdateSchemaSettingsInSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSchemaSettingsInSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Schema Settings in Source
    ApiResponse<UpdateSchemaSettingsInSource200Response> response = apiInstance.UpdateSchemaSettingsInSourceWithHttpInfo(sourceId, updateSchemaSettingsInSourceV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.UpdateSchemaSettingsInSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **updateSchemaSettingsInSourceV1Input** | [**UpdateSchemaSettingsInSourceV1Input**](UpdateSchemaSettingsInSourceV1Input.md) |  |  |

### Return type

[**UpdateSchemaSettingsInSource200Response**](UpdateSchemaSettingsInSource200Response.md)

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

<a id="updatesource"></a>
# **UpdateSource**
> UpdateSource200Response UpdateSource (string sourceId, UpdateSourceV1Input updateSourceV1Input)

Update Source

Updates an existing Source.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Source Modified * Source Enabled * Source Settings Modified * Source Disabled  Config API omitted fields: - `updateMask` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SourcesApi(config);
            var sourceId = 44LMHs8Wf5vidxba4kN52J;  // string | 
            var updateSourceV1Input = new UpdateSourceV1Input(); // UpdateSourceV1Input | 

            try
            {
                // Update Source
                UpdateSource200Response result = apiInstance.UpdateSource(sourceId, updateSourceV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SourcesApi.UpdateSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Source
    ApiResponse<UpdateSource200Response> response = apiInstance.UpdateSourceWithHttpInfo(sourceId, updateSourceV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SourcesApi.UpdateSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **updateSourceV1Input** | [**UpdateSourceV1Input**](UpdateSourceV1Input.md) |  |  |

### Return type

[**UpdateSource200Response**](UpdateSource200Response.md)

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

