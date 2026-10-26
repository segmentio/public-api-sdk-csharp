# Segment.PublicApi.Model.RequestError
Represents any error that could have occurred while performing a request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type for this error (validation, server, unknown, etc). | 
**Message** | **string** | An error message attached to this error. | [optional] 
**Field** | **string** | The name of an input field from the request that triggered this error. | [optional] 
**Data** | **Object** | Any extra data associated with this error. | [optional] 
**Status** | **decimal** | Http status code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

