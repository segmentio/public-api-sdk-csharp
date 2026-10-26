# Segment.PublicApi.Model.CreateWarehouseV2Input
Create a new Warehouse connected to a Credential. Unlike the v1 create endpoint, there is no `metadataId` or legacy `settings` flow — the Warehouse type and connection settings are always derived from the given Credential.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CredentialId** | **string** | The id of the Credential to connect this Warehouse to. The Warehouse&#39;s type and connection settings are derived from this Credential. | 
**Name** | **string** | An optional human-readable name for this Warehouse. | [optional] 
**Enabled** | **bool** | Enable to allow this Warehouse to receive data. Defaults to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

