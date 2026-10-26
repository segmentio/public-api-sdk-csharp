# Segment.PublicApi.Model.SyncExtractPhase
Object representing the extract phase + details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddedCount** | **string** | Counts the subset of records with status&#x3D;new, which indicates records that were created/inserted/added. | 
**UpdatedCount** | **string** | Counts the subset of records with status&#x3D;updated, which indicates records that were modified/updated. | 
**DeletedCount** | **string** | Counts the subset of records with status&#x3D;deleted, which indicates records that were deleted/removed. | 
**ExtractCount** | **string** | Counts the total number of records/rows handled by extract, across all statuses. | 
**ErrorCode** | **string** | Error code indicates a fatal sync error code, if applicable. | 
**StartedAt** | **string** | Time that the extract phase started. | 
**FinishedAt** | **string** | Time that the extract phase finished. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

