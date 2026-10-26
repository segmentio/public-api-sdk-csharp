# Segment.PublicApi.Api.IAMGroupsApi

All URIs are relative to *https://api.segmentapis.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPermissionsToUserGroup**](IAMGroupsApi.md#addpermissionstousergroup) | **POST** /groups/{userGroupId}/permissions | Add Permissions to User Group |
| [**AddUsersToUserGroup**](IAMGroupsApi.md#adduserstousergroup) | **POST** /groups/{userGroupId}/users | Add Users to User Group |
| [**CreateUserGroup**](IAMGroupsApi.md#createusergroup) | **POST** /groups | Create User Group |
| [**DeleteUserGroup**](IAMGroupsApi.md#deleteusergroup) | **DELETE** /groups/{userGroupId} | Delete User Group |
| [**GetUserGroup**](IAMGroupsApi.md#getusergroup) | **GET** /groups/{userGroupId} | Get User Group |
| [**ListInvitesFromUserGroup**](IAMGroupsApi.md#listinvitesfromusergroup) | **GET** /groups/{userGroupId}/invites | List Invites from User Group |
| [**ListUserGroups**](IAMGroupsApi.md#listusergroups) | **GET** /groups | List User Groups |
| [**ListUsersFromUserGroup**](IAMGroupsApi.md#listusersfromusergroup) | **GET** /groups/{userGroupId}/users | List Users from User Group |
| [**RemoveUsersFromUserGroup**](IAMGroupsApi.md#removeusersfromusergroup) | **DELETE** /group/{userGroupId}/users | Remove Users from User Group |
| [**ReplacePermissionsForUserGroup**](IAMGroupsApi.md#replacepermissionsforusergroup) | **PUT** /groups/{userGroupId}/permissions | Replace Permissions for User Group |
| [**ReplaceUsersInUserGroup**](IAMGroupsApi.md#replaceusersinusergroup) | **PUT** /group/{userGroupId}/users | Replace Users in User Group |
| [**UpdateUserGroup**](IAMGroupsApi.md#updateusergroup) | **PATCH** /groups/{userGroupId} | Update User Group |

<a id="addpermissionstousergroup"></a>
# **AddPermissionsToUserGroup**
> AddPermissionsToUserGroup200Response AddPermissionsToUserGroup (string userGroupId, AddPermissionsToUserGroupV1Input addPermissionsToUserGroupV1Input)

Add Permissions to User Group

Adds a list of access permissions to a user group.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Policy Created * User Group Policy Updated          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddPermissionsToUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var addPermissionsToUserGroupV1Input = new AddPermissionsToUserGroupV1Input(); // AddPermissionsToUserGroupV1Input | 

            try
            {
                // Add Permissions to User Group
                AddPermissionsToUserGroup200Response result = apiInstance.AddPermissionsToUserGroup(userGroupId, addPermissionsToUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.AddPermissionsToUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPermissionsToUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Permissions to User Group
    ApiResponse<AddPermissionsToUserGroup200Response> response = apiInstance.AddPermissionsToUserGroupWithHttpInfo(userGroupId, addPermissionsToUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.AddPermissionsToUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **addPermissionsToUserGroupV1Input** | [**AddPermissionsToUserGroupV1Input**](AddPermissionsToUserGroupV1Input.md) |  |  |

### Return type

[**AddPermissionsToUserGroup200Response**](AddPermissionsToUserGroup200Response.md)

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

<a id="adduserstousergroup"></a>
# **AddUsersToUserGroup**
> AddUsersToUserGroup200Response AddUsersToUserGroup (string userGroupId, AddUsersToUserGroupV1Input addUsersToUserGroupV1Input)

Add Users to User Group

Adds a list of users or invites to a user group.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Subjects Added to Group * User Added To User Group          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class AddUsersToUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var addUsersToUserGroupV1Input = new AddUsersToUserGroupV1Input(); // AddUsersToUserGroupV1Input | 

            try
            {
                // Add Users to User Group
                AddUsersToUserGroup200Response result = apiInstance.AddUsersToUserGroup(userGroupId, addUsersToUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.AddUsersToUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddUsersToUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Users to User Group
    ApiResponse<AddUsersToUserGroup200Response> response = apiInstance.AddUsersToUserGroupWithHttpInfo(userGroupId, addUsersToUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.AddUsersToUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **addUsersToUserGroupV1Input** | [**AddUsersToUserGroupV1Input**](AddUsersToUserGroupV1Input.md) |  |  |

### Return type

[**AddUsersToUserGroup200Response**](AddUsersToUserGroup200Response.md)

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

<a id="createusergroup"></a>
# **CreateUserGroup**
> CreateUserGroup200Response CreateUserGroup (CreateUserGroupV1Input createUserGroupV1Input)

Create User Group

Creates a user group.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* User Group Created * Policy Created          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class CreateUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var createUserGroupV1Input = new CreateUserGroupV1Input(); // CreateUserGroupV1Input | 

            try
            {
                // Create User Group
                CreateUserGroup200Response result = apiInstance.CreateUserGroup(createUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.CreateUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create User Group
    ApiResponse<CreateUserGroup200Response> response = apiInstance.CreateUserGroupWithHttpInfo(createUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.CreateUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createUserGroupV1Input** | [**CreateUserGroupV1Input**](CreateUserGroupV1Input.md) |  |  |

### Return type

[**CreateUserGroup200Response**](CreateUserGroup200Response.md)

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

<a id="deleteusergroup"></a>
# **DeleteUserGroup**
> DeleteUserGroup200Response DeleteUserGroup (string userGroupId)

Delete User Group

Removes a user group from a Workspace.    • When called, this endpoint may generate the `User Group Deleted` event in the [audit trail](/tag/Audit-Trail).          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class DeleteUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = 2c0vZc1kXJ9Nf9wIJ1Gb7JzORGf;  // string | 

            try
            {
                // Delete User Group
                DeleteUserGroup200Response result = apiInstance.DeleteUserGroup(userGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.DeleteUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User Group
    ApiResponse<DeleteUserGroup200Response> response = apiInstance.DeleteUserGroupWithHttpInfo(userGroupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.DeleteUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |

### Return type

[**DeleteUserGroup200Response**](DeleteUserGroup200Response.md)

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

<a id="getusergroup"></a>
# **GetUserGroup**
> GetUserGroup200Response GetUserGroup (string userGroupId)

Get User Group

Returns a user group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class GetUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 

            try
            {
                // Get User Group
                GetUserGroup200Response result = apiInstance.GetUserGroup(userGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.GetUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Group
    ApiResponse<GetUserGroup200Response> response = apiInstance.GetUserGroupWithHttpInfo(userGroupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.GetUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |

### Return type

[**GetUserGroup200Response**](GetUserGroup200Response.md)

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

<a id="listinvitesfromusergroup"></a>
# **ListInvitesFromUserGroup**
> ListInvitesFromUserGroup200Response ListInvitesFromUserGroup (string userGroupId, PaginationInput? pagination = null)

List Invites from User Group

Returns the emails of invitees to a user group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListInvitesFromUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination for invites to the group.  This parameter exists in v1. (optional) 

            try
            {
                // List Invites from User Group
                ListInvitesFromUserGroup200Response result = apiInstance.ListInvitesFromUserGroup(userGroupId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.ListInvitesFromUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInvitesFromUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Invites from User Group
    ApiResponse<ListInvitesFromUserGroup200Response> response = apiInstance.ListInvitesFromUserGroupWithHttpInfo(userGroupId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.ListInvitesFromUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination for invites to the group.  This parameter exists in v1. | [optional]  |

### Return type

[**ListInvitesFromUserGroup200Response**](ListInvitesFromUserGroup200Response.md)

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

<a id="listusergroups"></a>
# **ListUserGroups**
> ListUserGroups200Response ListUserGroups (PaginationInput? pagination = null)

List User Groups

Returns all user groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination for user groups.  This parameter exists in v1. (optional) 

            try
            {
                // List User Groups
                ListUserGroups200Response result = apiInstance.ListUserGroups(pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.ListUserGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUserGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List User Groups
    ApiResponse<ListUserGroups200Response> response = apiInstance.ListUserGroupsWithHttpInfo(pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.ListUserGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination for user groups.  This parameter exists in v1. | [optional]  |

### Return type

[**ListUserGroups200Response**](ListUserGroups200Response.md)

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

<a id="listusersfromusergroup"></a>
# **ListUsersFromUserGroup**
> ListUsersFromUserGroup200Response ListUsersFromUserGroup (string userGroupId, PaginationInput? pagination = null)

List Users from User Group

Returns users belonging to a user group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ListUsersFromUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var pagination = new PaginationInput?(); // PaginationInput? | Pagination for members of a group.  This parameter exists in v1. (optional) 

            try
            {
                // List Users from User Group
                ListUsersFromUserGroup200Response result = apiInstance.ListUsersFromUserGroup(userGroupId, pagination);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.ListUsersFromUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUsersFromUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Users from User Group
    ApiResponse<ListUsersFromUserGroup200Response> response = apiInstance.ListUsersFromUserGroupWithHttpInfo(userGroupId, pagination);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.ListUsersFromUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **pagination** | [**PaginationInput?**](PaginationInput?.md) | Pagination for members of a group.  This parameter exists in v1. | [optional]  |

### Return type

[**ListUsersFromUserGroup200Response**](ListUsersFromUserGroup200Response.md)

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

<a id="removeusersfromusergroup"></a>
# **RemoveUsersFromUserGroup**
> RemoveUsersFromUserGroup200Response RemoveUsersFromUserGroup (string userGroupId, List<string> emails)

Remove Users from User Group

Removes one or multiple users or invites from a user group by email.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Group Memberships Deleted * User Removed From User Group          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class RemoveUsersFromUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var emails = new List<string>(); // List<string> | The list of emails to remove from the user group.  This parameter exists in v1.

            try
            {
                // Remove Users from User Group
                RemoveUsersFromUserGroup200Response result = apiInstance.RemoveUsersFromUserGroup(userGroupId, emails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.RemoveUsersFromUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveUsersFromUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Users from User Group
    ApiResponse<RemoveUsersFromUserGroup200Response> response = apiInstance.RemoveUsersFromUserGroupWithHttpInfo(userGroupId, emails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.RemoveUsersFromUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **emails** | [**List&lt;string&gt;**](string.md) | The list of emails to remove from the user group.  This parameter exists in v1. |  |

### Return type

[**RemoveUsersFromUserGroup200Response**](RemoveUsersFromUserGroup200Response.md)

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

<a id="replacepermissionsforusergroup"></a>
# **ReplacePermissionsForUserGroup**
> ReplacePermissionsForUserGroup200Response ReplacePermissionsForUserGroup (string userGroupId, ReplacePermissionsForUserGroupV1Input replacePermissionsForUserGroupV1Input)

Replace Permissions for User Group

Updates the list of access permissions for a user group.    • When called, this endpoint may generate the `Policy Deleted` event in the [audit trail](/tag/Audit-Trail).          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ReplacePermissionsForUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var replacePermissionsForUserGroupV1Input = new ReplacePermissionsForUserGroupV1Input(); // ReplacePermissionsForUserGroupV1Input | 

            try
            {
                // Replace Permissions for User Group
                ReplacePermissionsForUserGroup200Response result = apiInstance.ReplacePermissionsForUserGroup(userGroupId, replacePermissionsForUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.ReplacePermissionsForUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplacePermissionsForUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace Permissions for User Group
    ApiResponse<ReplacePermissionsForUserGroup200Response> response = apiInstance.ReplacePermissionsForUserGroupWithHttpInfo(userGroupId, replacePermissionsForUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.ReplacePermissionsForUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **replacePermissionsForUserGroupV1Input** | [**ReplacePermissionsForUserGroupV1Input**](ReplacePermissionsForUserGroupV1Input.md) |  |  |

### Return type

[**ReplacePermissionsForUserGroup200Response**](ReplacePermissionsForUserGroup200Response.md)

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

<a id="replaceusersinusergroup"></a>
# **ReplaceUsersInUserGroup**
> ReplaceUsersInUserGroup200Response ReplaceUsersInUserGroup (string userGroupId, ReplaceUsersInUserGroupV1Input replaceUsersInUserGroupV1Input)

Replace Users in User Group

Replaces the members of a user group by email.    • When called, this endpoint may generate one or more of the following [audit trail](/tag/Audit-Trail) events:* Subjects Added to Group * User Added To User Group * Group Memberships Deleted          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class ReplaceUsersInUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var replaceUsersInUserGroupV1Input = new ReplaceUsersInUserGroupV1Input(); // ReplaceUsersInUserGroupV1Input | 

            try
            {
                // Replace Users in User Group
                ReplaceUsersInUserGroup200Response result = apiInstance.ReplaceUsersInUserGroup(userGroupId, replaceUsersInUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.ReplaceUsersInUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceUsersInUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace Users in User Group
    ApiResponse<ReplaceUsersInUserGroup200Response> response = apiInstance.ReplaceUsersInUserGroupWithHttpInfo(userGroupId, replaceUsersInUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.ReplaceUsersInUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **replaceUsersInUserGroupV1Input** | [**ReplaceUsersInUserGroupV1Input**](ReplaceUsersInUserGroupV1Input.md) |  |  |

### Return type

[**ReplaceUsersInUserGroup200Response**](ReplaceUsersInUserGroup200Response.md)

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

<a id="updateusergroup"></a>
# **UpdateUserGroup**
> UpdateUserGroup200Response UpdateUserGroup (string userGroupId, UpdateUserGroupV1Input updateUserGroupV1Input)

Update User Group

Updates a user group for a Workspace.    • When called, this endpoint may generate the `User Group Updated` event in the [audit trail](/tag/Audit-Trail).          The rate limit for this endpoint is 60 requests per minute, which is lower than the default due to access pattern restrictions. Once reached, this endpoint will respond with the 429 HTTP status code with headers indicating the limit parameters. See [Rate Limiting](/#tag/Rate-Limits) for more information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Segment.PublicApi.Api;
using Segment.PublicApi.Client;
using Segment.PublicApi.Model;

namespace Example
{
    public class UpdateUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.segmentapis.com";
            // Configure Bearer token for authorization: token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IAMGroupsApi(config);
            var userGroupId = bBABwqbaDf2QdwTbW8bNEm;  // string | 
            var updateUserGroupV1Input = new UpdateUserGroupV1Input(); // UpdateUserGroupV1Input | 

            try
            {
                // Update User Group
                UpdateUserGroup200Response result = apiInstance.UpdateUserGroup(userGroupId, updateUserGroupV1Input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IAMGroupsApi.UpdateUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User Group
    ApiResponse<UpdateUserGroup200Response> response = apiInstance.UpdateUserGroupWithHttpInfo(userGroupId, updateUserGroupV1Input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IAMGroupsApi.UpdateUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGroupId** | **string** |  |  |
| **updateUserGroupV1Input** | [**UpdateUserGroupV1Input**](UpdateUserGroupV1Input.md) |  |  |

### Return type

[**UpdateUserGroup200Response**](UpdateUserGroup200Response.md)

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

