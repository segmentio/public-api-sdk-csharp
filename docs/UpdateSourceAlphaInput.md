# Segment.PublicApi.Model.UpdateSourceAlphaInput
Updates an existing Source based on a set of parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | An optional human-readable name to associate with the Source.  Config API note: equal to &#x60;displayName&#x60;. | [optional] 
**Enabled** | **bool** | Enable to allow the Source to send data. | [optional] 
**Slug** | **string** | The slug that identifies the Source.  Config API note: equal to &#x60;name&#x60;. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

