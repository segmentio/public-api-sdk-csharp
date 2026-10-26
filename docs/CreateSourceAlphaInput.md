# Segment.PublicApi.Model.CreateSourceAlphaInput
Create a new Source based on a set of parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Slug** | **string** | The slug by which to identify the Source in the Segment app. | 
**Enabled** | **bool** | Enable to allow this Source to send data. Defaults to true. | 
**Name** | **string** | An optional human-readable name for this Source. | [optional] 
**MetadataId** | **string** | The id of the Source metadata from which this instance of the Source derives.  All Source metadata is available under &#x60;/catalog/sources&#x60;. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

