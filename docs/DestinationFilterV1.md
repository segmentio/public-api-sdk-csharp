# Segment.PublicApi.Model.DestinationFilterV1
Represents a Destination filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique id of this filter. | 
**SourceId** | **string** | The id of the Source associated with this filter. | 
**DestinationId** | **string** | The id of the Destination associated with this filter. | 
**VarIf** | **string** | A condition that defines whether to apply this filter to a payload. | 
**Actions** | [**List&lt;DestinationFilterActionV1&gt;**](DestinationFilterActionV1.md) | A list of actions this filter performs. | 
**Title** | **string** | A title for this filter. | 
**Description** | **string** | A description for this filter. | [optional] 
**Enabled** | **bool** | When set to true, this filter is active. | 
**CreatedAt** | **string** | The timestamp of this filter&#39;s creation. | 
**UpdatedAt** | **string** | The timestamp of this filter&#39;s last change. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

