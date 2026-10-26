# Segment.PublicApi.Model.Config
Configuration for PERIODIC or SPECIFIC_DAYS strategies.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **string** | Go duration format string, only supporting units \&quot;d\&quot; (days), \&quot;h\&quot; (hours) and \&quot;m\&quot; (minutes).  Acceptable values are: - 15m - 30m - 1h - 2h - 4h - 6h - 8h - 12h - 1d | 
**Days** | **List&lt;decimal&gt;** | Days of week for schedule (0&#x3D;Sunday, 6&#x3D;Saturday). | 
**Hours** | **List&lt;decimal&gt;** | Hours of day for schedule (0-23). | 
**Timezone** | **string** | TZ database time zone identifier; for example, America/New_York. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

