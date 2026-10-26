# Segment.PublicApi.Model.SourceEventVolumeDatapointV1
SourceEventVolumeDatapoint represents an individual timestamp/event count pair corresponding to a window of time designated by the granularity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **string** | The timestamp that corresponds to the beginning of the window given by the requested granularity. | 
**Count** | **decimal** | The number of valid events Segment received in the given window, after the events completed the validation process. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

