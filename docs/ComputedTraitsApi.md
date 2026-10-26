# Segment.PublicApi.Api.ComputedTraitsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateComputedTrait**](ComputedTraitsApi.md#createcomputedtrait) | **POST** /spaces/{spaceId}/computed-traits | Create Computed Trait |
| [**GetComputedTrait**](ComputedTraitsApi.md#getcomputedtrait) | **GET** /spaces/{spaceId}/computed-traits/{id} | Get Computed Trait |
| [**ListComputedTraits**](ComputedTraitsApi.md#listcomputedtraits) | **GET** /spaces/{spaceId}/computed-traits | List Computed Traits |
| [**RemoveComputedTraitFromSpace**](ComputedTraitsApi.md#removecomputedtraitfromspace) | **DELETE** /spaces/{spaceId}/computed-traits/{id} | Remove Computed Trait from Space |
| [**UpdateComputedTraitForSpace**](ComputedTraitsApi.md#updatecomputedtraitforspace) | **PATCH** /spaces/{spaceId}/computed-traits/{id} | Update Computed Trait for Space |

<a id="createcomputedtrait"></a>
# **CreateComputedTrait**
> CreateComputedTrait200Response CreateComputedTrait (string spaceId, CreateComputedTraitAlphaInput createComputedTraitAlphaInput)

Create Computed Trait

Creates a Computed Trait  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Computed Trait feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Computed Trait Created` event in the [audit trail](/tag/Audit-Trail).  Note: The definition for a Computed Trait created using the API is not editable through the Segment App.   The rate limit for this endpoint is 10 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateComputedTraitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputedTraitsApi(config);
            var spaceId = spaceId;  // string | 
            var createComputedTraitAlphaInput = new CreateComputedTraitAlphaInput(); // CreateComputedTraitAlphaInput | 

            try
            {
                // Create Computed Trait
                CreateComputedTrait200Response result = apiInstance.CreateComputedTrait(spaceId, createComputedTraitAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputedTraitsApi.CreateComputedTrait: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateComputedTraitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Computed Trait
    ApiResponse<CreateComputedTrait200Response> response = apiInstance.CreateComputedTraitWithHttpInfo(spaceId, createComputedTraitAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputedTraitsApi.CreateComputedTraitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **createComputedTraitAlphaInput** | [**CreateComputedTraitAlphaInput**](CreateComputedTraitAlphaInput.md) |  |  |

### Return type

[**CreateComputedTrait200Response**](CreateComputedTrait200Response.md)

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

<a id="getcomputedtrait"></a>
# **GetComputedTrait**
> GetComputedTrait200Response GetComputedTrait (string spaceId, string id)

Get Computed Trait

Returns the Computed Trait by id and spaceId  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Computed Trait feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 100 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetComputedTraitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputedTraitsApi(config);
            var spaceId = spaceId;  // string | 
            var id = id;  // string | 

            try
            {
                // Get Computed Trait
                GetComputedTrait200Response result = apiInstance.GetComputedTrait(spaceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputedTraitsApi.GetComputedTrait: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComputedTraitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Computed Trait
    ApiResponse<GetComputedTrait200Response> response = apiInstance.GetComputedTraitWithHttpInfo(spaceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputedTraitsApi.GetComputedTraitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**GetComputedTrait200Response**](GetComputedTrait200Response.md)

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

<a id="listcomputedtraits"></a>
# **ListComputedTraits**
> ListComputedTraits200Response ListComputedTraits (string spaceId, PaginationInput? pagination = null)

List Computed Traits

Returns Computed Traits by spaceId.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Computed Trait feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListComputedTraitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputedTraitsApi(config);
            var spaceId = spaceId;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. (optional) 

            try
            {
                // List Computed Traits
                ListComputedTraits200Response result = apiInstance.ListComputedTraits(spaceId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputedTraitsApi.ListComputedTraits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComputedTraitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Computed Traits
    ApiResponse<ListComputedTraits200Response> response = apiInstance.ListComputedTraitsWithHttpInfo(spaceId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputedTraitsApi.ListComputedTraitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListComputedTraits200Response**](ListComputedTraits200Response.md)

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

<a id="removecomputedtraitfromspace"></a>
# **RemoveComputedTraitFromSpace**
> RemoveComputedTraitFromSpace200Response RemoveComputedTraitFromSpace (string spaceId, string id)

Remove Computed Trait from Space

Deletes a Computed Trait by id and spaceId.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Computed Trait feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Computed Trait Deleted` event in the [audit trail](/tag/Audit-Trail).   The rate limit for this endpoint is 20 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveComputedTraitFromSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputedTraitsApi(config);
            var spaceId = spaceId;  // string | 
            var id = id;  // string | 

            try
            {
                // Remove Computed Trait from Space
                RemoveComputedTraitFromSpace200Response result = apiInstance.RemoveComputedTraitFromSpace(spaceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputedTraitsApi.RemoveComputedTraitFromSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveComputedTraitFromSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Computed Trait from Space
    ApiResponse<RemoveComputedTraitFromSpace200Response> response = apiInstance.RemoveComputedTraitFromSpaceWithHttpInfo(spaceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputedTraitsApi.RemoveComputedTraitFromSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**RemoveComputedTraitFromSpace200Response**](RemoveComputedTraitFromSpace200Response.md)

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

<a id="updatecomputedtraitforspace"></a>
# **UpdateComputedTraitForSpace**
> UpdateComputedTraitForSpace200Response UpdateComputedTraitForSpace (string spaceId, string id, UpdateComputedTraitForSpaceAlphaInput updateComputedTraitForSpaceAlphaInput)

Update Computed Trait for Space

Updates the Computed Trait.  • This endpoint is in **Alpha** testing.  Please submit any feedback by sending an email to friends@segment.com.   • In order to successfully call this endpoint, the specified Workspace needs to have the Computed Trait feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Computed Trait Modified` event in the [audit trail](/tag/Audit-Trail).  • Note that when a Computed Trait is updated, the Computed Trait will be locked from future edits until the changes have been incorporated. You can find more information [in the Segment docs](https://segment-docs.netlify.app/docs/unify/traits/computed-traits/#editing-realtime-traits).  Note: The definition for a Computed Trait updated using the API is not editable through the Segment App.   The rate limit for this endpoint is 10 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateComputedTraitForSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputedTraitsApi(config);
            var spaceId = spaceId;  // string | 
            var id = id;  // string | 
            var updateComputedTraitForSpaceAlphaInput = new UpdateComputedTraitForSpaceAlphaInput(); // UpdateComputedTraitForSpaceAlphaInput | 

            try
            {
                // Update Computed Trait for Space
                UpdateComputedTraitForSpace200Response result = apiInstance.UpdateComputedTraitForSpace(spaceId, id, updateComputedTraitForSpaceAlphaInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputedTraitsApi.UpdateComputedTraitForSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateComputedTraitForSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Computed Trait for Space
    ApiResponse<UpdateComputedTraitForSpace200Response> response = apiInstance.UpdateComputedTraitForSpaceWithHttpInfo(spaceId, id, updateComputedTraitForSpaceAlphaInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputedTraitsApi.UpdateComputedTraitForSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **updateComputedTraitForSpaceAlphaInput** | [**UpdateComputedTraitForSpaceAlphaInput**](UpdateComputedTraitForSpaceAlphaInput.md) |  |  |

### Return type

[**UpdateComputedTraitForSpace200Response**](UpdateComputedTraitForSpace200Response.md)

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

