# Segment.PublicApi.Api.ActivationsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddActivationToAudience**](ActivationsApi.md#addactivationtoaudience) | **POST** /spaces/{spaceId}/audiences/{audienceId}/destination-connections/{connectionId}/activations | Add Activation to Audience |
| [**AddDestinationToAudience**](ActivationsApi.md#adddestinationtoaudience) | **POST** /spaces/{spaceId}/audiences/{audienceId}/destination-connections | Add Destination to Audience |
| [**BatchQueryActivationsForSpace**](ActivationsApi.md#batchqueryactivationsforspace) | **POST** /spaces/{spaceId}/activations/batch | Batch Query Activations for Space |
| [**GetActivationFromAudience**](ActivationsApi.md#getactivationfromaudience) | **GET** /spaces/{spaceId}/audiences/{audienceId}/activations/{id} | Get Activation from Audience |
| [**ListActivationsFromAudience**](ActivationsApi.md#listactivationsfromaudience) | **GET** /spaces/{spaceId}/audiences/{audienceId}/activations | List Activations from Audience |
| [**ListDestinationsFromAudience**](ActivationsApi.md#listdestinationsfromaudience) | **GET** /spaces/{spaceId}/audiences/{audienceId}/destination-connections | List Destinations from Audience |
| [**ListSupportedDestinationsFromAudience**](ActivationsApi.md#listsupporteddestinationsfromaudience) | **GET** /spaces/{spaceId}/audienceType/{audienceType}/supported-destinations | List Supported Destinations from Audience |
| [**RemoveActivationFromAudience**](ActivationsApi.md#removeactivationfromaudience) | **DELETE** /spaces/{spaceId}/audiences/{audienceId}/activations/{id} | Remove Activation from Audience |
| [**RemoveDestinationFromAudience**](ActivationsApi.md#removedestinationfromaudience) | **DELETE** /spaces/{spaceId}/audiences/{audienceId}/destination-connections/{destinationId} | Remove Destination from Audience |
| [**UpdateActivationForAudience**](ActivationsApi.md#updateactivationforaudience) | **PATCH** /spaces/{spaceId}/audiences/{audienceId}/activations/{id} | Update Activation for Audience |
| [**UpdateDestinationForAudience**](ActivationsApi.md#updatedestinationforaudience) | **PATCH** /spaces/{spaceId}/audiences/{audienceId}/destination-connections/{destinationId} | Update Destination for Audience |

<a id="addactivationtoaudience"></a>
# **AddActivationToAudience**
> AddActivationToAudience200Response AddActivationToAudience (string spaceId, string audienceId, string connectionId, AddActivationToAudienceAlphaInput addActivationToAudienceAlphaInput)

Add Activation to Audience

Defines how audience data is sent to a Destination. This step enables the data sync. You must establish a connection (Add Destination to Audience) for this audience before an Activation can be created.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddActivationToAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var connectionId = ii_123456789;  // string | 
            var addActivationToAudienceAlphaInput = new AddActivationToAudienceAlphaInput(); // AddActivationToAudienceAlphaInput | 

            try
            {
                // Add Activation to Audience
                AddActivationToAudience200Response result = apiInstance.AddActivationToAudience(spaceId, audienceId, connectionId, addActivationToAudienceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.AddActivationToAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddActivationToAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Activation to Audience
    ApiResponse<AddActivationToAudience200Response> response = apiInstance.AddActivationToAudienceWithHttpInfo(spaceId, audienceId, connectionId, addActivationToAudienceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.AddActivationToAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **connectionId** | **string** |  |  |
| **addActivationToAudienceAlphaInput** | [**AddActivationToAudienceAlphaInput**](AddActivationToAudienceAlphaInput.md) |  |  |

### Return type

[**AddActivationToAudience200Response**](AddActivationToAudience200Response.md)

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

<a id="adddestinationtoaudience"></a>
# **AddDestinationToAudience**
> AddDestinationToAudience200Response AddDestinationToAudience (string spaceId, string audienceId, AddDestinationToAudienceAlphaInput addDestinationToAudienceAlphaInput)

Add Destination to Audience

Establishes a connection between an audience and a Destination. To start syncing data, you must create an Activation for the connection created here.  Note that the Destination must be added to Engage through the Engage Settings page within the App before creating the connection through the API.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddDestinationToAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var addDestinationToAudienceAlphaInput = new AddDestinationToAudienceAlphaInput(); // AddDestinationToAudienceAlphaInput | 

            try
            {
                // Add Destination to Audience
                AddDestinationToAudience200Response result = apiInstance.AddDestinationToAudience(spaceId, audienceId, addDestinationToAudienceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.AddDestinationToAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDestinationToAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Destination to Audience
    ApiResponse<AddDestinationToAudience200Response> response = apiInstance.AddDestinationToAudienceWithHttpInfo(spaceId, audienceId, addDestinationToAudienceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.AddDestinationToAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **addDestinationToAudienceAlphaInput** | [**AddDestinationToAudienceAlphaInput**](AddDestinationToAudienceAlphaInput.md) |  |  |

### Return type

[**AddDestinationToAudience200Response**](AddDestinationToAudience200Response.md)

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

<a id="batchqueryactivationsforspace"></a>
# **BatchQueryActivationsForSpace**
> BatchQueryActivationsForSpace200Response BatchQueryActivationsForSpace (string spaceId, BatchQueryActivationsForSpaceAlphaInput batchQueryActivationsForSpaceAlphaInput)

Batch Query Activations for Space

Lists Activations in bulk across many Audiences in one call. Intended for bulk reads, for example pulling activation metadata for hundreds of audiences on a schedule, so callers don't need one `listActivationsFromAudience` call per audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class BatchQueryActivationsForSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var batchQueryActivationsForSpaceAlphaInput = new BatchQueryActivationsForSpaceAlphaInput(); // BatchQueryActivationsForSpaceAlphaInput | 

            try
            {
                // Batch Query Activations for Space
                BatchQueryActivationsForSpace200Response result = apiInstance.BatchQueryActivationsForSpace(spaceId, batchQueryActivationsForSpaceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.BatchQueryActivationsForSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchQueryActivationsForSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch Query Activations for Space
    ApiResponse<BatchQueryActivationsForSpace200Response> response = apiInstance.BatchQueryActivationsForSpaceWithHttpInfo(spaceId, batchQueryActivationsForSpaceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.BatchQueryActivationsForSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **batchQueryActivationsForSpaceAlphaInput** | [**BatchQueryActivationsForSpaceAlphaInput**](BatchQueryActivationsForSpaceAlphaInput.md) |  |  |

### Return type

[**BatchQueryActivationsForSpace200Response**](BatchQueryActivationsForSpace200Response.md)

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

<a id="getactivationfromaudience"></a>
# **GetActivationFromAudience**
> GetActivationFromAudience200Response GetActivationFromAudience (string spaceId, string audienceId, string id)

Get Activation from Audience

Gets a single Activation by id.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetActivationFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var id = act_987654321;  // string | 

            try
            {
                // Get Activation from Audience
                GetActivationFromAudience200Response result = apiInstance.GetActivationFromAudience(spaceId, audienceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.GetActivationFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActivationFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Activation from Audience
    ApiResponse<GetActivationFromAudience200Response> response = apiInstance.GetActivationFromAudienceWithHttpInfo(spaceId, audienceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.GetActivationFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**GetActivationFromAudience200Response**](GetActivationFromAudience200Response.md)

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

<a id="listactivationsfromaudience"></a>
# **ListActivationsFromAudience**
> ListActivationsFromAudience200Response ListActivationsFromAudience (string spaceId, string audienceId, PaginationInput? pagination = null)

List Activations from Audience

Lists all Activations.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListActivationsFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Optional pagination.  This parameter exists in alpha. (optional) 

            try
            {
                // List Activations from Audience
                ListActivationsFromAudience200Response result = apiInstance.ListActivationsFromAudience(spaceId, audienceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.ListActivationsFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListActivationsFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Activations from Audience
    ApiResponse<ListActivationsFromAudience200Response> response = apiInstance.ListActivationsFromAudienceWithHttpInfo(spaceId, audienceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.ListActivationsFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional pagination.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListActivationsFromAudience200Response**](ListActivationsFromAudience200Response.md)

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

<a id="listdestinationsfromaudience"></a>
# **ListDestinationsFromAudience**
> ListDestinationsFromAudience200Response ListDestinationsFromAudience (string spaceId, string audienceId, PaginationInput? pagination = null)

List Destinations from Audience

Lists all Destinations from an Audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListDestinationsFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Optional pagination.  This parameter exists in alpha. (optional) 

            try
            {
                // List Destinations from Audience
                ListDestinationsFromAudience200Response result = apiInstance.ListDestinationsFromAudience(spaceId, audienceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.ListDestinationsFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDestinationsFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Destinations from Audience
    ApiResponse<ListDestinationsFromAudience200Response> response = apiInstance.ListDestinationsFromAudienceWithHttpInfo(spaceId, audienceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.ListDestinationsFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Optional pagination.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListDestinationsFromAudience200Response**](ListDestinationsFromAudience200Response.md)

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

<a id="listsupporteddestinationsfromaudience"></a>
# **ListSupportedDestinationsFromAudience**
> ListSupportedDestinationsFromAudience200Response ListSupportedDestinationsFromAudience (string spaceId, string audienceType, string? slug = null, string? actionId = null)

List Supported Destinations from Audience

Lists the Destinations that have been reviewed and validated for activation with this audience type.  Use this endpoint to discover the available action ids and the Destination fields that can be mapped before creating an Activation.  Destinations returned with an empty actions array are audience Destinations that are configured through connection settings rather than action mappings, and do not use destinationMapping.  Destinations that are not returned here have not been reviewed for activation and are unsupported. To request a review for an additional Destination, contact your customer success manager.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSupportedDestinationsFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceType = USERS;  // string | 
            var slug = "slug_example";  // string? | Optional destination slug to filter results.  This parameter exists in alpha. (optional) 
            var actionId = "actionId_example";  // string? | Optional destination action id to filter results.  This parameter exists in alpha. (optional) 

            try
            {
                // List Supported Destinations from Audience
                ListSupportedDestinationsFromAudience200Response result = apiInstance.ListSupportedDestinationsFromAudience(spaceId, audienceType, slug, actionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.ListSupportedDestinationsFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSupportedDestinationsFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Supported Destinations from Audience
    ApiResponse<ListSupportedDestinationsFromAudience200Response> response = apiInstance.ListSupportedDestinationsFromAudienceWithHttpInfo(spaceId, audienceType, slug, actionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.ListSupportedDestinationsFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceType** | **string** |  |  |
| **slug** | **string?** | Optional destination slug to filter results.  This parameter exists in alpha. | [optional]  |
| **actionId** | **string?** | Optional destination action id to filter results.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListSupportedDestinationsFromAudience200Response**](ListSupportedDestinationsFromAudience200Response.md)

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

<a id="removeactivationfromaudience"></a>
# **RemoveActivationFromAudience**
> RemoveActivationFromAudience200Response RemoveActivationFromAudience (string spaceId, string audienceId, string id)

Remove Activation from Audience

Deletes an Activation.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveActivationFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var id = act_987654321;  // string | 

            try
            {
                // Remove Activation from Audience
                RemoveActivationFromAudience200Response result = apiInstance.RemoveActivationFromAudience(spaceId, audienceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.RemoveActivationFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveActivationFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Activation from Audience
    ApiResponse<RemoveActivationFromAudience200Response> response = apiInstance.RemoveActivationFromAudienceWithHttpInfo(spaceId, audienceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.RemoveActivationFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**RemoveActivationFromAudience200Response**](RemoveActivationFromAudience200Response.md)

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

<a id="removedestinationfromaudience"></a>
# **RemoveDestinationFromAudience**
> RemoveDestinationFromAudience200Response RemoveDestinationFromAudience (string spaceId, string audienceId, string destinationId)

Remove Destination from Audience

Removes a Destination from an Audience. If there are activations associated with the Destination, the request will return a 409 Conflict error.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveDestinationFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var destinationId = ii_123456789;  // string | 

            try
            {
                // Remove Destination from Audience
                RemoveDestinationFromAudience200Response result = apiInstance.RemoveDestinationFromAudience(spaceId, audienceId, destinationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.RemoveDestinationFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDestinationFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Destination from Audience
    ApiResponse<RemoveDestinationFromAudience200Response> response = apiInstance.RemoveDestinationFromAudienceWithHttpInfo(spaceId, audienceId, destinationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.RemoveDestinationFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **destinationId** | **string** |  |  |

### Return type

[**RemoveDestinationFromAudience200Response**](RemoveDestinationFromAudience200Response.md)

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

<a id="updateactivationforaudience"></a>
# **UpdateActivationForAudience**
> UpdateActivationForAudience200Response UpdateActivationForAudience (string spaceId, string audienceId, string id, UpdateActivationForAudienceAlphaInput updateActivationForAudienceAlphaInput)

Update Activation for Audience

Updates an Activation.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateActivationForAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var id = act_987654321;  // string | 
            var updateActivationForAudienceAlphaInput = new UpdateActivationForAudienceAlphaInput(); // UpdateActivationForAudienceAlphaInput | 

            try
            {
                // Update Activation for Audience
                UpdateActivationForAudience200Response result = apiInstance.UpdateActivationForAudience(spaceId, audienceId, id, updateActivationForAudienceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.UpdateActivationForAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateActivationForAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Activation for Audience
    ApiResponse<UpdateActivationForAudience200Response> response = apiInstance.UpdateActivationForAudienceWithHttpInfo(spaceId, audienceId, id, updateActivationForAudienceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.UpdateActivationForAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **id** | **string** |  |  |
| **updateActivationForAudienceAlphaInput** | [**UpdateActivationForAudienceAlphaInput**](UpdateActivationForAudienceAlphaInput.md) |  |  |

### Return type

[**UpdateActivationForAudience200Response**](UpdateActivationForAudience200Response.md)

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

<a id="updatedestinationforaudience"></a>
# **UpdateDestinationForAudience**
> UpdateDestinationForAudience200Response UpdateDestinationForAudience (string spaceId, string audienceId, string destinationId, UpdateDestinationForAudienceAlphaInput updateDestinationForAudienceAlphaInput)

Update Destination for Audience

Updates a Destination for an Audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateDestinationForAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ActivationsApi(config);
            var spaceId = spa_9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var destinationId = ii_123456789;  // string | 
            var updateDestinationForAudienceAlphaInput = new UpdateDestinationForAudienceAlphaInput(); // UpdateDestinationForAudienceAlphaInput | 

            try
            {
                // Update Destination for Audience
                UpdateDestinationForAudience200Response result = apiInstance.UpdateDestinationForAudience(spaceId, audienceId, destinationId, updateDestinationForAudienceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivationsApi.UpdateDestinationForAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDestinationForAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Destination for Audience
    ApiResponse<UpdateDestinationForAudience200Response> response = apiInstance.UpdateDestinationForAudienceWithHttpInfo(spaceId, audienceId, destinationId, updateDestinationForAudienceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivationsApi.UpdateDestinationForAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |
| **destinationId** | **string** |  |  |
| **updateDestinationForAudienceAlphaInput** | [**UpdateDestinationForAudienceAlphaInput**](UpdateDestinationForAudienceAlphaInput.md) |  |  |

### Return type

[**UpdateDestinationForAudience200Response**](UpdateDestinationForAudience200Response.md)

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

