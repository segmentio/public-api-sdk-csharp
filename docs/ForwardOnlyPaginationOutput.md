# Segment.PublicApi.Model.ForwardOnlyPaginationOutput
Forward-only pagination — `previous` is omitted because this endpoint does not support backward traversal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Next** | **string** | A pointer to the next page.  This does not return when you retrieve the last page.  Consumers of the API must treat this value as opaque. | [optional] 
**Current** | **string** | The current cursor within a collection.  Consumers of the API must treat this value as opaque. | 
**TotalEntries** | **decimal** | The total number of entries available in the collection.  If calculating it impacts performance, the response may omit this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

