# Segment.PublicApi.Model.GetEventsVolumeFromWorkspaceV1Output
GetEventsVolumeFromWorkspaceV1Output represents the results given the input query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Observability event volume path. | 
**Query** | [**GetEventsVolumeFromWorkspaceV1Query**](GetEventsVolumeFromWorkspaceV1Query.md) |  | 
**Result** | [**List&lt;SourceEventVolumeV1&gt;**](SourceEventVolumeV1.md) | The resultant list of series broken down by the dimensions requested over the time frame requested and ordered by the total count of events in all series. Note: The limit of entries returned is 5000. | 
**Pagination** | [**PaginationOutput**](PaginationOutput.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

