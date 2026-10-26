# Segment.PublicApi.Model.AudienceOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeHistoricalData** | **bool** | Determines whether data prior to the audience being created is included when determining audience membership. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true. | [optional] 
**FilterByExternalIds** | **List&lt;string&gt;** | The set of profile external identifiers being used to determine audience membership. Profiles will only be considered for audience membership if the profile has at least one external id whose key matches a value in this set. If unspecified, a default set of external identifiers will be used: [&#39;user_id&#39;, &#39;email&#39;, &#39;android.idfa&#39;, &#39;ios.idfa&#39;]. | [optional] 
**BackfillEventDataDays** | **decimal** | If specified, the value of this field indicates the number of days (specified from the date the audience was created) that event data will be included from when determining audience membership. If not specified, the default is set to the maximum event window size, or 7 days if no window condition is defined. Note that this is applied on a best-effort basis and may not always be applicable. In such cases, the response will not return a backfillEventDataDays value, and all available data will be taken into account. Note that includeHistoricalData must be set to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

