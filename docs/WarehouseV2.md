# Segment.PublicApi.Model.WarehouseV2
Defines a data Warehouse used as a Destination for Segment data. Unlike the v1 Warehouse, a v2 Warehouse always has a Credential — its connection settings are always derived from that Credential rather than being stored directly on the Warehouse. There is no `metadataId`; the Warehouse type is inferred from the Credential.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Warehouse. | 
**WorkspaceId** | **string** | The id of the Workspace that owns this Warehouse. | 
**Name** | **string** | A human-readable name for this Warehouse. | [optional] 
**Enabled** | **bool** | When set to true, this Warehouse receives data. | 
**CredentialId** | **string** | The id of the Credential this Warehouse is connected to. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains the settings for a Warehouse, derived from its associated Credential. | 
**CreatedAt** | **string** | The time this Warehouse was created. | 
**UpdatedAt** | **string** | The time this Warehouse was last updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

