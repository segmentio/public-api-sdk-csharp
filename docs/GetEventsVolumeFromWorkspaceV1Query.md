# Segment.PublicApi.Model.GetEventsVolumeFromWorkspaceV1Query
GetEventVolumeOutputQuery represents the input query sent to output.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkspaceId** | **string** | Workspace being requested. | 
**Granularity** | **string** | Granularity corresponds to the requested bucket granularity. | 
**StartTime** | **string** | StartTime is the ISO8601 formatted timestamp corresponding to the beginning of the requested time frame, inclusive. | 
**EndTime** | **string** | EndTime is the ISO8601 formatted timestamp corresponding to the end of the requested time frame, noninclusive. | 
**GroupBy** | **List&lt;string&gt;** | GroupBy is a comma-delimited list of strings representing the dimensions to group the result by. The current options are: &#x60;eventName&#x60; or &#x60;eventType&#x60;. | [optional] 
**SourceId** | **List&lt;string&gt;** | List of strings which allow you to restrict the result to just the given Sources. | [optional] 
**EventName** | **List&lt;string&gt;** | EventName is a list of strings which allow you to restrict the result to just the given event names. | [optional] 
**EventType** | **List&lt;string&gt;** | EventType is a list of strings which allow you to restrict the result to just the given event types. | [optional] 
**AppVersion** | **List&lt;string&gt;** | AppVersion is a list of strings which allow you to restrict the result to just the given application versions. | [optional] 
**Limit** | **decimal** | Limit is the total number of items in the result. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

