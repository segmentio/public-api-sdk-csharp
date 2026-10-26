# Segment.PublicApi.Model.CreateSourceV1Input
Create a new Source based on a set of parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Slug** | **string** | The slug by which to identify the Source in the Segment app. | 
**Enabled** | **bool** | Enable to allow this Source to send data. Defaults to true. | 
**MetadataId** | **string** | The id of the Source metadata from which this instance of the Source derives.  All Source metadata is available under &#x60;/catalog/sources&#x60;. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object. | [optional] 
**DisconnectAllWarehouses** | **bool** | Whether to disconnect all Warehouses from the Source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

