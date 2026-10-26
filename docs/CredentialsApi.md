# Segment.PublicApi.Api.CredentialsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCredential**](CredentialsApi.md#createcredential) | **POST** /credentials | Create Credential |
| [**DeleteCredential**](CredentialsApi.md#deletecredential) | **DELETE** /credentials/{credentialId} | Delete Credential |
| [**GetCredential**](CredentialsApi.md#getcredential) | **GET** /credentials/{credentialId} | Get Credential |
| [**ListCredentialConsumers**](CredentialsApi.md#listcredentialconsumers) | **GET** /credentials/{credentialId}/consumers | List Credential Consumers |
| [**ListCredentials**](CredentialsApi.md#listcredentials) | **GET** /credentials | List Credentials |
| [**UpdateCredential**](CredentialsApi.md#updatecredential) | **PATCH** /credentials/{credentialId} | Update Credential |

<a id="createcredential"></a>
# **CreateCredential**
> CreateCredential201Response CreateCredential (CreateCredentialV1Input createCredentialV1Input)

Create Credential

Creates a new Credential.    • When called, this endpoint may generate the `Warehouse Credential Created` event in the [audit trail](/tag/Audit-Trail).    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner  * Warehouse Admin  * Source Admin  * Entities Admin  * Unify and Engage Admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var createCredentialV1Input = new CreateCredentialV1Input(); // CreateCredentialV1Input | 

            try
            {
                // Create Credential
                CreateCredential201Response result = apiInstance.CreateCredential(createCredentialV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.CreateCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Credential
    ApiResponse<CreateCredential201Response> response = apiInstance.CreateCredentialWithHttpInfo(createCredentialV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.CreateCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCredentialV1Input** | [**CreateCredentialV1Input**](CreateCredentialV1Input.md) |  |  |

### Return type

[**CreateCredential201Response**](CreateCredential201Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecredential"></a>
# **DeleteCredential**
> DeleteCredential200Response DeleteCredential (string credentialId)

Delete Credential

Deletes an existing Credential. Fails with a `409 Conflict` if the Credential is still in use by a Warehouse or Source (including a disabled one). This check isn't atomic with the delete — a Warehouse or Source that attaches to this Credential in between would be orphaned rather than blocking the delete.    • When called, this endpoint may generate the `Warehouse Credential Deleted` event in the [audit trail](/tag/Audit-Trail).    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var credentialId = cred_2JzKWb8FGhGVYZ3xVqQGc7NkYPl;  // string | 

            try
            {
                // Delete Credential
                DeleteCredential200Response result = apiInstance.DeleteCredential(credentialId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Credential
    ApiResponse<DeleteCredential200Response> response = apiInstance.DeleteCredentialWithHttpInfo(credentialId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.DeleteCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **string** |  |  |

### Return type

[**DeleteCredential200Response**](DeleteCredential200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcredential"></a>
# **GetCredential**
> GetCredential200Response GetCredential (string credentialId)

Get Credential

Returns a Credential by its id.    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner  * Warehouse Admin  * Source Admin  * Entities Admin  * Unify and Engage Admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var credentialId = cred_2JzKWb8FGhGVYZ3xVqQGc7NkYPl;  // string | 

            try
            {
                // Get Credential
                GetCredential200Response result = apiInstance.GetCredential(credentialId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Credential
    ApiResponse<GetCredential200Response> response = apiInstance.GetCredentialWithHttpInfo(credentialId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.GetCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **string** |  |  |

### Return type

[**GetCredential200Response**](GetCredential200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcredentialconsumers"></a>
# **ListCredentialConsumers**
> ListCredentialConsumers200Response ListCredentialConsumers (string credentialId, PaginationInput? warehousesPagination = null, PaginationInput? sourcesPagination = null)

List Credential Consumers

Returns the Warehouses and Sources that use a Credential.    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner  * Warehouse Admin  * Source Admin  * Entities Admin  * Unify and Engage Admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListCredentialConsumersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var credentialId = cred_2JzKWb8FGhGVYZ3xVqQGc7NkYPl;  // string | 
            var warehousesPagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters for the list of Warehouses.  This parameter exists in v1. (optional) 
            var sourcesPagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters for the list of Sources.  This parameter exists in v1. (optional) 

            try
            {
                // List Credential Consumers
                ListCredentialConsumers200Response result = apiInstance.ListCredentialConsumers(credentialId, warehousesPagination, sourcesPagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.ListCredentialConsumers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCredentialConsumersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Credential Consumers
    ApiResponse<ListCredentialConsumers200Response> response = apiInstance.ListCredentialConsumersWithHttpInfo(credentialId, warehousesPagination, sourcesPagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.ListCredentialConsumersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **string** |  |  |
| **warehousesPagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters for the list of Warehouses.  This parameter exists in v1. | [optional]  |
| **sourcesPagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters for the list of Sources.  This parameter exists in v1. | [optional]  |

### Return type

[**ListCredentialConsumers200Response**](ListCredentialConsumers200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcredentials"></a>
# **ListCredentials**
> ListCredentials200Response ListCredentials (PaginationInput? pagination = null)

List Credentials

Returns a list of Credentials.    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner  * Warehouse Admin  * Source Admin  * Entities Admin  * Unify and Engage Admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Defines the pagination parameters.  This parameter exists in v1. (optional) 

            try
            {
                // List Credentials
                ListCredentials200Response result = apiInstance.ListCredentials(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.ListCredentials: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCredentialsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Credentials
    ApiResponse<ListCredentials200Response> response = apiInstance.ListCredentialsWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.ListCredentialsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Defines the pagination parameters.  This parameter exists in v1. | [optional]  |

### Return type

[**ListCredentials200Response**](ListCredentials200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecredential"></a>
# **UpdateCredential**
> UpdateCredential200Response UpdateCredential (string credentialId, UpdateCredentialV1Input updateCredentialV1Input)

Update Credential

Updates an existing Credential. All Warehouses using this Credential are affected immediately.    • When called, this endpoint may generate the `Warehouse Credential Modified` event in the [audit trail](/tag/Audit-Trail).    This endpoint requires the user to have at least the following permission(s):   * Workspace Owner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CredentialsApi(config);
            var credentialId = cred_2JzKWb8FGhGVYZ3xVqQGc7NkYPl;  // string | 
            var updateCredentialV1Input = new UpdateCredentialV1Input(); // UpdateCredentialV1Input | 

            try
            {
                // Update Credential
                UpdateCredential200Response result = apiInstance.UpdateCredential(credentialId, updateCredentialV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CredentialsApi.UpdateCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Credential
    ApiResponse<UpdateCredential200Response> response = apiInstance.UpdateCredentialWithHttpInfo(credentialId, updateCredentialV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CredentialsApi.UpdateCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **string** |  |  |
| **updateCredentialV1Input** | [**UpdateCredentialV1Input**](UpdateCredentialV1Input.md) |  |  |

### Return type

[**UpdateCredential200Response**](UpdateCredential200Response.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.segment.v1+json
 - **Accept**: application/vnd.segment.v1+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failure |  -  |
| **429** | Too many requests |  * Retry-After - Number of whole seconds to wait before retrying. Sent when the request was rejected because the authentication token is rate limited. Prefer this over your own backoff schedule when present. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

