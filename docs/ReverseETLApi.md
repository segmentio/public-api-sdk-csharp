# Segment.PublicApi.Api.ReverseETLApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelReverseETLSyncForModel**](ReverseETLApi.md#cancelreverseetlsyncformodel) | **POST** /reverse-etl-models/{modelId}/syncs/{syncId}/cancel | Cancel Reverse ETL Sync for Model |
| [**CreateReverseETLManualSync**](ReverseETLApi.md#createreverseetlmanualsync) | **POST** /reverse-etl-syncs | Create Reverse ETL Manual Sync |
| [**CreateReverseEtlModel**](ReverseETLApi.md#createreverseetlmodel) | **POST** /reverse-etl-models | Create Reverse Etl Model |
| [**DeleteReverseEtlModel**](ReverseETLApi.md#deletereverseetlmodel) | **DELETE** /reverse-etl-models/{modelId} | Delete Reverse Etl Model |
| [**GetReverseETLSyncStatus**](ReverseETLApi.md#getreverseetlsyncstatus) | **GET** /reverse-etl-models/{modelId}/syncs/{syncId} | Get Reverse ETL Sync Status |
| [**GetReverseEtlModel**](ReverseETLApi.md#getreverseetlmodel) | **GET** /reverse-etl-models/{modelId} | Get Reverse Etl Model |
| [**ListReverseETLSyncStatusesFromModelAndSubscriptionId**](ReverseETLApi.md#listreverseetlsyncstatusesfrommodelandsubscriptionid) | **GET** /reverse-etl-models/{modelId}/subscriptionId/{subscriptionId}/syncs | List Reverse ETL Sync Statuses from Model And Subscription Id |
| [**ListReverseEtlModels**](ReverseETLApi.md#listreverseetlmodels) | **GET** /reverse-etl-models | List Reverse Etl Models |
| [**UpdateReverseEtlModel**](ReverseETLApi.md#updatereverseetlmodel) | **PATCH** /reverse-etl-models/{modelId} | Update Reverse Etl Model |

<a id="cancelreverseetlsyncformodel"></a>
# **CancelReverseETLSyncForModel**
> CancelReverseETLSyncForModel200Response CancelReverseETLSyncForModel (string modelId, string syncId, CancelReverseETLSyncForModelInput cancelReverseETLSyncForModelInput)

Cancel Reverse ETL Sync for Model

Cancels a sync for a Reverse ETL Connection. It might take a few seconds to completely cancel the sync.   Will return an error if the sync is already completed or cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CancelReverseETLSyncForModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = modelId;  // string | 
            var syncId = 1;  // string | 
            var cancelReverseETLSyncForModelInput = new CancelReverseETLSyncForModelInput(); // CancelReverseETLSyncForModelInput | 

            try
            {
                // Cancel Reverse ETL Sync for Model
                CancelReverseETLSyncForModel200Response result = apiInstance.CancelReverseETLSyncForModel(modelId, syncId, cancelReverseETLSyncForModelInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.CancelReverseETLSyncForModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelReverseETLSyncForModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Reverse ETL Sync for Model
    ApiResponse<CancelReverseETLSyncForModel200Response> response = apiInstance.CancelReverseETLSyncForModelWithHttpInfo(modelId, syncId, cancelReverseETLSyncForModelInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.CancelReverseETLSyncForModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |
| **syncId** | **string** |  |  |
| **cancelReverseETLSyncForModelInput** | [**CancelReverseETLSyncForModelInput**](CancelReverseETLSyncForModelInput.md) |  |  |

### Return type

[**CancelReverseETLSyncForModel200Response**](CancelReverseETLSyncForModel200Response.md)

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

<a id="createreverseetlmanualsync"></a>
# **CreateReverseETLManualSync**
> CreateReverseETLManualSync200Response CreateReverseETLManualSync (CreateReverseETLManualSyncInput createReverseETLManualSyncInput)

Create Reverse ETL Manual Sync

Triggers a manual sync for a Reverse ETL Connection.   In the request body, the `subscription id` is the id that follows after `/mappings/` portion in the URL of the sync.   For example, the `subscription id` would be `2` for this sync: https://app.Segment.com/example-workspace/reverse-etl/destinations/example-destination/sources/example-source/instances/1/mappings/2/source-id/3/model-id/4/sync-details   The rate limit for this endpoint is 20 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateReverseETLManualSyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var createReverseETLManualSyncInput = new CreateReverseETLManualSyncInput(); // CreateReverseETLManualSyncInput | 

            try
            {
                // Create Reverse ETL Manual Sync
                CreateReverseETLManualSync200Response result = apiInstance.CreateReverseETLManualSync(createReverseETLManualSyncInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.CreateReverseETLManualSync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReverseETLManualSyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Reverse ETL Manual Sync
    ApiResponse<CreateReverseETLManualSync200Response> response = apiInstance.CreateReverseETLManualSyncWithHttpInfo(createReverseETLManualSyncInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.CreateReverseETLManualSyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createReverseETLManualSyncInput** | [**CreateReverseETLManualSyncInput**](CreateReverseETLManualSyncInput.md) |  |  |

### Return type

[**CreateReverseETLManualSync200Response**](CreateReverseETLManualSync200Response.md)

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

<a id="createreverseetlmodel"></a>
# **CreateReverseEtlModel**
> CreateReverseEtlModel201Response CreateReverseEtlModel (CreateReverseEtlModelInput createReverseEtlModelInput)

Create Reverse Etl Model

Creates a new Reverse ETL Model.          • When called, this endpoint may generate the `Model Created` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateReverseEtlModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var createReverseEtlModelInput = new CreateReverseEtlModelInput(); // CreateReverseEtlModelInput | 

            try
            {
                // Create Reverse Etl Model
                CreateReverseEtlModel201Response result = apiInstance.CreateReverseEtlModel(createReverseEtlModelInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.CreateReverseEtlModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReverseEtlModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Reverse Etl Model
    ApiResponse<CreateReverseEtlModel201Response> response = apiInstance.CreateReverseEtlModelWithHttpInfo(createReverseEtlModelInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.CreateReverseEtlModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createReverseEtlModelInput** | [**CreateReverseEtlModelInput**](CreateReverseEtlModelInput.md) |  |  |

### Return type

[**CreateReverseEtlModel201Response**](CreateReverseEtlModel201Response.md)

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

<a id="deletereverseetlmodel"></a>
# **DeleteReverseEtlModel**
> DeleteReverseEtlModel200Response DeleteReverseEtlModel (string modelId)

Delete Reverse Etl Model

Deletes an existing Model.          • When called, this endpoint may generate the `Model Deleted` event in the [audit trail](/tag/Audit-Trail).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteReverseEtlModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = fxXMc5bLdKnDfEgBpDbV11;  // string | 

            try
            {
                // Delete Reverse Etl Model
                DeleteReverseEtlModel200Response result = apiInstance.DeleteReverseEtlModel(modelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.DeleteReverseEtlModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReverseEtlModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Reverse Etl Model
    ApiResponse<DeleteReverseEtlModel200Response> response = apiInstance.DeleteReverseEtlModelWithHttpInfo(modelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.DeleteReverseEtlModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |

### Return type

[**DeleteReverseEtlModel200Response**](DeleteReverseEtlModel200Response.md)

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

<a id="getreverseetlsyncstatus"></a>
# **GetReverseETLSyncStatus**
> GetReverseETLSyncStatus200Response GetReverseETLSyncStatus (string modelId, string syncId)

Get Reverse ETL Sync Status

Get the sync status for a Reverse ETL sync.  The sync status includes all detailed information about the sync - sync status, duration, details about the extract and load phase if applicable, etc.   The rate limit for this endpoint is 250 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetReverseETLSyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = modelId;  // string | 
            var syncId = syncId;  // string | 

            try
            {
                // Get Reverse ETL Sync Status
                GetReverseETLSyncStatus200Response result = apiInstance.GetReverseETLSyncStatus(modelId, syncId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.GetReverseETLSyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReverseETLSyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Reverse ETL Sync Status
    ApiResponse<GetReverseETLSyncStatus200Response> response = apiInstance.GetReverseETLSyncStatusWithHttpInfo(modelId, syncId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.GetReverseETLSyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |
| **syncId** | **string** |  |  |

### Return type

[**GetReverseETLSyncStatus200Response**](GetReverseETLSyncStatus200Response.md)

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

<a id="getreverseetlmodel"></a>
# **GetReverseEtlModel**
> GetReverseEtlModel200Response GetReverseEtlModel (string modelId)

Get Reverse Etl Model

Returns a Reverse ETL Model by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetReverseEtlModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = jSAVzDH3z89geNDZwoNY9V;  // string | 

            try
            {
                // Get Reverse Etl Model
                GetReverseEtlModel200Response result = apiInstance.GetReverseEtlModel(modelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.GetReverseEtlModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReverseEtlModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Reverse Etl Model
    ApiResponse<GetReverseEtlModel200Response> response = apiInstance.GetReverseEtlModelWithHttpInfo(modelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.GetReverseEtlModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |

### Return type

[**GetReverseEtlModel200Response**](GetReverseEtlModel200Response.md)

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

<a id="listreverseetlsyncstatusesfrommodelandsubscriptionid"></a>
# **ListReverseETLSyncStatusesFromModelAndSubscriptionId**
> ListReverseETLSyncStatusesFromModelAndSubscriptionId200Response ListReverseETLSyncStatusesFromModelAndSubscriptionId (string modelId, string subscriptionId, decimal? count = null, string? cursor = null)

List Reverse ETL Sync Statuses from Model And Subscription Id

Get the sync statuses for a Reverse ETL mapping subscription.  The sync status includes all detailed information about the sync - sync status, duration, details about the extract and load phase if applicable, etc.  The default page count is 10, and then the next page can be fetched by passing the `cursor` query parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListReverseETLSyncStatusesFromModelAndSubscriptionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = modelId;  // string | 
            var subscriptionId = subscriptionId;  // string | 
            var count = 8.14D;  // decimal? | The number of items to retrieve in a page, between 1 and 100. Default is 10  This parameter exists in alpha. (optional) 
            var cursor = "cursor_example";  // string? | The page to request. Acceptable values to use are from the `current`, `next`, and `previous` keys.  This parameter exists in alpha. (optional) 

            try
            {
                // List Reverse ETL Sync Statuses from Model And Subscription Id
                ListReverseETLSyncStatusesFromModelAndSubscriptionId200Response result = apiInstance.ListReverseETLSyncStatusesFromModelAndSubscriptionId(modelId, subscriptionId, count, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.ListReverseETLSyncStatusesFromModelAndSubscriptionId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReverseETLSyncStatusesFromModelAndSubscriptionIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Reverse ETL Sync Statuses from Model And Subscription Id
    ApiResponse<ListReverseETLSyncStatusesFromModelAndSubscriptionId200Response> response = apiInstance.ListReverseETLSyncStatusesFromModelAndSubscriptionIdWithHttpInfo(modelId, subscriptionId, count, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.ListReverseETLSyncStatusesFromModelAndSubscriptionIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **count** | **decimal?** | The number of items to retrieve in a page, between 1 and 100. Default is 10  This parameter exists in alpha. | [optional]  |
| **cursor** | **string?** | The page to request. Acceptable values to use are from the &#x60;current&#x60;, &#x60;next&#x60;, and &#x60;previous&#x60; keys.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListReverseETLSyncStatusesFromModelAndSubscriptionId200Response**](ListReverseETLSyncStatusesFromModelAndSubscriptionId200Response.md)

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

<a id="listreverseetlmodels"></a>
# **ListReverseEtlModels**
> ListReverseEtlModels200Response ListReverseEtlModels (PaginationInput? pagination = null)

List Reverse Etl Models

Returns a list of Reverse ETL Models.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListReverseEtlModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in alpha. (optional) 

            try
            {
                // List Reverse Etl Models
                ListReverseEtlModels200Response result = apiInstance.ListReverseEtlModels(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.ListReverseEtlModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReverseEtlModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Reverse Etl Models
    ApiResponse<ListReverseEtlModels200Response> response = apiInstance.ListReverseEtlModelsWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.ListReverseEtlModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListReverseEtlModels200Response**](ListReverseEtlModels200Response.md)

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

<a id="updatereverseetlmodel"></a>
# **UpdateReverseEtlModel**
> UpdateReverseEtlModel200Response UpdateReverseEtlModel (string modelId, UpdateReverseEtlModelInput updateReverseEtlModelInput)

Update Reverse Etl Model

Updates an existing Reverse ETL Model.          • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Model Settings Saved * Model State Change Toggled       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateReverseEtlModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReverseETLApi(config);
            var modelId = 6BthE21tPsXyA2cK3QPQFQ;  // string | 
            var updateReverseEtlModelInput = new UpdateReverseEtlModelInput(); // UpdateReverseEtlModelInput | 

            try
            {
                // Update Reverse Etl Model
                UpdateReverseEtlModel200Response result = apiInstance.UpdateReverseEtlModel(modelId, updateReverseEtlModelInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseETLApi.UpdateReverseEtlModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReverseEtlModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Reverse Etl Model
    ApiResponse<UpdateReverseEtlModel200Response> response = apiInstance.UpdateReverseEtlModelWithHttpInfo(modelId, updateReverseEtlModelInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseETLApi.UpdateReverseEtlModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **string** |  |  |
| **updateReverseEtlModelInput** | [**UpdateReverseEtlModelInput**](UpdateReverseEtlModelInput.md) |  |  |

### Return type

[**UpdateReverseEtlModel200Response**](UpdateReverseEtlModel200Response.md)

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

