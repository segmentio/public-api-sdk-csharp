# Segment.PublicApi.Model.PaginationInput
Pagination parameters.  Every resource that returns a list of items in its `Output` object may contain a `PaginationInput` in its `Input` object. Required, though some of its fields are optional.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | **string** | The page to request.  Acceptable values to use here are in PaginationOutput objects, in the &#x60;current&#x60;, &#x60;next&#x60;, and &#x60;previous&#x60; keys.  Consumers of the API must treat this value as opaque. | [optional] 
**Count** | **int** | The number of items to retrieve in a page, between 1 and 1000. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

