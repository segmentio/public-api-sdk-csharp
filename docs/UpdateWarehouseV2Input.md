# Segment.PublicApi.Model.UpdateWarehouseV2Input
Updates an existing Warehouse based on a set of parameters. There is no per-Warehouse settings override — settings are always fully derived from the associated Credential.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | An optional human-readable name to associate with this Warehouse. | [optional] 
**Enabled** | **bool** | Enable to allow this Warehouse to receive data. | [optional] 
**CredentialId** | **string** | The id of a Credential to connect this Warehouse to. Swapping the Credential re-derives this Warehouse&#39;s connection settings and re-validates the connection. The Credential must be the same type as the Warehouse&#39;s existing type — a Warehouse&#39;s type cannot be changed after creation, so a mismatched Credential is rejected rather than silently ignored. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

