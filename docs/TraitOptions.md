# Segment.PublicApi.Model.TraitOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeHistoricalData** | **bool** | Determines whether data prior to the computed trait being created is included when determining the computed trait value. Note that including historical data may be needed in order to properly handle the definition specified. In these cases, Segment will automatically handle including historical data and the response will return the includeHistoricalData parameter as true. | [optional] 
**IncludeAnonymousUsers** | **bool** | Determines whether anonymous users should be included when determining the computed trait value. | [optional] 
**BackfillDurationDays** | **decimal** | If specified, the value of this field indicates the number of days, specified from the date the audience was created, that event data will be included from when determining audience membership. If unspecified, defer to the value of &#x60;includeHistoricalData&#x60; to determine whether historical data is either entirely included or entirely excluded when determining audience membership. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

