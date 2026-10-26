# Segment.PublicApi.Model.ReverseETLSyncStatus
Defines the result of getting the sync status of a RETL connection.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SyncId** | **string** | The id of the sync. | 
**ModelId** | **string** | The Model id of the sync. | 
**SourceId** | **string** | The Source id of the sync. | 
**SyncStatus** | **string** | The status of the sync. It currently can be IN_PROGRESS, FAIL, SUCCESS, PARTIAL_SUCCESS. | 
**Duration** | **string** | The duration of the sync. | 
**StartedAt** | **string** | When the sync started. | 
**FinishedAt** | **string** | When the sync started. | [optional] 
**ExtractPhase** | [**SyncExtractPhase**](SyncExtractPhase.md) |  | [optional] 
**LoadPhase** | [**SyncLoadPhase**](SyncLoadPhase.md) |  | [optional] 
**Error** | **string** | Error message if applicable. | [optional] 
**ErrorCode** | **string** | Error code indicates a fatal sync error code, if applicable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

