# Segment.PublicApi.Model.SyncV1
Represents a sync between a Source and Warehouse.  A sync occurs when data from a Source is loaded into a Warehouse.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceId** | **string** | The id of the Source loaded in the sync. | 
**Start** | **string** | The start time of the sync. | 
**End** | **string** | The time the sync completed. Returns null if unfinished. | 
**Status** | **string** | The status of the sync. | 
**Duration** | **decimal** | The duration of the sync in seconds. Returns the partial duration if the sync has not finished yet. | 
**HumanDuration** | **string** | The human-readable counterpart of &#x60;duration&#x60;. | 
**Count** | **decimal** | The number of rows synced into the Warehouse. | 
**Notices** | [**List&lt;SyncNoticeV1&gt;**](SyncNoticeV1.md) | Notices that contain the events that occurred during the sync. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

