# Segment.PublicApi.Api.DeletionAndSuppressionApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCloudSourceRegulation**](DeletionAndSuppressionApi.md#createcloudsourceregulation) | **POST** /regulations/cloudsources/{sourceId} | Create Cloud Source Regulation |
| [**CreateSourceRegulation**](DeletionAndSuppressionApi.md#createsourceregulation) | **POST** /regulations/sources/{sourceId} | Create Source Regulation |
| [**CreateWorkspaceRegulation**](DeletionAndSuppressionApi.md#createworkspaceregulation) | **POST** /regulations | Create Workspace Regulation |
| [**GetRegulation**](DeletionAndSuppressionApi.md#getregulation) | **GET** /regulations/{regulateId} | Get Regulation |
| [**ListRegulationsFromSource**](DeletionAndSuppressionApi.md#listregulationsfromsource) | **GET** /regulations/sources/{sourceId} | List Regulations from Source |
| [**ListSuppressions**](DeletionAndSuppressionApi.md#listsuppressions) | **GET** /suppressions | List Suppressions |
| [**ListWorkspaceRegulations**](DeletionAndSuppressionApi.md#listworkspaceregulations) | **GET** /regulations | List Workspace Regulations |

<a id="createcloudsourceregulation"></a>
# **CreateCloudSourceRegulation**
> CreateCloudSourceRegulation200Response CreateCloudSourceRegulation (string sourceId, CreateCloudSourceRegulationV1Input createCloudSourceRegulationV1Input)

Create Cloud Source Regulation

Creates a Source-scoped regulation.    Please Note: Suppression rules at the Workspace level take precedence over those at the Source level. If a user has been suppressed at the Workspace level, any attempt to un-suppress at the Source level is not supported and the processing of the request will fail in Segment    Config API omitted fields: - `attributes`, - `userAgent`  Rate limit headers will be updated to reflect regulation-specific limits (tracked separately for Segment-only vs Segment & Destination regulation types): - X-RateLimit-Remaining: Remaining requests for the regulation type category   - Segment-only Regulations: DELETE_INTERNAL, SUPPRESS_WITH_DELETE_INTERNAL, SUPPRESS_ONLY, UNSUPPRESS, DELETE_ARCHIVE_ONLY   - Segment & Destination Regulations: DELETE_ONLY, SUPPRESS_WITH_DELETE - X-RateLimit-Reset: RFC 5322 timestamp for when the quota resets (for example, Tue, 31 Dec 2024 23:59:59 GMT)      The rate limit for this endpoint is 600 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateCloudSourceRegulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var createCloudSourceRegulationV1Input = new CreateCloudSourceRegulationV1Input(); // CreateCloudSourceRegulationV1Input | 

            try
            {
                // Create Cloud Source Regulation
                CreateCloudSourceRegulation200Response result = apiInstance.CreateCloudSourceRegulation(sourceId, createCloudSourceRegulationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateCloudSourceRegulation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCloudSourceRegulationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Cloud Source Regulation
    ApiResponse<CreateCloudSourceRegulation200Response> response = apiInstance.CreateCloudSourceRegulationWithHttpInfo(sourceId, createCloudSourceRegulationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateCloudSourceRegulationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **createCloudSourceRegulationV1Input** | [**CreateCloudSourceRegulationV1Input**](CreateCloudSourceRegulationV1Input.md) |  |  |

### Return type

[**CreateCloudSourceRegulation200Response**](CreateCloudSourceRegulation200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-RateLimit-Remaining - Remaining requests in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Consumed - Number of requests consumed in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Reset - RFC 5322 timestamp indicating when the regulation quota resets for the specific regulation type category. <br>  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsourceregulation"></a>
# **CreateSourceRegulation**
> CreateSourceRegulation200Response CreateSourceRegulation (string sourceId, CreateSourceRegulationV1Input createSourceRegulationV1Input)

Create Source Regulation

Creates a Source-scoped regulation.    Please Note: Suppression rules at the Workspace level take precedence over those at the Source level. If a user has been suppressed at the Workspace level, any attempt to un-suppress at the Source level is not supported and the processing of the request will fail in Segment  Config API omitted fields: - `attributes`, - `userAgent`  Rate limit headers will be updated to reflect regulation-specific limits (tracked separately for Segment-only vs Segment & Destination regulation types): - X-RateLimit-Remaining: Remaining requests for the regulation type category   - Segment-only Regulations: DELETE_INTERNAL, SUPPRESS_WITH_DELETE_INTERNAL, SUPPRESS_ONLY, UNSUPPRESS, DELETE_ARCHIVE_ONLY   - Segment & Destination Regulations: DELETE_ONLY, SUPPRESS_WITH_DELETE - X-RateLimit-Reset: RFC 5322 timestamp for when the quota resets (for example, Tue, 31 Dec 2024 23:59:59 GMT)      The rate limit for this endpoint is 600 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateSourceRegulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var createSourceRegulationV1Input = new CreateSourceRegulationV1Input(); // CreateSourceRegulationV1Input | 

            try
            {
                // Create Source Regulation
                CreateSourceRegulation200Response result = apiInstance.CreateSourceRegulation(sourceId, createSourceRegulationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateSourceRegulation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSourceRegulationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Source Regulation
    ApiResponse<CreateSourceRegulation200Response> response = apiInstance.CreateSourceRegulationWithHttpInfo(sourceId, createSourceRegulationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateSourceRegulationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **createSourceRegulationV1Input** | [**CreateSourceRegulationV1Input**](CreateSourceRegulationV1Input.md) |  |  |

### Return type

[**CreateSourceRegulation200Response**](CreateSourceRegulation200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-RateLimit-Remaining - Remaining requests in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Consumed - Number of requests consumed in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Reset - RFC 5322 timestamp indicating when the regulation quota resets for the specific regulation type category. <br>  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createworkspaceregulation"></a>
# **CreateWorkspaceRegulation**
> CreateWorkspaceRegulation200Response CreateWorkspaceRegulation (CreateWorkspaceRegulationV1Input createWorkspaceRegulationV1Input)

Create Workspace Regulation

Creates a Workspace-scoped regulation.  Config API omitted fields: - `attributes`, - `userAgent`  Rate limit headers will be updated to reflect regulation-specific limits (tracked separately for Segment-only vs Segment & Destination regulation types): - X-RateLimit-Remaining: Remaining requests for the regulation type category   - Segment-only Regulations: DELETE_INTERNAL, SUPPRESS_WITH_DELETE_INTERNAL, SUPPRESS_ONLY, UNSUPPRESS, DELETE_ARCHIVE_ONLY   - Segment & Destination Regulations: DELETE_ONLY, SUPPRESS_WITH_DELETE - X-RateLimit-Reset: RFC 5322 timestamp for when the quota resets (for example, Tue, 31 Dec 2024 23:59:59 GMT)      The rate limit for this endpoint is 600 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateWorkspaceRegulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var createWorkspaceRegulationV1Input = new CreateWorkspaceRegulationV1Input(); // CreateWorkspaceRegulationV1Input | 

            try
            {
                // Create Workspace Regulation
                CreateWorkspaceRegulation200Response result = apiInstance.CreateWorkspaceRegulation(createWorkspaceRegulationV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateWorkspaceRegulation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorkspaceRegulationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Workspace Regulation
    ApiResponse<CreateWorkspaceRegulation200Response> response = apiInstance.CreateWorkspaceRegulationWithHttpInfo(createWorkspaceRegulationV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.CreateWorkspaceRegulationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWorkspaceRegulationV1Input** | [**CreateWorkspaceRegulationV1Input**](CreateWorkspaceRegulationV1Input.md) |  |  |

### Return type

[**CreateWorkspaceRegulation200Response**](CreateWorkspaceRegulation200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json
 - **Accept**: application/vnd.segment.v1+json, application/json, application/vnd.segment.v1beta+json, application/vnd.segment.v1alpha+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-RateLimit-Remaining - Remaining requests in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Consumed - Number of requests consumed in the current period for the regulation type category. Tracked separately for Segment-only vs Segment &amp; Destination regulation types. <br>  * X-RateLimit-Reset - RFC 5322 timestamp indicating when the regulation quota resets for the specific regulation type category. <br>  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getregulation"></a>
# **GetRegulation**
> GetRegulation200Response GetRegulation (string regulateId)

Get Regulation

Gets a regulation from the Workspace.        Config API omitted fields: - `parent`       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetRegulationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var regulateId = 1qJkfE1tpwvQcklImGksLN629wn;  // string | 

            try
            {
                // Get Regulation
                GetRegulation200Response result = apiInstance.GetRegulation(regulateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.GetRegulation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRegulationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Regulation
    ApiResponse<GetRegulation200Response> response = apiInstance.GetRegulationWithHttpInfo(regulateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.GetRegulationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **regulateId** | **string** |  |  |

### Return type

[**GetRegulation200Response**](GetRegulation200Response.md)

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

<a id="listregulationsfromsource"></a>
# **ListRegulationsFromSource**
> ListRegulationsFromSource200Response ListRegulationsFromSource (string sourceId, string? status = null, List<string>? regulationTypes = null, PaginationInput? pagination = null)

List Regulations from Source

Lists all Source-scoped regulations.    Please note: List regulations for Source only returns deletion requests from the past 90 days. Deletion requests older than 90 days are not retained and will result in 404 resource not found.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListRegulationsFromSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var sourceId = qQEHquLrjRDN9j1ByrChyn;  // string | 
            var status = "FAILED";  // string? | The status on which to filter returned regulations.  This parameter exists in v1. (optional) 
            var regulationTypes = new List<string>?(); // List<string>? | The regulation types on which to filter returned regulations.  This parameter exists in v1. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Regulations from Source
                ListRegulationsFromSource200Response result = apiInstance.ListRegulationsFromSource(sourceId, status, regulationTypes, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.ListRegulationsFromSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRegulationsFromSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Regulations from Source
    ApiResponse<ListRegulationsFromSource200Response> response = apiInstance.ListRegulationsFromSourceWithHttpInfo(sourceId, status, regulationTypes, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.ListRegulationsFromSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  |  |
| **status** | **string?** | The status on which to filter returned regulations.  This parameter exists in v1. | [optional]  |
| **regulationTypes** | [**List&lt;string&gt;?**](string.md) | The regulation types on which to filter returned regulations.  This parameter exists in v1. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListRegulationsFromSource200Response**](ListRegulationsFromSource200Response.md)

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

<a id="listsuppressions"></a>
# **ListSuppressions**
> ListSuppressions200Response ListSuppressions (PaginationInput? pagination = null)

List Suppressions

Lists all suppressions in a given Workspace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListSuppressionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Suppressions
                ListSuppressions200Response result = apiInstance.ListSuppressions(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.ListSuppressions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSuppressionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Suppressions
    ApiResponse<ListSuppressions200Response> response = apiInstance.ListSuppressionsWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.ListSuppressionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListSuppressions200Response**](ListSuppressions200Response.md)

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

<a id="listworkspaceregulations"></a>
# **ListWorkspaceRegulations**
> ListWorkspaceRegulations200Response ListWorkspaceRegulations (string? status = null, List<string>? regulationTypes = null, PaginationInput? pagination = null)

List Workspace Regulations

Lists all Workspace-scoped regulations.    Please note: List Workspace regulations only returns deletion requests from the past 90 days. Deletion requests older than 90 days are not retained and will result in 404 resource not found.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListWorkspaceRegulationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeletionAndSuppressionApi(config);
            var status = "FAILED";  // string? | The status on which to filter the returned regulations.  This parameter exists in v1. (optional) 
            var regulationTypes = new List<string>?(); // List<string>? | The regulation types on which to filter returned regulations.  This parameter exists in v1. (optional) 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Workspace Regulations
                ListWorkspaceRegulations200Response result = apiInstance.ListWorkspaceRegulations(status, regulationTypes, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeletionAndSuppressionApi.ListWorkspaceRegulations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWorkspaceRegulationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Workspace Regulations
    ApiResponse<ListWorkspaceRegulations200Response> response = apiInstance.ListWorkspaceRegulationsWithHttpInfo(status, regulationTypes, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeletionAndSuppressionApi.ListWorkspaceRegulationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string?** | The status on which to filter the returned regulations.  This parameter exists in v1. | [optional]  |
| **regulationTypes** | [**List&lt;string&gt;?**](string.md) | The regulation types on which to filter returned regulations.  This parameter exists in v1. | [optional]  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListWorkspaceRegulations200Response**](ListWorkspaceRegulations200Response.md)

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

