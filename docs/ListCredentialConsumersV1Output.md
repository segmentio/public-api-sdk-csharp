# Segment.PublicApi.Model.ListCredentialConsumersV1Output
Returns the Warehouses and Sources that consume a Credential. The two lists are paginated independently, so a caller can page through one without affecting the other.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Warehouses** | [**List&lt;WarehouseV1&gt;**](WarehouseV1.md) | The Warehouses that use this Credential. | 
**WarehousesPagination** | [**PaginationOutput**](PaginationOutput.md) |  | 
**Sources** | [**List&lt;SourceV1&gt;**](SourceV1.md) | The Sources that use this Credential. | 
**SourcesPagination** | [**PaginationOutput**](PaginationOutput.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

