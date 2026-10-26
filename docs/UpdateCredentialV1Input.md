# Segment.PublicApi.Model.UpdateCredentialV1Input
Updates an existing Credential based on a set of parameters.  The Credential's type (`settings.type`) is immutable and cannot be changed after creation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | An optional human-readable name to associate with this Credential. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains type-specific settings for a Credential, plus a required &#x60;type&#x60; discriminator (for example &#x60;Snowflake&#x60;, &#x60;Redshift&#x60;) that determines which fields are expected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

