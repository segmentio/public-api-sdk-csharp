# Segment.PublicApi.Model.CreateWarehouseV1Input
Create a new Warehouse based on a set of parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataId** | **string** | The Warehouse metadata to use. | 
**Name** | **string** | An optional human-readable name for this Warehouse. | [optional] 
**Enabled** | **bool** | Enable to allow this Warehouse to receive data. Defaults to true. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific Warehouse settings. | 
**DisconnectAllSources** | **bool** | Whether to disconnect all Sources from this Warehouse. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

