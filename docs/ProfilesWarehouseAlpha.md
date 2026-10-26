# Segment.PublicApi.Model.ProfilesWarehouseAlpha
Defines a Profiles data Warehouse used as a Destination for Segment data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Warehouse. | 
**SpaceId** | **string** | The Space id. | 
**Metadata** | [**WarehouseMetadataV1**](WarehouseMetadataV1.md) |  | 
**WorkspaceId** | **string** | The id of the Workspace that owns this Warehouse. | 
**Enabled** | **bool** | When set to true, this Warehouse receives data. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific Warehouse settings. | 
**SchemaName** | **string** | The custom schema name that Segment uses on the Warehouse side. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

