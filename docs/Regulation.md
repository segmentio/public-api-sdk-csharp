# Segment.PublicApi.Model.Regulation
The regulate request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the regulate request. | 
**WorkspaceId** | **string** | The id of the Workspace that the regulate request belongs to. | 
**OverallStatus** | **string** | The current status of the regulate request. | 
**FinishedAt** | **string** | The timestamp of when the request finished. | [optional] 
**CreatedAt** | **string** | The timestamp of the creation of the request. | 
**StreamStatus** | [**List&lt;StreamStatusV1&gt;**](StreamStatusV1.md) | The status of each stream including all the Destinations that correspond to the stream. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

