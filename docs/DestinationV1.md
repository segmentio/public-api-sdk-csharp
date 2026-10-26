# Segment.PublicApi.Model.DestinationV1
Business tools or apps that you can connect to the data flowing through Segment.  This is equal to the Destination object in Config API, with the following fields omitted: - catalogId - createTime - updateTime - connectionMode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of this instance of a Destination.  Config API note: analogous to &#x60;name&#x60;. | 
**Name** | **string** | The name of this instance of a Destination.  Config API note: equal to &#x60;displayName&#x60;. | [optional] 
**Enabled** | **bool** | Whether this instance of a Destination receives data. | 
**Metadata** | [**DestinationMetadataV1**](DestinationMetadataV1.md) |  | 
**SourceId** | **string** | The id of a Source connected to this instance of a Destination.  Config API note: analogous to &#x60;parent&#x60;. | 
**Settings** | **Dictionary&lt;string, Object&gt;** | The collection of settings associated with a Destination.  Config API note: equal to &#x60;config&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

