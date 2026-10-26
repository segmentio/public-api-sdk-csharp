# Segment.PublicApi.Model.ReadAudiencePreviewOptions
Options which should be applied when segmenting audience previews.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterByExternalIds** | **List&lt;string&gt;** | The set of profile external identifiers being used to determine audience preview membership. Profiles will only be considered for audience preview membership if the profile has at least one external id whose key matches a value in this set. | [optional] 
**IncludeHistoricalData** | **bool** | Determines whether data prior to the audience preview being created is included when determining audience preview membership. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true. | [optional] 
**BackfillEventDataDays** | **decimal** | If specified, the value of this field indicates the number of days (specified from the date the audience preview was created) that event data will be included from when determining audience preview membership. If unspecified, defer to the value of &#x60;includeHistoricalData&#x60; to determine whether historical data is either entirely included or entirely excluded when determining audience preview membership. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

