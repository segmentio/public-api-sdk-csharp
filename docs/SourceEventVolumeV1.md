# Segment.PublicApi.Model.SourceEventVolumeV1
SourceEventVolume represents a time series of event volume for a Workspace broken down by the dimensions which the customer specifies (optional parameters).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**EventSourceV1**](EventSourceV1.md) |  | [optional] 
**EventName** | **string** | The name of the event, if applicable. | [optional] 
**EventType** | **string** | The event type, if applicable. | [optional] 
**Total** | **decimal** | The total count for all events in the requested time frame. | 
**Series** | [**List&lt;SourceEventVolumeDatapointV1&gt;**](SourceEventVolumeDatapointV1.md) | A list of the event counts broken down by the requested granularity. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

