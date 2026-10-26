# Segment.PublicApi.Api.AudiencesApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAudienceScheduleToAudience**](AudiencesApi.md#addaudiencescheduletoaudience) | **POST** /spaces/{spaceId}/audiences/{id}/schedules | Add Audience Schedule to Audience |
| [**CreateAudience**](AudiencesApi.md#createaudience) | **POST** /spaces/{spaceId}/audiences | Create Audience |
| [**CreateAudiencePreview**](AudiencesApi.md#createaudiencepreview) | **POST** /spaces/{spaceId}/audiences/previews | Create Audience Preview |
| [**ForceExecuteAudienceRun**](AudiencesApi.md#forceexecuteaudiencerun) | **POST** /spaces/{spaceId}/audiences/{audienceId}/runs | Force Execute Audience Run |
| [**GetAudience**](AudiencesApi.md#getaudience) | **GET** /spaces/{spaceId}/audiences/{id} | Get Audience |
| [**GetAudiencePreview**](AudiencesApi.md#getaudiencepreview) | **GET** /spaces/{spaceId}/audiences/previews/{id} | Get Audience Preview |
| [**GetAudienceScheduleFromSpaceAndAudience**](AudiencesApi.md#getaudienceschedulefromspaceandaudience) | **GET** /spaces/{spaceId}/audiences/{id}/schedules/{scheduleId} | Get Audience Schedule from Space And Audience |
| [**ListAudienceConsumersFromSpaceAndAudience**](AudiencesApi.md#listaudienceconsumersfromspaceandaudience) | **GET** /spaces/{spaceId}/audiences/{id}/audience-references | List Audience Consumers from Space And Audience |
| [**ListAudienceSchedulesFromSpaceAndAudience**](AudiencesApi.md#listaudienceschedulesfromspaceandaudience) | **GET** /spaces/{spaceId}/audiences/{id}/schedules | List Audience Schedules from Space And Audience |
| [**ListAudiences**](AudiencesApi.md#listaudiences) | **GET** /spaces/{spaceId}/audiences | List Audiences |
| [**RemoveAudienceFromSpace**](AudiencesApi.md#removeaudiencefromspace) | **DELETE** /spaces/{spaceId}/audiences/{id} | Remove Audience from Space |
| [**RemoveAudienceScheduleFromAudience**](AudiencesApi.md#removeaudienceschedulefromaudience) | **DELETE** /spaces/{spaceId}/audiences/{id}/schedules/{scheduleId} | Remove Audience Schedule from Audience |
| [**UpdateAudienceForSpace**](AudiencesApi.md#updateaudienceforspace) | **PATCH** /spaces/{spaceId}/audiences/{id} | Update Audience for Space |
| [**UpdateAudienceScheduleForAudience**](AudiencesApi.md#updateaudiencescheduleforaudience) | **PATCH** /spaces/{spaceId}/audiences/{id}/schedules/{scheduleId} | Update Audience Schedule for Audience |

<a id="addaudiencescheduletoaudience"></a>
# **AddAudienceScheduleToAudience**
> AddAudienceScheduleToAudience200Response AddAudienceScheduleToAudience (string spaceId, string id, AddAudienceScheduleToAudienceInput addAudienceScheduleToAudienceInput)

Add Audience Schedule to Audience

The ability to configure the run schedule for an Audience is limited to Linked Audiences (audienceType = LINKED).  Note that if a Linked Audience remains disabled for 90 days Segment will delete the associated schedule and a new schedule will need to be created.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddAudienceScheduleToAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var addAudienceScheduleToAudienceInput = new AddAudienceScheduleToAudienceInput(); // AddAudienceScheduleToAudienceInput | 

            try
            {
                // Add Audience Schedule to Audience
                AddAudienceScheduleToAudience200Response result = apiInstance.AddAudienceScheduleToAudience(spaceId, id, addAudienceScheduleToAudienceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.AddAudienceScheduleToAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAudienceScheduleToAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Audience Schedule to Audience
    ApiResponse<AddAudienceScheduleToAudience200Response> response = apiInstance.AddAudienceScheduleToAudienceWithHttpInfo(spaceId, id, addAudienceScheduleToAudienceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.AddAudienceScheduleToAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **addAudienceScheduleToAudienceInput** | [**AddAudienceScheduleToAudienceInput**](AddAudienceScheduleToAudienceInput.md) |  |  |

### Return type

[**AddAudienceScheduleToAudience200Response**](AddAudienceScheduleToAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createaudience"></a>
# **CreateAudience**
> CreateAudience200Response CreateAudience (string spaceId, CreateAudienceInput createAudienceInput)

Create Audience

Creates Audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Audience Created` event in the [audit trail](/tag/Audit-Trail).   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var createAudienceInput = new CreateAudienceInput(); // CreateAudienceInput | 

            try
            {
                // Create Audience
                CreateAudience200Response result = apiInstance.CreateAudience(spaceId, createAudienceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.CreateAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Audience
    ApiResponse<CreateAudience200Response> response = apiInstance.CreateAudienceWithHttpInfo(spaceId, createAudienceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.CreateAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **createAudienceInput** | [**CreateAudienceInput**](CreateAudienceInput.md) |  |  |

### Return type

[**CreateAudience200Response**](CreateAudience200Response.md)

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

<a id="createaudiencepreview"></a>
# **CreateAudiencePreview**
> CreateAudiencePreview200Response CreateAudiencePreview (string spaceId, CreateAudiencePreviewInput createAudiencePreviewInput)

Create Audience Preview

Previews Audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Audience Preview Created` event in the [audit trail](/tag/Audit-Trail).   The rate limit for this endpoint is 5 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information. This endpoint also has a rate limit of 700 requests per month per spaceId, which is lower than the default due to access pattern restrictions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateAudiencePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var createAudiencePreviewInput = new CreateAudiencePreviewInput(); // CreateAudiencePreviewInput | 

            try
            {
                // Create Audience Preview
                CreateAudiencePreview200Response result = apiInstance.CreateAudiencePreview(spaceId, createAudiencePreviewInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.CreateAudiencePreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAudiencePreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Audience Preview
    ApiResponse<CreateAudiencePreview200Response> response = apiInstance.CreateAudiencePreviewWithHttpInfo(spaceId, createAudiencePreviewInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.CreateAudiencePreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **createAudiencePreviewInput** | [**CreateAudiencePreviewInput**](CreateAudiencePreviewInput.md) |  |  |

### Return type

[**CreateAudiencePreview200Response**](CreateAudiencePreview200Response.md)

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

<a id="forceexecuteaudiencerun"></a>
# **ForceExecuteAudienceRun**
> ForceExecuteAudienceRun200Response ForceExecuteAudienceRun (string spaceId, string audienceId)

Force Execute Audience Run

The ability to force execute a run for an Audience is limited to Linked Audiences (audienceType = `LINKED`).  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Audience Run Forced` event in the [audit trail](/tag/Audit-Trail).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ForceExecuteAudienceRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var audienceId = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 

            try
            {
                // Force Execute Audience Run
                ForceExecuteAudienceRun200Response result = apiInstance.ForceExecuteAudienceRun(spaceId, audienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.ForceExecuteAudienceRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForceExecuteAudienceRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Force Execute Audience Run
    ApiResponse<ForceExecuteAudienceRun200Response> response = apiInstance.ForceExecuteAudienceRunWithHttpInfo(spaceId, audienceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.ForceExecuteAudienceRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **audienceId** | **string** |  |  |

### Return type

[**ForceExecuteAudienceRun200Response**](ForceExecuteAudienceRun200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaudience"></a>
# **GetAudience**
> GetAudience200Response GetAudience (string spaceId, string id, string? include = null)

Get Audience

Returns the Audience by id and spaceId. Supports including audience schedules using `?include=schedules`.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 100 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var include = "schedules";  // string? | Additional resource to include, support schedules only.  This parameter exists in alpha. (optional) 

            try
            {
                // Get Audience
                GetAudience200Response result = apiInstance.GetAudience(spaceId, id, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.GetAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Audience
    ApiResponse<GetAudience200Response> response = apiInstance.GetAudienceWithHttpInfo(spaceId, id, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.GetAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **include** | **string?** | Additional resource to include, support schedules only.  This parameter exists in alpha. | [optional]  |

### Return type

[**GetAudience200Response**](GetAudience200Response.md)

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

<a id="getaudiencepreview"></a>
# **GetAudiencePreview**
> GetAudiencePreview200Response GetAudiencePreview (string spaceId, string id)

Get Audience Preview

Reads the results of an audience preview.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 300 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetAudiencePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = 31XR7mRsdw3vz3ZqvRa1623re0q-compute_preview_execution-9aQ1Lj62S4bomZKLF4DPqW-compute_preview_execution;  // string | 

            try
            {
                // Get Audience Preview
                GetAudiencePreview200Response result = apiInstance.GetAudiencePreview(spaceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.GetAudiencePreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudiencePreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Audience Preview
    ApiResponse<GetAudiencePreview200Response> response = apiInstance.GetAudiencePreviewWithHttpInfo(spaceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.GetAudiencePreviewWithHttpInfo: " + e.Message);
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

[**GetAudiencePreview200Response**](GetAudiencePreview200Response.md)

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

<a id="getaudienceschedulefromspaceandaudience"></a>
# **GetAudienceScheduleFromSpaceAndAudience**
> GetAudienceScheduleFromSpaceAndAudience200Response GetAudienceScheduleFromSpaceAndAudience (string spaceId, string id, string scheduleId)

Get Audience Schedule from Space And Audience

Returns the schedule for the given audience and scheduleId.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetAudienceScheduleFromSpaceAndAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var scheduleId = sch_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 

            try
            {
                // Get Audience Schedule from Space And Audience
                GetAudienceScheduleFromSpaceAndAudience200Response result = apiInstance.GetAudienceScheduleFromSpaceAndAudience(spaceId, id, scheduleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.GetAudienceScheduleFromSpaceAndAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudienceScheduleFromSpaceAndAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Audience Schedule from Space And Audience
    ApiResponse<GetAudienceScheduleFromSpaceAndAudience200Response> response = apiInstance.GetAudienceScheduleFromSpaceAndAudienceWithHttpInfo(spaceId, id, scheduleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.GetAudienceScheduleFromSpaceAndAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **scheduleId** | **string** |  |  |

### Return type

[**GetAudienceScheduleFromSpaceAndAudience200Response**](GetAudienceScheduleFromSpaceAndAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaudienceconsumersfromspaceandaudience"></a>
# **ListAudienceConsumersFromSpaceAndAudience**
> ListAudienceConsumersFromSpaceAndAudience200Response ListAudienceConsumersFromSpaceAndAudience (string spaceId, string id, PaginationInput? pagination = null, ListAudienceSearchInput? search = null, ListAudienceConsumersSortInput? sort = null)

List Audience Consumers from Space And Audience

Returns the list of consumers for the given audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 25 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListAudienceConsumersFromSpaceAndAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsswThIGTUYm2K8FjOOfXtY1K;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. (optional) 
            var search = new ListAudienceSearchInput?(); // ListAudienceSearchInput? | Optional search criteria  This parameter exists in alpha. (optional) 
            var sort = new ListAudienceConsumersSortInput?(); // ListAudienceConsumersSortInput? | Optional sort criteria  This parameter exists in alpha. (optional) 

            try
            {
                // List Audience Consumers from Space And Audience
                ListAudienceConsumersFromSpaceAndAudience200Response result = apiInstance.ListAudienceConsumersFromSpaceAndAudience(spaceId, id, pagination, search, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.ListAudienceConsumersFromSpaceAndAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAudienceConsumersFromSpaceAndAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Audience Consumers from Space And Audience
    ApiResponse<ListAudienceConsumersFromSpaceAndAudience200Response> response = apiInstance.ListAudienceConsumersFromSpaceAndAudienceWithHttpInfo(spaceId, id, pagination, search, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.ListAudienceConsumersFromSpaceAndAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. | [optional]  |
| **search** | [**ListAudienceSearchInput?**](ListAudienceSearchInput?.md) | Optional search criteria  This parameter exists in alpha. | [optional]  |
| **sort** | [**ListAudienceConsumersSortInput?**](ListAudienceConsumersSortInput?.md) | Optional sort criteria  This parameter exists in alpha. | [optional]  |

### Return type

[**ListAudienceConsumersFromSpaceAndAudience200Response**](ListAudienceConsumersFromSpaceAndAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaudienceschedulesfromspaceandaudience"></a>
# **ListAudienceSchedulesFromSpaceAndAudience**
> ListAudienceSchedulesFromSpaceAndAudience200Response ListAudienceSchedulesFromSpaceAndAudience (string spaceId, string id)

List Audience Schedules from Space And Audience

Returns the list of schedules for the given audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListAudienceSchedulesFromSpaceAndAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 

            try
            {
                // List Audience Schedules from Space And Audience
                ListAudienceSchedulesFromSpaceAndAudience200Response result = apiInstance.ListAudienceSchedulesFromSpaceAndAudience(spaceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.ListAudienceSchedulesFromSpaceAndAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAudienceSchedulesFromSpaceAndAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Audience Schedules from Space And Audience
    ApiResponse<ListAudienceSchedulesFromSpaceAndAudience200Response> response = apiInstance.ListAudienceSchedulesFromSpaceAndAudienceWithHttpInfo(spaceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.ListAudienceSchedulesFromSpaceAndAudienceWithHttpInfo: " + e.Message);
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

[**ListAudienceSchedulesFromSpaceAndAudience200Response**](ListAudienceSchedulesFromSpaceAndAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaudiences"></a>
# **ListAudiences**
> ListAudiences200Response ListAudiences (string spaceId, ListAudienceSearchInput? search = null, ListAudiencesPaginationInput? pagination = null, string? include = null)

List Audiences

Returns Audiences by spaceId. Supports including audience schedules using `?include=schedules`.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListAudiencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var search = new ListAudienceSearchInput?(); // ListAudienceSearchInput? | Optional search criteria  This parameter exists in alpha. (optional) 
            var pagination = new ListAudiencesPaginationInput?(); // ListAudiencesPaginationInput? | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. (optional) 
            var include = "schedules";  // string? | Additional resource to include, support schedules only.  This parameter exists in alpha. (optional) 

            try
            {
                // List Audiences
                ListAudiences200Response result = apiInstance.ListAudiences(spaceId, search, pagination, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.ListAudiences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAudiencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Audiences
    ApiResponse<ListAudiences200Response> response = apiInstance.ListAudiencesWithHttpInfo(spaceId, search, pagination, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.ListAudiencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **search** | [**ListAudienceSearchInput?**](ListAudienceSearchInput?.md) | Optional search criteria  This parameter exists in alpha. | [optional]  |
| **pagination** | [**ListAudiencesPaginationInput?**](ListAudiencesPaginationInput?.md) | Information about the pagination of this response.  [See pagination](https://docs.segmentapis.com/tag/Pagination/#section/Pagination-parameters) for more info.  This parameter exists in alpha. | [optional]  |
| **include** | **string?** | Additional resource to include, support schedules only.  This parameter exists in alpha. | [optional]  |

### Return type

[**ListAudiences200Response**](ListAudiences200Response.md)

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

<a id="removeaudiencefromspace"></a>
# **RemoveAudienceFromSpace**
> RemoveAudienceFromSpace200Response RemoveAudienceFromSpace (string spaceId, string id)

Remove Audience from Space

Deletes an Audience by id and spaceId.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Audience Deleted` event in the [audit trail](/tag/Audit-Trail).   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveAudienceFromSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 

            try
            {
                // Remove Audience from Space
                RemoveAudienceFromSpace200Response result = apiInstance.RemoveAudienceFromSpace(spaceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.RemoveAudienceFromSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAudienceFromSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Audience from Space
    ApiResponse<RemoveAudienceFromSpace200Response> response = apiInstance.RemoveAudienceFromSpaceWithHttpInfo(spaceId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.RemoveAudienceFromSpaceWithHttpInfo: " + e.Message);
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

[**RemoveAudienceFromSpace200Response**](RemoveAudienceFromSpace200Response.md)

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

<a id="removeaudienceschedulefromaudience"></a>
# **RemoveAudienceScheduleFromAudience**
> RemoveAudienceScheduleFromAudience200Response RemoveAudienceScheduleFromAudience (string spaceId, string id, string scheduleId)

Remove Audience Schedule from Audience

Deletes an audience schedule for a Linked Audience (audienceType = LINKED).  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveAudienceScheduleFromAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var scheduleId = sch_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 

            try
            {
                // Remove Audience Schedule from Audience
                RemoveAudienceScheduleFromAudience200Response result = apiInstance.RemoveAudienceScheduleFromAudience(spaceId, id, scheduleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.RemoveAudienceScheduleFromAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAudienceScheduleFromAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Audience Schedule from Audience
    ApiResponse<RemoveAudienceScheduleFromAudience200Response> response = apiInstance.RemoveAudienceScheduleFromAudienceWithHttpInfo(spaceId, id, scheduleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.RemoveAudienceScheduleFromAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **scheduleId** | **string** |  |  |

### Return type

[**RemoveAudienceScheduleFromAudience200Response**](RemoveAudienceScheduleFromAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaudienceforspace"></a>
# **UpdateAudienceForSpace**
> UpdateAudienceForSpace200Response UpdateAudienceForSpace (string spaceId, string id, UpdateAudienceForSpaceInput updateAudienceForSpaceInput)

Update Audience for Space

Updates the Audience.  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.  • When called, this endpoint may generate the `Audience Modified` event in the [audit trail](/tag/Audit-Trail).  • Note that when an Audience is updated, the Audience will be locked from future edits until the changes have been incorporated. You can find more information [in the Segment docs](https://segment-docs.netlify.app/docs/engage/audiences/#editing-realtime-audiences-and-traits).   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateAudienceForSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var updateAudienceForSpaceInput = new UpdateAudienceForSpaceInput(); // UpdateAudienceForSpaceInput | 

            try
            {
                // Update Audience for Space
                UpdateAudienceForSpace200Response result = apiInstance.UpdateAudienceForSpace(spaceId, id, updateAudienceForSpaceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.UpdateAudienceForSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAudienceForSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Audience for Space
    ApiResponse<UpdateAudienceForSpace200Response> response = apiInstance.UpdateAudienceForSpaceWithHttpInfo(spaceId, id, updateAudienceForSpaceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.UpdateAudienceForSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **updateAudienceForSpaceInput** | [**UpdateAudienceForSpaceInput**](UpdateAudienceForSpaceInput.md) |  |  |

### Return type

[**UpdateAudienceForSpace200Response**](UpdateAudienceForSpace200Response.md)

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

<a id="updateaudiencescheduleforaudience"></a>
# **UpdateAudienceScheduleForAudience**
> UpdateAudienceScheduleForAudience200Response UpdateAudienceScheduleForAudience (string spaceId, string id, string scheduleId, UpdateAudienceScheduleForAudienceInput updateAudienceScheduleForAudienceInput)

Update Audience Schedule for Audience

Updates an audience schedule for a Linked Audience (audienceType = LINKED).  • In order to successfully call this endpoint, the specified Workspace needs to have the Audience feature enabled. Please reach out to your customer success manager for more information.   The rate limit for this endpoint is 50 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateAudienceScheduleForAudienceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AudiencesApi(config);
            var spaceId = 9aQ1Lj62S4bomZKLF4DPqW;  // string | 
            var id = aud_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var scheduleId = sch_0ujsszwN8NRY24YaXiTIE2VWDTS;  // string | 
            var updateAudienceScheduleForAudienceInput = new UpdateAudienceScheduleForAudienceInput(); // UpdateAudienceScheduleForAudienceInput | 

            try
            {
                // Update Audience Schedule for Audience
                UpdateAudienceScheduleForAudience200Response result = apiInstance.UpdateAudienceScheduleForAudience(spaceId, id, scheduleId, updateAudienceScheduleForAudienceInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AudiencesApi.UpdateAudienceScheduleForAudience: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAudienceScheduleForAudienceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Audience Schedule for Audience
    ApiResponse<UpdateAudienceScheduleForAudience200Response> response = apiInstance.UpdateAudienceScheduleForAudienceWithHttpInfo(spaceId, id, scheduleId, updateAudienceScheduleForAudienceInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AudiencesApi.UpdateAudienceScheduleForAudienceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spaceId** | **string** |  |  |
| **id** | **string** |  |  |
| **scheduleId** | **string** |  |  |
| **updateAudienceScheduleForAudienceInput** | [**UpdateAudienceScheduleForAudienceInput**](UpdateAudienceScheduleForAudienceInput.md) |  |  |

### Return type

[**UpdateAudienceScheduleForAudience200Response**](UpdateAudienceScheduleForAudience200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

