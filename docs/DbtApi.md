# Segment.PublicApi.Api.DbtApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDbtModelSyncTrigger**](DbtApi.md#createdbtmodelsynctrigger) | **POST** /dbt-model-syncs/trigger | Create Dbt Model Sync Trigger |

<a id="createdbtmodelsynctrigger"></a>
# **CreateDbtModelSyncTrigger**
> CreateDbtModelSyncTrigger200Response CreateDbtModelSyncTrigger (CreateDbtModelSyncTriggerInput createDbtModelSyncTriggerInput)

Create Dbt Model Sync Trigger

Creates a trigger for a new dbt model sync for a Source.   The rate limit for this endpoint is 10 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateDbtModelSyncTriggerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DbtApi(config);
            var createDbtModelSyncTriggerInput = new CreateDbtModelSyncTriggerInput(); // CreateDbtModelSyncTriggerInput | 

            try
            {
                // Create Dbt Model Sync Trigger
                CreateDbtModelSyncTrigger200Response result = apiInstance.CreateDbtModelSyncTrigger(createDbtModelSyncTriggerInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DbtApi.CreateDbtModelSyncTrigger: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDbtModelSyncTriggerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Dbt Model Sync Trigger
    ApiResponse<CreateDbtModelSyncTrigger200Response> response = apiInstance.CreateDbtModelSyncTriggerWithHttpInfo(createDbtModelSyncTriggerInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DbtApi.CreateDbtModelSyncTriggerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDbtModelSyncTriggerInput** | [**CreateDbtModelSyncTriggerInput**](CreateDbtModelSyncTriggerInput.md) |  |  |

### Return type

[**CreateDbtModelSyncTrigger200Response**](CreateDbtModelSyncTrigger200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/vnd.segment.v1beta+json
 - **Accept**: application/vnd.segment.v1beta+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

