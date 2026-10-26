# Segment.PublicApi.Model.SourceAlpha
Defines a data Source for Segment data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the Source.  Config API note: analogous to &#x60;name&#x60;. | 
**Slug** | **string** | The slug used to identify the Source in the Segment app.  Config API note: equal to &#x60;name&#x60;. | 
**Name** | **string** | The name of the Source.  Config API note: equal to &#x60;displayName&#x60;. | [optional] 
**Metadata** | [**SourceMetadataV1**](SourceMetadataV1.md) |  | 
**WorkspaceId** | **string** | The id of the Workspace that owns the Source.  Config API note: equal to &#x60;parent&#x60;. | 
**Enabled** | **bool** | Enable to receive data from the Source. | 
**WriteKeys** | **List&lt;string&gt;** | The write keys used to send data from the Source. This field is left empty when the current token does not have the &#39;source admin&#39; permission. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | A key-value object that contains instance-specific settings for a Source.  The &#x60;options&#x60; field in the Source metadata defines the schema of this object. | [optional] 
**Labels** | [**List&lt;LabelV1&gt;**](LabelV1.md) | A list of labels applied to the Source. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

