# Segment.PublicApi.Model.PaginationOutput
Pagination metadata for a list response.  Responses return this object alongside a list of resources, which provides the necessary metadata for manipulating a paginated collection. In operations that return lists, it's always present, though some of its fields might not be.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Current** | **string** | The current cursor within a collection.  Consumers of the API must treat this value as opaque. | 
**Next** | **string** | A pointer to the next page.  This does not return when you retrieve the last page.  Consumers of the API must treat this value as opaque. | [optional] 
**Previous** | **string** | A pointer to the previous page.  This does not return when you retrieve the first page.  Consumers of the API must treat this value as opaque. | [optional] 
**TotalEntries** | **decimal** | The total number of entries available in the collection.  If calculating it impacts performance, the response may omit this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

