# Segment.PublicApi.Model.CreateProfilesWarehouseAlphaInput
Create a new Profiles Warehouse based on a set of parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataId** | **string** | The Warehouse metadata to use. | 
**Name** | **string** | An optional human-readable name for this Warehouse. | [optional] 
**Enabled** | **bool** | Enable to allow this Warehouse to receive data. Defaults to true. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific Warehouse settings. | 
**SchemaName** | **string** | The custom schema name that Segment uses on the Warehouse side. The space slug value is default otherwise. The schema name cannot be an existing schema name in the Warehouse. To use an existing schema name, please create a profiles Warehouse through the Segment app UI. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

