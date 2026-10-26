# Segment.PublicApi.Model.CreateDestinationV1Input
Creates a new Destination.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceId** | **string** | The id of the Source to connect to this Destination instance.  Config API note: analogous to &#x60;parent&#x60;. | 
**MetadataId** | **string** | The id of the metadata to link to the new Destination. | 
**Enabled** | **bool** | Whether this Destination should receive data. | [optional] 
**Name** | **string** | Defines the display name of the Destination.  Config API note: equal to &#x60;displayName&#x60;. | [optional] 
**Settings** | **Dictionary&lt;string, Object&gt;** | An object that contains settings for the Destination based on the \&quot;required\&quot; and \&quot;advanced\&quot; settings present in the Destination metadata.  Config API note: equal to &#x60;config&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

