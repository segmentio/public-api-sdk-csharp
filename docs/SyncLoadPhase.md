# Segment.PublicApi.Model.SyncLoadPhase
Object representing the load phase + details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliverSuccessCount** | **string** | Counts the subset of records successfully delivered to the downstream Destination. | 
**DeliverFailureCount** | **string** | Counts the subset of records status that failed to be delivered by either receiving a permanent error (for example, 400 Bad Request) or by exhausting all retries for temporary errors (for example, 429 Too Many Requests). | 
**ErrorCode** | **string** | Error code indicates a fatal sync error code, if applicable. | 
**StartedAt** | **string** | Time that the load phase started. | 
**FinishedAt** | **string** | Time that the load phase finished. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

