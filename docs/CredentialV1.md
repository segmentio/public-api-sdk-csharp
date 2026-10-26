# Segment.PublicApi.Model.CredentialV1
Defines a reusable Credential that can be used to connect one or more Warehouses to a data Warehouse.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Credential. | 
**WorkspaceId** | **string** | The id of the Workspace that owns this Credential. | 
**Name** | **string** | A human-readable name for this Credential. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains type-specific settings for a Credential, plus a required &#x60;type&#x60; discriminator (for example &#x60;Snowflake&#x60;, &#x60;Redshift&#x60;) that determines which fields are expected. | 
**CreatedAt** | **string** | The time this Credential was created. | 
**UpdatedAt** | **string** | The time this Credential was last updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

