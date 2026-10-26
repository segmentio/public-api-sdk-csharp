# Segment.PublicApi.Model.DeliveryOverviewMetricsDataset
Dataset within GetDeliveryOverviewMetricsBetaOutput.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The name of the event if group By[] included &#39;event Name&#39; in the request. | [optional] 
**AppVersion** | **string** | The version of the app if group By[] included &#39;app Version&#39; in the request. | [optional] 
**EventType** | **string** | The event type if group By[] included &#39;event Type&#39; in the request. | [optional] 
**DiscardReason** | **string** | The discard reason for dropped events if group By[] included &#39;discard Reason&#39; in the request. | [optional] 
**Total** | **decimal** | Holds the count of all event counts over the time frame of the series. | 
**Series** | [**List&lt;DeliveryOverviewMetricsDatapoint&gt;**](DeliveryOverviewMetricsDatapoint.md) | A list of the event counts broken down by the requested granularity, time frame, and group By options. | 
**TotalRetryCount** | **decimal** | The number of events successfully delivered upon retry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

